using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Как Вас зовут?");
        string name = (Console.ReadLine());
        Console.WriteLine("Сколько Вам лет");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш знак зодиака");
        string libra = (Console.ReadLine());
        Console.WriteLine("Любимое блюдо");
        string dish = (Console.ReadLine());
        int date = 2022 - age;
        Console.WriteLine("ОБРАБОТКА ДАННЫХ...... нажмите Enter");
        Console.ReadLine();
        Console.WriteLine("Вас зовут: {0} \nВы родились в {1} г. \nпо гороскопу Вы: {2} \nжрете в основном {3}", name, date, libra, dish);
    }
}
