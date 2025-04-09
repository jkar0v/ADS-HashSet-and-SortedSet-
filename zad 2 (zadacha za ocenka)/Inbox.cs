using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2__zadacha_za_ocenka_
{
    internal class Inbox
    {
        HashSet<string> blocked = new HashSet<string>();
        Queue<Message> messages = new Queue<Message>();

        public void Blocked(string name)
        {
            blocked.Add(name);
        }
        public void AddMessage(Message message)
        {
            messages.Enqueue(message);
        }
        public void Print()
        {
            foreach (Message message in messages)
            {
                if (!blocked.Contains(message.Name))
                {
                    Console.WriteLine(message.ToString());
                }
            }
        }
    }
}
