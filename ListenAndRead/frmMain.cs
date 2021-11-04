using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListenAndRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (axWindowsMediaPlayer1.playState== WMPLib.WMPPlayState.wmppsPlaying)
            {
                 axWindowsMediaPlayer1.Ctlcontrols.pause();
                 playToolStripMenuItem.Text = "Pause (F2)";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                playToolStripMenuItem.Text = "Play (F2)";

            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coppy Right 2014 By Nguyen Phuc Developer");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                panel1.Visible = true;

            }
            else
            {
                panel1.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox1_ReadOnlyChanged(object sender, EventArgs e)
        {
  
        }
    }
}
