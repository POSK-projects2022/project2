using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterSprawnosci
{
    public partial class Form2 : Form
    {
        public Form2(Form1 parentForm)
        {
            this.parentForm = parentForm;   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.stopwatch.Start();
            this.timer1.Start();
            this.button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.i++;
            if (this.i >= 10) {
                this.stopwatch.Stop();
                this.timer1.Stop();
                this.pictureBox1.Visible = false;
                this.i = 0;

                if (this.checkBox1.CheckState == CheckState.Unchecked)
                {


                    if (this.stopwatch.ElapsedMilliseconds / 1000 < 6)
                    {
                        this.label3.ForeColor = Color.Green;
                        this.label4.ForeColor = Color.Green;
                        this.label4.Text = "A";
                    }
                    else if (this.stopwatch.ElapsedMilliseconds / 1000 >= 5 && this.stopwatch.ElapsedMilliseconds / 1000 < 9)
                    {
                        this.label3.ForeColor = Color.Gold;
                        this.label4.ForeColor = Color.Gold;
                        this.label4.Text = "B";
                    }
                    else
                    {
                        this.label3.ForeColor = Color.Red;
                        this.label4.ForeColor = Color.Red;
                        this.label4.Text = "C";
                    }

                    this.label3.Text = (float)this.stopwatch.ElapsedMilliseconds / 1000 + "s";

                    MessageBox.Show("Twój czas wykonania zadania to: " + (float)this.stopwatch.ElapsedMilliseconds / 1000 + "s");
                } else if (this.checkBox1.CheckState == CheckState.Checked)
                {
                    MessageBox.Show("Twój czas wykonania zadania to: " + (float)this.stopwatch.ElapsedMilliseconds / 1000 + "s");
                }
                this.button1.Enabled = true;
                this.stopwatch = new Stopwatch();
                

            } else
            {
                this.pictureBox1.Visible = false;
                this.pictureBox1.Location = new Point(r.Next(100, this.panel1.Size.Width - 100) , r.Next(75,this.panel1.Size.Height - 75));
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
