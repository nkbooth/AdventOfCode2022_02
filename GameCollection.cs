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
                game.MyMove = CalculateMove(gameData);
                Games.Add(game);
            }
        }

        public string CalculateMove(string[] data)
        {
            string strategy = data[1];
            string theirLastMove = data[0];
            
            if (strategy.ToUpper() == "X")
            {
                if (theirLastMove == "A") { return "C";}
                if(theirLastMove == "B") { return "A"; }
                if(theirLastMove == "C") { return "B"; }
            }
            if (strategy.ToUpper() == "Y")
            {
                return theirLastMove;
            }
            if (strategy.ToUpper() == "Z")
            {
                if(theirLastMove == "A") { return "B"; }
                if(theirLastMove == "B") { return "C"; }
                if(theirLastMove == "C") { return "A"; }
            }
            return "error";
        }
    }
}