using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Enums;
using System.Windows.Forms;

namespace Programming.View.Control
{
    /// <summary>
    /// Представляет реализацию по выбору времени года
    /// </summary>
    public partial class Season_HandleConrol : UserControl
    {
        /// <summary>
        /// Представляет реализацию по измененнию фона по времени года
        /// </summary>
        public Season_HandleConrol()
        {
            InitializeComponent();

            var values = Enum.GetValues(typeof(Season));

            foreach (var value in values)
            {
                SeasonNamesComboBox.Items.Add(value.ToString());
            }
            SeasonNamesComboBox.SelectedIndex = 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonNamesComboBox.SelectedItem)
            {
                case Season.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
    }
}
