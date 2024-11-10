using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Nullables
    {

        static int num3;
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if(num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            } else
            {
                Console.WriteLine("a variável não possui valor");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

        }   
    }
}
