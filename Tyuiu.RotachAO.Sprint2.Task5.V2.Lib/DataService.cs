using tyuiu.cources.programming.interfaces.Sprint2; 
 
namespace Tyuiu.RotachAO.Sprint2.Task5.V2.Lib;

public class DataService : ISprint2Task5V2
{
    public string FindMonthSeason(int value)
    {
        switch (value)
        {
            case 1:
            case 2:
            case 12:
                return "����";
            case 3:
            case 4:
            case 5:
                return "�����";
            case 6:
            case 7:
            case 8:
                return "����";
            case 9:
            case 10:
            case 11:
                return "�����";
            default:
                throw new ArgumentException($"����� ������ ���� �� 1 �� 12.�������� {value}");
        }
    }
} 
