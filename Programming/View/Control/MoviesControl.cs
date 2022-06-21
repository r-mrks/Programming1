using System;
using Programming.Model.Enums;
using Programming.Model;
using Colors = Programming.Model.AppColors;
using System.Windows.Forms;

namespace Programming.View.Control
{
    /// <summary>
    /// Представляет реализацию по представлению  фильмов
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Количество фильмов
        /// </summary>
        private const int ElementsCount = 5;
        /// <summary>
        /// Коллекция фильмов
        /// </summary>
        private Movie[] _movies;
        /// <summary>
        /// Выбранный фильм
        /// </summary>
        private Movie _currentMovie;
        /// <summary>
        /// Поле, которое предоставляет генерацию случайных чисел
        /// </summary>

        private Random _random = new Random();
        /// <summary>
        /// Сообщенает об ошибке
        /// </summary>
        ToolTip _toolTip= new ToolTip();

        public MoviesControl()
        {
            InitializeComponent();
            CreateMovies();
        }
        /// <summary>
        /// Создает коллекцию фильмов <see cref="CreateMovies"/>
        /// </summary>
        private void CreateMovies()
        {
            _movies = new Movie[ElementsCount];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _random.Next(1900, DateTime.Now.Year);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.DurationMinutes = _random.Next(151);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }

            MovieListBox.SelectedIndex = 0;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            NameMovieTextBox.Text = _currentMovie.Name;
            GenreMovieTextBox.Text = _currentMovie.Genre;
            YearReleaseMovieTextBox.Text = _currentMovie.ReleaseYear.ToString();
            DurationMinutesMovieTextBox.Text = _currentMovie.DurationMinutes.ToString();
            RatingMovieTextBox.Text = _currentMovie.Rating.ToString();
        }
       
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }
        /// <summary>
        /// Находит фильм, чей рейтинг больше остальных
        /// </summary>
        /// <param name="Movies"> Коллекция фильмов</param>
        /// <returns> Возвращает индекс элемента, чей рейтинг больше остальных</returns>
        private int FindMovieWithMaxRating(Movie[] Movies)
        {
            int maxRatingIndex = 0;
            double maxValue = Movies[0].Rating;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (Movies[i].Rating > maxValue)
                {
                    maxValue = Movies[i].Rating;
                    maxRatingIndex = i;
                }
            }

            return maxRatingIndex;
        }

        private void YearReleaseMovieTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string currentYearRelease = YearReleaseMovieTextBox.Text;
                int yearReleaseMovieValue = int.Parse(currentYearRelease);
                _currentMovie.ReleaseYear = yearReleaseMovieValue;
            }
            catch  (Exception ex)
            {
                _toolTip.SetToolTip(YearReleaseMovieTextBox, ex.Message);
                YearReleaseMovieTextBox.BackColor = Colors.ErrorColor;
                return;
            }

            YearReleaseMovieTextBox.BackColor = Colors.CorrectColor;
        }

        private void DurationMinutesMovieTextBox_TextChanged_1(object sender, EventArgs e)
        {
            
            try
            {
                string currentDurationMinutes = DurationMinutesMovieTextBox.Text;
                int durationMinutesMovieValue = int.Parse(currentDurationMinutes);
                _currentMovie.DurationMinutes = durationMinutesMovieValue;
            }
            catch (Exception ex)
            {
                _toolTip.SetToolTip(DurationMinutesMovieTextBox, ex.Message);
                DurationMinutesMovieTextBox.BackColor = Colors.ErrorColor;
                return;
            }

            DurationMinutesMovieTextBox.BackColor = Colors.CorrectColor;

        }

        private void RatingMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = RatingMovieTextBox.Text;
                double ratingMovieValue = double.Parse(currentRating);
                _currentMovie.Rating = ratingMovieValue;
            }
            catch (Exception ex)
            {
                _toolTip.SetToolTip(RatingMovieTextBox, ex.Message);
                RatingMovieTextBox.BackColor = Colors.ErrorColor;
                return;
            }
            RatingMovieTextBox.BackColor = Colors.CorrectColor;

        }

        private void GenreMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreMovieValue = GenreMovieTextBox.Text;
            _currentMovie.Genre = genreMovieValue;
        }

        private void NameMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            
            
            string nameMovieValue = NameMovieTextBox.Text;
            _currentMovie.Name = nameMovieValue;
        }
    }
}
