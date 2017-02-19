using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityTest
{
    public abstract class CommandInterpreter
    {
        protected CommandInterpreter interpreter;
        public void SetInterpreter(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }
        public abstract ICommand Interpret(string commandString);
    }
}
