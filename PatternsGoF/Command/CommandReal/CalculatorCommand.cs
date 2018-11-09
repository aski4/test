using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Command.CommandReal
{
    internal class CalculatorCommand : ICommand
    {
        private char _operator;
        private float _operand;
        private Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, float operand)
        {
            _operand = operand;
            _operator = @operator;
            _calculator = calculator;
        }

        public char Operator
        {
            set { _operator = value; }
        }
        public int Operand
        {
            set { _operand = value; }
        }

        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new ArgumentException("@operator");
            }
        }
    }
}
