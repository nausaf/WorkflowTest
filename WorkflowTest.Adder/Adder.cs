using System;

namespace WorkflowTest.Adder
{
    public class Adder
    {
        public int Add(int x, int y)
        {
            checked
            {
                return x + y;
            }
        }

        public double Subtract(int x, int y)
        {
            return x + y;

        }
    }
}
