class Program
{
    static void Main(string[] args)
    {
        const string PATH = "./../input.txt";

        var score = 0;

        var rock = "A";
        var paper = "B";
        var scissors = "C";

        var lose = "X";
        var draw = "Y";
        var win = "Z";

        var rockScore = 1;
        var paperScore = 2;
        var scissorsScore = 3;

        var lostPoint = 0;
        var drawPoint = 3;
        var winPoint = 6;
        
        foreach (string line in File.ReadLines(@PATH))
        {
            var round = line.Split(" ");

            var apponentsHand = round[0];
            var end = round[1];


            if (end == lose)
            {
                score += lostPoint;

                if (apponentsHand == rock)
                {
                    score += scissorsScore;
                }
                else if (apponentsHand == paper)
                {
                    score += rockScore;
                }
                else if (apponentsHand == scissors)
                {
                    score += paperScore;
                }
            }
            else if (end == draw)
            {
                score += drawPoint;

                if (apponentsHand == rock)
                {
                    score += rockScore;
                }
                else if (apponentsHand == paper)
                {
                    score += paperScore;
                }
                else if (apponentsHand == scissors)
                {
                    score += scissorsScore;
                }
            }
            else if (end == win)
            {
                score += winPoint;

                if (apponentsHand == rock)
                {
                    score += paperScore;
                }
                else if (apponentsHand == paper)
                {
                    score += scissorsScore;
                }
                else if (apponentsHand == scissors)
                {
                    score += rockScore;
                }
            }
        }
        Console.WriteLine($"{score}");
    }
}