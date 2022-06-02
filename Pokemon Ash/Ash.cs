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
        
        public Ash(){
            posicaoAtual = new Posicao();
            posicoesVisitadas = new PosicoesVisitadas();
        }

        public void AndarProNorte(){
            posicaoAtual.y++;
            SalvarPosicaoVisitada();
        }

        public void AndarProSul(){
            posicaoAtual.y--;
            SalvarPosicaoVisitada();
        }

        public void AndarProEste(){
            posicaoAtual.x++;
            SalvarPosicaoVisitada();
        }

        public void AndarProOeste(){
            posicaoAtual.x--;
            SalvarPosicaoVisitada();
        }

        public void Movimentar(string sequencia){
            foreach (char c in sequencia)
            {
                switch (c)
                {
                    case 'N':
                        AndarProNorte();
                        break;
                    case 'S':
                        AndarProSul();
                        break;
                    case 'E':
                        AndarProEste();
                        break;
                    case 'O':
                        AndarProOeste();
                        break;
                    default:
                        break;
                }
            }
        }

        private void SalvarPosicaoVisitada(){
            if (!posicoesVisitadas.ContemPosicao(posicaoAtual))
            {
                posicoesVisitadas.AdicionarPosicao(posicaoAtual);
            };
        }
        public Posicao RetornarPosicao(){
            return posicaoAtual;
        }

        public int RetornarQuantidadePokemonsCapturados(){
            return posicoesVisitadas.ObterTamanho();

        }

    }
}
