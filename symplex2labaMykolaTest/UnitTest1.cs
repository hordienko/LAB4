using Simplex;
using System;
using Xunit;

namespace symplex2labaAnnaTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            double x1 = 10;
            double x2 = 5;
            double expected = 40;

            //act
            Simplex.Program c = new Simplex.Program();
            double actual = c.Calc(x1, x2);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
