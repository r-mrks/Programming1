namespace Programming.Model
{
    using System;
    /// <summary>
    /// Хранит информацию о времени
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Количество часов
        /// </summary>
        private int _hours;

        /// <summary>
        /// Количество минут
        /// </summary>
        private int _minutes;
        /// <summary>
        /// Количество секунд
        /// </summary>
        private int _seconds;
        /// <summary>
        /// Созадет экземпляр класса <see cref="Time"/>
        /// </summary>
        public Time()
        {
        }
        /// <summary>
        /// Созадет экземпляр класса <see cref="Time"/>
        /// </summary>
        /// <param name="hours">Количество часов</param>
        /// <param name="minutes">количество минут</param>
        /// <param name="seconds">количество секунди</param>
        public Time(int hours,
            int minutes,
            int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Возвращает и задает количество часов До 23
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (0 > value || value > 23)
                {
                    throw new ArgumentException(
                        "the value of the Hours field must be in the range from 0 to 23");
                }

                _hours = value;
            }
        }
        /// <summary>
        /// Возвращает и задает количество минут До 59
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (0 > value || value > 59)
                {
                    throw new ArgumentOutOfRangeException(
                        "the value of the Minutes field must be in the range from 0 to 59");
                }

                _minutes = value;
            }
        }
        /// <summary>
        /// Возвращает и задает количество секунд До 59
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (0 > value || value > 60)
                {
                    throw new ArgumentOutOfRangeException(
                        "the value of the Seconds field must be in the range from 0 to 60");
                }

                _seconds = value;
            }
        }
    }
}