using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGoF.Command.CommandReal
{
    public class User
    {
        private Calculator _calculator = new Calculator();
        private List<ICommand> _commands = new List<ICommand>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    ICommand command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    ICommand command = _commands[--_current] as ICommand;
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, float operand)
        {
            ICommand command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();

            _commands.Add(command);
            _current++;
        }
    }
}
