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
            int result = 0;
            if (x > 2)
            {

                result = x * x;
            }

            return result;
        }

    }
}
