class Program
{
    static void Main(string[] args)
    {
        const string PATH = "./../input.txt";

        var lines = new List<string>();

        foreach (string line in File.ReadLines(@PATH)) { lines.Add(line); }

        Console.WriteLine(star1(lines));
    }
    static int star1(List<string> lines)
    {
        var sum = 0;

        lines.ForEach(e =>
        {
            var first = e.Substring(0, e.Length / 2);
            var second = e.Substring(e.Length / 2, e.Length / 2);

            var result = 0;

            for (int i = 0; i < first.Length; i++)
            {
                if (second.Contains(first[i]))
                {
                    result = (char.IsUpper(first[i])) ? (byte)first[i] - 38
                    : (char.IsLower(first[i])) ? (byte)first[i] - 96
                    : 0;
                }
            }

            sum += result;
        });

        return sum;
    }
}