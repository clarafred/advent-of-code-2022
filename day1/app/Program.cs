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
                    else
                    {
                        int number = int.Parse(line);
                        caloriesAmount += number;
                        caloriesArr[elfCounter] = caloriesAmount;
                    }
                }
            }

            var topCaloriesArr = new int[3];

            for (int i = 0; i < caloriesArr.Length; i++)
            {
                if (caloriesArr[i] > topCaloriesArr[0])
                {
                    topCaloriesArr[2] = topCaloriesArr[1];
                    topCaloriesArr[1] = topCaloriesArr[0];
                    topCaloriesArr[0] = caloriesArr[i];
                }
                else if (caloriesArr[i] > topCaloriesArr[1] && caloriesArr[i] != topCaloriesArr[0])
                {
                    topCaloriesArr[2] = topCaloriesArr[1];
                    topCaloriesArr[1] = caloriesArr[i];
                }
                else if (caloriesArr[i] > topCaloriesArr[2] && caloriesArr[i] != topCaloriesArr[1])
                {
                    topCaloriesArr[2] = caloriesArr[i];
                }
            }
            Console.WriteLine(topCaloriesArr[0] + topCaloriesArr[1] + topCaloriesArr[2]);
        }
    }
}
