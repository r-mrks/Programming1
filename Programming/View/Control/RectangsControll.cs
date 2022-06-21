using Programming.Model.Geometryy;
using System;
using System.Windows.Forms;
using Colors = Programming.Model.AppColors;
using Rectangle = Programming.Model.Geometryy.Rectangle;
namespace Programming.View.Control
{
    /// <summary>
    /// Представляет реализацию по представлению прямоугольников
    /// </summary>
    public partial class RectangsControll : UserControl
    {
        /// <summary>
        /// Количество Прямоугольников
        /// </summary>
        private const int RectanglesCount = 5;

        /// <summary>
        /// Коллекция прямоугольников
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Выбранный прямоугольник
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Сообщает об ошибке
        /// </summary>
        ToolTip toolTip = new ToolTip();

        public RectangsControll()
        {
            InitializeComponent();
            _rectangles = CreateRectangles();
            RectangleListBox.SelectedIndex = 0;

        }
        /// <summary>
        /// Создает коллекцию прямоугольников 
        /// </summary>
        /// <returns> возвращает коллекцию прямоугольников </returns>
        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[RectanglesCount];
            for (int i = 0; i < RectanglesCount; i++)
            {
                _currentRectangle = RectangleFactory.Randomize();
                rectangles[i] = _currentRectangle;
                RectangleListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            HeightRectangleTextBox.Text = _currentRectangle.Height.ToString();
            WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
            ColorRectangleTextBox.Text = _currentRectangle.Color;
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdRectangleTextBox.Text = _currentRectangle.Id.ToString();

        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = findMaxWidthIndex;

        }

        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {

            if (RectangleListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Height = int.Parse(HeightRectangleTextBox.Text);
                HeightRectangleTextBox.BackColor = Colors.CorrectColor;
            }
            catch (Exception ex)
            {
                toolTip.SetToolTip(HeightRectangleTextBox, ex.Message);
                HeightRectangleTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Width = int.Parse(WidthRectangleTextBox.Text);
                WidthRectangleTextBox.BackColor = Colors.CorrectColor;
            }
            catch (Exception ex)
            {
                toolTip.SetToolTip(WidthRectangleTextBox, ex.Message);
                WidthRectangleTextBox.BackColor = Colors.ErrorColor;
            }
        }
        /// <summary>
        /// Находит прямоугольник, чья ширина больше остальных
        /// </summary>
        /// <param name="rectangles"> Массив прямоугольников </param>
        /// <returns> Возвращает индекс прямоугольника, чья ширина болье других</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = rectangles[0].Width;
            for (int i = 0; i < RectanglesCount; i++)
            {
                if (rectangles[i].Width > maxValue)
                {
                    maxValue = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }

            return maxWidthIndex;
        }
    }
}
