namespace AlarmApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            alarmBox1 = new Panel();
            label12 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            descriptionBox1 = new TextBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label1 = new Label();
            checkBox2 = new CheckBox();
            label3 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            checkBox3 = new CheckBox();
            label5 = new Label();
            textBox2 = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            checkBox4 = new CheckBox();
            label7 = new Label();
            textBox3 = new TextBox();
            panel4 = new Panel();
            label8 = new Label();
            checkBox5 = new CheckBox();
            label9 = new Label();
            textBox4 = new TextBox();
            panel5 = new Panel();
            label10 = new Label();
            checkBox6 = new CheckBox();
            label11 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            label13 = new Label();
            label14 = new Label();
            alarmBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // alarmBox1
            // 
            alarmBox1.BackColor = Color.SeaShell;
            alarmBox1.BorderStyle = BorderStyle.FixedSingle;
            alarmBox1.Controls.Add(label12);
            alarmBox1.Controls.Add(checkBox1);
            alarmBox1.Controls.Add(label2);
            alarmBox1.Controls.Add(descriptionBox1);
            alarmBox1.Location = new Point(48, 52);
            alarmBox1.Name = "alarmBox1";
            alarmBox1.Size = new Size(704, 119);
            alarmBox1.TabIndex = 0;
            alarmBox1.DoubleClick += edit;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(14, 84);
            label12.Name = "label12";
            label12.Size = new Size(126, 22);
            label12.TabIndex = 5;
            label12.Text = "18.05.2024";
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.BackColor = Color.SeaShell;
            checkBox1.Enabled = false;
            checkBox1.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            checkBox1.Image = Properties.Resources.knopka_pitaniya_kxqfjqnvluox_64__1_;
            checkBox1.Location = new Point(605, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 64);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(14, 22);
            label2.Name = "label2";
            label2.Size = new Size(105, 45);
            label2.TabIndex = 3;
            label2.Text = "7:00";
            // 
            // descriptionBox1
            // 
            descriptionBox1.BackColor = Color.LightGoldenrodYellow;
            descriptionBox1.BorderStyle = BorderStyle.None;
            descriptionBox1.Cursor = Cursors.IBeam;
            descriptionBox1.Enabled = false;
            descriptionBox1.Font = new Font("Complex", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            descriptionBox1.Location = new Point(146, 18);
            descriptionBox1.Multiline = true;
            descriptionBox1.Name = "descriptionBox1";
            descriptionBox1.Size = new Size(440, 83);
            descriptionBox1.TabIndex = 2;
            descriptionBox1.Text = "Описание этого будильника временно недоступно";
            descriptionBox1.TextChanged += descriptionBox1_TextChanged;
            descriptionBox1.KeyDown += save_description;
            descriptionBox1.KeyPress += enterPress;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.Font = new Font("Algerian", 72F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(48, 177);
            button1.Name = "button1";
            button1.Size = new Size(704, 134);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(41, 339);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 119);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(14, 84);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 5;
            label1.Text = "18.05.2024";
            // 
            // checkBox2
            // 
            checkBox2.Appearance = Appearance.Button;
            checkBox2.BackColor = Color.SeaShell;
            checkBox2.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            checkBox2.Image = Properties.Resources.knopka_vklyucheniya_ruhcxbllsa4e_64__1_;
            checkBox2.Location = new Point(605, 22);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 64);
            checkBox2.TabIndex = 4;
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(14, 22);
            label3.Name = "label3";
            label3.Size = new Size(105, 45);
            label3.TabIndex = 3;
            label3.Text = "7:00";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGoldenrodYellow;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Complex", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(146, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 83);
            textBox1.TabIndex = 2;
            textBox1.KeyDown += save_description;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(26, 486);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 119);
            panel2.TabIndex = 6;
            panel2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(14, 84);
            label4.Name = "label4";
            label4.Size = new Size(126, 22);
            label4.TabIndex = 5;
            label4.Text = "18.05.2024";
            // 
            // checkBox3
            // 
            checkBox3.Appearance = Appearance.Button;
            checkBox3.BackColor = Color.SeaShell;
            checkBox3.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            checkBox3.Image = Properties.Resources.knopka_vklyucheniya_ruhcxbllsa4e_64__1_;
            checkBox3.Location = new Point(605, 22);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(64, 64);
            checkBox3.TabIndex = 4;
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(14, 22);
            label5.Name = "label5";
            label5.Size = new Size(105, 45);
            label5.TabIndex = 3;
            label5.Text = "7:00";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGoldenrodYellow;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Complex", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(146, 18);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(440, 83);
            textBox2.TabIndex = 2;
            textBox2.KeyDown += save_description;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(checkBox4);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox3);
            panel3.Location = new Point(826, 476);
            panel3.Name = "panel3";
            panel3.Size = new Size(704, 119);
            panel3.TabIndex = 6;
            panel3.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(14, 84);
            label6.Name = "label6";
            label6.Size = new Size(126, 22);
            label6.TabIndex = 5;
            label6.Text = "18.05.2024";
            // 
            // checkBox4
            // 
            checkBox4.Appearance = Appearance.Button;
            checkBox4.BackColor = Color.SeaShell;
            checkBox4.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            checkBox4.Image = Properties.Resources.knopka_vklyucheniya_ruhcxbllsa4e_64__1_;
            checkBox4.Location = new Point(605, 22);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(64, 64);
            checkBox4.TabIndex = 4;
            checkBox4.UseVisualStyleBackColor = false;
            checkBox4.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(14, 22);
            label7.Name = "label7";
            label7.Size = new Size(105, 45);
            label7.TabIndex = 3;
            label7.Text = "7:00";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGoldenrodYellow;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Complex", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(146, 18);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(440, 83);
            textBox3.TabIndex = 2;
            textBox3.KeyDown += save_description;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaShell;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(checkBox5);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(textBox4);
            panel4.Location = new Point(811, 269);
            panel4.Name = "panel4";
            panel4.Size = new Size(704, 119);
            panel4.TabIndex = 6;
            panel4.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(14, 84);
            label8.Name = "label8";
            label8.Size = new Size(126, 22);
            label8.TabIndex = 5;
            label8.Text = "18.05.2024";
            // 
            // checkBox5
            // 
            checkBox5.Appearance = Appearance.Button;
            checkBox5.BackColor = Color.SeaShell;
            checkBox5.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            checkBox5.Image = Properties.Resources.knopka_vklyucheniya_ruhcxbllsa4e_64__1_;
            checkBox5.Location = new Point(605, 22);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(64, 64);
            checkBox5.TabIndex = 4;
            checkBox5.UseVisualStyleBackColor = false;
            checkBox5.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(14, 22);
            label9.Name = "label9";
            label9.Size = new Size(105, 45);
            label9.TabIndex = 3;
            label9.Text = "7:00";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGoldenrodYellow;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Complex", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(146, 18);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(440, 83);
            textBox4.TabIndex = 2;
            textBox4.KeyDown += save_description;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SeaShell;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label10);
            panel5.Controls.Add(checkBox6);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(textBox5);
            panel5.Location = new Point(811, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(704, 119);
            panel5.TabIndex = 6;
            panel5.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(14, 84);
            label10.Name = "label10";
            label10.Size = new Size(126, 22);
            label10.TabIndex = 5;
            label10.Text = "18.05.2024";
            // 
            // checkBox6
            // 
            checkBox6.Appearance = Appearance.Button;
            checkBox6.BackColor = Color.SeaShell;
            checkBox6.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            checkBox6.Image = Properties.Resources.knopka_vklyucheniya_ruhcxbllsa4e_64__1_;
            checkBox6.Location = new Point(605, 22);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(64, 64);
            checkBox6.TabIndex = 4;
            checkBox6.UseVisualStyleBackColor = false;
            checkBox6.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(14, 22);
            label11.Name = "label11";
            label11.Size = new Size(105, 45);
            label11.TabIndex = 3;
            label11.Text = "7:00";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightGoldenrodYellow;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Font = new Font("Complex", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(146, 18);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(440, 83);
            textBox5.TabIndex = 2;
            textBox5.KeyDown += save_description;
            // 
            // button2
            // 
            button2.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(841, 33);
            button2.Name = "button2";
            button2.Size = new Size(251, 63);
            button2.TabIndex = 7;
            button2.Text = "Очистить всё";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(56, 9);
            label13.Name = "label13";
            label13.Size = new Size(384, 20);
            label13.TabIndex = 8;
            label13.Text = "Прим* Максимальное кол-во будильников равно 5";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label14.ForeColor = SystemColors.ControlDark;
            label14.Location = new Point(56, 29);
            label14.Name = "label14";
            label14.Size = new Size(507, 20);
            label14.TabIndex = 9;
            label14.Text = "Прим** Для подтверждения описания будильника нажмите Enter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1437, 785);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(alarmBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Будильник";
            Load += Form1_Load;
            alarmBox1.ResumeLayout(false);
            alarmBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel alarmBox1;
        private TextBox descriptionBox1;
        private Label label2;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox checkBox1;
        private Label label12;
        private Panel panel1;
        private Label label1;
        private CheckBox checkBox2;
        private Label label3;
        private TextBox textBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label10;
        private CheckBox checkBox6;
        private Label label11;
        private TextBox textBox5;
        private Label label8;
        private CheckBox checkBox5;
        private Label label9;
        private TextBox textBox4;
        private Label label6;
        private CheckBox checkBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label4;
        private CheckBox checkBox3;
        private Label label5;
        private TextBox textBox2;
        private Button button2;
        private Label label13;
        private Label label14;
    }
}
