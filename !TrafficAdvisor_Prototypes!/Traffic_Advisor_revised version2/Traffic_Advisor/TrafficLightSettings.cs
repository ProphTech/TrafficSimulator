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
    public partial class TrafficLightSettings : Form
    {
        private Cell cell;

        public TrafficLightSettings(Cell ce)
        {
            InitializeComponent();
            this.cell = ce;
        }

        private void TrafficLightSettings_Load(object sender, EventArgs e)
        {

        }

        private void btCompelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrafficLightSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to save the setting and quit?", "Save and Quit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int red = Convert.ToInt32(numericUpDownRed.Value);
                int yellow = Convert.ToInt32(numericUpDownYellow.Value);
                int green = Convert.ToInt32(numericUpDownGreen.Value);

                cell.corssing.Initialization();
                foreach (Lane l in cell.corssing.Lanes)
                {
                    l.Light.SetInterval(red, yellow, green);
                }
                //set the input numbers to "cell";
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
