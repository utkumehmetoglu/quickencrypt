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
    public partial class Decrypt : Form
    {
        private String Filename,Outname;
        public Decrypt(String Filename)
        {
            this.Filename = Filename;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncryptionProvider enc = new EncryptionProvider();
            try
            {
                enc.decrypt_aes(textBox1.Text, textBox3.Text, textBox2.Text);
                MessageBox.Show("Decryption was successful", "Success",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void Decrypt_Load(object sender, EventArgs e)
        {
            textBox1.Text = Filename;
            Outname = Filename;
            Outname.Remove(Outname.Length - 3);
            textBox3.Text = Outname;
        }
    }
}
