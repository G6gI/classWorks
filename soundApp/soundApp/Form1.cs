using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soundApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                textBox1.Text = path;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.openPlayer(path);
        }
    }
}
