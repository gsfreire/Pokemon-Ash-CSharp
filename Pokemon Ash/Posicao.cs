using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Ash
{
    public class Posicao
    {
        public int x { get; private set; }
        public int y {get; private set;}

        public Posicao(int _x = 0, int _y = 0)
        {
            x = _x;
            y = _y;
        }
        public Posicao(Posicao B)
        {
            x = B.x;
            y = B.y;
        }
        public void AdicionarEmX(int z) {
            this.x += z;
        }

        public void AdicionarEmY(int z){
            this.y += z;
        }
    }

    public class ComparadorPosicao : IEqualityComparer<Posicao>
    {
        public bool Equals(Posicao A, Posicao B)
        {
            return (A.x.Equals(B.x)) && (A.y.Equals(B.y));
        }

        public int GetHashCode(Posicao obj)
        {
            return 0;
        }
    }
}
