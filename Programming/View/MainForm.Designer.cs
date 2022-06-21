namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.EnumerationTabPage = new System.Windows.Forms.TabPage();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.season_HandleConrol1 = new Programming.View.Control.Season_HandleConrol();
            this.enumerationsControl1 = new Programming.View.Control.EnumerationsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.moviesControl1 = new Programming.View.Control.MoviesControl();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.rectangsControll1 = new Programming.View.Control.RectangsControll();
            this.Reactagles = new System.Windows.Forms.TabPage();
            this.rectangleCollisionControl1 = new Programming.View.Control.RectangleCollisionControl();
            this.MainTabControl.SuspendLayout();
            this.EnumerationTabPage.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.Reactagles.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumerationTabPage);
            this.MainTabControl.Controls.Add(this.ClassesTabPage);
            this.MainTabControl.Controls.Add(this.Reactagles);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(734, 401);
            this.MainTabControl.TabIndex = 0;
            // 
            // EnumerationTabPage
            // 
            this.EnumerationTabPage.Controls.Add(this.weekdayParsingControl1);
            this.EnumerationTabPage.Controls.Add(this.season_HandleConrol1);
            this.EnumerationTabPage.Controls.Add(this.enumerationsControl1);
            this.EnumerationTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumerationTabPage.Name = "EnumerationTabPage";
            this.EnumerationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumerationTabPage.Size = new System.Drawing.Size(726, 375);
            this.EnumerationTabPage.TabIndex = 1;
            this.EnumerationTabPage.Text = "Enums";
            this.EnumerationTabPage.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(5, 278);
            this.weekdayParsingControl1.Margin = new System.Windows.Forms.Padding(2);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(321, 89);
            this.weekdayParsingControl1.TabIndex = 2;
            // 
            // season_HandleConrol1
            // 
            this.season_HandleConrol1.Location = new System.Drawing.Point(377, 278);
            this.season_HandleConrol1.Name = "season_HandleConrol1";
            this.season_HandleConrol1.Size = new System.Drawing.Size(343, 89);
            this.season_HandleConrol1.TabIndex = 1;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl1.Location = new System.Drawing.Point(3, 3);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(720, 369);
            this.enumerationsControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(726, 375);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.moviesControl1);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MoviesGroupBox.Location = new System.Drawing.Point(366, 3);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(357, 369);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // moviesControl1
            // 
            this.moviesControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.moviesControl1.Location = new System.Drawing.Point(3, 16);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(273, 350);
            this.moviesControl1.TabIndex = 0;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.rectangsControll1);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(357, 369);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            this.RectanglesGroupBox.Enter += new System.EventHandler(this.RectanglesGroupBox_Enter);
            // 
            // rectangsControll1
            // 
            this.rectangsControll1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rectangsControll1.Location = new System.Drawing.Point(3, 16);
            this.rectangsControll1.Name = "rectangsControll1";
            this.rectangsControll1.Size = new System.Drawing.Size(256, 350);
            this.rectangsControll1.TabIndex = 0;
            // 
            // Reactagles
            // 
            this.Reactagles.Controls.Add(this.rectangleCollisionControl1);
            this.Reactagles.Location = new System.Drawing.Point(4, 22);
            this.Reactagles.Name = "Reactagles";
            this.Reactagles.Padding = new System.Windows.Forms.Padding(3);
            this.Reactagles.Size = new System.Drawing.Size(726, 375);
            this.Reactagles.TabIndex = 3;
            this.Reactagles.Text = "Rectangles";
            this.Reactagles.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionControl1
            // 
            this.rectangleCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectangleCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectangleCollisionControl1.Name = "rectangleCollisionControl1";
            this.rectangleCollisionControl1.Size = new System.Drawing.Size(720, 369);
            this.rectangleCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 401);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.MainTabControl.ResumeLayout(false);
            this.EnumerationTabPage.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.Reactagles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage EnumerationTabPage;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.TabPage Reactagles;
        private Controls.WeekdayParsingControl weekdayParsingControl1;
        private Control.Season_HandleConrol season_HandleConrol1;
        private Control.EnumerationsControl enumerationsControl1;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private Control.RectangsControll rectangsControll1;
        private Control.MoviesControl moviesControl1;
        private Control.RectangleCollisionControl rectangleCollisionControl1;
    }
}

