namespace AlarmApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveButton = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.AntiqueWhite;
            saveButton.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(256, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(114, 29);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AntiqueWhite;
            button2.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Info;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.GrayText;
            dateTimePicker1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(45, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(279, 77);
            dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            button1.Location = new Point(77, 188);
            button1.Name = "button1";
            button1.Size = new Size(206, 29);
            button1.TabIndex = 3;
            button1.Text = "Повтор";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.AntiqueWhite;
            button3.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            button3.Location = new Point(77, 223);
            button3.Name = "button3";
            button3.Size = new Size(206, 29);
            button3.TabIndex = 4;
            button3.Text = "Название";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.AntiqueWhite;
            button4.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            button4.Location = new Point(78, 258);
            button4.Name = "button4";
            button4.Size = new Size(206, 51);
            button4.TabIndex = 5;
            button4.Text = "Повторение сигнала(да/нет)";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(382, 353);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(saveButton);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button saveButton;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}