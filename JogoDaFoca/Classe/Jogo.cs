using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaFoca.Classe
{
    public abstract class Jogo
    {
        public bool JogoAtivo { get; protected set; }

        public Jogo()
        {
            JogoAtivo = true;
        }
        public abstract void IniciarJogo();
        public abstract void AdivinhaLetra(char letra);
        public abstract void ExibirEstado();
        public abstract void ExibirResultadoFinal();
    }
}
