using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3__zad_za_ocenka_
{
    internal class Command
    {
        public string Name { get; set; }
        internal Command(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
