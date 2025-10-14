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
    public partial class CaptchForm : Form
    {
        public CaptchForm()
        {
            InitializeComponent();
        }
        private string Captch;
        private void timer1_Tick(object sender, EventArgs e)
        {
            CreateCaptch();
        }

        private void textBoxCaptch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCaptch.Text == Captch)
                Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CreateCaptch();
        }

        private void labelCaptch_Click(object sender, EventArgs e)
        {
            CreateCaptch();
        }
        private void CreateCaptch()
        {
            timer1.Stop();
            string combination = "123456789АБВГДЕЁЖЗИЙКЛМН" + "ОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнорпстуфхцшщъыьэюя";
            Captch = null;
            Random r = new Random();
            for (int i = 0; i < 5; i++)
                Captch += combination[r.Next(combination.Length)];
            labelCaptch.Text = Captch;
            timer1.Start();
}
    }
}
