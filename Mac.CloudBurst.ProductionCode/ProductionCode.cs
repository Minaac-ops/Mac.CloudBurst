using System;
using System.Linq;

namespace Mac.CloudBurst.ProductionCode
{
    public class ProductionCode : IProductionCode
    {
        /**
         * This method is to check if theres a cloudburst. For now the method returns -1 if there
         * isn't cloudburst og the lenght of the array of there is.
         * The definition of cloudburst is at least 15 ml rain in 30 minutes. Every entry is 5 minutes,
         * So every place in the array if there's 6 entries that summed gives more than 15 there is a cloudburst.
         */
        public int ContainsCloudburst(double[] rain)
        {
            int i;
            double mlIn30Minutes;
            for (i = 5; i < rain.Length; i++)
            {
                mlIn30Minutes = rain[i-5] + rain[i-4] + rain[i-3] + rain[i-2] + rain[i-1] + rain[i];
                if (mlIn30Minutes >= 15)
                {
                    return rain.Length;
                }
            }
            return -1;
        }
    }
}