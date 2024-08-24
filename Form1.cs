using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IjabKabul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelterima.Text = "Saya terima nikahnya : ";
            labelNM.Text = textBoxNMW.Text + " Binti " + textBoxNAMW.Text;
            labelmaskawin.Text = "Dengan mas kawin : ";
            labelmk.Text = textBoxMahar.Text + " Senilai "+ textBoxTMahar.Text;
            labeldibayar.Text = "Dibayar tunai/utang";
        }
    }
}
