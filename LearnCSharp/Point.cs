namespace LearnCSharp
{
    public class Point(int x, int y)
    {
        public int X = x;
        public int Y = y;

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(Point newLocation)
        {
            ArgumentNullException.ThrowIfNull(nameof(newLocation));

            Move(newLocation.X, newLocation.Y);
        }
    }
}
