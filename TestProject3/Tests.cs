namespace Task3.Test;

[TestClass]
public sealed class Tests
{
    [TestMethod]
    public void OnlyPluses()
    {
        Assert.AreEqual(10, Solver.FindSumFromText("1+4+2+3"));
    }
    [TestMethod]
    public void OnlyMinuses()
    {
        Assert.AreEqual(0, Solver.FindSumFromText("10-2-1-4-3"));
    }
    [TestMethod]
    public void PlusesAndMinuses()
    {
        Assert.AreEqual(0, Solver.FindSumFromText("1+4+2+3-10"));
    }
    [TestMethod]
    public void ResultSumBelowZero()
    {
        Assert.AreEqual(-10, Solver.FindSumFromText("1+4+2+3-20"));
    }
}
