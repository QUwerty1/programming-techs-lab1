namespace Task1.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void K1()
    {
        var money = new Money(0, 1);
        Assert.AreEqual("У вас есть 1 копейка", money.ToString());

    }
    [TestMethod]
    public void K2_4()
    {
        var money = new Money(0, 2);
        Assert.AreEqual("У вас есть 2 копейки", money.ToString());
    }
    [TestMethod]
    public void K5_9()
    {
        var money = new Money(0, 5);
        Assert.AreEqual("У вас есть 5 копеек", money.ToString());
    }
    [TestMethod]
    public void R1()
    {
        var money = new Money(1, 0);
        Assert.AreEqual("У вас есть 1 рубль", money.ToString());
    }
    [TestMethod]
    public void R2_4()
    {
        var money = new Money(2, 0);
        Assert.AreEqual("У вас есть 2 рубля", money.ToString());
    }
    [TestMethod]
    public void R5_9()
    {
        var money = new Money(5, 0);
        Assert.AreEqual("У вас есть 5 рублей", money.ToString());
    }
    [TestMethod]
    public void NoMoney()
    {
        var money = new Money(0, 0);
        Assert.AreEqual("Денег нет, но вы держитесь", money.ToString());
    }
    [TestMethod]
    public void RublesAndKopeks()
    {
        var money = new Money(1, 1);
        Assert.AreEqual("У вас есть 1 рубль и 1 копейка", money.ToString());
    }
}
