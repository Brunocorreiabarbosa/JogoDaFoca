using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaFoca.Classe
{
    public class LetraInvalidaException : Exception
    {
        public LetraInvalidaException(string message) : base(message) { }
    }
}
