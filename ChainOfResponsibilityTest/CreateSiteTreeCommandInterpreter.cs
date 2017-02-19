using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityTest
{
    public class CreateSiteTreeCommandInterpreter : CommandInterpreter
    {
        public override ICommand Interpret(string commandString)
        {
            if (commandString.Split(':')[0] == "CST")
            {
                return new CreateSiteTreeCommand();
            }
            else if(interpreter!=null)return interpreter.Interpret(commandString);
            return null;
        }
    }
}
