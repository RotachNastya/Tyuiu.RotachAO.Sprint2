using Tyuiu.RotachAO.Sprint2.Task6.V5.Lib;

namespace Tyuiu.RotachAO.Sprint2.Task6.V5.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        Assert.AreEqual("øåñòåðêà", ds.FindCardValue(6));
        Assert.AreEqual("ñåìåðêà", ds.FindCardValue(7));
        Assert.AreEqual("âîñüìåðêà", ds.FindCardValue(8));
        Assert.AreEqual("äåâÿòêà", ds.FindCardValue(9));
        Assert.AreEqual("äåñÿòêà", ds.FindCardValue(10));
        Assert.AreEqual("âàëåò", ds.FindCardValue(11));
        Assert.AreEqual("äàìà", ds.FindCardValue(12));
        Assert.AreEqual("êîðîëü", ds.FindCardValue(13));
        Assert.AreEqual("òóç", ds.FindCardValue(14));
        Assert.ThrowsException<ArgumentException>(() => ds.FindCardValue(5));
        Assert.ThrowsException<ArgumentException>(() => ds.FindCardValue(15));
    }
}