namespace Programming.Model
{
    using System;
    /// <summary>
    /// Хранит информацию о полете
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полета в минутах
        /// </summary>
        private int _flightTimeMinutes;
        /// <summary>
        /// Созадет экземпляр класса <see cref="Flight"/>
        /// </summary>
        public Flight()
        {
        }
        /// <summary>
        /// Созадет экземпляр класса <see cref="Flight"/>
        /// </summary>
        /// <param name="departure">Место отправление</param>
        /// <param name="destination">Место назначения</param>
        /// <param name="flightTimeMinutes"> Длительность полета в минутах</param>
        public Flight(string departure,
            string destination,
            int flightTimeMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }
        /// <summary>
        /// Возвращает и задает место отправление
        /// </summary>
        public string Departure { get; set; }
        /// <summary>
        /// Возвращает и задает место назначения
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает длительнсоть полета в минутах
        /// </summary>
        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "the FlightTImeMinutes field must be greater than 0");
                }

                _flightTimeMinutes = value;
            }
        }
    }
}