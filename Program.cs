namespace AdventOfCode_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilename = "input.txt";
            GameCollection gameCollection = new GameCollection();
            Console.WriteLine("Reading input file...");
            gameCollection.LoadData(inputFilename);

            Console.WriteLine($"My total score: {gameCollection.Games.Sum(x => x.MyScore)}");
            Console.WriteLine($"Their total score: {gameCollection.Games.Sum(x => x.TheirScore)}");
        }
    }
}