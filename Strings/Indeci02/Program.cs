using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var texto = "Este texto e um teste Zuado kkkkkk";
            Console.WriteLine(texto.IndexOf("Z"));
            Console.WriteLine(texto.IndexOf("z",StringComparison.CurrentCultureIgnoreCase));//Para carater especais
            Console.WriteLine(texto.IndexOf("z",StringComparison.OrdinalIgnoreCase));//Ignora case sensitive
            Console.WriteLine(texto.LastIndexOf('e'));
            Console.WriteLine(texto.LastIndexOf('k'));//Funciona com Char porque nesse casso string e um array de char, mas e preciso ter cuidado com os tipos que tem de ser iguais!
        }
    }
}
