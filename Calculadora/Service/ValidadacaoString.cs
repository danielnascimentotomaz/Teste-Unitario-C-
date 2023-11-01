using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Service
{
    public class ValidadacaoString
    {
        public int ContarCaracteres(string texto){
            int totalCarateres = texto.Length;
            return totalCarateres;
        }
    }
}