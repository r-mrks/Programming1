namespace Programming.Model
{
    using System;
    /// <summary>
    /// Хранит информацию о фильмах
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Год релиза фильма
        /// </summary>
        private int _releaseYear;
        /// <summary>
        /// Рейтинг фильма
        /// </summary>
        private double _rating;
        /// <summary>
        /// Длительность фильма в минутах
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>
        /// </summary>
        public Movie()
        {
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>
        /// </summary>
        /// <param name="releaseYear">Год релиза фильма. От 1900 по нынешний год</param>
        /// <param name="durationMinutes">Длительность фильма в минутах </param>
        /// <param name="rating">Рейтинг фильма От 0 до 10</param>
        /// <param name="name"> название фильма</param>
        /// <param name="genre">Жанр фильма</param>
        public Movie(int releaseYear,
            int durationMinutes,
            int rating,
            string name,
            string genre
        )
        {
            ReleaseYear = releaseYear;
            DurationMinutes = durationMinutes;
            Rating = rating;
            Name = name;
            Genre = genre;
        }
        /// <summary>
        /// Возвращает и задает название фильма
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращает и задает жанр фильма
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает длительность фильма в минутах
        /// </summary>
        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationMinutes), value);
                _durationMinutes = value;
            }
        }
        /// <summary>
        /// Возвращает и задает год релиза фильма От 1900 по нынешний год
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1900, DateTime.Now.Year);
                _releaseYear = value;
            }
        }
        /// <summary>
        /// Возвращает и задает рейтинг фильма От 0 до 10
        /// </summary>

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0, 10);
                _rating = value;
            }
        }
    }
}