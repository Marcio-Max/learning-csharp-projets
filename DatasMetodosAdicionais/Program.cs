using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Adicionando mas Anos, meses, dias... nas datas, nesses casos a incrementacao e automatica
            Console.Clear();

            var data = DateTime.Now;
            Console.WriteLine("Data atual: " + data);
            Console.WriteLine(data.AddYears(1));
            Console.WriteLine(data.AddMonths(2));
            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddDays(-28));
            Console.WriteLine(data.AddHours(24));

            //Comparacao de datas
            var data01 = DateTime.Now;

            // if(data01 == DateTime.Now){    ISSO NUNCA VAI FUNCIONAR POIS DateTime.Now nunca e estatico
            //     Console.WriteLine("A data é igual");
            // }


           //Agora funciona pois Agora so compara a data e nao os segundos, milisegundo ...
            if(data01.Date == DateTime.Now.Date){
                Console.WriteLine("\n A data é IGUAL \n");
            }



        }
    }
}
