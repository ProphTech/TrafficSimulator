using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGY
{
    public partial class Type2 : Form
    {
        public Type2()
        {
            InitializeComponent();
        }
        int r1;
        int r2;
        int r3;
        int y1;
        int y2;
        int y3;
        int g1;
        int g2;
        int g3;
        bool bg1 = true;
        bool bg2 = true;
        bool bg3 = true;
        private void button2_Click(object sender, EventArgs e)
        {
            r1 = Convert.ToInt32(numericUpDown13.Value * 30);
            g1 = Convert.ToInt32(numericUpDown14.Value * 30);
            y1 = Convert.ToInt32(numericUpDown15.Value * 30);
            r2 = Convert.ToInt32(numericUpDown1.Value * 30);
            g2 = Convert.ToInt32(numericUpDown2.Value * 30);
            y2 = Convert.ToInt32(numericUpDown3.Value * 30);
            r3 = Convert.ToInt32(numericUpDown6.Value * 30);
            g3 = Convert.ToInt32(numericUpDown7.Value * 30);
            y3 = Convert.ToInt32(numericUpDown8.Value * 30);
            if (radioButton10.Checked)
            {
                bg1 = true;
            }
            else
            {
                bg1 = false;
            }
            if (radioButton2.Checked)
            {
                bg2 = true;
            }
            else
            {
                bg2 = false;
            }
            if (radioButton4.Checked)
            {
                bg3 = true;
            }
            else
            {
                bg3 = false;
            }
            Form1 frm1 = (Form1)this.Owner;
            frm1.l1 = new Light(r1, g1, y1, bg1);
            frm1.l2 = new Light(r2, g2, y2, bg2);
            frm1.l3 = new Light(r3, g3, y3, bg3);
            frm1.l5 = new Light(r1, g1, y1, bg1);
            frm1.l6 = new Light(r2, g2, y2, bg2);
            frm1.l7 = new Light(r3, g3, y3, bg3);
            //frm1.textBox1.Text = this.textBox1.Text;
            this.Close();
        }
    }
}
