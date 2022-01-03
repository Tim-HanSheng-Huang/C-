using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSHuangGALibrary
{
    /// <summary>
    /// XXXXX
    /// </summary>
    public class RealNumerEncodedGA:GenericGASolver<double>
    {

        double[] lowerBounds;
        double[] upperBounds;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOFVariables"></param>
        /// <param name="lowerBounds"></param>
        /// <param name="upperBounds"></param>
        /// <param name="optimizationType"></param>
        /// <param name="objectiveFunction"></param>
        /// <param name="hostPanelForMonitor"></param>
        public RealNumerEncodedGA(int numberOFVariables, double[] lowerBounds, double[] upperBounds, OptimizationType optimizationType,
            ObjectiveFunction<double> objectiveFunction, Panel hostPanelForMonitor = null)
            : base(numberOFVariables, optimizationType, objectiveFunction, hostPanelForMonitor = null)
        {
            this.lowerBounds = lowerBounds;
            this.upperBounds = upperBounds;
        }

        public override void InitializePopulation()
        {
            for(int p=0;p<populationSize;p++)
            {
                for (int i = 0; i < numberOfGenes; i++)
                {
                    chromosomes[p][i] = lowerBounds[i] + randomizer.NextDouble() * (upperBounds[i] - lowerBounds[i]);
                }
            }

        }
    }
}
