using System;
using Mac.CloudBurst.ProductionCode;
using Xunit;
using Assert = TestToolsToXunitProxy.Assert;

namespace Mac.CloudBurst.ProductionCodeTest
{
    public class ProductionCodeTest
    {
        /**
         * Test to check if theres a cloudburst. I have some InLineData to check different situations.
         * For now, if there is a cloudburst if just returns the lenght of the array (not finished with that part)
         */
        [Theory]
        [InlineData(new double[] {0, 0, 4, 4, 2, 2, 4}, 7)]
        [InlineData(new double[] {1, 0, 2,10, 5,2}, 6)]
        [InlineData(new double[] {5, 2, 7, 4, 5.6, 6.6}, 6)]
        [InlineData(new double[] {1, 4, 5, 5, 4, 6,5}, 7)]
        [InlineData(new double[] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, -1)]
        public void TestIsThereCloudBurst(double[] rain, int expectedRes)
        {
            //Arrange
            IProductionCode p = new ProductionCode.ProductionCode();
            //Act
            int actualRes = p.ContainsCloudburst(rain);
            //Assert
            Assert.AreEqual(expectedRes, actualRes);
        }
    }
}