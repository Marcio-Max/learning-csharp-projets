using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            var utcData =  DateTime.UtcNow; //Data/Hora Global sem as TimeZones

            Console.WriteLine(DateTime.Now); //Data e hora do Servidor da aplicacao
            Console.WriteLine(utcData);      //Data e hora universal
            Console.WriteLine(utcData.ToLocalTime()); //Time Local da maquina

            //Pegando a TimeZone da Australia
            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine($" Pegando a TimeZone da Australia: {timeZoneAustralia} ");
            //Convertendo a timeZone para mostrar 
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcData, timeZoneAustralia);
            Console.WriteLine($"O horario atual da Auckland é: {horaAustralia}");

            //-------------------------//---------------------------//----------------------

            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timezone in timeZones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcData, destinationTimeZone: timezone));
                Console.WriteLine("-------------------");
            }

        }
    }
}
