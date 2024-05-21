using System;
using System.Security.Policy;
namespace ДЗ.Поликлиника
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queueNumber;
            int waitingQueue;
            int receptionMinutesForPerson = 10;
            int minutesHour = 60;
            int waiteHours;
            int waiteMinutes;
            Console.WriteLine("Добро пожаловать в нашу поликлинику. Возьмите пожалуйста талон на приём к врачю.");
            Console.Write("Укажите ваш номер в очереди по талону:");
            queueNumber = Convert.ToInt32(Console.ReadLine());
            waitingQueue = (queueNumber - 1)* receptionMinutesForPerson;
            waiteHours = waitingQueue / minutesHour;
            waiteMinutes = waitingQueue % minutesHour;
            Console.WriteLine($"Ваше время ожидание в очереди: {waiteHours} ч., {waiteMinutes} мин.");
        }
    }
}
