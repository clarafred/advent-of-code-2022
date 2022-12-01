namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "./../input.txt";

            var lineCounter = 1;

            foreach (string line in System.IO.File.ReadLines(@PATH))
            {
                if (line == string.Empty)
                    lineCounter++;
            }

            var caloriesArr = new int[lineCounter];

            var elfCounter = 0;
            var caloriesAmount = 0;

            using (StreamReader reader = new StreamReader(PATH))
            {
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();

                    if (line == string.Empty)
                    {
                        elfCounter++;
                        caloriesAmount = 0;
                    }
                    if (line != string.Empty)
                    {
                        int number = int.Parse(line);
                        caloriesAmount += number;
                        caloriesArr[elfCounter] = caloriesAmount;

                    }
                }
            }

            // First star
            int elfWithMostCalories = 0;
            int mostCalories = 0;

            for (int i = 0; i < caloriesArr.Length; i++)
            {
                if (caloriesArr[i] > mostCalories)
                {
                    elfWithMostCalories = i;
                    mostCalories = caloriesArr[i];
                }
            }

            Console.WriteLine($"Calories: {caloriesArr[elfWithMostCalories]}");            
        }
    }
}
