namespace Task2;

class Program
{
    internal static void Main()
    {
        var ids = Solver.FindPair([.. Console.ReadLine()!.Split(' ').Select(n => Convert.ToInt32(n))]);
        if (ids is null)
        {
            Console.WriteLine("Пар не обнаружено");
        }
        else
        {
            Console.WriteLine(
                $"Id первой пары одинаковых чисел {ids.Value.Item1} и {ids.Value.Item2}");
        }
    }
}

public class Solver
{
    /// <summary>
    /// Возвращает id-шники первой пары соседних одинаковых элементов или null, если таких не обнаружено
    /// </summary>
    /// <param name="array">Массив чисел</param>
    /// <returns>Пара id-шников</returns>
    public static (int, int)? FindPair(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == array[i])
                return (i - 1, i);
        }

        return null;
    }
}