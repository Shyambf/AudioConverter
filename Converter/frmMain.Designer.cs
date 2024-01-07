namespace Converter
{
    partial class frmMain
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
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnChooseSource = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.grpStep1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStep1
            // 
            this.grpStep1.Controls.Add(this.label1);
            this.grpStep1.Controls.Add(this.label2);
            this.grpStep1.Controls.Add(this.txtSource);
            this.grpStep1.Controls.Add(this.btnChooseSource);
            this.grpStep1.Location = new System.Drawing.Point(8, 3);
            this.grpStep1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpStep1.Size = new System.Drawing.Size(570, 128);
            this.grpStep1.TabIndex = 5;
            this.grpStep1.TabStop = false;
            this.grpStep1.Text = "Step 1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of files";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(158, 77);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(135, 26);
            this.txtSource.TabIndex = 0;
            // 
            // btnChooseSource
            // 
            this.btnChooseSource.Location = new System.Drawing.Point(458, 77);
            this.btnChooseSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChooseSource.Name = "btnChooseSource";
            this.btnChooseSource.Size = new System.Drawing.Size(104, 35);
            this.btnChooseSource.TabIndex = 2;
            this.btnChooseSource.Text = "Browse";
            this.btnChooseSource.UseVisualStyleBackColor = true;
            this.btnChooseSource.Click += new System.EventHandler(this.btnChooseSource_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(570, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2";
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сhoose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "mp3",
            "ogg",
            "wav",
            "flac",
            "aac",
            "amr",
            "aiff",
            "wma"});
            this.comboBox2.Location = new System.Drawing.Point(188, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "convert file to\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Supported audio files|*.mp3;*.ogg;*.wav;*.flac;*.acc;*.amr;*.aiff;*.wma|Mp3 |*.mp" +
    "3|Ogg |*.ogg|Wav |*.wav|Flac |*.flac|Aac |*.aac|Amr |*.amr|Aiff |*.aiff|Wma |*.w" +
    "ma\"";
            this.openFileDialog1.Multiselect = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(8, 230);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(570, 126);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 3";
            this.groupBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Select a folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(555, 32);
            this.progressBar1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpStep1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Universal audio Converter";
            this.grpStep1.ResumeLayout(false);
            this.grpStep1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnChooseSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
    }
}

