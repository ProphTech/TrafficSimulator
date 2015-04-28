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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void bt_NewProject_Click(object sender, EventArgs e)
        {
            Project_Grid_Screen pjs = new Project_Grid_Screen("");
            pjs.Visible = true;
            this.Visible = false;
            pjs.FormClosed += pjs_FormClosed;
        }

        void pjs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void bt_OpenFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                Project_Grid_Screen pj = new Project_Grid_Screen(path);
                pj.Visible = true;
                this.Visible = false;
                pj.FormClosed += pj_FormClosed;
            }
        }

        void pj_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }
    }
}
