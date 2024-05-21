using System;
using System.Security.Policy;
namespace ДЗ.Поликлиника
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queueNumber;
            int waitingTimeInQueue;
            int receptionTimeForOnePersonInMinutes = 10;
            int minutesInAHour = 60;
            int waitingHour;
            int waitingMinute;
            Console.WriteLine("Добро пожаловать в нашу поликлинику. Возьмите пожалуйста талон на приём к врачю.");
            Console.Write("Укажите ваш номер в очереди по талону:");
            queueNumber = Convert.ToInt32(Console.ReadLine());
            waitingTimeInQueue=(queueNumber - 1)* receptionTimeForOnePersonInMinutes;
            waitingHour=waitingTimeInQueue/ minutesInAHour;
            waitingMinute = waitingTimeInQueue % minutesInAHour;
            Console.WriteLine($"Ваше время ожидание в очереди: {waitingHour} ч., {waitingMinute} мин.");
        }
    }
}
