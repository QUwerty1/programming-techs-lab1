static class Program
{
    internal static void Main()
    {
        var text = "1+4-3+2";
        Console.WriteLine(Solver.FindSumFromText(text));
    }
}

static class Solver
{
    /// <summary>
    /// Находит сумму чисел в строке
    /// </summary>
    /// <param name="text">Строка в формате d1±d2±...±dn, где di > 0</param>
    /// <returns>Сумма чисел</returns>
    public static int FindSumFromText(string text)
    {
        int numStartPos = 0;
        int sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if ((numStartPos != i) && (text[i] is '-' or '+'))
            {
                sum += Convert.ToInt32(text[numStartPos..i]);
                numStartPos = i;
            }
        }
        sum += Convert.ToInt32(text[numStartPos..]);

        return sum;
    }
}