namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OutLabel = new System.Windows.Forms.Label();
            this.WeekDayParsing = new System.Windows.Forms.GroupBox();
            this.WeekDayParsing.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(179, 30);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(70, 20);
            this.ParseButton.TabIndex = 5;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParseTextBox.Location = new System.Drawing.Point(6, 31);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(167, 20);
            this.ParseTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type value for parsing:";
            // 
            // OutLabel
            // 
            this.OutLabel.AutoSize = true;
            this.OutLabel.Location = new System.Drawing.Point(4, 63);
            this.OutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutLabel.Name = "OutLabel";
            this.OutLabel.Size = new System.Drawing.Size(0, 13);
            this.OutLabel.TabIndex = 6;
            // 
            // WeekDayParsing
            // 
            this.WeekDayParsing.Controls.Add(this.ParseTextBox);
            this.WeekDayParsing.Controls.Add(this.OutLabel);
            this.WeekDayParsing.Controls.Add(this.label4);
            this.WeekDayParsing.Controls.Add(this.ParseButton);
            this.WeekDayParsing.Location = new System.Drawing.Point(3, 3);
            this.WeekDayParsing.Name = "WeekDayParsing";
            this.WeekDayParsing.Size = new System.Drawing.Size(316, 100);
            this.WeekDayParsing.TabIndex = 7;
            this.WeekDayParsing.TabStop = false;
            this.WeekDayParsing.Text = "WeekDayParsing";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekDayParsing);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(371, 117);
            this.WeekDayParsing.ResumeLayout(false);
            this.WeekDayParsing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label OutLabel;
        private System.Windows.Forms.GroupBox WeekDayParsing;
    }
}
