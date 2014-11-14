using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Security.Cryptography;
using MetroFramework;
namespace SHACheck
{
    public partial class CheckSHA : MetroForm
    {
        public CheckSHA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            SHA1.Text = "";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                String file = openFileDialog1.FileName;
                FileStream stream = File.OpenRead(file);
                metroTextBox1.Text = file;

                using (SHA1Managed sha1 = new SHA1Managed())
                {
                    BufferedStream bs = new BufferedStream(stream);
                    byte[] hash = sha1.ComputeHash(bs);
                    StringBuilder formatted = new StringBuilder(2 * hash.Length);
                    foreach (byte b in hash)
                    {
                        formatted.AppendFormat("{0:X2}", b);
                    }
                    SHA1.Text = formatted.ToString();
                    SHA1.Visible = true;
                    
                    if (!(SHAtoCheck.Text == "" || SHAtoCheck == null || SHAtoCheck.Text == "Input SHA1"))
                    {
                        //MetroMessageBox.Show(this, "Enter a SHA1 to check against", "ALERT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                        String checkagainst = SHAtoCheck.Text;
                        if (formatted.ToString().Equals(checkagainst, StringComparison.InvariantCultureIgnoreCase))
                        {
                            MetroMessageBox.Show(this, "The SHA1 checks out ok", "Checked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "The SHA1 doesn't match!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            
                        }
                    }
                }
                
            }

        }

    }
}
