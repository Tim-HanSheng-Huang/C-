using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09725060HSHunagBinPacking
{
    class BinPackingGA
    {
        protected Random randomizer = new Random();

        // data field
        protected double[] itemWeights;
        
        int numberOfItems;

        protected double[][][] chromosomes;
        protected double[][] binAccumulation;
        protected double[] objectives;
        protected double[] fitnessValues;
        protected int[] binused;


        protected double[][][] selectedChromosomes;
        protected double[] selectedObjectives;

        protected double[][] soFarTheBestSolution;
        protected double soFarTheBestObjectiveValue;
        protected double soFarTheBestBinUsed;

        protected double iterationBestObjective;
        protected double iterationAverageObjective;

        protected int[] indices;

        protected int populationSize = 10;
        protected double crossoverRate = 0.8;
        protected double mutationRate = 0.5;

        protected double[] itemWeightsTemp;
        protected double[] crossoveritemrecordTemp;
        protected double[] binAccumulationCalTemp;

        // Just For Debugging~
        protected int[] itemnumberTemp;
        

        protected ObjectiveFunction<double> objectiveFunction = null;
        protected SelectionMode selectionType = SelectionMode.Deterministic;

        int iterationLimit = 100;
        int iterationId = 0;
        int k_obj = 2;

        bool sofarthebestisupdated;

        int numberOFCrossoveredChildren;
        int numberOFMutatedChildren;

        double[][] aSolutionTemp;
        double binCapacity;

        [Browsable(false)]
        public double SoFarTheBestObjectiveValue { get => soFarTheBestObjectiveValue;}
        [Browsable(false)]
        public double IterationAverageObjective { get => iterationAverageObjective;}
        [Browsable(false)]
        public double SoFarTheBestBinUsed { get => soFarTheBestBinUsed; }
        [Browsable(false)]
        public int IterationId { get => iterationId; }
        [Browsable(false)]
        public double IterationBestObjective { get => iterationBestObjective; }
        [Browsable(false)]
        public double[][] SoFarTheBestSolution { get => soFarTheBestSolution; }
        [Browsable(false)]
        public bool Sofarthebestisupdated { get => sofarthebestisupdated; }

        [Category("Stopping Condition")]
        [Description("Stopping condition of the upper limit of iteration")]
        public int IterationLimit 
        { 
            get => iterationLimit;
            set
            {
                if (value > 0)
                    iterationLimit = value;
            }
        }

        [Category("GA Parameters")]
        [Description("Number of chromosomes employed")]
        public int PopulationSize
        {
            get => populationSize;
            set
            {
                if (value > 1)
                    populationSize = value;
            }
        }
        [Category("GA Parameters")]
        [Description("The ratio of chromosomes need to perform crossover operation")]
        public double CrossoverRate
        {
            get => crossoverRate;
            set
            {
                if (value >= 0 && value <= 1.0)
                    crossoverRate = value;
            }
        }
        [Category("GA Parameters")]
        [Description("The percentage of the total number of genes to be operated by the mutation")]
        public double MutationRate
        {
            get => mutationRate;
            set
            {
                if (value >= 0 && value <= 1.0)
                    mutationRate = value;
            }
        }
        [Category("Operation Mode")]
        [Description("Genetic selection mode setting")]
        public SelectionMode SelectionType { get => selectionType; set => selectionType = value; }

        [Category("GGA Cost Function Parameters")]
        [Description("The parameter of cost function of GGA")]
        public int K_obj
        {
            get => k_obj;
            set
            {
                if (value > 1)
                    k_obj = value;
            }
        }

        public BinPackingGA(int numberOfItems, double[] itemWeights, double binCap, ObjectiveFunction<double> objectiveFunction)
        {
            this.numberOfItems = numberOfItems;
            this.itemWeights = itemWeights;
            this.binCapacity = binCap;
            this.objectiveFunction = objectiveFunction;
        }


        public void Reset()
        {
            iterationId = 0;

            int ThreeTimesSize = populationSize * 3;
            objectives = new double[ThreeTimesSize];
            fitnessValues = new double[ThreeTimesSize];
            binused = new int[ThreeTimesSize];
            indices = new int[ThreeTimesSize];
            itemWeightsTemp = new double[numberOfItems];
            crossoveritemrecordTemp = new double[numberOfItems];
            binAccumulationCalTemp = new double[numberOfItems];
            selectedObjectives = new double[populationSize];

            // For Debugging
            itemnumberTemp = new int[ThreeTimesSize];


            soFarTheBestSolution = new double[numberOfItems][];
            for (int i = 0; i < numberOfItems; i++)
                soFarTheBestSolution[i] = new double[numberOfItems];

            sofarthebestisupdated = false;

            soFarTheBestObjectiveValue = -1;

            chromosomes = new double[ThreeTimesSize][][];
            for (int i=0;i< ThreeTimesSize; i++)
            {
                chromosomes[i] = new double[numberOfItems][];
                for (int j = 0; j < numberOfItems; j++)
                {
                    chromosomes[i][j] = new double[numberOfItems];
                    for (int k = 0; k < numberOfItems; k++)
                        chromosomes[i][j][k] = -1;
                }
            }

            selectedChromosomes = new double[populationSize][][];
            for(int i=0;i<populationSize;i++)
            {
                selectedChromosomes[i] = new double[numberOfItems][];
                for(int j=0;j<numberOfItems;j++)
                {
                    selectedChromosomes[i][j] = new double[numberOfItems];
                    for (int k = 0; k < numberOfItems; k++)
                        selectedChromosomes[i][j][k] = -1;
                }
            }

            binAccumulation = new double[ThreeTimesSize][];
            for (int i = 0; i < ThreeTimesSize; i++)
                binAccumulation[i] = new double[numberOfItems];

            InitializePopulation();

            // Evaluation objectives of the population
            for (int i = 0; i < populationSize; i++)
            {
                objectives[i] = objectiveFunction(chromosomes[i], binAccumulation[i], k_obj);
                binused[i] = CalculateBinUsed(chromosomes[i]);
            }
        }

        public void RunOneIteration()
        {
            PerformCrossoverOperation();
            PerformMutationOperation();
            UpdateSoFarTheBestSolutionAndObjective();
            PerformSelectionOperation();
            PerformInversionOperation();

            iterationId++;
        }

        private void PerformInversionOperation()
        {
            for (int i = 0; i < populationSize; i++)
                InvertAChromosomes(chromosomes[i], binAccumulation[i]);

        }

        private void PerformSelectionOperation()
        {
            int total = populationSize + numberOFCrossoveredChildren + numberOFMutatedChildren;
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

                    while (true)
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
            for (int i=0;i<populationSize;i++)
            {
                for(int j=0;j<numberOfItems;j++)
                    for(int k=0;k<numberOfItems;k++)
                        selectedChromosomes[i][j][k] = chromosomes[indices[i]][j][k];
                selectedObjectives[i] = objectives[indices[i]];
            }

            // gene-wise copy genes back to our population
            for (int i = 0; i < populationSize; i++)
            {
                for (int j = 0; j < numberOfItems; j++)
                    for (int k = 0; k < numberOfItems; k++)
                        chromosomes[i][j][k] = selectedChromosomes[i][j][k];
                objectives[i] = selectedObjectives[i];
                binused[i] = CalculateBinUsed(chromosomes[i]);
                binAccumulation[i] = CalculateBinAccumulation(chromosomes[i]);
            }

        }

        private void UpdateSoFarTheBestSolutionAndObjective()
        {
            SetFitnessFromObjectives();

            sofarthebestisupdated = false;
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

            // check whether iterationBestObjective value is better than the current best objective
            // If it does, update the best objective and gene-wise copy the iteration best chromosomes to so-far-the-best solution
            if (objectives[iteration_bestid] > soFarTheBestObjectiveValue)
            {
                soFarTheBestObjectiveValue = objectives[iteration_bestid];
                soFarTheBestBinUsed = binused[iteration_bestid];
                sofarthebestisupdated = true;

                for(int p=0;p<numberOfItems;p++)
                    for(int q=0;q<numberOfItems;q++)
                        soFarTheBestSolution[p][q] = chromosomes[iteration_bestid][p][q];

            }
        }

        private void SetFitnessFromObjectives()
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
                fitnessValues[i] = b + (objectives[i] - o_min);

        }

        private void PerformMutationOperation()
        {
            int numberOfMutateChromosomes = (int)(mutationRate * populationSize);
            numberOFMutatedChildren = numberOfMutateChromosomes;
            int childID = populationSize + numberOFCrossoveredChildren;

            for (int i=0;i<numberOfMutateChromosomes;i++)
            {
                int parentID = randomizer.Next(populationSize);
                int binused_parent = CalculateBinUsed(chromosomes[parentID]);
                int remainingbins = binused_parent;
                // numberOfMutatedbins represents how much bins need to be deleted and numberOfMutatedbins do not exceed half of number of binsused in parent
                int numberOfMutatedbins = randomizer.Next(1, (int)(binused_parent / 2));
                int binAssignIndex = 0;

                for (int m = 0; m < numberOfItems; m++)
                    for (int n = 0; n < numberOfItems; n++)
                        chromosomes[childID][m][n] = chromosomes[parentID][m][n];

                for (int j = 0; j < numberOfMutatedbins; j++) // delete the selected bins (Do not copy from parent chromosomes)
                {
                    binAssignIndex = 0;
                    int selectedBinIndex = randomizer.Next(remainingbins);
                    for (int p = 0; p < selectedBinIndex; p++)
                    {
                        for (int q = 0; q < numberOfItems; q++)
                        {
                            chromosomes[childID][binAssignIndex][q] = chromosomes[childID][p][q];
                        }
                        binAssignIndex++;
                    }

                    for (int p = selectedBinIndex + 1; p < numberOfItems; p++)
                    {
                        for (int q = 0; q < numberOfItems; q++)
                        {
                            chromosomes[childID][binAssignIndex][q] = chromosomes[childID][p][q];
                        }
                        binAssignIndex++;
                    }
                    remainingbins--;
                }

                for (int p = binAssignIndex; p <= numberOfItems; p++)
                    for (int q = 0; q < numberOfItems; q++)
                        chromosomes[childID][binAssignIndex][q] = -1;

                ShuffleAnArray(itemWeights, itemWeights.Length);
                FirstFitFill(chromosomes[childID]);

                binused[childID] = CalculateBinUsed(chromosomes[childID]);
                binAccumulation[childID] = CalculateBinAccumulation(chromosomes[childID]);
                objectives[childID] = objectiveFunction(chromosomes[childID], binAccumulation[childID], k_obj);

                childID++;
            }
        }

        private void PerformCrossoverOperation()
        {
            numberOFCrossoveredChildren = (int)(populationSize * crossoverRate);
            if (numberOFCrossoveredChildren % 2 == 1)
                numberOFCrossoveredChildren--;
            ShuffleIndices(indices, populationSize);
            int father, mother, child1 = populationSize, child2 = populationSize + 1;
            for (int i = 0; i < numberOFCrossoveredChildren; i += 2)
            {
                father = indices[i];
                mother = indices[i + 1];
                CrossoverAPairParent(father, mother, child1, child2);
                binAccumulation[child1] = CalculateBinAccumulation(chromosomes[child1]);
                binAccumulation[child2] = CalculateBinAccumulation(chromosomes[child2]);
                binused[child1] = CalculateBinUsed(chromosomes[child1]);
                binused[child2] = CalculateBinUsed(chromosomes[child2]);
                objectives[child1] = objectiveFunction(chromosomes[child1], binAccumulation[child1], k_obj);
                objectives[child2] = objectiveFunction(chromosomes[child2], binAccumulation[child2], k_obj);

                child1 += 2;
                child2 += 2;
            }
        }

        private void CrossoverAPairParent(int father, int mother, int child1, int child2)
        {
            // reset child position
            for(int i=0;i<numberOfItems;i++)
            {
                for (int j = 0; j < numberOfItems; j++)
                {
                    chromosomes[child1][i][j] = -1;
                    chromosomes[child2][i][j] = -1;
                }
            }

            int cutPosFather1 = randomizer.Next(binused[father]);
            int cutPosFather2 = randomizer.Next(binused[father]);
            int temp;
            if (cutPosFather1 > cutPosFather2)
            {
                temp = cutPosFather1;
                cutPosFather1 = cutPosFather2;
                cutPosFather2 = temp;
            }

            int cutPosMother1 = randomizer.Next(binused[mother]);
            int cutPosMother2 = randomizer.Next(binused[mother]);
            if (cutPosMother1 > cutPosMother2)
            {
                temp = cutPosMother1;
                cutPosMother1 = cutPosMother2;
                cutPosMother2 = temp;
            }

            int itemCount;
            int binAssignIndex;

            // child1 assignment
            itemCount = 0;
            binAssignIndex = 0;
            for (int i = 0; i < numberOfItems; i++)
                crossoveritemrecordTemp[i] = -1;

            for (int i = cutPosMother1; i <= cutPosMother2; i++)
            {
                for (int j = 0; j < numberOfItems; j++)
                {
                    if (chromosomes[mother][i][j] == -1)
                        break;
                    else
                    {
                        crossoveritemrecordTemp[itemCount] = chromosomes[mother][i][j];
                        itemCount++;
                    }
                }
            }

            for (int i = 0; i < cutPosFather1; i++)
            {
                bool deleted = false;
                for (int j = 0; j < numberOfItems; j++)
                {
                    if (chromosomes[father][i][j] == -1)
                        break;
                    for(int k=0;k<numberOfItems;k++)
                    {
                        if (chromosomes[father][i][j] == crossoveritemrecordTemp[k])
                        {
                            crossoveritemrecordTemp[k] = -999;
                            deleted = true;
                            break;
                        }    
                    }
                }
                if (!deleted) // father bin j does not contain any items in selected mother bins
                {
                    for (int p = 0; p < numberOfItems; p++)
                        chromosomes[child1][binAssignIndex][p] = chromosomes[father][i][p];
                    binAssignIndex++;
                }
            }

            for (int i = cutPosMother1; i <= cutPosMother2; i++)
            {
                for (int j = 0; j < numberOfItems; j++)
                    chromosomes[child1][binAssignIndex][j] = chromosomes[mother][i][j];
                binAssignIndex++;
            }

            for (int i = cutPosFather2 + 1; i < binused[father]; i++)
            {
                bool deleted = false;
                for (int j = 0; j < numberOfItems; j++)
                {
                    
                    if (chromosomes[father][i][j] == -1)
                        break;
                    for (int k = 0; k < numberOfItems; k++)
                    {
                        if (chromosomes[father][i][j] == crossoveritemrecordTemp[k])
                        {
                            crossoveritemrecordTemp[k] = -999;
                            deleted = true;
                            break;
                        }
                    }
                }
                if (!deleted) // father bin j does not contain any items in selected mother bins
                {
                    for (int p = 0; p < numberOfItems; p++)
                        chromosomes[child1][binAssignIndex][p] = chromosomes[father][i][p];
                    binAssignIndex++;
                }
            }

            for (int i = binAssignIndex; i <= numberOfItems; i++)
                for (int j = 0; j < numberOfItems; j++)
                    chromosomes[child1][binAssignIndex][j] = -1;

            FirstFitFill(chromosomes[child1]);


            // child2 assignment
            itemCount = 0;
            binAssignIndex = 0;
            for (int i = 0; i < numberOfItems; i++)
                crossoveritemrecordTemp[i] = -1;

            for (int i = cutPosFather1; i <= cutPosFather2; i++)
            {
                for (int j = 0; j < numberOfItems; j++)
                {
                    if (chromosomes[father][i][j] == -1)
                        break;
                    else
                    {
                        crossoveritemrecordTemp[itemCount] = chromosomes[father][i][j];
                        itemCount++;
                    }
                }
            }

            for (int i = 0; i < cutPosMother1; i++)
            {
                bool deleted = false;
                for (int j = 0; j < numberOfItems; j++)
                {
                    if (chromosomes[mother][i][j] == -1)
                        break;
                    for (int k = 0; k < numberOfItems; k++)
                    {
                        if (chromosomes[mother][i][j] == crossoveritemrecordTemp[k])
                        {
                            crossoveritemrecordTemp[k] = -999;
                            deleted = true;
                            break;
                        }
                    }
                }
                if (!deleted) // father bin j does not contain any items in selected mother bins
                {
                    for (int p = 0; p < numberOfItems; p++)
                        chromosomes[child2][binAssignIndex][p] = chromosomes[mother][i][p];
                    binAssignIndex++;
                }
            }

            for (int i = cutPosFather1; i <= cutPosFather2; i++)
            {
                for (int j = 0; j < numberOfItems; j++)
                    chromosomes[child2][binAssignIndex][j] = chromosomes[father][i][j];
                binAssignIndex++;
            }

            for (int i = cutPosMother2 + 1; i < binused[mother]; i++)
            {
                bool deleted = false;
                for (int j = 0; j < numberOfItems; j++)
                {
                    if (chromosomes[mother][i][j] == -1)
                        break;
                    for (int k = 0; k < numberOfItems; k++)
                    {
                        if (chromosomes[mother][i][j] == crossoveritemrecordTemp[k])
                        {
                            crossoveritemrecordTemp[k] = -999;
                            deleted = true;
                            break;
                        }
                    }
                }
                if (!deleted) // father bin j does not contain any items in selected mother bins
                {
                    for (int p = 0; p < numberOfItems; p++)
                        chromosomes[child2][binAssignIndex][p] = chromosomes[mother][i][p];
                    binAssignIndex++;
                }
            }

            for (int i = binAssignIndex; i <= numberOfItems; i++)
                for (int j = 0; j < numberOfItems; j++)
                    chromosomes[child2][binAssignIndex][j] = -1;


            FirstFitFill(chromosomes[child2]);

        }

        public void FirstFitFill(double[][] aSolution)
        {
            for (int i = 0; i < numberOfItems; i++)
                itemWeightsTemp[i] = itemWeights[i];

            for(int i=0;i<numberOfItems;i++)
            {
                for(int j=0;j<numberOfItems;j++)
                {
                    for(int k=0;k<numberOfItems;k++)
                    {
                        if(aSolution[i][j]==itemWeightsTemp[k])
                        {
                            itemWeightsTemp[k] = -999;
                            break;
                        }
                    }
                }
            }

            int binused_temp = CalculateBinUsed(aSolution);

            for (int i = 0; i < numberOfItems; i++)
            {
                if (itemWeightsTemp[i] == -999)
                    continue;

                for (int j = 0; j < numberOfItems; j++)
                {
                    double accumulationtemp = 0.0;
                    int insertpos = 0;
                    for (int k = 0; k < numberOfItems; k++)
                    {
                        if (aSolution[j][k] == -1)
                        {
                            insertpos = k;
                            break;
                        }
                        accumulationtemp += aSolution[j][k];
                    }

                    if (j >= binused_temp)
                    {
                        binused_temp++;
                        aSolution[j][0] = itemWeights[i];
                        break;
                    }

                    if (accumulationtemp + itemWeightsTemp[i] <= binCapacity)
                    {
                        aSolution[j][insertpos] = itemWeightsTemp[i];
                        break;
                    }
                }
            }
        }

        public void ShuffleAnArray(double[] array, int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                int changing_pos = randomizer.Next(limit);
                double temp = array[i];
                array[i] = array[changing_pos];
                array[changing_pos] = temp;
            }
        }

        public int CalculateItemNumber(double[][] aSolution) // For Debugging
        {
            int itemnumberaccumulation = 0;
            for(int i=0;i<numberOfItems;i++)
            {
                if (aSolution[i][0] == -1)
                    break;

                for (int j=0;j<numberOfItems;j++)
                {
                    if (aSolution[i][j] == -1)
                        break;
                    itemnumberaccumulation++;
                }
            }

            return itemnumberaccumulation;
        }

        public int CalculateBinUsed(double[][] aSolution)
        {
            int BinUsed = 0;
            for (int i = 0; i < aSolution.Length; i++)
            {
                if (aSolution[i][0] == -1) // there is no more bin after(including) bin i
                    break;
                BinUsed++;
            }

            return BinUsed;
        }

        public double[] CalculateBinAccumulation(double[][] aSolution)
        {
            for (int i = 0; i < numberOfItems; i++)
                binAccumulationCalTemp[i] = -1;

            for(int i=0;i<numberOfItems;i++)
            {
                if (aSolution[i][0] == -1)
                    break;

                double accumulationtemp = 0.0;
                for(int j=0;j<numberOfItems;j++)
                {
                    if (aSolution[i][j] == -1)
                        break;
                    accumulationtemp += aSolution[i][j];
                }
                binAccumulationCalTemp[i] = accumulationtemp;
            }
            return binAccumulationCalTemp;
        }

        protected void ShuffleIndices(int[] array, int limit)
        {
            for (int i = 0; i < limit; i++)
                array[i] = i;

            for (int i = 0; i < limit; i++)
            {
                int changing_pos = randomizer.Next(limit);
                int temp = array[i];
                array[i] = array[changing_pos];
                array[changing_pos] = temp;
            }
        }

        private void InvertAChromosomes(double[][] aSolution, double[] binAccumulation)
        {
            for (int i = 0; i < binAccumulation.Length; i++)
                binAccumulationCalTemp[i] = binAccumulation[i];

            int wellfitbinID1 = 0;
            int wellfitbinID2 = 0;
            int interval = randomizer.Next(1, 3);

            for (int i = 0; i < binAccumulationCalTemp.Length; i++)
            {
                if (binAccumulationCalTemp[i] == -1)
                    break;
                if (binAccumulationCalTemp[i] > binAccumulationCalTemp[wellfitbinID1])
                {
                    wellfitbinID1 = i;
                    binAccumulationCalTemp[i] = -999;
                }
            }

            while(interval>0)
            {
                for (int i = 0; i < binAccumulationCalTemp.Length; i++)
                {
                    if (binAccumulationCalTemp[i] > binAccumulationCalTemp[wellfitbinID1])
                    {
                        wellfitbinID2 = i;
                        binAccumulationCalTemp[i] = -999;
                    }
                }
                interval--;
            }

            int temp;
            if (wellfitbinID1 > wellfitbinID2)
            {
                temp = wellfitbinID1;
                wellfitbinID1 = wellfitbinID2;
                wellfitbinID2 = temp;
            }

            int beginID = wellfitbinID1 + 1;
            int endID = wellfitbinID2;

            while(beginID<endID)
            {
                for(int i=0;i<numberOfItems;i++)
                {
                    double temptemp;
                    temptemp = aSolution[beginID][i];
                    aSolution[beginID][i] = aSolution[endID][i];
                    aSolution[endID][i] = temptemp;
                }
                beginID++;
                endID--;
            }
        }

        public void InitializePopulation()
        {
            string outcometemp = ""; //temp


            for (int i=0;i<populationSize;i++)
            {
                for (int j = 0; j < numberOfItems; j++)
                    binAccumulation[i][j] = -1;

                for (int j = 0; j < numberOfItems; j++)
                    for (int k = 0; k < numberOfItems; k++)
                        chromosomes[i][j][k] = -1;
            }


            for (int i = 0; i < populationSize; i++)
            {
                ShuffleAnArray(itemWeights, itemWeights.Length);

                int numberOfOpenBins = 0;
                for (int j = 0; j < numberOfItems; j++) // 看看塞到第幾個item了
                {
                    for (int k = 0; k < numberOfItems; k++)
                    {
                        // item can be assigned to bin k
                        if (binAccumulation[i][k] != -1 && binAccumulation[i][k] + itemWeights[j] <= binCapacity) 
                        {
                            int insertpos = 0;
                            while (chromosomes[i][k][insertpos] != -1)
                                insertpos++;
                            chromosomes[i][k][insertpos] = itemWeights[j];
                            binAccumulation[i][k] += itemWeights[j];
                            break;
                        }
                        // open new bin
                        if (k >= numberOfOpenBins)
                        {
                            binAccumulation[i][k] = 0; // open new bin
                            numberOfOpenBins++;
                            chromosomes[i][k][0] = itemWeights[j];
                            binAccumulation[i][k] += itemWeights[j];
                            break;
                        }
                    }
                }
            }

        }


        public delegate double ObjectiveFunction<T>(double[][] aSolution, double[] binAccumulation, int k_Obj);

        public enum SelectionMode { Deterministic, Stochastic }

    }
}
