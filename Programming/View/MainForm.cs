using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Geometryy;
using Programming.View.Control;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;

        private readonly Color ErrorColor = Color.Pink;

        private readonly Color CorrectColor = Color.White;



        private Random _random = new Random();

        public MainForm()
        {
            InitializeComponent();
            Array allEnums = Enum.GetValues(typeof(Enums));
       

            
           
            
        }
  

        private void RectanglesGroupBox_Enter(object sender, EventArgs e)
        {

        }

        
    }
}