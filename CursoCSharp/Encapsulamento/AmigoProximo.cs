using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class AmigoProximo
    {

        public readonly SubCelebridades amiga = new SubCelebridades();

        public void MeusAcessos()
        {
            Console.WriteLine("amigoProximo....");

            Console.WriteLine(amiga.InfoPublica);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitodeFalar);
            
        }
    }
}
