namespace Task1.Tests;

[TestClass]
public sealed class Tests
{
    [TestMethod]
    public void K1()
    {
        Assert.AreEqual("У вас есть 1 копейка", Solver.KopekToRubles(1).ToString());

    }
    [TestMethod]
    public void K2_4()
    {
        Assert.AreEqual("У вас есть 2 копейки", Solver.KopekToRubles(2).ToString());
    }
    [TestMethod]
    public void K5_9()
    {
        Assert.AreEqual("У вас есть 5 копеек", Solver.KopekToRubles(5).ToString());
    }
    [TestMethod]
    public void R1()
    {
        Assert.AreEqual("У вас есть 1 рубль", Solver.KopekToRubles(100).ToString());
    }
    [TestMethod]
    public void R2_4()
    {
       Assert.AreEqual("У вас есть 2 рубля", Solver.KopekToRubles(200).ToString());
    }
    [TestMethod]
    public void R5_9()
    {
        Assert.AreEqual("У вас есть 5 рублей", Solver.KopekToRubles(500).ToString());
    }
    [TestMethod]
    public void NoMoney()
    {
        Assert.AreEqual("Денег нет, но вы держитесь", Solver.KopekToRubles(0).ToString());
    }
    [TestMethod]
    public void RublesAndKopeks()
    {
        Assert.AreEqual("У вас есть 1 рубль и 1 копейка", Solver.KopekToRubles(101).ToString());
    }
}
