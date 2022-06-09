using System;

namespace Model
{
    public abstract class ThreeDimensionalShape
    {
       public double Side { get; set; }

       public abstract double GetVolume();
       public double InputValidation(string input)
        {
            if (!double.TryParse(input, out double a))
            {
                throw new ArgumentException("Входная строка имела неверный формат.");
            }
            return a;
        }
    }
}
