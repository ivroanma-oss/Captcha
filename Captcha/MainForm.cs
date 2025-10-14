using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (new ModelEF().Users.Any(x => x.Login == loginTextBox.Text && x.Password == passwordTextBox.Text))
            {
                MessageBox.Show("Пользователь найден");
                return;
            }
            MessageBox.Show("Пользователь не найден,пройдите проверку Captcha!");
            new CaptchForm().ShowDialog();
        }
    }
}
