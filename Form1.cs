using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;
using System.Threading;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f1 = new Form2();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f1 = new Form2();
            f1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("bro welcome to my system ur about to get hacked lol", "Potato2Mato", MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("bro u just got hacked lol","BTATSM7MRAAAAAAAAAAAA");
                pictureBox1.Image = Resources.hacked;
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "Hacker Potato !";
            notifyIcon1.BalloonTipText = "ur being hacked lol";
            notifyIcon1.ShowBalloonTip(1000); // millisecond 
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            for( int i = 0; i <=10; i++)
            {
                if(progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(1000);
                    progressBar1.Value += 1;
                    label2.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                    progressBar1.Refresh();
                    label2.Refresh();
                    
                }
                else
                {

                    button7.Enabled = false;
                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button7.Enabled = checkBox1.Checked;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled = true)
            {
                pictureBox2.Load("C:\\Users\\eslamia\\OneDrive - Alexandria University\\Desktop\\mid.png");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled = true)
            {
                pictureBox2.Load("C:\\Users\\eslamia\\OneDrive - Alexandria University\\Desktop\\jg.png");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://wol.gg/stats/eune/potato2mato-eune/");
                

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("message bro");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "bro put ur name");

            }
            else
            {
                e.Cancel = false;


            }
        }
    }
}
