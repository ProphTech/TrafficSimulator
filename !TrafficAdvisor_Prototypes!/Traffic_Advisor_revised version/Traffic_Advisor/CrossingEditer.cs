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
        private Cell crossing;

        public CrossingEditer(Cell c)
        {
            InitializeComponent();
            crossing = c;
        }
    }
}
