namespace Programming.Model
{
    using System;
    /// <summary>
    /// Хранит информацию о контактах человека
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона человека
        /// </summary>
        private string _number;
        /// <summary>
        /// Имя человека
        /// </summary>
        public string _name;

    /// <summary>
    /// фамилия человека
    /// </summary>
        public string _surname;
        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Созадает экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя человека Состоит только из букв латинского алфавита</param>
        /// <param name="surname">Фамилия человека Состоит только из букв латинского алфавита</param>
        /// <param name="number"> Номер человека Состоит только из цифр (макс11)</param>
        public Contact(string name,
            string surname,
            string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
        /// <summary>
        /// Возвращает и задает Имя человека
        /// Состоит только из букв латинского алфавита
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задает Фамилию человека 
        /// Состоит только из букв латинского алфавита
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }
        /// <summary>
        /// Возвращает и задает номер телефона человека
        /// Состоит только из цифр (макс 11)
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (!long.TryParse(value, out long num))
                {
                    throw new ArgumentException(
                        "the value of the Number field must consist of digits only");
                }

                if (value.Length != 11)
                {
                    throw new System.ArgumentException(
                        "the value of the Number field must consist of 11 digits");
                }

                _number = value;
            }

        }

       
    }
}