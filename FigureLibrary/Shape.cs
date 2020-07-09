namespace Figure
{
    public abstract class Shape
    {
        public abstract string Type { get; }
        public abstract double Area { get; }
        public abstract double[] FigureSides{ get; set; }
        public abstract bool isValid(double[] sides);
    }
}