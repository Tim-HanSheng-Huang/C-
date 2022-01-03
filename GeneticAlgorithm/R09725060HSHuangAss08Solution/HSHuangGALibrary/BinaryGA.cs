using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSHuangGALibrary
{

    public enum BinaryCrossoverOperator
    {
        OnePointCut, TwoPointCut, NPointCut
    }


    public class BinaryGA : GenericGASolver<byte>
    {
        // PROPERTIES
        int[] pos_cutlocation;

        [Category("Binary Encoded GA")]
        [Description("Crossover Operator Options")]
        public BinaryCrossoverOperator CrossoverOperator
        {
            set;
            get;
        }
        = BinaryCrossoverOperator.OnePointCut;

        /// <summary>
        /// Create a Binary GA Solver
        /// </summary>
        /// <param name="numberOFVariables"></param>
        /// <param name="optimizationType"></param>
        /// <param name="objectiveFunction">The delegate to the objective function</param>


        public BinaryGA(int numberOFVariables, OptimizationType optimizationType, ObjectiveFunction<byte> objectiveFunction, Panel hostPanelForGAMonitor=null) : base(numberOFVariables, optimizationType, objectiveFunction, hostPanelForGAMonitor)
        {
            //int b = soFarTheBestSolution[0] * 8; 
            pos_cutlocation = new int[numberOFVariables]; //放到後面切點會用到
        }

       public override void InitializePopulation()
       {
            for(int r=0;r<populationSize;r++)
            {
                for(int c=0;c<numberOfGenes;c++)
                {
                    chromosomes[r][c] = (byte)randomizer.Next(2);
                }
            }
       }

        public override void CrossoverAPairParent(int father, int mother, int child1, int child2)
        {
            // implement crossover mechanism
            // chromosomes[father]
            switch(CrossoverOperator)
            {
                case BinaryCrossoverOperator.OnePointCut:
                    int cutPos = randomizer.Next(numberOfGenes);
                    for(int i=0;i<numberOfGenes;i++)
                    {
                        if(i>=cutPos)
                        {
                            chromosomes[child1][i] = chromosomes[father][i];
                            chromosomes[child2][i] = chromosomes[mother][i];
                        }
                        else
                        {
                            chromosomes[child1][i] = chromosomes[mother][i];
                            chromosomes[child2][i] = chromosomes[father][i];
                        }
                    }
                    break;
                case BinaryCrossoverOperator.TwoPointCut:
                    int cutPos1 = randomizer.Next(numberOfGenes);
                    int cutPos2 = randomizer.Next(numberOfGenes);
                    for(int i=0;i<numberOfGenes;i++)
                    {
                        if(i<=cutPos1)
                        {
                            chromosomes[child1][i] = chromosomes[father][i];
                            chromosomes[child2][i] = chromosomes[mother][i];
                        }
                        else if(i<=cutPos2)
                        {
                            chromosomes[child1][i] = chromosomes[mother][i];
                            chromosomes[child2][i] = chromosomes[father][i];
                        }
                        else
                        {
                            chromosomes[child1][i] = chromosomes[father][i];
                            chromosomes[child2][i] = chromosomes[mother][i];
                        }
                    }
                    break;
                case BinaryCrossoverOperator.NPointCut:
                    int n = randomizer.Next(numberOfGenes / 2);
                    for(int i=0;i<n;i++)
                    {
                        pos_cutlocation[i] = randomizer.Next(numberOfGenes);
                    }
                    Array.Sort(pos_cutlocation, 0, n);
                    // Do the gene assignments

                    for (int i = 0; i < pos_cutlocation.Length; i++)
                    {
                        int currentcut = pos_cutlocation[i];
                        int currentparent = father;
                        int j = 0;
                        while (j < currentcut && j < numberOfGenes)
                        {
                            if (j < currentcut)
                                chromosomes[child1][j] = chromosomes[currentparent][j];
                            else
                            {
                                chromosomes[child1][j] = chromosomes[currentparent][j];
                                if (currentparent == father)
                                    currentparent = mother;
                                else
                                    currentparent = father;
                            }
                            j++;
                        }
                        currentparent = father;
                        j = 0;
                        while (j < currentcut && j < numberOfGenes)
                        {
                            if (j < currentcut)
                                chromosomes[child2][j] = chromosomes[currentparent][j];
                            else
                            {
                                chromosomes[child2][j] = chromosomes[currentparent][j];
                                if (currentparent == father)
                                    currentparent = mother;
                                else
                                    currentparent = father;
                            }
                            j++;
                        }
                    }
                    break;

            }
        }


        public override void MutateAParent(int parentId, int childId, bool[] mutatedFlag)
        {
            for(int i=0;i<numberOfGenes;i++)
            {
                if(mutatedFlag[i])
                {
                    if (chromosomes[parentId][i] == 1)
                        chromosomes[childId][i] = 0;
                    else
                        chromosomes[childId][i] = 1;
                }
                else
                {
                    chromosomes[childId][i] = chromosomes[parentId][i];
                }
            }
        }

        public override void MutateAParent(int parentId, int childId)
        {
            int mutatedgene = randomizer.Next(numberOfGenes);
            
            for(int i=0;i<numberOfGenes;i++)
            {
                if(i==mutatedgene)
                {
                    if (chromosomes[parentId][mutatedgene] == 1)
                        chromosomes[childId][mutatedgene] = 0;
                    else
                        chromosomes[childId][mutatedgene] = 1;
                }
                else
                {
                    chromosomes[childId][i] = chromosomes[parentId][i];
                }
            }
        }
    }
}
