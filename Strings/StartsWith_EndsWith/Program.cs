using System;

namespace StartsWith_EndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Este texto e um teste";

            //StartWith
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));//ignora //casesensitive
            Console.WriteLine(texto.StartsWith("  Este"));//Verifica o espaçamento ou nao no inicio do texto

            Console.WriteLine("-------");

            //EndWith
            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("xpto"));
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("  teste"));



            Console.ReadLine();
        }
    }
}