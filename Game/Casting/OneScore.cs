using System;


namespace cse210_05.Game.Casting
{
    // The score of player one.
    /// The responsibility of OneScore is to keep track of Player one's score.
    public class OneScore : Actor
    {
        private int points = 0;

        // Constructs a new instance of an OneScore.
        public OneScore()
        {
            AddPointsOne(0);
        }

        /// Adds the given points to the score.
        // The points to add.
        public void AddPointsOne(int points)
        {
            this.points += points;
            SetText($"Player One: {this.points}");
        }
    }
}