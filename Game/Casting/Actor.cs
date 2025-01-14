using System;


namespace cse210_05.Game.Casting
{
    // A thing that participates in the game.
    // The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    // space.
    public class Actor
    {
        private string text = "";
        private int fontSize = 15;
        private Color color = Constants.WHITE;
        private Point position = new Point(0, 0);
        private Point velocity = new Point(0, 0);

        // Constructs a new instance of Actor.
        public Actor()
        {
        }

        // Gets the actor's color.
        public Color GetColor()
        {
            return color;
        }

        // Gets the actor's font size.
        public int GetFontSize()
        {
            return fontSize;
        }

        // Gets the actor's position.
        public Point GetPosition()
        {
            return position;
        }

        // Gets the actor's text.
        public string GetText()
        {
            return text;
        }


        // Gets the actor's current velocity.
        public Point GetVelocity()
        {
            return velocity;
        }

        // Moves the actor to its next position according to its velocity. Will wrap the position 
        // from one side of the screen to the other when it reaches the maximum x and y 
        // values.
        public virtual void MoveNext()
        {
            int x = ((position.GetX() + velocity.GetX()) + Constants.MAX_X) % Constants.MAX_X;
            int y = ((position.GetY() + velocity.GetY()) + Constants.MAX_Y) % Constants.MAX_Y;
            position = new Point(x, y);
        }

        // Sets the actor's color to the given value.
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this.color = color;
        }

        // Sets the actor's font size to the given value.
        // When font size is less than or equal to zero.
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this.fontSize = fontSize;
        }

        // Sets the actor's position to the given value.

        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this.position = position;
        }

        // Sets the actor's text to the given value.
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this.text = text;
        }

        // Sets the actor's velocity to the given value.
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this.velocity = velocity;
        }

    }
}