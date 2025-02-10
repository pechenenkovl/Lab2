namespace Lab2.Models
{
    public class Point
    {
        private double _x;
        private double _y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double GetX()
        {
            return _x;
        }

        public double GetY()
        {
            return _y;
        }
    }
}
