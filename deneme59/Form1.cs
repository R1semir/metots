using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme59
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void metot()
        {
            label1.Text = " 20 ağustos 2022";
            label2.Text = " Tatlı bir gün";
            label3.Text = " Yağmurlu bir sonbahar";
            label4.Text = " Boş bir yaşam";
        }
        void metot2()
        {
            label1.BackColor = Color.White;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Yellow;
            label4.BackColor = Color.Cyan;
        }
        void metot3()
        {
            label1.ForeColor = Color.DarkBlue;
            this.Text = " c# denemeleri 99";
            MessageBox.Show("Ders Bitti");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            metot();
            metot2();
            metot3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metot3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            metot2();
        }
    }
}
