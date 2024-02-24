using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if( textBox1.Text != "")
            {
                printImege(textBox1.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK )
            {
                string path = dialog.FileName;
                textBox1.Text = path;
                printImege(path);
            }
        }
        public void printImege(string path)
        {
            pictureBox1.Image = Image.FromFile(path);
        }
        private void button3_Click(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; }
        private void button4_Click(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;}
        private void button5_Click(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;}
    }
}
