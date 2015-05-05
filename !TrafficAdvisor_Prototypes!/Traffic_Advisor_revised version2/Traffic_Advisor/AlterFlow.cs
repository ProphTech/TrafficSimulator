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
    public partial class AlterFlow : Form
    {

        private Cell cell;

        public AlterFlow(Cell ce)
        {
            InitializeComponent();
            this.cell = ce;
        }

        private void AlterFlow_FormClosing(object sender, FormClosingEventArgs e)
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
                    cell.corssing.SetCurrentFlowOfLanes(Convert.ToInt32(tbMaxL1.Text), Convert.ToInt32(tbMaxL2.Text), Convert.ToInt32(tbMaxUp1.Text), Convert.ToInt32(tbMaxUp2.Text),
                        Convert.ToInt32(tbMaxR1.Text), Convert.ToInt32(tbMaxR2.Text), Convert.ToInt32(tbMaxD1.Text), Convert.ToInt32(tbMaxD2.Text));
                }
                //set the input numbers to "cell";
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btCompelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
