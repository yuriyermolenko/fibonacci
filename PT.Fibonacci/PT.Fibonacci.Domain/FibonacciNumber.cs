namespace PT.Fibonacci.Domain
{
    public class FibonacciNumber
    {
        public decimal Value { get; set; }
        public int Index { get; set; }

        public FibonacciNumber()
        {
        }
        
        public FibonacciNumber(decimal value, int index)
        {
            Value = value;
            Index = index;
        }


        public override string ToString()
        {
            return $"{Value}({Index})";
        }
    }
}
