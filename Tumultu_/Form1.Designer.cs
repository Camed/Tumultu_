namespace Tumultu_
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sha512label = new System.Windows.Forms.Label();
            this.sha256label = new System.Windows.Forms.Label();
            this.sha1label = new System.Windows.Forms.Label();
            this.md5label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vtButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileTypesLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.avgEntLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vtKeyTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sha512label);
            this.groupBox1.Controls.Add(this.sha256label);
            this.groupBox1.Controls.Add(this.sha1label);
            this.groupBox1.Controls.Add(this.md5label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(443, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hashes (right click to copy):";
            // 
            // sha512label
            // 
            this.sha512label.AutoSize = true;
            this.sha512label.Location = new System.Drawing.Point(86, 91);
            this.sha512label.Name = "sha512label";
            this.sha512label.Size = new System.Drawing.Size(0, 13);
            this.sha512label.TabIndex = 7;
            this.sha512label.Click += new System.EventHandler(this.sha512label_Click);
            // 
            // sha256label
            // 
            this.sha256label.AutoSize = true;
            this.sha256label.Location = new System.Drawing.Point(86, 72);
            this.sha256label.Name = "sha256label";
            this.sha256label.Size = new System.Drawing.Size(0, 13);
            this.sha256label.TabIndex = 6;
            this.sha256label.Click += new System.EventHandler(this.sha256label_Click);
            // 
            // sha1label
            // 
            this.sha1label.AutoSize = true;
            this.sha1label.Location = new System.Drawing.Point(86, 53);
            this.sha1label.Name = "sha1label";
            this.sha1label.Size = new System.Drawing.Size(0, 13);
            this.sha1label.TabIndex = 5;
            this.sha1label.Click += new System.EventHandler(this.sha1label_Click);
            // 
            // md5label
            // 
            this.md5label.AutoSize = true;
            this.md5label.Location = new System.Drawing.Point(86, 34);
            this.md5label.Name = "md5label";
            this.md5label.Size = new System.Drawing.Size(0, 13);
            this.md5label.TabIndex = 4;
            this.md5label.Click += new System.EventHandler(this.md5label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SHA512:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SHA256:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHA1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MD5:";
            // 
            // vtButton
            // 
            this.vtButton.Enabled = false;
            this.vtButton.Location = new System.Drawing.Point(12, 311);
            this.vtButton.Name = "vtButton";
            this.vtButton.Size = new System.Drawing.Size(107, 23);
            this.vtButton.TabIndex = 4;
            this.vtButton.Text = "VirusTotal Check";
            this.vtButton.UseVisualStyleBackColor = true;
            this.vtButton.Click += new System.EventHandler(this.vtButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(446, 288);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 41);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save gathered data";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 264);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entropy chart";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fileTypesLabel);
            this.groupBox3.Controls.Add(this.fileSizeLabel);
            this.groupBox3.Controls.Add(this.avgEntLabel);
            this.groupBox3.Controls.Add(this.locationLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(443, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 131);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Info (right click to copy)";
            // 
            // fileTypesLabel
            // 
            this.fileTypesLabel.Location = new System.Drawing.Point(105, 59);
            this.fileTypesLabel.Name = "fileTypesLabel";
            this.fileTypesLabel.Size = new System.Drawing.Size(234, 66);
            this.fileTypesLabel.TabIndex = 7;
            this.fileTypesLabel.Click += new System.EventHandler(this.fileTypesLabel_Click);
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(107, 46);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(0, 13);
            this.fileSizeLabel.TabIndex = 6;
            this.fileSizeLabel.Click += new System.EventHandler(this.fileSizeLabel_Click);
            // 
            // avgEntLabel
            // 
            this.avgEntLabel.AutoSize = true;
            this.avgEntLabel.Location = new System.Drawing.Point(101, 33);
            this.avgEntLabel.Name = "avgEntLabel";
            this.avgEntLabel.Size = new System.Drawing.Size(0, 13);
            this.avgEntLabel.TabIndex = 5;
            this.avgEntLabel.Click += new System.EventHandler(this.avgEntLabel_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(60, 20);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(0, 13);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Click += new System.EventHandler(this.locationLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Possible type of file:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "File size (in bytes):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Average entropy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Location:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(692, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com/camed";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Enter number of samples (default 256):";
            // 
            // vtKeyTextBox
            // 
            this.vtKeyTextBox.Location = new System.Drawing.Point(284, 313);
            this.vtKeyTextBox.Name = "vtKeyTextBox";
            this.vtKeyTextBox.Size = new System.Drawing.Size(147, 20);
            this.vtKeyTextBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Enter your VirusTotal API key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vtKeyTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.vtButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 378);
            this.MinimumSize = new System.Drawing.Size(816, 378);
            this.Name = "Form1";
            this.Text = "Tumultu_";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button vtButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sha512label;
        private System.Windows.Forms.Label sha256label;
        private System.Windows.Forms.Label sha1label;
        private System.Windows.Forms.Label md5label;
        private System.Windows.Forms.Label fileTypesLabel;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label avgEntLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vtKeyTextBox;
        private System.Windows.Forms.Label label10;
    }
}

