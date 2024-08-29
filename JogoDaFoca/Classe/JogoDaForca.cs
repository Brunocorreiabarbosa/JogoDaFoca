using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaFoca.Classe
{
    public class JogoDaForca : Jogo
    {
        private string PalavraSecreta { get; set; }
        private HashSet<char> LetrasAdivinhadas { get; set; }
        public int TentativasRestantes { get; private set; }
        public string EstadoAtual { get; private set; }


        public JogoDaForca(string palavraSecreta)
        {
            PalavraSecreta = palavraSecreta.ToUpper();
            LetrasAdivinhadas = new HashSet<char>();
            TentativasRestantes = 6;
            EstadoAtual = new string('_', PalavraSecreta.Length);
        }
        public override void IniciarJogo()
        {
            Console.WriteLine("Bem- vindo ao jogo da Forca!!");
            ExibirEstado();
        }
        public override void AdivinhaLetra(char letra)
        {
            if (!JogoAtivo)
            
                throw new JogoTerminadoException("O jogo Já terminou");

                letra = char.ToUpper(letra);


            if (!char.IsLetter(letra))
                throw new LetraInvalidaException("Voce deve adivinhar uma letra!");

            if (LetrasAdivinhadas.Contains(letra))
            {
                Console.WriteLine($" Voce Ja tentou a letra '{letra}. Tente outra.");
                return;
            }
            LetrasAdivinhadas.Add(letra);
            if (PalavraSecreta.Contains(letra))
            {
                AtualizarEstadoAtual(letra);
                if (VerificarVitoria())
                {
                    JogoAtivo = false;
                    ExibirResultadoFinal();
                }
            }
            else
            {
                TentativasRestantes--;
                Console.WriteLine($"A letra '{letra}' não esta na palavra. Tentativas Restantes: {TentativasRestantes}  ");
                if (TentativasRestantes == 0)
                {
                    JogoAtivo = false;
                    ExibirResultadoFinal();
                }
            } 
        }
        private void AtualizarEstadoAtual(char letra)
        {
            char[] estadoAtualArray = EstadoAtual.ToCharArray();

            for (int i = 0; i < PalavraSecreta.Length; i++)
            {
                if (PalavraSecreta[i] == letra)
                {
                    estadoAtualArray[i] = letra;
                }
            }
            EstadoAtual = new string(estadoAtualArray);
        }
        public override void ExibirEstado()
        {
            Console.WriteLine($"Palavra: {EstadoAtual}");
        }
        private bool VerificarVitoria()
        {
            return !EstadoAtual.Contains('_');
        }
        public override void ExibirResultadoFinal()
        {
            if (VerificarVitoria())
            {
                Console.WriteLine("Parabéns! Você venceu o jogo da forca!");
                Console.WriteLine($"A palavra era: {PalavraSecreta}");
            }
            else
            {
                Console.WriteLine("Você perdeu o jogo da forca.");
                Console.WriteLine($"A palavra era: {PalavraSecreta}");
            }
        }
    }
}
