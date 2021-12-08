namespace WorkflowTest.Adder
{
    public class Multiplier
    {
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        // public double Divide(int x, int y)
        // {
        //     return x / y;
        // }

        public int testBranchVsLine(int x)
        {
            return x > 2 ? x * x : x % 2;
        }

    }
}
