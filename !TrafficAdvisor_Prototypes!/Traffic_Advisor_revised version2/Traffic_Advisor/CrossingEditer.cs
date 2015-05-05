using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Advisor
{
    public partial class CrossingEditer : Form
    {
        private Cell cell;

        public CrossingEditer(Cell c)
        {
            InitializeComponent();
            cell = c;

            this.pictureBox1.Image = cell.image;
        }

        private void CrossingEditer_Load(object sender, EventArgs e)
        {

        }

        private void btCompelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrossingEditer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to save the setting and quit?", "Save and Quit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (tbMaxD1.Text == "" || tbMaxD2.Text == "" || tbMaxL1.Text == "" || tbMaxL2.Text == "" || tbMaxR1.Text == "" || tbMaxR2.Text == "" || tbMaxUp1.Text == "" || tbMaxUp2.Text == "")
                {
                    MessageBox.Show("Information not completed filled in.");
                    e.Cancel = true;
                }
                else
                {
                    cell.corssing.SetMaxFlowOfLanes(Convert.ToInt32(tbMaxL1.Text), Convert.ToInt32(tbMaxL2.Text),Convert.ToInt32(tbMaxUp1.Text), Convert.ToInt32(tbMaxUp2.Text), 
                        Convert.ToInt32(tbMaxR1.Text), Convert.ToInt32(tbMaxR2.Text),Convert.ToInt32(tbMaxD1.Text), Convert.ToInt32(tbMaxD2.Text));
                }
                //set the input numbers to "cell";
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tbMaxUp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                e.KeyChar = '\0';//numbers only.
        }

        private void tbMaxUp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                e.KeyChar = '\0';//numbers only.
        }

        private void tbMaxL1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                e.KeyChar = '\0';//numbers only.
        }

        private void tbMaxL2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                e.KeyChar = '\0';//numbers only.
        }

        private void tbMaxD1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                e.KeyChar = '\0';//numbers only.
        }

        private void tbMaxD2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                e.KeyChar = '\0';//numbers only.
        }

        private void tbMaxR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                e.KeyChar = '\0';//numbers only.
        }

        private void tbMaxR2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != '.'))
                e.KeyChar = '\0';//numbers only.
        }
    }
}
