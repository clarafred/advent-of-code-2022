class Program
{
    static void Main(string[] args)
    {
        const string PATH = "./../input.txt";

        var lines = new List<string>();

        foreach (string line in File.ReadLines(@PATH))
        {
            lines.Add(line);
        }

        var sum1 = round1(lines);
        var sum2 = round2(lines);

        Console.WriteLine(sum1);
        Console.WriteLine(sum2);
    }

    static int round1(List<string> lines)
    {
        var sum = 0;

        lines.ForEach(e => 
        {
            var score =
                e == "A X" ? sum += 4
                : e == "B X" ? sum += 1
                : e == "C X" ? sum += 7
                : e == "A Y" ? sum += 8
                : e == "B Y" ? sum += 5
                : e == "C Y" ? sum += 2
                : e == "A Z" ? sum += 3
                : e == "B Z" ? sum += 9
                : e == "C Z" ? sum += 6
                : 0;
        });

        return sum;
    }

    static int round2(List<string> lines)
    {
        var sum = 0;

        lines.ForEach(e => 
        {
            var score =
                e == "A X" ? sum += 3
                : e == "B X" ? sum += 1
                : e == "C X" ? sum += 2
                : e == "A Y" ? sum += 4
                : e == "B Y" ? sum += 5
                : e == "C Y" ? sum += 6
                : e == "A Z" ? sum += 8
                : e == "B Z" ? sum += 9
                : e == "C Z" ? sum += 7
                : 0;
        });

        return sum;
    }
}