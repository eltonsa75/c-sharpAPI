using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridades
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido....");


            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitodeFalar);
            Console.WriteLine(SegredoFamilia);
           
        }
    }
}
