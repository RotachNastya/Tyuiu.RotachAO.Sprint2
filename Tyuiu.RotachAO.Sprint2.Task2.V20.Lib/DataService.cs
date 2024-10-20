using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.RotachAO.Sprint2.Task2.V20.Lib;

public class DataService : ISprint2Task2V20
{
    public bool CheckDotInShadedArea(int x, int y)
    {
        if ((x >= 3 && x <= 5 && y >= 3 && y <= 5))
            return true;
        else if ((x == 3 && y == 6))
            return true;
        else if ((x >= 6 && x <= 9 && y >= 5 && y <= 8))
            return true;
        else if ((x == 9 && y >=3&& y <= 4))
            return true;
        else if ((y == 11 && x >= 3 && x <= 6))
            return true;
        else if ((x == 6 && y >= 9 && y <= 11))
            return true;
        if ((x >= 9 && x <= 12 && y >= 8 && y <= 13))
            return true;
        else if ((x == 13 && y >= 6 && y <= 8))
            return true;
        else if ((x == 9 && y >= 9 && y <= 12))
            return true;



        else return false;
    }
} 
