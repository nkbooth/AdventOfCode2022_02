using System.Collections.Generic;

namespace AdventOfCode_02
{
    public class RockPaperScissorsGame
    {
        public string TheirMove { get; set; }
        public string MyMove { get; set; }
        public int TheirScore { 
            get
            {
                Scores scores = new Scores();
                int myChoicePoints = scores.PossibleScores[MyMove];
                int theirChoicePoints = scores.PossibleScores[TheirMove];

                return theirChoicePoints + WinnerPoints(theirChoicePoints, myChoicePoints);
            }}
        public int MyScore { 
            get
            {
                Scores scores = new Scores();
                int myChoicePoints = scores.PossibleScores[MyMove];
                int theirChoicePoints = scores.PossibleScores[TheirMove];
                
                return myChoicePoints + WinnerPoints(myChoicePoints, theirChoicePoints);                
            }
        }

        public int WinnerPoints(int a, int b)
        {
            if( a == b) { return 3; }
            if (a == 1)
            {
                if (b == 2) {return 0;}
                if (b == 3) {return 6;}
            } else if (a == 2)
            {
                if (b == 1) {return 6; }
                if (b == 3) {return 0; }
            } else if (a == 3)
            {
                if (b == 1) {return 0; }
                if (b == 2) {return 6; }
            }
            return 0;
        }
    }
}