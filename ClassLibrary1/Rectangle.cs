namespace ClassLibrary1
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double sideA, double sideB) => (side1, side2) = (sideA, sideB);

        
         private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator() => 2*side1 + 2*side2;

        public double Area
        {
            get => AreaCalculator();

        }
        public double Perimeter { get => PerimeterCalculator(); }
    }
}