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
            if (textBox1.Text.Equals(textBox3.Text))
            {
                MessageBox.Show("Output name should not be same as the input name\nTry changing them", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            String check = Outname.Substring(Math.Max(0, Outname.Length - 4));
            if (check.Equals(".aes"))
            {
                Outname = Outname.Remove(Outname.Length - 4);
            }
            
            textBox3.Text = Outname;
            
            
        }
    }
}
