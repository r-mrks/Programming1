using System;
using System.Collections.Generic;
using Programming.Model.Geometryy;
using System.Drawing;
using System.Windows.Forms;
using Colors = Programming.Model.AppColors;
using Rectangle = Programming.Model.Geometryy.Rectangle;

namespace Programming.View.Control
{
    /// <summary>
    /// Реализация прямоугольников
    /// </summary>
    public partial class RectangleCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников
        /// </summary>
        private List<Rectangle> _rectangle = new List<Rectangle>();
        /// <summary>
        /// Выбранный прямоугольник
        /// </summary>
        private Rectangle _currentrectangle;
        /// <summary>
        /// Коллекция отображаемых панелей
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Создает экземпляр класса <see cref="RectangleCollisionControl"/>
        /// </summary>
        public RectangleCollisionControl()
        {
            InitializeComponent();
        }

        private void AddRectangleButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveRectangleButton_MouseMove(object sender, MouseEventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }
        /// <summary>
        /// Обновляет информацию в списке
        /// </summary>
        /// <param name="rectangle"> Прямоугольник которому нужно обновить информацию</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = AddingRectaglesListBox.FindString(rectangle.Id.ToString());
            AddingRectaglesListBox.Items[index] = rectangle.GetRectangleInfo();
        }
        /// <summary>
        /// Находит пересечение прямоугольников 
        /// При пересечений красит в красный
        /// </summary>
        private void FindCollisions()
        {

            for (int n = 0; n < _rectangle.Count; n++)
            {
                CanvaPanel.Controls[n].BackColor = Colors.IsNotCollision;
            }

            for (int i = 0; i < _rectangle.Count; i++)
            {
                for (int j = i + 1; j < _rectangle.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangle[j], _rectangle[i]))
                    {
                        CanvaPanel.Controls[i].BackColor = Colors.IsCollision;
                        CanvaPanel.Controls[j].BackColor = Colors.IsCollision;
                    }
                }
            }
        }


        private void AddRectangleButton_Click(object sender, EventArgs e)
        {

            var newRectangle = RectangleFactory.Randomize(CanvaPanel.Width, CanvaPanel.Height);
            _rectangle.Add(newRectangle);

            Panel rectanglePanel = new Panel
            {
                Width = newRectangle.Width,
                Height = newRectangle.Height,
                Location = new Point(newRectangle.Center.X, newRectangle.Center.Y),
                BackColor = Colors.IsNotCollision,
                BorderStyle = BorderStyle.FixedSingle
            };

            _rectanglePanels.Add(rectanglePanel);
            CanvaPanel.Controls.Add(rectanglePanel);
            

            UpdateListBoexs();
        }

        private void AddingRectaglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddingRectaglesListBox.SelectedIndex == -1) return;

            int rectangleIndex = AddingRectaglesListBox.SelectedIndex;
            _currentrectangle = _rectangle[rectangleIndex];
            HeightTextBox.Text = _currentrectangle.Height.ToString();
            WidthTextBox.Text = _currentrectangle.Width.ToString();
            XTextBox.Text = _currentrectangle.Center.X.ToString();
            YTextBox.Text = _currentrectangle.Center.Y.ToString();
            IdTextBox.Text = _currentrectangle.Id.ToString();

        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (_rectanglePanels.Count > 0)
            {
                var selectedindex = AddingRectaglesListBox.SelectedIndex;
                _rectanglePanels.RemoveAt(selectedindex);
                _rectangle.RemoveAt(selectedindex);
                CanvaPanel.Controls.RemoveAt(selectedindex);
                UpdateListBoexs();
                FindCollisions();

            }
            else
            {
                Clearinfo();
            }
        }
        /// <summary>
        /// Обновляет информацию в списке
        /// </summary>
        private void UpdateListBoexs()
        {
            AddingRectaglesListBox.Items.Clear();

            for (int i = 0; i < _rectangle.Count; i++)
            {
                AddingRectaglesListBox.Items.Add(_rectangle[i].GetRectangleInfo());
            }

            AddingRectaglesListBox.SelectedIndex = _rectangle.Count - 1;
        }
        private void Clearinfo()
        {
            IdTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            WidthTextBox.Clear();
            HeightTextBox.Clear();
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectaglesListBox.SelectedIndex == -1) return;

            try
            {
                if (AddingRectaglesListBox.SelectedIndex >= 0)
                {
                    _currentrectangle.Center.X = int.Parse(XTextBox.Text);
                    XTextBox.BackColor = Colors.CorrectColor;
                    CanvaPanel.Controls[AddingRectaglesListBox.SelectedIndex].Location = new Point(_currentrectangle.Center.X, _currentrectangle.Center.Y);
                    FindCollisions();
                    UpdateRectangleInfo(_currentrectangle);
                }
            }
            catch
            {
                XTextBox.BackColor = Colors.ErrorColor;
            }

        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectaglesListBox.SelectedIndex == -1) return;

            try
            {
                if (AddingRectaglesListBox.SelectedIndex >= 0)
                {
                    _currentrectangle.Center.Y = int.Parse(YTextBox.Text);
                    YTextBox.BackColor = Colors.CorrectColor;
                    CanvaPanel.Controls[AddingRectaglesListBox.SelectedIndex].Location = new Point(_currentrectangle.Center.X, _currentrectangle.Center.Y);
                    FindCollisions();
                    UpdateRectangleInfo(_currentrectangle);
                }
            }
            catch
            {
                YTextBox.BackColor = Colors.ErrorColor;
            }

        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {

            if (AddingRectaglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentrectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = Colors.CorrectColor;
                CanvaPanel.Controls[AddingRectaglesListBox.SelectedIndex].Width = _currentrectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentrectangle);
            }
            catch
            {
                WidthTextBox.BackColor = Colors.ErrorColor;
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddingRectaglesListBox.SelectedIndex == -1) return;

            try
            {
                _currentrectangle.Height = int.Parse(HeightTextBox.Text);
                HeightTextBox.BackColor = Colors.CorrectColor;
                CanvaPanel.Controls[AddingRectaglesListBox.SelectedIndex].Height = _currentrectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentrectangle);
            }
            catch
            {
                HeightTextBox.BackColor = Colors.ErrorColor;
            }

        }
    }
}
