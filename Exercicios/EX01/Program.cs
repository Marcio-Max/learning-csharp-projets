using System;

namespace EX01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

           Aluno aluno1 = new Aluno();
           aluno1.nome= "Maria";
           aluno1.nota1 = 10.0;
           aluno1.nota2 =  8.5 ;
           aluno1.Mensagem();

           Aluno aluno2 = new Aluno();
           aluno2.nome= "João";
           aluno2.nota1 = 9.0;
           aluno2.nota2 =  4.5 ;
           aluno2.Mensagem();
        }
    }
}
