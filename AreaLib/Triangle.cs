using System;
using System.Collections.Generic;

namespace AreaLib
{
    public class Triangle : Figure
    {
        public double a;
        public double b;
        public double c;
        /// <summary>
        /// Проверка треугольника на неравенство треугольника и отрицательные стороны
        /// </summary>
        /// <param name="inp_a">Сторона а</param>
        /// <param name="inp_b">Сторона b</param>
        /// <param name="inp_c">Сторона с</param>
        /// <returns>True - если треугольник корректный, иначе - False </returns>
        private bool Triangle_check(double inp_a, double inp_b, double inp_c)
        {
            //Check negative sides
            if (inp_a <= 0 || inp_b <= 0 || inp_c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides must be positive");
            }

            // Check Triangle inequality
            if (
                inp_a + inp_b <= inp_c ||
                inp_a + inp_c <= inp_b ||
                inp_c + inp_b <= inp_a
                )
            {
                throw new Exception("This triangle doesn't exist");
            }
            return true;
        }

        /// <summary>
        /// Ввод полей размера сторон треугольника и поля типа фигуры
        /// </summary>
        /// <param name="inp_a">Сторона а</param>
        /// <param name="inp_b">Сторона b</param>
        /// <param name="inp_c">Сторона с</param>
        private void Triangle_setter(double inp_a, double inp_b, double inp_c)
        {
            this.shape = Shapes.Triangle;
            this.a = inp_a;
            this.b = inp_b;
            this.c = inp_c;
        }

        public Triangle(double inp_a, double inp_b, double inp_c)
        {
            
            if (Triangle_check(inp_a, inp_b, inp_c)){
                Triangle_setter(inp_a, inp_b, inp_c);
            }
            
        }
        
        public override double Area
        {
            get
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        /// <summary>
        /// Возвращает True, если треугольник прямоугольный. Иначе возвращает False
        /// </summary>
        public bool IsRectangle
        {
            get
            {
                bool result = a * a + c * c == b * b ||
                    a * a + b * b == c * c||
                    c * c + b * b == a * a;
                return result;
            }

        }
    }
    
}
