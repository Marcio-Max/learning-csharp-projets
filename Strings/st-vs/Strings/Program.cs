using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Este texto e um teste";
            Console.WriteLine(texto);
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            //Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.IndexOf("Teste", StringComparison.OrdinalIgnoreCase) >= 0 );


            Console.ReadLine();
        }
    }
}
