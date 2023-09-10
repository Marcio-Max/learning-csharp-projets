using System;
using System.Collections.Specialized;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.Clear();                 /* - Podemo ter mais de 1 catch
                                                - tratar os erros do especifico ou genérico
                                                - NameObjectCollectionBase tentar colocar tudo dentro do try
                                            */
            var arr = new int[3];               
            try //tenta
            {
               //System.IndexOutOfRangeException: Index was outside the bounds of the array.
            //    for(int index = 0; index <= 10; index++)
            //     { 
            //          Console.WriteLine(arr[index]);
            //     } 

                Cadastrar("");
            }
/*pegar*/   catch(IndexOutOfRangeException ex) //tratamento de erro ESPECIFICO
            {
                Console.WriteLine(ex.InnerException);
               
                Console.WriteLine(" Nao encontrei o \"index\"   ");
            }
 /*pegar*/  catch (System.Exception ex) //tratamento de erros gericos
            {
                 //Aqui NO (catch) tratamos o ERRO
                 Console.WriteLine(ex.Message);//Message serra usado para passar a mensagem da Exception que nos mesmo criamos (nesse caso a exception que esta na função Cadastrar()
                 Console.WriteLine(" Algo deu errado!!!");
            }
            finally
            {
            Console.WriteLine("Chegou ao fim porque (finally) sempre serra executado dentro de um \"try catch\", Similar ao close que usamos quando acessamos um BD e temos de o fechar a conexão do final \n ");
            }
            
        }
        //Criando e Disparando uma Exception nossa, usando o throw!
        private static void Cadastrar(string texto)
        {
            if(string.IsNullOrEmpty(texto)){
                throw new Exception("** O texto nao pode ser nulo ou vazio.");
            }
        }

        //Assim como criamos funções podemos também criar nossa propiá (Class Exception) com seus método.

    }
}
        