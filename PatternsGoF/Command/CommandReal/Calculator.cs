using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Command.CommandReal
{
    internal class Calculator
    {
        private float _curr = 0f;

        public void Operation(char @operator, float operand)
        {
            switch (@operator)
            {
                case '+':
                    _curr += operand;
                    break;
                case '-':
                    _curr -= operand;
                    break;
                case '/':
                    _curr /= operand;
                    break;
                case '*':
                    _curr *= operand;
                    break;
            }
            Console.WriteLine("Current value = {0,3} (following {1} {2})", _curr, @operator, operand);
        }
    }
}
