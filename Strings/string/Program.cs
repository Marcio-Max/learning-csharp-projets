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
            string texto01 = "Testando";
            string texto = "Este texto e um teste";
            Console.WriteLine(texto);

        //Metodo CompareTo usado para comparar String com qualquer objetos retorna um inteiro (0 ou 1)
            Console.WriteLine(texto01.CompareTo("Testando"));
            Console.WriteLine(texto01.CompareTo("testando"));

        Console.WriteLine("------------------------");
        
        //Metodo Contains compara string  e retorna um boolean
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("Este texto e um teste"));
            Console.WriteLine(texto.Contains("Este texto e um Teste"));

            //ignora case-sensitive
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.IndexOf("Teste", StringComparison.OrdinalIgnoreCase) >= 0 ); 


            Console.ReadLine();
        }
    }
}

