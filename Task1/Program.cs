namespace Task1;

static class Program
{
    internal static void Main()
    {
        int kopeks = Convert.ToInt32(Console.ReadLine());
        var rublesAndKopeks = Solver.KopekToRubles(kopeks);
        Console.WriteLine(rublesAndKopeks);
    }
}

public class Money(int rubles, int kopeks = 0)
{
    public int Rubles { get; set; } = rubles;
    public int Kopeks { get; set; } = kopeks;

    public string GetStringRubles()
    {
        var secondLastDig = Rubles % 100 / 10;
        string rublesWord;
        if (secondLastDig == 1)
        {
            rublesWord = "рублей";
        }
        else
        {
            var lastDig = Rubles % 10;
            if (lastDig == 1)
                rublesWord = "рубль";
            else if (lastDig is > 1 and < 5) 
                rublesWord = "рубля";
            else 
                rublesWord = "рублей";
        }
        return rublesWord;
    }

    public string GetStringKopeks()
    {
        var secondLastDig = Kopeks % 100 / 10;
        string kopeksWord;
        if (secondLastDig == 1)
        {
            kopeksWord = "копеек";
        }
        else
        {
            var lastDig = Kopeks % 10;
            if (lastDig == 1)
                kopeksWord = "копейка";
            else if (lastDig is > 1 and < 5) 
                kopeksWord = "копейки";
            else 
                kopeksWord = "копеек";
        }
        return kopeksWord;
    }

    override public string ToString()
    {
        string kopeksWord = GetStringKopeks();
        string rublesWord = GetStringRubles();

        if (Rubles == 0 && Kopeks == 0)
        {
            return "Денег нет, но вы держитесь";
        }
        else if (Kopeks == 0)
        {
            return $"У вас есть {Rubles} {rublesWord}";
        }
        else if (Rubles == 0)
        {
            return $"У вас есть {Kopeks} {kopeksWord}";
        }
        else
        {
            return $"У вас есть {Rubles} {rublesWord} и {Kopeks} {kopeksWord}";
        }
    }
}

public class Solver
{
    public static Money KopekToRubles(int n)
    {
        return new(n / 100, n % 100);
    }
}