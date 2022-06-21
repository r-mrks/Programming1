namespace Programming.Model.Geometryy
{
    /// <summary>
    /// Хранит информацию о координатах фигуры
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата X
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата Y
        /// </summary>
        private int _y;

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y"> Координата Y</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Возвращает и задаёт значение координату X. Значение >= 0.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }

             set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение координату Y. Значение >= 0.
        /// </summary>-

        public int Y
        {
            get
            {
                return _y;
            }
             set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                _y = value;
            }
        }
    }
}