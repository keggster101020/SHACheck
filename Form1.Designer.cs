namespace SHACheck
{
    partial class CheckSHA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSHA = new MetroFramework.Controls.MetroLabel();
            this.browseLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.browseButton = new MetroFramework.Controls.MetroButton();
            this.SHA1 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SHAtoCheck = new MetroFramework.Controls.MetroTextBox();
            this.check = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.sha256 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // labelSHA
            // 
            this.labelSHA.AutoSize = true;
            this.labelSHA.Location = new System.Drawing.Point(107, 170);
            this.labelSHA.Name = "labelSHA";
            this.labelSHA.Size = new System.Drawing.Size(42, 19);
            this.labelSHA.TabIndex = 0;
            this.labelSHA.Text = "SHA1:";
            // 
            // browseLabel
            // 
            this.browseLabel.AutoSize = true;
            this.browseLabel.Location = new System.Drawing.Point(107, 106);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(95, 19);
            this.browseLabel.TabIndex = 1;
            this.browseLabel.Text = "Enter File Path:";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[] {
        "Browse for a file"};
            this.metroTextBox1.Location = new System.Drawing.Point(208, 106);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(291, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.Text = "Browse for a file";
            this.metroTextBox1.UseSelectable = true;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(505, 106);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseSelectable = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // SHA1
            // 
            this.SHA1.AutoSize = true;
            this.SHA1.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.SHA1.Location = new System.Drawing.Point(208, 169);
            this.SHA1.Name = "SHA1";
            this.SHA1.Size = new System.Drawing.Size(103, 19);
            this.SHA1.TabIndex = 4;
            this.SHA1.Text = "PLACE HOLDER";
            this.SHA1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(107, 271);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Check against: ";
            // 
            // SHAtoCheck
            // 
            this.SHAtoCheck.Lines = new string[] {
        "Input SHA value"};
            this.SHAtoCheck.Location = new System.Drawing.Point(208, 267);
            this.SHAtoCheck.MaxLength = 32767;
            this.SHAtoCheck.Name = "SHAtoCheck";
            this.SHAtoCheck.PasswordChar = '\0';
            this.SHAtoCheck.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SHAtoCheck.SelectedText = "";
            this.SHAtoCheck.Size = new System.Drawing.Size(291, 23);
            this.SHAtoCheck.TabIndex = 6;
            this.SHAtoCheck.Text = "Input SHA value";
            this.SHAtoCheck.UseSelectable = true;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(505, 267);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 7;
            this.check.Text = "Check";
            this.check.UseSelectable = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(107, 214);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "SHA256:";
            // 
            // sha256
            // 
            this.sha256.AutoSize = true;
            this.sha256.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.sha256.Location = new System.Drawing.Point(208, 214);
            this.sha256.Name = "sha256";
            this.sha256.Size = new System.Drawing.Size(103, 19);
            this.sha256.TabIndex = 4;
            this.sha256.Text = "PLACE HOLDER";
            this.sha256.Visible = false;
            // 
            // CheckSHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 388);
            this.Controls.Add(this.check);
            this.Controls.Add(this.SHAtoCheck);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.sha256);
            this.Controls.Add(this.SHA1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.browseLabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.labelSHA);
            this.Name = "CheckSHA";
            this.Text = "Check SHA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelSHA;
        private MetroFramework.Controls.MetroLabel browseLabel;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton browseButton;
        private MetroFramework.Controls.MetroLabel SHA1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox SHAtoCheck;
        private MetroFramework.Controls.MetroButton check;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel sha256;


    }
}

