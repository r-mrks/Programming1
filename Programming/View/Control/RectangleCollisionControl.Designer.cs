namespace Programming.View.Control
{
    partial class RectangleCollisionControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectangleCollisionControl));
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Rectagleslabel = new System.Windows.Forms.Label();
            this.AddingRectaglesListBox = new System.Windows.Forms.ListBox();
            this.CanvaPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.ForeColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(173, 121);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(47, 30);
            this.RemoveRectangleButton.TabIndex = 43;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            this.RemoveRectangleButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoveRectangleButton_MouseMove);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.ForeColor = System.Drawing.Color.White;
            this.AddRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(29, 121);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(51, 30);
            this.AddRectangleButton.TabIndex = 42;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            this.AddRectangleButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddRectangleButton_MouseMove);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(55, 277);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(87, 20);
            this.HeightTextBox.TabIndex = 41;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 277);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Height:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(55, 254);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(87, 20);
            this.WidthTextBox.TabIndex = 39;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 254);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Width:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(55, 232);
            this.YTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(87, 20);
            this.YTextBox.TabIndex = 37;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 232);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Y:";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(55, 209);
            this.XTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(87, 20);
            this.XTextBox.TabIndex = 35;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 209);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "X:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(55, 186);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(87, 20);
            this.IdTextBox.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Selected Rectangle:";
            // 
            // Rectagleslabel
            // 
            this.Rectagleslabel.AutoSize = true;
            this.Rectagleslabel.Location = new System.Drawing.Point(5, 4);
            this.Rectagleslabel.Name = "Rectagleslabel";
            this.Rectagleslabel.Size = new System.Drawing.Size(58, 13);
            this.Rectagleslabel.TabIndex = 30;
            this.Rectagleslabel.Text = "Rectagles:";
            // 
            // AddingRectaglesListBox
            // 
            this.AddingRectaglesListBox.FormattingEnabled = true;
            this.AddingRectaglesListBox.Location = new System.Drawing.Point(3, 20);
            this.AddingRectaglesListBox.Name = "AddingRectaglesListBox";
            this.AddingRectaglesListBox.Size = new System.Drawing.Size(265, 95);
            this.AddingRectaglesListBox.TabIndex = 29;
            this.AddingRectaglesListBox.SelectedIndexChanged += new System.EventHandler(this.AddingRectaglesListBox_SelectedIndexChanged);
            // 
            // CanvaPanel
            // 
            this.CanvaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvaPanel.Location = new System.Drawing.Point(274, 22);
            this.CanvaPanel.Name = "CanvaPanel";
            this.CanvaPanel.Size = new System.Drawing.Size(360, 275);
            this.CanvaPanel.TabIndex = 28;
            // 
            // RectangleCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Rectagleslabel);
            this.Controls.Add(this.AddingRectaglesListBox);
            this.Controls.Add(this.CanvaPanel);
            this.Name = "RectangleCollisionControl";
            this.Size = new System.Drawing.Size(655, 319);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Rectagleslabel;
        private System.Windows.Forms.ListBox AddingRectaglesListBox;
        private System.Windows.Forms.Panel CanvaPanel;
    }
}
