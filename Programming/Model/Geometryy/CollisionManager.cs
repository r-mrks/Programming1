using System;

namespace Programming.Model.Geometryy
{
    /// <summary>
    /// Пересечение двух фигур
    /// </summary>
    public class CollisionManager
    {
        /// <summary>
        /// Проверяет пересечение двух прямоугольников
        /// </summary>
        /// <param name="rectangle1"> Первый прямоугольник</param>
        /// <param name="rectangle2"> Второй прямоугольник</param>
        /// <returns> true если пересекаются False если не пересекаются</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X &&
                rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Height &&
                rectangle1.Height + rectangle1.Center.Y > rectangle2.Center.Y;
        }
        /// <summary>
        /// Проверяет пересечение двух колец
        /// </summary>
        /// <param name="ring1"> Первое кольцо</param>
        /// <param name="ring2"> Второе кольцо</param>
        /// <returns> True если пересекаются False если не пересекаются</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double C = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            if (C < (ring1.OuterRadius + ring2.OuterRadius))
            {
                return true;
            }

            return false;
        }
    }
}