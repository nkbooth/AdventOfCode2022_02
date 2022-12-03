namespace AdventOfCode_02
{
    public class GameCollection
    {
        public List<RockPaperScissorsGame> Games = new List<RockPaperScissorsGame>();

        public void LoadData(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] gameData = line.Split(" ");
                RockPaperScissorsGame game = new RockPaperScissorsGame();
                game.TheirMove = gameData[0];
                game.MyMove = gameData[1];
                Games.Add(game);
            }
        }
    }
}