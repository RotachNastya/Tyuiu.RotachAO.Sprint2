using Tyuiu.RotachAO.Sprint2.Task4.V21.Lib; 
 
namespace Tyuiu.RotachAO.Sprint2.Task4.V21.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidCondition1()  
   { 
        DataService ds = new DataService();
        double x =1 ;
        double y = 4 ;
        double res = ds.Calculate(x,y) ;
        double wait = 16 ;
        Assert.AreEqual(wait, res) ;
    }

    [TestMethod]
    public void ValidCondition2()
    {
        DataService ds = new DataService();
        double x = 1;
        double y = 0 ;
        double res = ds.Calculate(x, y);
        double wait = 0.916;
        Assert.AreEqual(wait, res);
    }
} 
