namespace AlarmApp
{
    public partial class Form1 : Form
    {
        List<Panel> panels = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            panels.Add(alarmBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void descriptionBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Image = Properties.Resources.knopka_pitaniya_kxqfjqnvluox_64__1_;
            }
            else
            {
                checkBox1.Image = Properties.Resources.knopka_vklyucheniya_ruhcxbllsa4e_64__1_;
            }
        }

        private void enterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
