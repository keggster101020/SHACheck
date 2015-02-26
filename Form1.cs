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
            md5.Text = "";
            SHAtoCheck.Text = "Input SHA/MD5 value";
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

                FileStream streamMD5 = File.OpenRead(file); //file for MD5 check
                String MD5 = computeMD5(streamMD5);
                streamMD5.Close();
                
                SHA1.Text = SHA;
                sha256.Text = SHA256;
                md5.Text = MD5;
                SHA1.Visible = true;
                sha256.Visible = true;
                md5.Visible = true;
            }

        }

        private void check_Click(object sender, EventArgs e)
        {
            //making sure the check box has some validation
            if (SHAtoCheck.Text == "" || SHAtoCheck.Text == null || SHAtoCheck.Text == "Input SHA/MD5 value"
                || SHA1.Text == "" || sha256.Text == "" || SHA1.Text == "PLACE HOLDER" || sha256.Text == "PLACE HOLDER"
                || md5.Text =="" || md5.Text == "PLACEHOLDER")
            {
                MetroMessageBox.Show(this, "Enter a SHA/MD5 to check against", "Check is Empty or invalid", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                String computedSHA = SHA1.Text;
                String computedSHA256 = sha256.Text;
                String computedMD5 = md5.Text;
                String checkSHA = SHAtoCheck.Text;
                //does an equalsIgnoreCase
                if (computedSHA.Equals(checkSHA, StringComparison.InvariantCultureIgnoreCase) || computedSHA256.Equals(checkSHA,StringComparison.InvariantCultureIgnoreCase)
                    || computedMD5.Equals(checkSHA,StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "The SHA's/MD5's match", "Match", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "The SHA's/MD5's don't match", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private String computeSHA(FileStream stream)
        {
            SHA1Managed sha1 = new SHA1Managed();
            BufferedStream bs = new BufferedStream(stream);
            byte[] hash = sha1.ComputeHash(bs);
            String hold = BitConverter.ToString(hash).Replace("-", String.Empty);
            return hold;
        }

        private String computeSHA256(FileStream stream)
        {
            SHA256Managed sha256 = new SHA256Managed();
            BufferedStream bs = new BufferedStream(stream);
            byte[] hash = sha256.ComputeHash(bs);
            String holder = BitConverter.ToString(hash).Replace("-", String.Empty);
            return holder;
        }

        private String computeMD5(FileStream stream){
            var md5 = MD5.Create();
            var streamF = File.OpenRead(metroTextBox1.Text);
            return (BitConverter.ToString(md5.ComputeHash(streamF)).Replace("-", String.Empty));
            /*
            MD5 md5 = MD5.Create();
            BufferedStream bs = new BufferedStream(stream);
            byte[] hash = md5.ComputeHash(bs);
            String holder = BitConverter.ToString(hash).Replace("-", String.Empty);
            md5.Clear();
            return holder;*/

        }
    }
}
