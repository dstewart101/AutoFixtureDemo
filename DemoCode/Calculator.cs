using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
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
