using System;


namespace cse210_05.Game.Casting{

    // The score of player Two.
    // The responsibility of TwoScore is to keep track of Player two's score.
    public class TwoScore : Actor
    {
        private int points = 0;

        // Constructs a new instance of an TwoScore.
        public TwoScore()
        {
            AddPointsTwo(0);
        }

        // Adds the given points to the score.
        public void AddPointsTwo(int points)
        {
            this.points += points;
            SetText($"Player Two: {this.points}");
        }
    }
}