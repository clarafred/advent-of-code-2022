class Program
{
    static void Main(string[] args)
    {
        const string PATH = "./../input.txt";

        var sum = 0;

        foreach (string line in File.ReadLines(@PATH))
        {
            var score =
                line == "A X" ? sum += 3
                : line == "B X" ? sum += 1
                : line == "C X" ? sum += 2
                : line == "A Y" ? sum += 4
                : line == "B Y" ? sum += 5
                : line == "C Y" ? sum += 6
                : line == "A Z" ? sum += 8
                : line == "B Z" ? sum += 9
                : line == "C Z" ? sum += 7
                : 0;
        }

        Console.WriteLine(sum);
    }
}