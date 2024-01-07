using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Converter
{
    public partial class frmMain : Form
    {
        string filenames, path;
        Process process;

        public frmMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnChooseSource_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filenames = openFileDialog1.FileName;
                txtSource.Text = openFileDialog1.FileNames.Count().ToString();
                if (filenames.Length > 0)
                {
                    groupBox1.Show();
                }
                else
                {
                    MessageBox.Show("file not found.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                groupBox2.Show();
            }
            else
            {
                MessageBox.Show("The format is not selected");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Converter con = new Converter();
            int currentFile = 0;
            foreach (String file in openFileDialog1.FileNames)
            {
                currentFile++;
                progressBar1.Value = (int)((double)((double)currentFile / (double)openFileDialog1.FileNames.Count()) * 100.0);
                con.convert(comboBox2.Text, file, path);
            }
            MessageBox.Show("The conversion is successful, the received file is next to the original file");
            groupBox1.Hide();
            groupBox2.Hide();
            comboBox2.Text = "";
            path = null;
            filenames = null;
            openFileDialog1.FileName = null;
            txtSource.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
        }
    }
}
