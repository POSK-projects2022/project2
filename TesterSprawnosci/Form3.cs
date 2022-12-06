using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterSprawnosci
{
    public partial class Form3 : Form
    {
        public Form3(Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.i == 3)
            {
                this.stopwatch.Stop();
                this.timer1.Stop();
                this.button1.BackColor = Color.DarkRed;
                this.button1.Enabled = false;
                float avgTime = (this.t1 + this.t2 + this.t3) / 3;
                if (this.checkBox1.CheckState == CheckState.Unchecked)
                {
                    if (avgTime >= 200 && avgTime < 300)
                    {
                        this.label2.ForeColor = Color.LimeGreen;
                        this.label5.ForeColor = Color.LimeGreen;
                        this.label5.Text = "Zdane";
                    }
                    else if (avgTime >= 300)
                    {
                        this.label2.ForeColor = Color.Red;
                        this.label5.ForeColor = Color.Red;
                        this.label5.Text = "Za wolno";
                    }
                    this.label2.Text = avgTime + "ms";
                } else if (this.checkBox1.CheckState == CheckState.Checked)
                {
                    this.label2.Text = avgTime + "ms";
                }
                    
                this.label4.Text = "Pomiar: " + this.i + "/3";
                this.button2.Enabled = true;
            } else
            {
                this.stopwatch.Stop();
                if (this.i == 1)
                {
                    this.t1 = (float)this.stopwatch.ElapsedMilliseconds;               
                } else if (this.i == 2)
                {
                    this.t2 = (float)this.stopwatch.ElapsedMilliseconds;
                }
                else if (this.i == 3)
                {
                    this.t3 = (float)this.stopwatch.ElapsedMilliseconds;
                }
                this.button1.BackColor = Color.DarkRed;
                this.button1.Enabled = false;
                this.label4.Text = "Pomiar: " + this.i + "/3";
            }
            this.timer1.Interval = r.Next(1500, 5000);
            this.stopwatch = new System.Diagnostics.Stopwatch();
        }

        private void button2_Click(object sender, EventArgs e)
        {   

            this.timer1.Interval = r.Next(1500, 5000);
            this.timer1.Start();
            this.button2.Enabled = false;
            this.i = 0;
            this.label4.Text = "Pomiar: " + this.i + "/3";


        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            SoundPlayer sp = new SoundPlayer(@"C:\Users\User\Desktop\projekt2POSK\beep-08b.wav");
            sp.Play();
            this.button1.Enabled = true;
            this.button1.BackColor = Color.LimeGreen;
            this.stopwatch.Start();
            this.i++;


        }
    }
}
