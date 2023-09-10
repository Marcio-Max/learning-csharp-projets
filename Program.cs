using System;
using System.Globalization;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("\t\tExibindo a data conforme a cultura");

            var pt = new CultureInfo("pt-PT"); //Primeiro criamos uma nova instancia da cultura desejada!
            Console.WriteLine(DateTime.Now.ToString("D", pt));

            var br = new CultureInfo("pt-BR");
            Console.WriteLine(DateTime.Now.ToString("D", br));

            var en = new CultureInfo("en-US");
            Console.WriteLine(DateTime.Now.ToString("d", en));

            var bt = new CultureInfo("en-UK");
            Console.WriteLine(DateTime.Now.ToString("D", bt));

            var de = new CultureInfo("de-DE");
            Console.WriteLine(DateTime.Now.ToString("D", de));

            var culturaAtualDaMaquina = CultureInfo.CurrentCulture;
            Console.WriteLine(DateTime.Now.ToString("D", culturaAtualDaMaquina));

            Console.WriteLine("\n");

        }
    }
}
