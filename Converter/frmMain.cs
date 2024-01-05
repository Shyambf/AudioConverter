using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Converter
{
    public partial class frmMain : Form
    {
        string filenames;
        Process process;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChooseSource_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filenames = openFileDialog1.FileName;
                txtSource.Text = filenames;
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
            Converter con = new Converter();
            con.convert(comboBox2.Text, filenames);
            MessageBox.Show("The conversion is successful, the received file is next to the original file");
            groupBox1.Hide();
            comboBox2.Text = "";
            filenames = null;
            openFileDialog1.FileName = null; 
            txtSource.Text = null;
        }
    }
}
