using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Ash
{
    public class main
    {
        static void Main(){
            Ash ash = new Ash();
            string sequencia = Console.ReadLine();
            ash.Movimentar(sequencia);
            Console.WriteLine(ash.RetornarQuantidadePokemonsCapturados());
        }
    }
}
