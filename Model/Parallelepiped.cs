using System;

namespace Model
{
    public class Parallelepiped : ThreeDimensionalShape
    {
        private double a;
        private double b;
        private double c;

        /// <summary>
        /// Сторона А
        /// </summary>
        public double Side
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение стороны A не может быть отрицательным или равным нулю");

                a = value;
            }
        }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение стороны B не может быть отрицательным или равным нулю");

                b = value;
            }
        }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение стороны C не может быть отрицательным или равным нулю");

                c = value;
            }
        }

        // конструктор класса Parallelepiped по умолчанию
        public Parallelepiped() { }
        // конструктор класса Parallelepiped с параметрами вариант 1
        public Parallelepiped(double a, double b, double c)
        {
            Side = a;
            B = b;
            C = c;
        }
        // конструктор класса Parallelepiped с параметрами вариант 2
        public Parallelepiped(string a, string b, string c)
        {
            Side = InputValidation(a);
            B = InputValidation(b);
            C = InputValidation(c);
        }
        // функция подсчета объёма
        public override double GetVolume()
        {
            return Math.Round(Side * B * C, 2);
        }
    }
}
