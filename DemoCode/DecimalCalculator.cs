
namespace AutoFixtureDemo.Code
{
    public class DecimalCalculator
    {
        public decimal Value { get; set; }

        public void Subtract(decimal number)
        {
            Value -= number;
        }

        public void Add(decimal number)
        {
            Value += number;
        }
    }
}
