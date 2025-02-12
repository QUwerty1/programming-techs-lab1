namespace Task2.Test;

[TestClass]
public sealed class Tests
{
    [TestMethod]
    public void PairExists()
    {
        int[] array = [1, 2, 3, 6, 3, 5, 2, 2, 3];
        var pair = (6, 7);
        Assert.AreEqual(Solver.FindPair(array)!, pair);
    }
    [TestMethod]
    public void PairDoesNotExists()
    {
        int[] array = [1, 2, 6, 34, 58, 2, 23];
        Assert.IsNull(Solver.FindPair(array));
    }
    [TestMethod]
    public void NotNeighborEquivalentNumbers()
    {
        int[] array = [1, 2, 3, 6, 3, 5, 2, 3];
        Assert.IsNull(Solver.FindPair(array));
    }
}
