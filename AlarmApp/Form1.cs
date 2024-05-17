using System.IO;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AlarmApp
{
    public partial class Form1 : Form
    {
        public List<Panel> panels = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
            panels.Add(alarmBox1);
            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);
            panels.Add(panel4);
            panels.Add(panel5);
            using (StreamReader reader = new StreamReader("../../../Resources/Data.txt"))
            {
                string line;
                int i = 1;
                int j = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "next")
                    {
                        j = 0;
                        i++;
                    }
                    else
                    {
                        var panel = panels[i];
                        panel.Visible = true;
                        panel.Location = new Point(panels[i - 1].Location.X, panels[i - 1].Location.Y + panels[i - 1].Size.Height + 10);
                        var controls = panel.Controls.Cast<Control>();
                        foreach (Control control in controls)
                        {
                            if (control is Label)
                            {
                                if (((Label)control).Text == "7:00" && j == 0 || ((Label)control).Text != "7:00" && j == 1)
                                {
                                    ((Label)control).Text = line;
                                    break;
                                }
                            }
                            else if (control is TextBox && j == 2)
                            {
                                ((TextBox)control).Text = line.Replace('`', '\n');
                            }
                            else if(control is System.Windows.Forms.CheckBox && j == 3)
                            {
                                ((System.Windows.Forms.CheckBox)control).Checked = line=="checked";
                            }
                        }
                        panels[i] = panel;
                        button1.Location = new Point(panel.Location.X, panel.Location.Y + panel.Size.Height + 10);
                        j++;
                    }
                }
            }
        }

        public static T Clone<T>(T controlToClone) where T : Control
        {
            T instance = Activator.CreateInstance<T>();

            Type control = controlToClone.GetType();
            PropertyInfo[] info = control.GetProperties();
            object p = control.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, controlToClone, null);
            foreach (PropertyInfo pi in info)
            {
                if ((pi.CanWrite) && !(pi.Name == "WindowTarget") && !(pi.Name == "Capture"))
                {
                    pi.SetValue(instance, pi.GetValue(controlToClone, null), null);
                }
            }
            return instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, panels, button1);
            form2.ShowDialog();
        }

        private void descriptionBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = (System.Windows.Forms.CheckBox)sender;
            string[] arrLine = File.ReadAllLines("../../../Resources/Data.txt");
            int number = int.Parse(checkbox.Name[checkbox.Name.Length - 1] + "");
            
            
            if (checkbox.Checked)
            {
                checkbox.Image = Properties.Resources.knopka_pitaniya_kxqfjqnvluox_64__1_;
                arrLine[(number - 2) * 5 + 3] = "checked";
            }
            else
            {
                checkbox.Image = Properties.Resources.knopka_vklyucheniya_ruhcxbllsa4e_64__1_;
                arrLine[(number-2) * 5 + 3] = "not checked";
            }
            try
            {
                File.WriteAllLines("../../../Resources/Data.txt", arrLine);
            } catch { }
        }

        private void enterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void save_description(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (e.KeyData == Keys.Enter)
            {
                string[] arrLine = File.ReadAllLines("../../../Resources/Data.txt");
                int number = int.Parse(tb.Name[tb.Name.Length - 1] + "");
                arrLine[(number - 1) * 5 + 2] = tb.Text.Replace('\n', '`');
                File.WriteAllLines("../../../Resources/Data.txt", arrLine);
            }
        }

        private void edit(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var panel in panels)
            {
                if (panel == alarmBox1)
                {
                    continue;
                }
                panel.Visible = false;
            }
            using (StreamWriter writer = new StreamWriter("../../../Resources/Data.txt", false))
            {
                writer.Write("");
            }
        }
    }
}
