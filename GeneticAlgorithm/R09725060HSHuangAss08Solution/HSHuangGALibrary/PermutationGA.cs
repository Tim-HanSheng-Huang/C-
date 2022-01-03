using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSHuangGALibrary
{
    public class PermutationGA : GenericGASolver<int>
    {
        int[] m; 
        int[] n;
        
        public PermutationCrossoverOperator CrossoverOperator { set; get; } = PermutationCrossoverOperator.PartialMappedX;

        public PermutationMutationOperator MutationOperator { set; get; } = PermutationMutationOperator.Inversion;


        public PermutationGA(int numberOFVariables, OptimizationType optimizationType, 
            ObjectiveFunction<int> objectiveFunction, Panel hostPanelForMonitor = null)
            :base(numberOFVariables, optimizationType, objectiveFunction, hostPanelForMonitor)
        {
            m = new int[numberOFVariables];
            n = new int[numberOFVariables];
        }

        public override void CrossoverAPairParent(int father, int mother, int child1, int child2)
        {
            int i1 = randomizer.Next(numberOfGenes);
            int i2 = randomizer.Next(numberOfGenes);
            int temp;
            if (i1 > i2) 
            {
                temp = i1;
                i1 = i2;
                i2 = temp;
            }
            
            switch (CrossoverOperator)
            {
                case PermutationCrossoverOperator.PartialMappedX:
                    int[] p1 = chromosomes[father];
                    int[] p2 = chromosomes[mother];
                    int[] c1 = chromosomes[child1];
                    int[] c2 = chromosomes[child2];
                    for (int i = 0; i < numberOfGenes; i++)
                        m[i] = -1;
                    for (int i = i1; i < i2; i++)
                    {
                        if (p1[i] == p2[i])
                            continue;

                        if (m[p1[i]] == -1 && m[p2[i]] == -1)
                        {
                            m[p1[i]] = p2[i];
                            m[p2[i]] = p1[i];
                        }
                        else if (m[p1[i]] == -1)
                        {
                            m[p1[i]] = m[p2[i]];
                            m[m[p2[i]]] = p1[i];
                            m[p2[i]] = -2;
                        }
                        else if (m[p2[i]] == -1)
                        {
                            m[p2[i]] = m[p1[i]];
                            m[m[p1[i]]] = p2[i];
                            m[p1[i]] = -2;
                        }
                        else
                        {
                            m[m[p2[i]]] = m[p1[i]];
                            m[m[p1[i]]] = m[p2[i]];
                            m[p1[i]] = -3;
                            m[p2[i]] = -3;
                        }
                    }
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i1 <= i && i < i2)
                        {
                            c1[i] = p2[i];
                            c2[i] = p1[i];
                        }
                        else
                        {
                            if (m[p1[i]] < 0)
                                c1[i] = p1[i];
                            else
                                c1[i] = m[p1[i]];

                            if (m[p2[i]] < 0)
                                c2[i] = p2[i];
                            else
                                c2[i] = m[p2[i]];
                        }
                    }
                    break;
                case PermutationCrossoverOperator.OrderX:
                    // child1 assignment
                    for (int i = 0; i < numberOfGenes; i++)
                        m[i] = -1;
                    for (int i = i1; i <= i2; i++)
                    {
                        for(int j=0;j<numberOfGenes;j++)
                        {
                            if (chromosomes[mother][j] == chromosomes[father][i])
                            {
                                m[j] = -999; // this position cannot be assigned to child
                                break;
                            }
                        }
                    }
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i >= i1 && i <= i2)
                            chromosomes[child1][i] = chromosomes[father][i];
                        else
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                if (m[j] == -1)
                                {
                                    chromosomes[child1][i] = chromosomes[mother][j];
                                    m[j] = -999;
                                    break;
                                }
                            }
                        }
                    }
                    // child2 assignment
                    for (int i = 0; i < numberOfGenes; i++)
                        m[i] = -1;
                    for (int i = i1; i <= i2; i++)
                    {
                        for (int j = 0; j < numberOfGenes; j++)
                        {
                            if (chromosomes[father][j] == chromosomes[mother][i])
                            {
                                m[j] = -999; // this position cannot be assigned to child
                                break;
                            }
                        }
                    }
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (i >= i1 && i <= i2)
                            chromosomes[child2][i] = chromosomes[mother][i];
                        else
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                if (m[j] == -1)
                                {
                                    chromosomes[child2][i] = chromosomes[father][j];
                                    m[j] = -999;
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case PermutationCrossoverOperator.PositionBasedX:
                    for (int i = 0; i < m.Length; i++)
                        m[i] = randomizer.Next(2); // if m[i]==0, which means this position is unchanged                    
                    // child1 assignment
                    for (int i = 0; i < n.Length; i++)
                        n[i] = -1;
                    for (int i = 0; i < m.Length; i++)
                    {
                        if (m[i] == 0)
                        {
                            for(int j=0;j<numberOfGenes;j++)
                            {
                                if (chromosomes[mother][j] == chromosomes[father][i])
                                {
                                    n[j] = -999;
                                    break;
                                }    
                            }
                        } 
                    }
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (m[i] == 0)
                            chromosomes[child1][i] = chromosomes[father][i];
                        else
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                if (n[j] == -1)
                                {
                                    chromosomes[child1][i] = chromosomes[mother][j];
                                    n[j] = -999;
                                    break;
                                }
                            }
                        }
                    }
                    // child2 assignment
                    for (int i = 0; i < n.Length; i++)
                        n[i] = -1;
                    for (int i = 0; i < m.Length; i++)
                    {
                        if (m[i] == 0)
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                if (chromosomes[father][j] == chromosomes[mother][i])
                                {
                                    n[j] = -999;
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (m[i] == 0)
                            chromosomes[child2][i] = chromosomes[mother][i];
                        else
                        {
                            for (int j = 0; j < numberOfGenes; j++)
                            {
                                if (n[j] == -1)
                                {
                                    chromosomes[child2][i] = chromosomes[father][j];
                                    n[j] = -999;
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case PermutationCrossoverOperator.OrderBasedX:
                    int current_m = 0;
                    int current_n = 0;
                    for (int i = 0; i < m.Length; i++)
                    {
                        m[i] = randomizer.Next(2); // if m[i]==1, which means this position is chosen
                        n[i] = 0;
                    }  
                    for(int i=0;i<m.Length;i++)
                    {
                        if (m[i] == 1)
                        {
                            for(int j=0;j<n.Length;j++)
                            {
                                if (chromosomes[father][i] == chromosomes[mother][j])
                                    n[j] = 1;
                            }
                        }
                    }
                    // child1 assignment
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (n[i] == 1)
                        {
                            for (int j = current_m; j < numberOfGenes; j++)
                            {
                                if (m[j] == 1)
                                {
                                    chromosomes[child1][i] = chromosomes[father][j];
                                    current_m = j + 1;
                                    break;
                                }
                            }
                        }
                        else
                            chromosomes[child1][i] = chromosomes[mother][i];
                    }
                    // child2 assignment
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        if (m[i] == 1)
                        {
                            for (int j = current_n; j < numberOfGenes; j++)
                            {
                                if (n[j] == 1)
                                {
                                    chromosomes[child2][i] = chromosomes[mother][j];
                                    current_n = j + 1;
                                    break;
                                }
                            }
                        }
                        else
                            chromosomes[child2][i] = chromosomes[father][i];
                    }
                    break;
            }
        }

        public override void MutateAParent(int parentId, int childId, bool[] mutatedFlag)
        {
            // if user choose GeneNumberBased, it would just simply change the mutated gene with a random gene in the permutation
            for(int i=0;i<numberOfGenes;i++)
            {
                if(mutatedFlag[i])
                {
                    for (int j = 0; j < numberOfGenes; j++)
                        chromosomes[childId][j] = chromosomes[parentId][j];

                    int i1 = randomizer.Next(numberOfGenes);
                    int temp = chromosomes[childId][i1];
                    chromosomes[childId][i1] = chromosomes[childId][i];
                    chromosomes[childId][i] = temp;
                }
            }
        }

        public override void MutateAParent(int parentId, int childId)
        {
            int i1 = randomizer.Next(numberOfGenes);
            int i2 = randomizer.Next(numberOfGenes);
            int temp;

            switch (MutationOperator)
            {
                case PermutationMutationOperator.Inversion:
                    if (i1 > i2)
                    {
                        temp = i1;
                        i1 = i2;
                        i2 = temp;
                    }
                    for (int i = 0; i < numberOfGenes; i++)
                    {
                        chromosomes[childId][i] = chromosomes[parentId][i];
                    }
                    for (int i = 0; i <= i2 - i1; i++)
                    {
                        chromosomes[childId][i1 + i] = chromosomes[parentId][i2 - i];
                    }
                    break;
                case PermutationMutationOperator.Insertion:
                    for(int i=0;i<numberOfGenes;i++)
                    {
                        chromosomes[childId][i] = chromosomes[parentId][i];
                    }
                    temp = chromosomes[parentId][i1];
                    if (i1 < i2)
                    {
                        for (int i = i1; i <= i2; i++)
                        {
                            if (i == i2)
                                chromosomes[childId][i] = temp;
                            else
                                chromosomes[childId][i] = chromosomes[childId][i + 1];
                        }
                    }
                    else
                    {
                        for (int i = i1; i >= i2; i--)
                        {
                            if (i == i2)
                                chromosomes[childId][i] = temp;
                            else
                                chromosomes[childId][i] = chromosomes[childId][i - 1];
                        }
                    }
                    break;
                case PermutationMutationOperator.Displacement:
                    int current_pos_unselect = 0;
                    int current_pos_insubtour = 0;
                    if (i1 > i2)
                    {
                        temp = i1;
                        i1 = i2;
                        i2 = temp;
                    }
                    for(int i=0;i<numberOfGenes;i++)
                    {
                        n[i] = -1;
                        m[i] = -1;
                    }
                    for(int i=0;i<numberOfGenes;i++)
                    {
                        if (i < i1 || i > i2)
                        {
                            n[current_pos_unselect] = chromosomes[parentId][i]; // n is array that store the unselected gene
                            current_pos_unselect++;
                        }
                        else
                        {
                            m[current_pos_insubtour] = chromosomes[parentId][i]; // m is array that store the subtour
                            current_pos_insubtour++;
                        }
                    }
                    int cutting_pos = randomizer.Next(current_pos_unselect+1); // select a insertion point

                    int num_subtour = current_pos_insubtour;
                    current_pos_unselect = 0;
                    current_pos_insubtour = 0;

                    for(int i=0;i<numberOfGenes;i++)
                    {
                        if (i < cutting_pos || i > cutting_pos + num_subtour)
                        {
                            chromosomes[childId][i] = n[current_pos_unselect];
                            current_pos_unselect++;
                        }
                        else
                        {
                            chromosomes[childId][i] = m[current_pos_insubtour];
                            current_pos_insubtour++;
                        }
                    }
                    break;
                case PermutationMutationOperator.ReciprocalExchange:
                    for(int i=0;i<numberOfGenes;i++)
                    {
                        chromosomes[childId][i] = chromosomes[parentId][i];
                    }
                    temp = chromosomes[childId][i1];
                    chromosomes[childId][i1] = chromosomes[childId][i2];
                    chromosomes[childId][i2] = temp;
                    break;
            }
        }


        public override void InitializePopulation()
        {
            for (int r = 0; r < populationSize; r++)
            {                
                ShuffleAnArray(chromosomes[r], numberOfGenes);
            }    
        }


    }

    /// <summary>
    /// Canonical crossover operator
    /// </summary>
    public enum PermutationCrossoverOperator
    {
        PartialMappedX, OrderX, PositionBasedX, OrderBasedX //CycleX, SubtourExchange
    }

    public enum PermutationMutationOperator
    {
        Inversion, Insertion, Displacement, ReciprocalExchange
    }


}
