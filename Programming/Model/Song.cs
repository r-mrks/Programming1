namespace Programming.Model
{
    using System;
    /// <summary>
    /// Хранит информацию о песне
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Дилтельность песни в секундах
        /// </summary>
        private int _durationSeconds;
        /// <summary>
        /// Созадет экземпляр класса <see cref="Song"/>
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Созадет экземпляр класса <see cref="Song"/>
        /// </summary>
        /// <param name="artist">Имя исполнителя</param>
        /// <param name="name">Название песни</param>
        /// <param name="durationSeconds">Длительность в секундах</param>
        public Song(string artist,
            string name,
            int durationSeconds)
        {
            Artist = artist;
            Name = name;
            DurationSeconds = durationSeconds;
        }
        /// <summary>
        /// Возвращает и задает Имя артиста
        /// </summary>
        public string Artist { get; set; }
        /// <summary>
        /// Возвращает и задает название песни
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращает и задает длительность песни в секундах
        /// </summary>
        public int DurationSeconds
        {
            get
            {
                return _durationSeconds;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "the value of the Duration Seconds field must be greater than zero");
                }

                _durationSeconds = value;
            }
        }
    }
}