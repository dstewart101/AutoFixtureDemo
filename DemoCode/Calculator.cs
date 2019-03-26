
namespace AutoFixtureDemo.Code
{
    public class Calculator
    {
        public int Value { get; set; }

        public void Subtract(int number)
        {
            Value -= number;
        }
    }
}
