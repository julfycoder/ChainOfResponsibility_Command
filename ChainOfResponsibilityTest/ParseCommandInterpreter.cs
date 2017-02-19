using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityTest
{
    public class ParseCommandInterpreter : CommandInterpreter
    {
        public override ICommand Interpret(string commandString)
        {
            if (commandString.Split(':')[0] == "P")
            {
                return new ParseCommand();
            }
            if (interpreter != null) return interpreter.Interpret(commandString);
            return null;
        }
    }
}
