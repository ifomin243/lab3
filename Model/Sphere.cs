using System;

namespace Model
{
    public class Sphere : ThreeDimensionalShape
    {
        private double r;

        /// <summary>
        /// Радиус
        /// </summary>
        public double Side
        {
            get
            {
                return r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение радиуса не может быть отрицательным или равным нулю");

                r = value;
            }
        }
        // конструктор класса Parallelepiped по умолчанию
        public Sphere() { }
        // конструктор класса Parallelepiped с параметрами вариант 1
        public Sphere(double r)
        {
            Side = r;
        }
        // конструктор класса Parallelepiped с параметрами вариант 2
        public Sphere(string r)
        {
            Side = InputValidation(r);
        }
        // функция подсчета объёма
        public override double GetVolume()
        {
            return Math.Round(4 / 3.0 * (Math.PI * (Side * Side * Side)), 2);
        }
    }
}
