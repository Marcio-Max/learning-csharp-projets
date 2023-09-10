using System;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Equals" usado para quando os objetos sejam exatamente iguais ou identicos
            var texto = "Este texto e um teste";
            Console.WriteLine(texto.Equals("Este texto e um teste"));
            Console.WriteLine(texto.Equals("Este texto e um Teste"));
            Console.WriteLine(texto.Equals("este texto e um Teste",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.Equals("  Este texto e um Teste"));

        }
    }
}