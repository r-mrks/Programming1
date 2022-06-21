namespace Programming.Model.Geometryy
{
    /// <summary>
    /// Хранит данные о прямоугольниках
    /// </summary>

    public class Rectangle
    {
        /// <summary>
        /// Общее количество прямоугольников
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Высота прямоугольника
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина прямоугольника
        /// </summary>
        private int _width;

        /// <summary>
        /// Индефикатор данного класса
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>
        /// </summary>
        /// <param name="height"> Высота прямоугольника</param>
        /// <param name="width">Ширина Прямоугольника</param>
        /// <param name="color">Цвет прямоугольника</param>
        /// <param name="center"> Координаты прямоугольника</param>
        public Rectangle(int height,
            int width,
            string color,
            Point2D center)
        {
            Height=height;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = AllRectanglesCount;
        }
        /// <summary>
        /// Возвращает и задает координаты прямоугольника
        /// </summary>
        public Point2D Center { get; set; }
        /// <summary>
        /// Возвращает и задает цвет прямоугольника
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Возвращает индефикатор прямоугольника
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }
        /// <summary>
        /// Предоставляет информацию о прямоугольника
        /// </summary>
        /// <returns>Выводит id X Y W H</returns>
        public string GetRectangleInfo()
        {
            return $"{_id}: (X={Center.X}; Y={Center.Y}; W={_width}; H={_height})";
        }

        /// <summary>
        /// Возвращает общее количество прямоугольников
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Положителное число
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Height), value);
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает шиирну прямоугольника. Положительное число
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }
    }
}