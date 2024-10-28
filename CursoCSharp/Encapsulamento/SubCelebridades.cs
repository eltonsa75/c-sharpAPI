using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public  class SubCelebridades
    {
        // Todos

        public string InfoPublica = "Tenho um instagram!";

        // herança

        protected string CorDoOlho = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCelular = 5511999999999;

        // herança ou mesmo projeto
        protected internal string JeitodeFalar = "Uso muitas gírias";

        // mesma class ou herança no mesmo projeto ( C# >= 7.2)
        private protected string SegredoFamilia = "Bla bla ";

        // private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcesso()
        {
            Console.WriteLine("SubCelebridades....");


            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitodeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
