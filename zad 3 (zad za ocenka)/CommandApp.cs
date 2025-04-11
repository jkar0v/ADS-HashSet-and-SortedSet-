using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3__zad_za_ocenka_
{
    internal class CommandApp
    {
        internal void Run()
        {
            CommandTracker commandTracker = new CommandTracker();
            string command;
            Console.WriteLine("Wuwedete chislo:");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                Console.WriteLine("Enter command (or 'exit' to quit):");
                command = Console.ReadLine();

                Command cmd = new Command(command);
                commandTracker.AddCommand(cmd);
                number--;
            }
            Console.WriteLine("Command Queue:");
            commandTracker.CommandQueue();
            Console.WriteLine("Command History:");
            commandTracker.History();
        }
    }
}