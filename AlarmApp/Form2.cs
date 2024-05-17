using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AlarmApp
{
    public partial class Form2 : Form
    {
        List<Panel> panelList;
        Button plusButton;
        Form1 parent;
        public Form2(Form1 form, List<Panel> panels, Button button1)
        {
            InitializeComponent();
            parent = form;
            panelList = panels;
            plusButton = button1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < parent.panels.Count; i++)
            {
                Panel panel = parent.panels[i];
                if (i > 4)
                {
                    MessageBox.Show("Форма может содержать не более 5 будильников!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (!panel.Visible)
                {
                    panel.Visible = true;
                    var controls = panel.Controls.Cast<Control>();
                    string str = dateTimePicker1.Value.ToString();
                    string[] time_parts = str.Split(' ')[1].Split(':');
                    foreach (Control control in controls)
                    {
                        if (control is Label)
                        {
                            if (((Label)control).Font.Size == 24)
                            {
                                ((Label)control).Text = time_parts[0] + ":" + time_parts[1];
                            }
                            else
                            {
                                ((Label)control).Text = str.Split(' ')[0];
                            }
                        }
                    }
                    using (StreamWriter writer = new StreamWriter("../../../Resources/Data.txt", true))
                    {
                        writer.WriteLine(time_parts[0] + ":" + time_parts[1]);
                        writer.WriteLine(str.Split(' ')[0]);
                        writer.WriteLine();
                        writer.WriteLine("checked");
                        writer.WriteLine("next");
                    }
                    panel.Location = new Point(parent.panels[i - 1].Location.X, parent.panels[i - 1].Location.Y + parent.panels[i - 1].Size.Height + 10);
                    plusButton.Location = new Point(plusButton.Location.X, plusButton.Location.Y + parent.panels[i - 1].Size.Height + 10);
                    parent.panels[i] = panel;
                    break;
                }
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
