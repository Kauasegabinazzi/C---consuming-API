using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____consuming_API.Models
{
    internal class Character
    {
        public string name { get; set; }
        public List<string>? aliases { get; set; }

        public void ExibirApelidosDaPersonagem()
        {
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine("Apelidos:");
            foreach (string apelido in aliases)
            {
                Console.WriteLine($"- {apelido}");
            }
        }
    }
}
