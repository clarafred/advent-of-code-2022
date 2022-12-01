namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "./../input.txt";

            using (StreamReader sr = new StreamReader(PATH))
            {
                var elfs = new List<int>();

                sr.ReadToEnd().Split("\n\n").ToList().ForEach(i =>
                {
                    var sum = 0;

                    i.Split("\n").ToList().ForEach(j =>
                    {
                        sum += int.Parse(j);
                    });

                    elfs.Add(sum);
                });

                var top = elfs.OrderByDescending(e => e).ToArray();

                Console.WriteLine(top[0] + top[1] + top[2]);
            }
        }
    }
}