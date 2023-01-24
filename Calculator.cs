namespace SpecFlowCalculator
{
    public enum Operation
    {
        Plus,
        Minus,
        Multiply,
        Divide,
        Unspecified
    }
    public class Calculator
    {
        private double argument;
        private double result;
        private String argumentString;
        private Operation currentOperation;
        private bool firstOperation;
        public double Argument { get { return argument; } set { argument = value; } }
        public double Result { get { return result; } set { result = value; } }
        public String ArgumentString { get { return argumentString; } set { argumentString = value; } }
        public Operation CurrentOperation { get { return currentOperation; } set { currentOperation = value; } }
        public bool FirstOperation { get { return firstOperation; } set { firstOperation = value; } }
        public Calculator()
        {
            argument = 0.0;
            result = 0.0;
            argumentString = String.Empty;
            currentOperation = Operation.Unspecified;
            firstOperation = true;
        }

        public void Calculate()
        {
            if (currentOperation == Operation.Plus)
            {
                argument = Double.Parse(argumentString);
                if (firstOperation)
                {
                    firstOperation = false;
                    result = argument;
                }
                else
                {
                    result += argument;
                }
                argumentString = String.Empty;
            }
            else if (currentOperation == Operation.Minus)
            {
                argument = Double.Parse(argumentString);
                if (firstOperation) { firstOperation = false; result = argument; }
                else
                {
                    result -= argument;
                }
                argumentString = String.Empty;
            }
            else if (currentOperation == Operation.Multiply)
            {
                argument = Double.Parse(argumentString);
                if (firstOperation) { result = 1.0; firstOperation = false; }
                result *= argument;
                argumentString = String.Empty;
            }
            else if (currentOperation == Operation.Divide)
            {
                argument = Double.Parse(argumentString);
                if (firstOperation) { result = argument; firstOperation = false; }
                else
                {
                    /*
                    if (argument == 0.0)
                    {
                        throw new DivideByZeroException();
                    }
                    else
                    {
                    */
                    result /= argument;
                    //}

                }
                argumentString = String.Empty;
            }
            else if (currentOperation == Operation.Unspecified)
            {
                throw new Exception("Operation Uncpecified");
            }
        }

    }
}