using Microsoft.Win32;
using System;
using System.Security.Principal;
using System.Windows.Forms;
using Rentex.Properties;

namespace Rentex
{
    public partial class Form2 : Form
    {
        private string password;

        public Form2(string password)
        {
            InitializeComponent();
            this.password = password;
        }

        public bool IsAdmin()
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Запустите приложение с правами администратора", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                //MessageBox.Show("Приложение запущено с правами администратора", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    tskmgr.Lock();
                    taskbar.Lock();
                    rightclick.Lock();
                    rebooting.Lock();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password == textBox1.Text)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ваш существующий код обработки изменений текста в textBox1
        }
    }
}
