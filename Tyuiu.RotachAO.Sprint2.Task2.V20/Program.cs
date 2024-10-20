using Tyuiu.RotachAO.Sprint2.Task2.V20.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint2.Task2.V20; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #2 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #20                                                          *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("Введите значение переменной х");
        Console.WriteLine("************************************************************************");
       int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение переменной у");
        int y = Convert.ToInt32(Console.ReadLine());
        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Результат");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
{
        Console.WriteLine("Точка не находится в заштрихованной области");
}
        Console.ReadKey();
    }

} 