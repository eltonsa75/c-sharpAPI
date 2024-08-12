using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList
    {

        public static void Executar()
        {
            var arralist = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arralist.Add(3.14);

            foreach (var item in arralist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
