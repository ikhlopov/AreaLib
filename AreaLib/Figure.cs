using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLib
{
    public abstract class Figure
    {
        
        public enum Shapes
        {
            Triangle,
            Circle
        }

        protected Shapes shape;
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Shape type as Figure.Shapes enum element</returns>
        public Shapes GetShape() { return this.shape; }

        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        public abstract double Area { get; }
        
    }
}
