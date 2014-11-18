using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Security;
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
            sha256.Text = "";
            SHAtoCheck.Text = "Input SHA value";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                String file = openFileDialog1.FileName; //get filepath
                FileStream stream256 = File.OpenRead(file); //open file for read only
                metroTextBox1.Text = file;
                String SHA256 = computeSHA256(stream256);
                stream256.Close(); //otherwise the data will be written twice to the stream
                
                FileStream stream = File.OpenRead(file);
                String SHA = computeSHA(stream);
                stream.Close();
                
                SHA1.Text = SHA;
                sha256.Text = SHA256;
                SHA1.Visible = true;
                sha256.Visible = true;
            }

        }

        private void check_Click(object sender, EventArgs e)
        {
            //making sure the check box has some validation
            if (SHAtoCheck.Text == "" || SHAtoCheck.Text == null || SHAtoCheck.Text == "Input SHA value"
                || SHA1.Text == "" || sha256.Text == "" || SHA1.Text == "PLACE HOLDER" || sha256.Text == "PLACE HOLDER")
            {
                MetroMessageBox.Show(this, "Enter a SHA to check against", "Check is Empty of invalid", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                String computedSHA = SHA1.Text;
                String computedSHA256 = sha256.Text;
                String checkSHA = SHAtoCheck.Text;
                //does an equalsIgnoreCase
                if (computedSHA.Equals(checkSHA, StringComparison.InvariantCultureIgnoreCase) || computedSHA256.Equals(checkSHA,StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "The SHA's match", "Match", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "The SHA's don't match", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private String computeSHA(FileStream stream)
        {
            SHA1Managed sha1 = new SHA1Managed();
            BufferedStream bs = new BufferedStream(stream);
            byte[] hash = sha1.ComputeHash(bs);
            String hold = BitConverter.ToString(hash).Replace("-", String.Empty);
            sha1.Clear();
            return hold;
        }

        private String computeSHA256(FileStream stream)
        {
            SHA256Managed sha256 = new SHA256Managed();
            BufferedStream bs = new BufferedStream(stream);
            byte[] hash = sha256.ComputeHash(bs);
            String holder = BitConverter.ToString(hash).Replace("-", String.Empty);
            sha256.Clear();
            return holder;
        }
    }
}
