using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaFoca.Classe
{
    class Program
    {
        static void Main (string[] args)
        {
            string palavraSecreta = "programcao";
            JogoDaForca jogo = new JogoDaForca(palavraSecreta);

            jogo.IniciarJogo();

            while (jogo.JogoAtivo)
            {
                Console.WriteLine(" Digite uma Letra:");
                char letra;

                try
                {
                    letra = Console.ReadLine()[0];
                    jogo.AdivinhaLetra(letra);
                    jogo.ExibirEstado();
                }
                catch (LetraInvalidaException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch (JogoTerminadoException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }
            }
            Console.ReadKey();
        }
    }
}
