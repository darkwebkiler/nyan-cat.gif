using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neOlduguBilinmeyenReiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 1;
            Random rnd = new Random();
            int kirmizi = rnd.Next(256);
            int mavi = rnd.Next(256);
            int yesil = rnd.Next(256);
            this.BackColor = Color.FromArgb(kirmizi, yesil, mavi);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                 this.Close();
                }
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
