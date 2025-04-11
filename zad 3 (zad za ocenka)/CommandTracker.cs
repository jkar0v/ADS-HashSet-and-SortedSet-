using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3__zad_za_ocenka_
{
    internal class CommandTracker
    {
        Queue<Command> commandQueue = new Queue<Command>();
        Dictionary<string, int> history = new Dictionary<string, int>();
        internal void AddCommand(Command command)
        {
            commandQueue.Enqueue(command);
            if (history.ContainsKey(command.Name))
            {
                history[command.Name]++;
            }
            else
            {
                history[command.Name] = 1;
            }
        }
        internal void CommandQueue()
        {
            foreach (var command in commandQueue)
            {
                Console.WriteLine(command);
            }
        }
        internal void History()
        {
            SortedDictionary<string, int> history1 = new SortedDictionary<string, int>(history);
            foreach (var command in history1)
            {
                Console.WriteLine($"{command.Key} : {command.Value}");
            }
        }
    }
    }
