using System;
using Xunit;

namespace WorkflowTest.Adder.UnitTests
{
    public class AdderTests
    {
        [Theory]
        [InlineData("two numbers", 12, 3, 15)]
        [InlineData("right operand 0", 12, 0, 12)]
        [InlineData("left operand 0", 0, 13, 13)]
        [InlineData("both operands 0", 0, 0, 0)]
        [InlineData("both operands negative", -12, -11, -23)]
        [InlineData("left operand negative", -12, 16, 4)]
        [InlineData("operand non-negative but result 0", -57, 57, 0)]
        public void Add(string label, int leftOperand, int rightOperand, int expectedSum)
        {
            //arrange
            var adder = new Adder();

            //act
            int result = adder.Add(leftOperand, rightOperand);

            //assert
            Assert.Equal(expectedSum, result);
        }

        [Fact]
        public void Overflow()
        {
            //arrange
            var adder = new Adder();

            //act, assert
            Assert.Throws<OverflowException>(() => adder.Add(int.MaxValue, int.MaxValue));

        }

        [Theory]
        [InlineData("left op larger", 5, 2, 3)]
        [InlineData("left op equal to right", 2, 2, 0)]
        [InlineData("left op zero", 0, 2, -2)]
        [InlineData("right op zero", 5, 0, 5)]
        [InlineData("botht op zero", 0, 0, 0)]
        [InlineData("botht op negative", -5, -6, 1)]
        public void Subtract(string label, int leftOperand, int rightOperand, int expected)
        {
            //arrange
            var adder = new Adder();

            //act
            double result = adder.Subtract(leftOperand, rightOperand);

            //assert
            Assert.Equal(expected, result);

        }

    }
}
