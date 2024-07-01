using System;
using System.Windows.Forms;

namespace Rentex
{
    public partial class Form1 : Form
    {
        private string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Подтверждено",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            Form2 form2 = new Form2(password);
            form2.Show();
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {
            // Implement if needed
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implement if needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
