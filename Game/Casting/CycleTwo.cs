using System;
using System.Collections.Generic;
using System.Linq;

namespace cse210_05.Game.Casting
{
    // Player two's motorcycle with light ribbons trailing behind it.
    // The responsibility of CycleTwo is to move itself.
    public class CycleTwo : Actor
    {
        private List<Actor> segments = new List<Actor>();

        // Constructs a new instance of player two's bike. 
        public CycleTwo()
        {
            PrepareBody();
        }

        // Gets the bike's light ribbon segments.
        public List<Actor> GetBody()
        {
            return new List<Actor>(segments.Skip(1).ToArray());
        }

        // Gets the bike segment.
        public Actor GetHead()
        {
            return segments[0];
        }

        // Gets the bike's segments (including the bike).
        public List<Actor> GetSegments()
        {
            return segments;
        }

        // Grows the bike's light ribbons by the given number of segments.
        public void GrowTail(int numberOfSegments)
        {
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor tail = segments.Last<Actor>();
                Point velocity = tail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = tail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText("#");
                segment.SetColor(Constants.BLUE);
                segments.Add(segment);
            }
        }

        // <inheritdoc/>
        public override void MoveNext()
        {
            foreach (Actor segment in segments)
            {
                segment.MoveNext();
            }

            for (int i = segments.Count - 1; i > 0; i--)
            {
                Actor trailing = segments[i];
                Actor previous = segments[i - 1];
                Point velocity = previous.GetVelocity();
                trailing.SetVelocity(velocity);
            }
        }

        // Turns the bike in the given direction.
        public void TurnHead(Point direction)
        {
            segments[0].SetVelocity(direction);
        }

        // Prepares the bike body for moving.
        private void PrepareBody()
        {
            int x = Constants.MAX_X  / (4);
            int y = Constants.MAX_Y  / (4);

            for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
            {
                Point position = new Point(x - i * Constants.CELL_SIZE, y);
                Point velocity = new Point(1 * Constants.CELL_SIZE, 0);
                string text = i == 0 ? "8" : "#";
                Color color = i == 0 ? Constants.HEADBLUE : Constants.BLUE;

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText(text);
                segment.SetColor(color);
                segments.Add(segment);
            }
        }
    }
}