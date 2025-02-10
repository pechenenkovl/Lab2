
namespace Lab2.Models
{
    public class Line
    {
        private Point _point1;
        private Point _point2;

        /// <summary>
        /// The default constructor
        /// </summary>
        public Line()
        {
            _point1 = new Point(0, 0);
            _point2 = new Point(1, 1);
        }

        /// <summary>
        /// The constructor with parameters
        /// </summary>
        /// <param name="point1">The point1.</param>
        /// <param name="point2">The point2.</param>
        public Line(Point point1, Point point2)
        {
            _point1 = point1;
            _point2 = point2;
        }

        /// <summary>
        /// The constructor for replacing <paramref name="anotherLine"/> object
        /// </summary>
        /// <param name="anotherLine">The Another line.</param>
        public Line(ref Line anotherLine)
        {
            _point1 = anotherLine._point1;
            _point2 = anotherLine._point2;
            // Replace "anotherLine" parameter outside using "ref" parameter modifier
            anotherLine = null;
        }

        /// <summary>
        /// The constructor for coping
        /// </summary>
        /// <param name="other">The other line.</param>
        public Line(Line other)
        {
            // Using "deep" points copying
            _point1 = new Point(other._point1.GetX(), other._point1.GetY());
            _point2 = new Point(other._point2.GetX(), other._point2.GetY());
        }

        ~Line()
        {
            Console.WriteLine("Destructor called");
        }

        public Point GetPoint1()
        {
            return _point1;
        }

        public Point GetPoint2()
        {
            return _point2;
        }

        public Point Point1
        {
            get { return _point1; }
            private set { _point1 = value; }
        }

        public Point Point2
        {
            get { return _point2; }
            private set { _point2 = value; }
        }
    }
}
