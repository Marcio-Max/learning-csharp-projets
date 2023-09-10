using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            for (int index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }

            Console.WriteLine("==========");

            //Usando (foreach) para iterar sobre um Array
            foreach (var contador in meuArray)
            {
                Console.WriteLine(contador);
            }

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { id = 5637, nome = "Daniela" };

            foreach (var funcionario in funcionarios)
            {

                Console.WriteLine(funcionario.id);
                Console.WriteLine(funcionario.nome);
            }


        }
        
        public struct Funcionario
        {
            public int id { get; set; }
            public string nome { get; set; }
        }
    }
}
