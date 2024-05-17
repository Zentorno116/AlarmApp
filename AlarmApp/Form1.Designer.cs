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
            checkBox1 = new CheckBox();
            label2 = new Label();
            descriptionBox1 = new TextBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            alarmBox1.SuspendLayout();
            SuspendLayout();
            // 
            // alarmBox1
            // 
            alarmBox1.BackColor = Color.SeaShell;
            alarmBox1.BorderStyle = BorderStyle.FixedSingle;
            alarmBox1.Controls.Add(checkBox1);
            alarmBox1.Controls.Add(label2);
            alarmBox1.Controls.Add(descriptionBox1);
            alarmBox1.Location = new Point(48, 52);
            alarmBox1.Name = "alarmBox1";
            alarmBox1.Size = new Size(704, 119);
            alarmBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.BackColor = Color.SeaShell;
            checkBox1.Font = new Font("Segoe UI", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            checkBox1.Image = Properties.Resources.knopka_vklyucheniya_ruhcxbllsa4e_64__1_;
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
            label2.Font = new Font("Algerian", 28.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(16, 31);
            label2.Name = "label2";
            label2.Size = new Size(124, 53);
            label2.TabIndex = 3;
            label2.Text = "7:00";
            // 
            // descriptionBox1
            // 
            descriptionBox1.BackColor = Color.LightGoldenrodYellow;
            descriptionBox1.BorderStyle = BorderStyle.None;
            descriptionBox1.Cursor = Cursors.IBeam;
            descriptionBox1.Font = new Font("Complex", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            descriptionBox1.Location = new Point(146, 18);
            descriptionBox1.Multiline = true;
            descriptionBox1.Name = "descriptionBox1";
            descriptionBox1.Size = new Size(440, 83);
            descriptionBox1.TabIndex = 2;
            descriptionBox1.Text = "амас";
            descriptionBox1.TextChanged += descriptionBox1_TextChanged;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(alarmBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Будильник";
            Load += Form1_Load;
            alarmBox1.ResumeLayout(false);
            alarmBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel alarmBox1;
        private TextBox descriptionBox1;
        private Label label2;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox checkBox1;
    }
}
