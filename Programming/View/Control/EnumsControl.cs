using System;
using System.Windows.Forms;
using Programming.Model.Enums;


namespace Programming.View.Control
{
    /// <summary>
    /// Предоставляет реализацию по представлению перечислений.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="EnumerationsControl"/>
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();
            foreach (Enums enumsValues in Enum.GetValues(typeof(Enums)))
            {
                EnumListBox.Items.Add(enumsValues);
            }

            EnumListBox.SelectedIndex = 0;
            ValueListBox.SelectedIndex = 0;
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            var item = EnumListBox.SelectedItem;
            var itemType = (Enums)item;
            Array values;

            switch (itemType)
            {
                case Enums.Colors:
                    values = Enum.GetValues(typeof(Colors));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Manufacture:
                    values = Enum.GetValues(typeof(Manufacture));
                    break;
                case Enums.Season:
                    values = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in values)
            {
                ValueListBox.Items.Add(value);
            }

        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValueListBox.SelectedItem;
            IntValueTextBox.Text = ((int)item).ToString();
        }
    }
}
