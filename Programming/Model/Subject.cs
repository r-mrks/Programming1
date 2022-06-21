namespace Programming.Model
{
    using System;
    /// <summary>
    /// Хранит информацию о дисциплине
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка по дисциплине 
        /// </summary>
        private int _mark;
        /// <summary>
        /// Созадет экземпляр класса <see cref="Subject"/>
        /// </summary>
        public Subject()
        {
        }
        /// <summary>
        /// Созадет экземпляр класса <see cref="Subject"/>
        /// </summary>
        /// <param name="name">Имя ученика</param>
        /// <param name="mark">Оценка по дисциплине</param>
        public Subject(string name,
            int mark)
        {
            Name = name;
            Mark = mark;
        }
        /// <summary>
        /// Возвращает и задает имя ученика
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// возвращает и задает оценку по дисциплине
        /// </summary>
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException(
                        "the value of the Mark field should be between 1 (unsatisfactory) and 5 (excellent)");
                }

                _mark = value;
            }
        }
    }
}