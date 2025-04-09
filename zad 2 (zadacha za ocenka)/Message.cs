using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2__zadacha_za_ocenka_
{
    internal class Message
    {
        internal string Name { get; set; }
        string _Message {  get; set; }
        public Message(string name, string message) 
        {
            Name = name;
            _Message = message;
        }

        public override string ToString()
        {
            return $"From: {Name} - {_Message}";
        }
    }
}
