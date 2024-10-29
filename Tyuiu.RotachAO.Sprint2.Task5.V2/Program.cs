using Tyuiu.RotachAO.Sprint2.Task5.V2.Lib; 
 
namespace Tyuiu.RotachAO.Sprint2.Task5.V2; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService dataService = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #2                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #2                                                           *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("                                                                       *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Введите порядковый номер месяца: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string res;
        if ((x < 1) || (x > 12))
        {
            res = "Введено неверное значение!";
        }
        else
        {
            res = "Это сезон: " + dataService.FindMonthSeason(x);
        }
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    } 
} 
