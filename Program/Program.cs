using Tyuiu.RotachAO.Sprint2.Task0.V16.Lib;

namespace Tyuiu.RotachAO.Sprint2.Task0.V16;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 1025;
        int y = 275;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);
        Console.Title = "Спринт #2 | Выполнил: Ротач. А. О. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #2                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #0                                                           *");
        Console.WriteLine("* Вариант #16                                                          *");
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}
