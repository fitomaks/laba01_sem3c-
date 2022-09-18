
namespace ClassLibrary1
{
    public class Figura
    {
        private Point[] points;
        private double perimetr = 0;

        public string Name { get; set; }
        public double Perimetr => perimetr;
        public Figura(Point p1, Point p2 , Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;

            PerimeterCalculator();
        }

        public Figura(Point p1, Point p2, Point p3, Point p4 )
        {
            points = new Point[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;

            PerimeterCalculator();
        }

        public Figura(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;

            PerimeterCalculator();
        }
         private double LengthSide(Point A, Point B)
        {
            double x2 = Math.Pow( Math.Abs(A.X - B.X),2) ;
            double y2 = Math.Pow( Math.Abs(A.Y - B.Y),2) ;

            return Math.Sqrt (x2 + y2);
        }

         private void PerimeterCalculator()
        {
            for(int i = 0; i < points.Length - 1; i++)
            {
                perimetr += LengthSide(points[i], points[i+1]);
            }
            perimetr += LengthSide(points[0], points[points.Length - 1]);

        }


    }
}
