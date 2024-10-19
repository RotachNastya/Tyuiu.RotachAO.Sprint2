using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.RotachAO.Sprint2.Task1.V13.Lib;

public class DataService : ISprint2Task1V13
{
    public bool[] GetLogicOperations(int a, int b, int c, int d)
    {
        bool[] res = new bool[6];
        res[0] = (a > b) | (c < b);
        res[1] = (a + 1000 > b) & (c < d + 100);
        res[2] = (a > b) || (c < b);
        res[3] = (a + 2000 > b) && (c < d + 300);
        res[4] = !(!res[0]);   
        res[5] = (a > b) ^ (c < d);
        return res;

    }
} 
