using tyuiu.cources.programming.interfaces.Sprint2; 
namespace Tyuiu.RotachAO.Sprint2.Task0.V16.Lib; 
 
public class DataService: ISprint2Task0V16 
{ 
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] res = new bool[6];
        res[0] = x - 750 == y;
        res[1] = x!= y + 750;
        res[2] = x < y + 1000;
        res[3] = x - 1000 > y;
        res[4] = x <= y + 751;
        res[5] = x -7040 >= y;
        return res;

    }
}
