using Xunit;

namespace WorkflowTest.Adder.UnitTests
{
    public class MultiplierTests
    {
        [Theory]
        [InlineData("non zero", 52, 3, 156)]
        [InlineData("zero dividend", 0, 13, 0)]
        public void Multiply(string label, int leftOp, int rightOp, double expected)
        {
            //arrange
            Multiplier multiplier = new Multiplier();

            //act
            double result = multiplier.Multiply(leftOp, rightOp);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void testBranchVsLine()
        {
            //arrange
            Multiplier mult = new Multiplier();
            const int valToTestWith = 4;

            //act
            int result = mult.testBranchVsLine(valToTestWith);

            //assert
            Assert.Equal(16, result);
        }
    }
}