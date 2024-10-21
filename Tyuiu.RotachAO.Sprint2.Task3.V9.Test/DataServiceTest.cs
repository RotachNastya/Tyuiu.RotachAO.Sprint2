using Tyuiu.RotachAO.Sprint2.Task3.V9.Lib; 
 
namespace Tyuiu.RotachAO.Sprint2.Task3.V9.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidCondition1()  
   { 
        DataService ds = new DataService();
        double x = 1;
        double res = ds.Calculate(x);
        double wait = -2.667;
        Assert.AreEqual(wait, res);
   }

    public void ValidCondition2()
    {
        DataService ds = new DataService();
        double x = 0;
        double res = ds.Calculate(x);
        double wait = -1;
        Assert.AreEqual(wait, res);
    }

    public void ValidCondition3()
    {
        DataService ds = new DataService();
        double x = -14;
        double res = ds.Calculate(x);
        double wait = -154.071;
        Assert.AreEqual(wait, res);
    }

    public void ValidCondition4()
    {
        DataService ds = new DataService();
        double x = 2;
        double res = ds.Calculate(x);
        double wait = -23.12;
        Assert.AreEqual(wait, res);
    }
} 
