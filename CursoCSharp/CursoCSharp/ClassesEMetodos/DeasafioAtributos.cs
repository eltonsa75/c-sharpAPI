using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributos
    {

        int a = 10;
        public static void Executar()
        {  
            // Acessar variável 'a' dentro do método Executar!
            //Console.WriteLine(a);

            DesafioAtributos desafio = new DesafioAtributos();
            Console.WriteLine(desafio.a);
        }
    }
}
