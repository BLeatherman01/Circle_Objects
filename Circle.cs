namespace Circle_Objects
{
    class Circle
    {
        private double Radius;


        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double CalculateArea()
        {
            double area = Radius * Radius * Math.PI;
            area = Math.Round(area, 2);
            return area;
        }
        public double CalculateCircumference()
        {
            double circumference = 2 * (Math.PI * Radius);
            circumference = Math.Round(circumference, 2);
            return circumference;
        }
    }
}
