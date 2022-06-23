using System;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\nАдминистратор Юлия (приветливо): Добро пожаловать в поликлиннику, я помогу рассчитать время ожидания:)");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nнажмите Enter для продолжения диалога");
        Console.ReadLine();
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Администратор Юлия (с улыбкой): Сколько бабушек Вы видите перед собой?");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        double viewGrandmother = Convert.ToDouble(Console.ReadLine());
        double fixTime = 10;
        double waitTimeInMinute = viewGrandmother * fixTime;
        double waitTimeInHour = waitTimeInMinute / 60;
        TimeSpan time = TimeSpan.FromHours(waitTimeInHour);
        string textTime = Convert.ToString(time);
        char h1 = textTime[0];
        char h2 = textTime[1];
        char m1 = textTime[3];
        char m2 = textTime[4];

        /*
         * Не смог разобраться как написать код, если бабушек более 72, то часы переваливают за дни,
         * пробывал добавлять if в if, не получилось, так как там уже есть условие если бабушек 0 - то это другой сценарий.
         */

        if (viewGrandmother <= 0)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Администратор Юлия (с ухмылкой): Прекрасно, проходите к окну №2");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nАдминистратор Юлия (серьезно): Вы должны отстоять в очереди {0}{1} часов и {2}{3} минут.", h1, h2, m1, m2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nНажмите Enter если желаете использовать С4");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

            double timeMinuteAfterC4 = waitTimeInMinute * 2;
            double timeHourAfterC4 = timeMinuteAfterC4 / 60;
            TimeSpan timeAfterC4 = TimeSpan.FromHours(timeHourAfterC4);
            string textTimeAfterC4 = Convert.ToString(timeAfterC4);
            char h11 = textTimeAfterC4[0];
            char h22 = textTimeAfterC4[1];
            char m11 = textTimeAfterC4[3];
            char m22 = textTimeAfterC4[4];

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Администратор Юлия (кашляя от пыли): Время ожидания сокращено, и составляет {0}{1} часов и {2}{3} минут.", h11, h22, m11, m22);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nнажмите Enter для продолжения диалога");
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Вы (возмущенно): Почему бл*** время увеличилось?!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nнажмите Enter для продолжения диалога");
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Администратор Юлия (злорадный смех): у этих бабушек ресисты к С4, плюс пришли бабушки по записи...");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

