using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator

{
    public class MathData
    {
        public int FirstNumber;
        public int SecondNumber;
        public string Operation;

        public MathData(int firstNumber, int secondNumber, string operation)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
            this.Operation = operation;
        }
    }
}