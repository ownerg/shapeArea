namespace Figure
{
    public class Circle : Shape
    {
        /// <summary>
        /// Значение радиуса
        /// </summary>
        private double[] figureSides;

        /// <summary>
        /// Конструктор Circle
        /// </summary>
        public Circle(double _radius)
        {
            FigureSides = new double[] {_radius};
            Type = "Circle";
        }
        
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public override string Type {get;}

        /// <summary>
        /// Радиус окружности double[]
        /// </summary>
        public override double[] FigureSides
        {
            get { return figureSides; }
            set
            {
                double[] radius = (double[])value;

                if ((radius != figureSides) && isValid(radius))
                {
                    figureSides = value;
                }
            }
        }

        /// <summary>
        /// Валидация круга. Если радиус больше или равен 0 - фигура соответствует.
        /// </summary>
        /// <param name="radius">Значение радиуса double</param>
        /// <returns>true - круг; исключение - при отрицательном радиусе</returns>
        /// <exception cref="ArgumentException">Недопустимое значение аргумента</exception>
        public override bool isValid(double[] radius)
        {
            if (radius[0] > 0 && radius[0] <= double.MaxValue) 
            {
                return true;
            } 
            else 
            {
                throw new System.ArgumentException("Radius must be > 0");
            }
        }
    
        /// <summary>
        /// Площадь круга double
        /// </summary>
        public override double Area
        {
            get
            {
                return System.Math.PI * FigureSides[0] * FigureSides[0];
            }
        }

        public override string ToString()
        {
            return $"{Type} Area = {Area:F2} \n";
        }
    }
}
