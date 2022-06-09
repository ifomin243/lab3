using System;

namespace Model
{
    public class RegularTriangularPyramid : ThreeDimensionalShape
    {
        private double h;
        private double a;

        /// <summary>
        /// Высота
        /// </summary>
        public double Side
        {
            get
            {
                return h;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение высоты пирамиды не может быть отрицательным или равным нулю");

                h = value;
            }
        }

        /// <summary>
        /// Длина основания
        /// </summary>
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение длины стороны основания пирамиды не может быть отрицательным или равным нулю");

                a = value;
            }
        }

        public RegularTriangularPyramid() { }
        public RegularTriangularPyramid(double h, double a)
        {
            Side = h;
            A = a;
        }
        public RegularTriangularPyramid(string h, string a)
        {
            Side = InputValidation(h);
            A = InputValidation(a);
        }
        public override double GetVolume()
        {
            return Math.Round(Side * (A * A) / (4 * Math.Sqrt(3)), 2);
        }
    }
}
