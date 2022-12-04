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
        var sum = 0;

        lines.ForEach(e => {
            var x = e.Split(",");
            var y = x[0].Split("-");
            var z = x[1].Split("-");

            var a = int.Parse(y[0]);
            var b = int.Parse(y[1]);
            var c = int.Parse(z[0]);
            var d = int.Parse(z[1]);

            if ((a <= c && b >= d) || (a >= c && b <= d))
                sum++;
        });

        return sum;
    }

    static int star2(List<string> lines)
    {
        var sum = 0;

        lines.ForEach(e => {
            var x = e.Split(",");
            var y = x[0].Split("-");
            var z = x[1].Split("-");

            var a = int.Parse(y[0]);
            var b = int.Parse(y[1]);
            var c = int.Parse(z[0]);
            var d = int.Parse(z[1]);

            if ((a <= c && b >= d) || (a >= c && b <= d) || (b >= c && a < c) || (a <= d && b > d))
                sum ++;
        });

        return sum;
    }
}