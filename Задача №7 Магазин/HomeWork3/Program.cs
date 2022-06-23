using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько у Вас золотых монет?");
        double startBalance = Convert.ToDouble(Console.ReadLine());
        double diamondPrice = 7;

        Console.WriteLine("\nНа вашем балансе {0} золотых", startBalance);
        Console.WriteLine("Стоимость 1 кристалла = {0} золотых", diamondPrice);
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\nСколько кристаллов Вы желаете купить?");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        double wantDiamond = Convert.ToDouble(Console.ReadLine());

        if (wantDiamond <= 0)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nДля приличия мог бы купить 1 кристалл");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        else

        if (wantDiamond * diamondPrice <= startBalance)
        {
            double newBalance = startBalance - (wantDiamond * diamondPrice);
            double buyDiamond = wantDiamond;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nСпасибо за покупку!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nВы приобрели: {0} кристаллов \nТекущий остаток средств: {1} золотых", wantDiamond, newBalance);
            Console.WriteLine("\nЖелаете купить что то еще?");
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Братишка, а как насчет элитных кристаллов?");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            double diamondElitePrice = 1000;

            Console.WriteLine("\nНа вашем балансе {0} золотых", newBalance);
            Console.WriteLine("Стоимость 1 элитного кристалла = {0} золотых", diamondElitePrice);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nСколько элитных кристаллов Вы желаете купить?");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            double wantEliteDiamond = Convert.ToDouble(Console.ReadLine());

            if (wantEliteDiamond <= 0)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\nЕсли надумаешь, ты знаешь где меня найти ;)");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            else

           if (wantEliteDiamond * diamondElitePrice <= newBalance)
            {
                double newAfterEliteBalance = newBalance - (wantEliteDiamond * diamondElitePrice);
                double buyEliteDiamond = wantEliteDiamond;

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nАхуеть, ты первый у кого хватило золотых!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nВы приобрели: {0} элитных кристалов \nТекущий остаток средств: {1} золотых", wantEliteDiamond, newAfterEliteBalance);
                Console.WriteLine("\nЖелаете купить что то посерьезнее?");
                Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Я Вижу что ты разбираешься в кристаллах, у меня есть запрещенные кристаллы");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                double diamondIllegalPrice = startBalance * 0.35;
                double allBuyCrystall = wantDiamond + wantEliteDiamond;
                double allSpendGold = (wantDiamond * diamondPrice) + (wantEliteDiamond * diamondElitePrice);

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\nТы уже приобрел у меня {0} кристаллов, на сумму {1} золотых, \nЯ сделаю хорошую скидку на запрещенные кристаллы!", allBuyCrystall, allSpendGold);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nНа вашем балансе {0} золотых", newAfterEliteBalance);
                Console.WriteLine("Стоимость 1 запрещенного кристалла с учетом скидки = {0} золотых", diamondIllegalPrice);
                Console.WriteLine("\nСколько запрещенных кристаллов Вы желаете купить?");

                double wantIllegalDiamond = Convert.ToDouble(Console.ReadLine());

                if (wantIllegalDiamond <= 0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\nЛадно, если что, я ничего не предлагал.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else

                if (wantIllegalDiamond * diamondIllegalPrice <= newAfterEliteBalance)
                {
                    double newAfterIllegalBalance = newAfterEliteBalance - (wantIllegalDiamond * diamondIllegalPrice);
                    double buyIllegalDiamond = wantIllegalDiamond;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nВот это я понимаю покупка!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nВы приобрели: {0} запрещенных кристалов \nТекущий остаток средств: {1} золотых", wantEliteDiamond, newAfterIllegalBalance);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\nС тобой приятно иметь дело! Удачи!");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Недостаточно средств! Приходи когда будет золото.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Недостаточно средств! Приходите завтра.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
















    }
}
