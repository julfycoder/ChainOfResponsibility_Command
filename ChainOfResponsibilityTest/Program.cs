using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandInterpreter p = new ParseCommandInterpreter();
            CommandInterpreter c = new CreateSiteTreeCommandInterpreter();
            p.SetInterpreter(c);

            while (true)
            {
                Console.WriteLine("Enter command:");
                ICommand command = p.Interpret(Console.ReadLine());
                if(command!=null)                command.Execute();
                else Console.WriteLine("Command has been not recognized!");

                Console.WriteLine();
            }
        }
    }
}
