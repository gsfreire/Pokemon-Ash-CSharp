using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Ash
{
    public class Ash
    {
        private Posicao posicaoAtual;
        private PosicoesVisitadas posicoesVisitadas;
        
        public Ash()
        {
            posicaoAtual = new Posicao();
            posicoesVisitadas = new PosicoesVisitadas();
        }

        public void Andar(char sentido)
        {
            switch (sentido)
            {
                case 'N':
                    posicaoAtual.AdicionarEmY(1);
                    break;
                case 'S':
                    posicaoAtual.AdicionarEmY(-1);
                    break;
                case 'E':
                    posicaoAtual.AdicionarEmX(1);
                    break;
                case 'O':
                    posicaoAtual.AdicionarEmX(-1);
                    break;
                default:
                    break;
            }
            if (!posicoesVisitadas.ContemPosicao(posicaoAtual))
            {
                posicoesVisitadas.AdicionarPosicao(posicaoAtual);
            };

        }
        public Posicao RetornarPosicao()
        {
            return posicaoAtual;
        }

        public int RetornarQuantidadePokemonsCapturados()
        {
            return posicoesVisitadas.ObterTamanho();

        }

    }
}
