using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{

    public class Negativoexception : Exception
    {
        public Negativoexception() { }

        public Negativoexception(string message) : base(message) { }

        public Negativoexception(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }

    internal class ExcecoesPersonalizadas
    {

        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new Negativoexception("Número negativo...(");
            }

            if (valor % 2 == 1)
            {
                throw new ImparException("Valor impar...(");
            }

            return valor;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (Negativoexception ex)
            {
                Console.WriteLine(ex.Message);
            } catch(ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
