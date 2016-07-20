namespace PT.Fibonacci.Domain
{
    public class FibonacciNumber
    {
        public int Value { get; set; }
        public int Index { get; set; }

        public FibonacciNumber()
        {
        }
        
        public FibonacciNumber(int value, int index)
        {
            Value = value;
            Index = index;
        }


        public override string ToString()
        {
            return $"{Index}:{Value}";
        }
    }
}
