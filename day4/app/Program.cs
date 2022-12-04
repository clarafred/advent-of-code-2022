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

        var sum1 = star1(lines);
        var sum2 = star2(lines);

        Console.WriteLine(sum1);
        Console.WriteLine(sum2);
    }

    static int star1(List<string> lines)
    {
        var result = 0;

        for (int i = 0; i < lines.Count; i++)
        {
            var splitted = lines[i].Split(",");

            var firstPair = splitted[0];
            var secondPair = splitted[1];

            var splitFirstPair = firstPair.Split("-");
            var splitSecondPair = secondPair.Split("-");

            var firstFirst = int.Parse(splitFirstPair[0]);
            var firstLast = int.Parse(splitFirstPair[1]);

            var secondFirst = int.Parse(splitSecondPair[0]);
            var secondLast = int.Parse(splitSecondPair[1]);

            if ((firstFirst <= secondFirst && firstLast >= secondLast) || (firstFirst >= secondFirst && firstLast <= secondLast))
            {
                result += 1;
            }
        }
        return result;
    }

    static int star2(List<string> lines)
    {
        var sum = 0;

        for (int i = 0; i < lines.Count; i++)
        {
            var splitted = lines[i].Split(",");

            var firstPair = splitted[0];
            var secondPair = splitted[1];

            var splitFirstPair = firstPair.Split("-");
            var splitSecondPair = secondPair.Split("-");

            var firstFirst = int.Parse(splitFirstPair[0]);
            var firstLast = int.Parse(splitFirstPair[1]);

            var secondFirst = int.Parse(splitSecondPair[0]);
            var secondLast = int.Parse(splitSecondPair[1]);

            var result = ((firstFirst <= secondFirst && firstLast >= secondLast) || (firstFirst >= secondFirst && firstLast <= secondLast)) ? 1
            : (firstLast >= secondFirst && firstFirst < secondFirst) ? 1
            : (firstFirst <= secondLast && firstLast > secondLast) ? 1
            : 0;

            sum += result;
        }

        return sum;
    }
}