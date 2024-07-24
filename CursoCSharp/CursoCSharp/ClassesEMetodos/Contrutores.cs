using System;


namespace CursoCSharp.ClassesEMetodos
{

    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        // Contrutor Padrão
        public Carro() { }
    }
    internal class Contrutores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            Console.WriteLine($"{ carro1.Fabricante} { carro1.Modelo} { carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);

            Console.WriteLine($"{carro2.Fabricante} { carro2.Modelo} {carro2.Ano}");

        }
    }
}
