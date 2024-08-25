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

        private void buttonReset_Click(object sender, EventArgs e)
        {

            textBoxNMW.Text = "";
            textBoxNAMW.Text = "";
            textBoxMahar.Text = "";
            textBoxTMahar.Text = "";
            textBoxOutput.Text = "";
            this.Refresh();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNMW.Text) || string.IsNullOrWhiteSpace(textBoxNAMW.Text) || string.IsNullOrWhiteSpace(textBoxMahar.Text) || string.IsNullOrWhiteSpace(textBoxTMahar.Text))
            {
                MessageBox.Show("Field tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Hentikan eksekusi lebih lanjut
            }

            textBoxOutput.Text = "Saya terima nikahnya, " + textBoxNMW.Text +
                " Binti " + textBoxNAMW.Text + " Dengan Mas Kawin, " + textBoxMahar.Text
                + " Senilai/Sejumlah " + textBoxTMahar.Text +
                " Dibayar tunai/utang. ";
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxOutput.Text))
            {
                Clipboard.SetText(textBoxOutput.Text);
                MessageBox.Show("Teks berhasil disalin!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("TextBox kosong, tidak ada yang disalin.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
