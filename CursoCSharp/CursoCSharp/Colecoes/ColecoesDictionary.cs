﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar()
        {
            // Chave valor Dictionary
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");


            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));


            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filmes2006);
            Console.WriteLine($"Filme {filmes2006}!");

            // Percorrendo do Dictionary

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor); 
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}
