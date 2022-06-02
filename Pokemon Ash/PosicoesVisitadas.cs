using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Ash
{
    public class PosicoesVisitadas
    {
        private List<Posicao> posicoesVisitadas;

        public PosicoesVisitadas(){
            posicoesVisitadas = new List<Posicao>() { new Posicao() };
        }

        public void AdicionarPosicao(Posicao posicao){
            posicoesVisitadas.Add(new Posicao (posicao));
        }

        public int ObterTamanho(){
            return posicoesVisitadas.Count;
        }

        public bool ContemPosicao(Posicao posicao){
            return posicoesVisitadas.Contains(new Posicao(posicao), new ComparadorPosicao());
        }
    }
}
