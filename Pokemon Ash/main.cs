using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Ash
{
    public class main
    {
        static void Main(string[] args)
        {
            Ash ash = new Ash();
            string entrada = Console.ReadLine();
            foreach (char c in entrada) {
                ash.Andar(c);
                Console.WriteLine(c);
            }  

            Console.WriteLine(ash.RetornarQuantidadePokemonsCapturados());
            entrada = Console.ReadLine();
        }
    }
}
