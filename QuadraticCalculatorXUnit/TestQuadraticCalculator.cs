using System;
using Xunit;
using QuadraticCalculator;

namespace QuadraticCalculatorXUnit
{
    public class TestQuadraticCalculator
    {
        [Theory]
        [InlineData(-4, 1, 0, 1)]
        [InlineData( 0, 2, 4, 2)]
        [InlineData( 53, 2, 5, -3.5)]
        public void DescriminantTheory(double expected, double a, double b, double c)
        {
            double actual = Program.Descriminant(a, b, c);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Дискриминант меньше нуля. Корней нет.",-4, 1, 0)]
        [InlineData("Дискриминант равен нулю. Корень равен -1", 0, 2, 4)]
        [InlineData("Дискриминант равен 53. Первый корень равен -3,07. Второй корень равен 0,57", 53, 2, 5)]
        public void CheckDescriminantTheory(string expected, double checkD, double a , double b )
        {
            string actual = Program.CheckDescriminant(checkD, a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Descriminant_2and4and2_zero()
        {
            double a = 2;
            double b = 4;
            double c = 2;
            double expected = 0;
            double actual = Program.Descriminant(a, b, c);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 2, 4)]
        public void DescriminantEqualsZeroTheory(double expected, double a, double b)
        {
            double actual = Program.DescriminantEqualsZero(a, b);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(-3.07, 2, 5, 53)]
        public void DescriminantLargeZeroOneRootTheory(double expected, double a, double b, double d)
        {
            double actual = Program.DescriminantLargeZeroOneRoot(a, b, d);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0.57, 2, 5, 53)]
        public void DescriminantLargeZeroTwoRootTheory(double expected, double a, double b, double d)
        {
            double actual = Program.DescriminantLargeZeroTwoRoot(a, b, d);
            Assert.Equal(expected, actual);
        }
        #region Copy
        //[Fact]
        //public void Descriminant_1and0and1_minus4()
        //{
        //    double a = 1;
        //    double b = 0;
        //    double c = 1;
        //    double expected = -4;
        //    double actual = Program.Descriminant(a, b, c);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void CheckDescriminant_minus4_1_0_DescriminantSmallerZero()
        //{
        //    double checkD = -4;
        //    double a = 1;
        //    double b = 0;
        //    string expected = "Дискриминант меньше нуля. Корней нет.";
        //    string actual = Program.CheckDescriminant(checkD, a, b);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void Descriminant_2and4and2_zero()
        //{
        //    double a = 2;
        //    double b = 4;
        //    double c = 2;
        //    double expected = 0;
        //    double actual = Program.Descriminant(a, b, c);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void DescriminantEqualsZero_2_4_minus1()
        //{
        //    double a = 2;
        //    double b = 4;
        //    double expected = -1;
        //    double actual = Program.DescriminantEqualsZero(a, b);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void CheckDescriminant_0_2_4_DescriminantEqualsZero()
        //{
        //    double checkD = 0;
        //    double a = 2;
        //    double b = 4;
        //    string expected = "Дискриминант равен нулю. Корень равен -1";
        //    string actual = Program.CheckDescriminant(checkD, a, b);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void Descriminant_2and5andMinus3_5_53()
        //{
        //    double a = 2;
        //    double b = 5;
        //    double c = -3.5;
        //    double expected = 53;
        //    double actual = Program.Descriminant(a, b, c);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void DescriminantLargeZeroOneRoot_2_5_53_minus3_07()
        //{
        //    double a = 2;
        //    double b = 5;
        //    double d = 53;
        //    double expected = -3.07;
        //    double actual = Program.DescriminantLargeZeroOneRoot(a, b, d);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void DescriminantLargeZeroTwoRoot_2_5_53_0_57()
        //{
        //    double a = 2;
        //    double b = 5;
        //    double d = 53;
        //    double expected = 0.57;
        //    double actual = Program.DescriminantLargeZeroTwoRoot(a, b, d);
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void CheckDescriminant_53_2_5_DescriminantLargeZero()
        //{
        //    double checkD = 53;
        //    double a = 2;
        //    double b = 5;
        //    string expected = "Дискриминант равен 53. Первый корень равен -3,07. Второй корень равен 0,57";
        //    string actual = Program.CheckDescriminant(checkD, a, b);
        //    Assert.Equal(expected, actual);
        //}
        #endregion
    }
}
