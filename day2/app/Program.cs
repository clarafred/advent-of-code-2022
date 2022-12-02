class Program
{
    static void Main(string[] args)
    {
        const string PATH = "./../input.txt";

        var score = 0;

        foreach (string line in File.ReadLines(@PATH))
        {
            var hand = line.Split(" ");

            var apponentsHand = hand[0];
            var myHand = hand[1];

            var rockA = "A";
            var rockX = "X";
            var paperB = "B";
            var paperY = "Y";
            var scissorsC = "C";
            var scissorsZ = "Z";

            var rockScore = 1;
            var paperScore = 2;
            var scissorsScore = 3;

            var lost = 0;
            var draw = 3;
            var win = 6;

            if (myHand == rockX)
            {
                score += rockScore;
            }
            else if (myHand == paperY)
            {
                score += paperScore;
            }
            else if (myHand == scissorsZ)
            {
                score += scissorsScore;
            }

            if (apponentsHand == rockA)
            {
                if (myHand == rockX)
                {
                    score += draw;
                }
                else if (myHand == paperY)
                {
                    score += win;
                }
                else if (myHand == scissorsZ)
                {
                    score += lost;
                }
            }
            else if (apponentsHand == paperB)
            {
                if (myHand == rockX)
                {
                    score += lost;
                }
                else if (myHand == paperY)
                {
                    score += draw;
                }
                else if (myHand == scissorsZ)
                {
                    score += win;
                }
            }
            else if (apponentsHand == scissorsC)
            {
                if (myHand == rockX)
                {
                    score += win;
                }
                else if (myHand == paperY)
                {
                    score += lost;
                }
                else if (myHand == scissorsZ)
                {
                    score += draw;
                }
            }
        }

        Console.WriteLine($"{score}");
    }
}