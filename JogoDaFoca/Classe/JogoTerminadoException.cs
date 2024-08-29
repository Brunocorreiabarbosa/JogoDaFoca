using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaFoca.Classe
{
    public class JogoTerminadoException : Exception
    {
        public JogoTerminadoException(string message) : base(message) { }
    }
}
