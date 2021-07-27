using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickEncrypt
{
    public partial class Encrypt : Form
    {
        private String Filename, Password;
        EncryptionProvider enc = new EncryptionProvider();
        public Encrypt(String Filename)
        {
            InitializeComponent();
            this.Filename = Filename;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password = textBox2.Text;
            try
            {
                enc.encrypt_aes(Filename, Password);
                MessageBox.Show("Successful", "Encryption Was Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void Encrypt_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.Filename;
            
        }
    }
}
