using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLib
{
    public class Circle : Figure
    {
        public double radius;
        /// <summary>
        /// Устанавливает значение параметра радиуса окружности и типа фигуры, 
        /// также проверяет положительное занчение аргумента
        /// </summary>
        /// <param name="inp_radius"></param>
        private void Setter(double inp_radius)
        {
            if (inp_radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius must be positive");
            }
            this.shape = Shapes.Circle;
            this.radius = inp_radius;
            
        }

        public Circle(double inp_r) { Setter(inp_r); }
        public Circle(float inp_r) { Setter(inp_r); }
        public Circle(int inp_r) { Setter(inp_r); }
        
        public override double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }
    }
}
