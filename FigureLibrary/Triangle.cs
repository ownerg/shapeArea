using System.Collections;
using System.Linq;
using System;

namespace Figure
{
    public class Triangle : Shape
    {   
        /// <summary>
        /// Свойство прямоугольного треугольника
        /// </summary>
        private bool _rectangular;

        /// <summary>
        /// Значение сторон фигуры
        /// </summary>
        private double[] figureSides;

        /// <summary>
        /// Конструктор Triangle
        /// </summary>
        /// <param name="_sideA">Сторона A double</param>
        /// <param name="_sideB">Сторона B double</param>
        /// <param name="_sideC">Сторона C double</param>
        public Triangle(double _sideA,double _sideB,double _sideC)
        {
            FigureSides = new double[] {_sideA, _sideB, _sideC};
            Type = "Triangle";
        }
        
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public override string Type {get;}
        
        /// <summary>
        /// Стороны фигуры double[]
        /// </summary>
        public override double[] FigureSides
        {
            get { return figureSides; }
            set
            {
                double[] triangleSides = (double[])value.Clone();

                if (triangleSides != figureSides)
                {
                    if (isValid(triangleSides))
                    {
                        figureSides = triangleSides;
                    }
                }
            }
        }

        /// <summary>
        /// Теорема Пифагора
        /// Свойство прямоугольного треугольника bool
        /// </summary>
        private bool checkRect(double[] sides)
        {
            Array.Sort(sides);
            if ( sides[2]*sides[2] == sides[1]*sides[1] + sides[0]*sides[0])
            {
                _rectangular = true;
            }
            else
            {
                _rectangular = false;
            }
            return _rectangular;
        }
        public bool Rectangular
        {
            get
            {
               return checkRect(FigureSides);
            }
        }
        
        /// <summary>
        /// Валидация треугольника. Фигура соответствует треугольнику если (в соответствии с контролем):
        /// - отдельные стороны не равны 0 и не меньше
        /// - наибольшая сторона не больше суммы двух других
        /// </summary>
        /// <param name="sides">Значение радиуса double[]</param>
        /// <returns>true - треугольник; исключение - при несоответствии</returns>
        /// <exception cref="ArgumentException">Один из аргументов принимает недопустимое значение</exception>
        public override bool isValid(double[] sides)
        {
            Array.Sort(sides);
            double sumOfSides = sides.Sum();

            foreach (var side in sides)
            {
                if (side == 0 && sumOfSides == 0) 
                {
                    throw new ArgumentException("Zero sides length");
                }
                else if (side <= 0 && sumOfSides != 0)
                {
                    throw new ArgumentException("One of the side has 0 or negative length");
                }
            }

            if (sides[2] >= sides[1] + sides[0] && sumOfSides != 0)
            {
                throw new ArgumentException("One of the sides too long");
            }

            return true;
        }

        /// <summary>
        /// Площадь треугольника double
        /// </summary>
        public override double Area
        {
            get
            {
                double halfP = (FigureSides.Sum()) / 2;
                return System.Math.Sqrt(halfP * (halfP - FigureSides[0]) * (halfP - FigureSides[1]) * (halfP - FigureSides[2]));
            }
        }

        public override string ToString()
        {
            return $"{Type} Area = {Area:F2} \n" + $"Rectangular = {Rectangular} \n";
        }
    }
}
