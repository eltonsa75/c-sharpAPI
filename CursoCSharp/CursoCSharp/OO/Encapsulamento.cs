using System;
using System.Collections.Generic;
using Encapsulamento;

namespace CursoCSharp.OO
{

    public class FilhoNaoReconhecido : SubCelebridades
    {
        public new void MeusAcesso()
        {
            Console.WriteLine("FilhoNaoReconhecido....");

            Console.WriteLine(InfoPublica);

            Console.WriteLine(CorDoOlho);
            Console.WriteLine(JeitodeFalar);
            
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridades amiga = new SubCelebridades();

        public void MeusAcesso()
        {
            Console.WriteLine("AmigoDistante....");

            Console.WriteLine(amiga.InfoPublica);
        }
    }
    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridades sub = new SubCelebridades();
            sub.MeusAcesso();

            new FilhoNaoReconhecido().MeusAcesso();
            new AmigoDistante().MeusAcesso();

            new FilhoNaoReconhecido().MeusAcesso();
            new AmigoDistante().MeusAcesso();
        }
    }
}
