using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HSHuangGALibrary
{
    // template class
    public class GenericGASolver<T>
    {
        protected GAMonitor<T> theMonitor = null;
        protected Random randomizer = new Random();


        [Browsable(false)]
        public T[][] Chromosomes { get => chromosomes; }

        [Browsable(false)]
        public double CurrentBestObjective { get => soFarTheBestObjectiveValue; }

        [Browsable(false)]
        public T[] CurrentBestSolution { get => soFarTheBestSolution; }


        // data fields

        protected T[][] chromosomes;

        /// <summary>
        /// objective value array of the objective function
        /// </summary>
        protected double[] objectives;
        /// <summary>
        /// fitness value array of GA (Not objective value of the objective function)
        /// </summary>
        protected double[] fitnessValues;
        protected T[] soFarTheBestSolution;
        protected double soFarTheBestObjectiveValue;

        protected double iterationBestObjective;
        protected double iterationAverageObjective;
        protected int[] indices;

        protected bool[][] mutatedGenes;

        protected T[][] selectedChromosomes;
        protected double[] selectedObjectives;

        protected int numberOfGenes;
        protected OptimizationType optimizationType = OptimizationType.Minimization;
        protected ObjectiveFunction<T> objectiveFunction = null;
        protected double leastFitnessFraction = 0.1;

        protected int populationSize = 10;
        protected double crossoverRate = 0.8;
        protected double mutationRate = 0.05; // Gene number-based; not population-size-based
        MutationMode mutationType = MutationMode.GeneNumberBased;
        SelectionMode selectionType = SelectionMode.Deterministic;
        int iterationLimit = 200;

        int numberOFCrossoveredChildren;
        int numberOFMutatedChildren;

        // runtime data
        int iterationId = 0;

        #region PROPERTIES
        /// <summary>
        /// Specity the populationsize of GA
        /// </summary>
        [Category("GA Parameters")]
        [Description("Number of chromosomes employed")]
        public int PopulationSize 
        { 
            get => populationSize;
            set
            {
                if(value>1)
                    populationSize = value;
            }
        }

        /// <summary>
        /// Specity the crossoverrate of GA
        /// </summary>
        [Category("GA Parameters")]
        [Description("All how much chromosomes to perform crossover operation")]
        public double CrossoverRate 
        { 
            get => crossoverRate; 
            set
            {
                if (value >= 0 && value <= 1.0)
                    crossoverRate = value;
            } 
        }

        /// <summary>
        /// Specity the mutation of GA
        /// </summary>
        [Category("GA Parameters")]
        [Description("The percentage of the total number of genes to be operated by the mutation")]
        public double MutationRate { get => mutationRate; set => mutationRate = value; }

        /// <summary>
        /// Specity the stopping criteria of GA
        /// </summary>
        [Category("Stopping Condition")]
        [Description("Stop after how much iterations")]
        public int IterationLimit
        {
            get => iterationLimit;
            set
            {
                if (value > 1)
                    iterationLimit = value;
            }
        }

        /// <summary>
        /// Specity the mutation type of GA
        /// </summary>
        [Category("Operation Mode")]
        [Description("Gene-Based or Population-Based. If it is permutation-encoded GA, gene-based mutation method would randomly change the mutated genes with another gene in the same permutation.")]
        public MutationMode MutationType
        {
            get => mutationType;
            set
            {
                mutationType = value;
            }
        }

        /// <summary>
        /// Specity the selection type of GA
        /// </summary>
        [Category("Operation Mode")]
        [Description("Genetic selection mode setting")]
        public SelectionMode SelectionType
        {
            get => selectionType;
            set
            {
                selectionType = value;
            }
        }


        #endregion

        /// <summary>
        /// Generic GA Solver 
        /// </summary>
        /// <param name="numberOFVariables"> Number of GA Genes in one Chromosome </param>
        /// <param name="optimizationType"> Minimazation or Maximazation Problem </param>
        /// <param name="objectiveFunction"> Customed ObjectiveFunction By Situation </param>


        //constructor
        public GenericGASolver(int numberOFVariables, OptimizationType optimizationType, ObjectiveFunction<T> objectiveFunction, Panel hostPanelForMonitor=null)
        {
            this.numberOfGenes = numberOFVariables;
            this.optimizationType = optimizationType;
            this.objectiveFunction = objectiveFunction;

            if (hostPanelForMonitor != null)
            {
                // create monitor object and add it to the host pannel
                theMonitor = new GAMonitor<T>(this);
                hostPanelForMonitor.Controls.Add(theMonitor);
                theMonitor.Dock = DockStyle.Fill;
                theMonitor.ppgGA.SelectedObject = this;
            }


            //soFarTheBestSolution[0]=soFarTheBestSolution blablabla
            soFarTheBestSolution = new T[numberOFVariables];
        }

        // Helping functions

        protected void ShuffleAnArray(int []array, int limit)
        {
            for (int i = 0; i < limit; i++)
                array[i] = i;
            
            for (int i = 0; i < limit; i++)
            {
                int changing_pos= randomizer.Next(limit);
                int temp = array[i];
                array[i] = array[changing_pos];
                array[changing_pos] = temp;
            }
        }

        void SetFitnessFromObjectives()
        {
            int total = populationSize + numberOFCrossoveredChildren + numberOFMutatedChildren;
            
            double alpha = 0.25; // least fitness fraction
            double o_max = double.MinValue;
            double o_min = double.MaxValue;

            //  wirte my own for-loop statements to get min or max
            for (int i = 0; i < total; i++)
            {
                if (objectives[i] > o_max)
                    o_max = objectives[i];
                if (objectives[i] < o_min)
                    o_min = objectives[i];
            }

            double b = Math.Max(alpha * (o_max - o_min), 0.00001); // minumum fitness


            for (int i = 0; i < total; i++)
            {
                if (optimizationType == OptimizationType.Maximization)
                    fitnessValues[i] = b + (objectives[i] - o_min);
                else
                    fitnessValues[i] = b + (o_max - objectives[i]);
            }
        }

        /// <summary>
        /// reset the parameters
        /// </summary>
        public void Reset()
        {
            // variable reset
            iterationId = 0;

            if (optimizationType == OptimizationType.Maximization)
                soFarTheBestObjectiveValue = double.MinValue;
            else
                soFarTheBestObjectiveValue = double.MaxValue;

            // memory reallocation

            if(indices==null|| indices.Length!=populationSize*3)
            {
                int ThreeTimesSize = populationSize * 3;

                chromosomes = new T[ThreeTimesSize][];
                for (int r = 0; r < ThreeTimesSize; r++)
                    chromosomes[r] = new T[numberOfGenes];

                selectedChromosomes = new T[populationSize][];
                for (int r = 0; r < populationSize; r++)
                    selectedChromosomes[r] = new T[numberOfGenes];

                indices = new int[ThreeTimesSize];
                objectives = new double[ThreeTimesSize];
                fitnessValues = new double[ThreeTimesSize];
                selectedObjectives = new double[populationSize];
                mutatedGenes = new bool[populationSize][];
                for (int r = 0; r < populationSize; r++)
                    mutatedGenes[r] = new bool[numberOfGenes];
            }

            // set initial solution
            InitializePopulation();

            // Evaluation objectives of the population
            for(int i=0;i<populationSize;i++)
                objectives[i] = objectiveFunction(chromosomes[i]);

            if(theMonitor!=null)
            {
                // reset to initial condition
                theMonitor.btnRunOneIteration.Enabled = true;
                theMonitor.btnRunToEnd.Enabled = true;
                foreach (Series s in theMonitor.chtGA.Series)
                    s.Points.Clear();
                theMonitor.labSoFarTheBestObjective.Text = "The Best Objectives:";
                theMonitor.rtbTheBestSolution.Clear();
            }
        }

        /// <summary>
        /// Initialize the population 
        /// </summary>
        public virtual void InitializePopulation()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Run one iteration of GA
        /// </summary>
        public void RunOneIteration()
        {
            PerformCrossoverOperation();
            PerformMutationOperation();
            UpdateSoFarTheBestSolutionAndObjective();
            PerformSelectionOperation();

            iterationId++;

            if(theMonitor!=null)
            {
                theMonitor.chtGA.Series[0].Points.AddXY(iterationId, iterationAverageObjective); // iterationAverageObjective);
                theMonitor.chtGA.Series[1].Points.AddXY(iterationId, iterationBestObjective); // iterationBestObjective); 
                theMonitor.chtGA.Series[2].Points.AddXY(iterationId, soFarTheBestObjectiveValue); // soFarTheBestObjectiveValue);
            }
        }

        private void UpdateSoFarTheBestSolutionAndObjective()
        {

            SetFitnessFromObjectives();

            bool sofarthebestisupdated = false;
            int iteration_bestid = 0;
            double objectivevalue_sum = 0.0;
            int total = populationSize + numberOFCrossoveredChildren + numberOFMutatedChildren;            

            // find the iteration best solution id first
            for (int i = 0; i < total; i++)
            {
                objectivevalue_sum += objectives[i];
                if (fitnessValues[i] > fitnessValues[iteration_bestid])
                    iteration_bestid = i;
            }

            // calculate iterationBestObjective and iterationAverageObjective
            iterationBestObjective = objectives[iteration_bestid];
            iterationAverageObjective = objectivevalue_sum / total;

            // check whether its value is better than the current best objective
            // If it does, update the best objective and gene-wise copy the iteration best chromosomes to so-far-the-best solution
            if (optimizationType == OptimizationType.Maximization && objectives[iteration_bestid] > soFarTheBestObjectiveValue
                || optimizationType == OptimizationType.Minimization && objectives[iteration_bestid] < soFarTheBestObjectiveValue)
            {
                soFarTheBestObjectiveValue = objectives[iteration_bestid];
                sofarthebestisupdated = true;
                for (int j = 0; j < numberOfGenes; j++)
                    soFarTheBestSolution[j] = chromosomes[iteration_bestid][j];
            }


            //if (optimizationType == OptimizationType.Maximization)
            //{
            //    for (int i = 0; i < total; i++)
            //    {
            //        objectivevalue_sum = objectivevalue_sum + objectives[i];

            //        if (objectives[i] > objectives[iteration_bestid])
            //        {
            //            iteration_bestid = i;
            //        }
            //    }

            //    if (objectives[iteration_bestid] >= soFarTheBestObjectiveValue)
            //    {
            //        soFarTheBestObjectiveValue = objectives[iteration_bestid];
            //        sofarthebestisupdated = true;
            //        for (int j = 0; j < numberOfGenes; j++)
            //        {
            //            soFarTheBestSolution[j] = chromosomes[iteration_bestid][j];
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < total; i++)
            //    {
            //        objectivevalue_sum = objectivevalue_sum + objectives[i];

            //        if (objectives[i] < objectives[iteration_bestid])
            //        {
            //            iteration_bestid = i;
            //        }
            //    }

            //    if (objectives[iteration_bestid] <= soFarTheBestObjectiveValue)
            //    {
            //        soFarTheBestObjectiveValue = objectives[iteration_bestid];
            //        sofarthebestisupdated = true;
            //        for (int j = 0; j < numberOfGenes; j++)
            //        {
            //            soFarTheBestSolution[j] = chromosomes[iteration_bestid][j];
            //        }
            //    }
            //}


            // If so far the best is updated in this iteration, update objective label and the solution
            if (theMonitor != null && sofarthebestisupdated)
            {
                theMonitor.labSoFarTheBestObjective.Text = $"The Best Objective:{soFarTheBestObjectiveValue:0.0000}";

                StringBuilder sb = new StringBuilder();
                sb.Clear();
                foreach (T i in soFarTheBestSolution) sb.Append($"{i}, ");
                theMonitor.rtbTheBestSolution.Text = sb.ToString();
            }

        }

        private void PerformCrossoverOperation()
        {
            numberOFCrossoveredChildren = (int)(populationSize * crossoverRate);
            if (numberOFCrossoveredChildren % 2 == 1)
                numberOFCrossoveredChildren--;
            ShuffleAnArray(indices, populationSize);
            int father, mother, child1 = populationSize, child2 = populationSize + 1;
            for (int i=0;i<numberOFCrossoveredChildren;i+=2)
            {
                father = indices[i];
                mother = indices[i + 1];
                CrossoverAPairParent(father, mother, child1, child2);
                objectives[child1] = objectiveFunction(chromosomes[child1]);
                objectives[child2] = objectiveFunction(chromosomes[child2]);
                child1 += 2;
                child2 += 2; 
            }
        }

        public virtual void CrossoverAPairParent(int father, int mother, int child1, int child2)
        {
            throw new NotImplementedException();
        }

        public void PerformSelectionOperation()
        {
            int total = populationSize + numberOFCrossoveredChildren + numberOFMutatedChildren;

            // SetFitnessFromObjectives();
            // the fitness was set in the UpdateSoFarTheBestSolutionAndObjective
            // so we don't need to setfiness again in this function

            if (selectionType == SelectionMode.Deterministic)
            {
                for (int i = 0; i < total; i++)
                {
                    indices[i] = i;
                }
                Array.Sort(fitnessValues, indices, 0, total);
                Array.Reverse(indices, 0, total);
            }
            else
            {
                double fitness_sum = fitnessValues.Sum();

                for (int i = 0; i < total; i++)
                {
                    double random_position = randomizer.NextDouble() * fitness_sum;
                    int k = 0;
                    double accumulated_fitness = 0;

                    while(true)
                    {
                        accumulated_fitness += fitnessValues[k];
                        if (random_position <= accumulated_fitness)
                        {
                            indices[i] = k;
                            break;
                        }
                        else
                            k += 1;
                    }
                }
            }

            // Gene-wise copy genes from selected parents and children to temparray matrix
            for (int i = 0; i < populationSize; i++)
            {
                for (int j = 0; j < numberOfGenes; j++)
                    selectedChromosomes[i][j] = chromosomes[indices[i]][j];
                selectedObjectives[i] = objectives[indices[i]];
            }

            // gene-wise copy genes back to our population
            for (int i = 0; i < populationSize; i++)
            {
                for (int j = 0; j < numberOfGenes; j++)
                    chromosomes[i][j] = selectedChromosomes[i][j];
                objectives[i] = selectedObjectives[i];
            }
        }

        protected void PerformMutationOperation()
        {
            
            if(mutationType==MutationMode.GeneNumberBased)
            {
                int limit = populationSize * numberOfGenes;
                int numberOfMutateGenes = (int)(mutationRate * populationSize * numberOfGenes);
                
                for (int i = 0; i < populationSize; i++)
                {
                    indices[i] = 0;
                    for (int j = 0; j < numberOfGenes; j++)
                        mutatedGenes[i][j] = false;
                }

                for(int i=0;i< numberOfMutateGenes; i++)
                {
                    int serialPos = randomizer.Next(limit);
                    int parentId, geneId;
                    parentId = serialPos / numberOfGenes;
                    geneId = serialPos % numberOfGenes;
                    indices[parentId] = int.MinValue;
                    mutatedGenes[parentId][geneId] = true;
                }

                numberOFMutatedChildren = 0;
                int childId = populationSize + numberOFCrossoveredChildren;
                for(int i=0;i<populationSize;i++)
                {
                    if(indices[i]==int.MinValue)
                    {
                        // mutation operation
                        MutateAParent(i, childId, mutatedGenes[i]);
                        objectives[childId] = objectiveFunction(chromosomes[childId]);
                        childId++;
                        numberOFMutatedChildren++;
                    }
                }    
            }
            else
            {
                int limit = populationSize;
                int numberOfMutatedPopulation = (int)(mutationRate * populationSize);

                for (int i = 0; i < populationSize; i++)
                    indices[i] = 0;

                for (int i = 0; i < numberOfMutatedPopulation; i++)
                {
                    int parentId;
                    parentId = randomizer.Next(limit);
                    indices[parentId] = int.MinValue;
                }

                numberOFMutatedChildren = 0;
                int childId = populationSize + numberOFCrossoveredChildren;
                for (int i = 0; i < populationSize; i++)
                {
                    if (indices[i] == int.MinValue)
                    {
                        // mutation operation
                        MutateAParent(i, childId);
                        objectives[childId] = objectiveFunction(chromosomes[childId]);
                        childId++;
                        numberOFMutatedChildren++;
                    }
                }
            }
        }

        public virtual void MutateAParent(int parentId, int childId, bool[] mutatedFlag)
        {
            throw new NotImplementedException();
        }

        public virtual void MutateAParent(int parentId, int childId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Run until stopping criteria is satisfied
        /// </summary>
        public void RunToEnd()
        {
            for (int i = 0; i < iterationLimit; i++)
                RunOneIteration();
        }
    }


    public enum OptimizationType { Minimization, Maximization}
    public enum MutationMode { GeneNumberBased, PopulationSizeBased}
    public enum SelectionMode { Deterministic, Stochastic}
    public delegate double ObjectiveFunction<T>(T[] aSolution);
}
