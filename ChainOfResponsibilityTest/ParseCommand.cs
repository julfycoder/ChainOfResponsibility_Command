using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityTest
{
    public class ParseCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Executed by ParseCommand");
        }
    }
}
