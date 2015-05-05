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
    public class Cell
    {
        //public string Type { get;private set; }
        public int X { get;private set; }
        public int Y { get;private set; }
        public Image image { get;private set; }
        public Crossing corssing { get;private set; }

        public string Test { get; set; }

        public Cell(int x,int y)
        {
            this.X = x / 200;
            this.Y = y / 200;
        }

        public void SetImageAndCrossing(Image i,Crossing cro)
        {
            this.image = i;
            this.corssing = cro;
            this.corssing.SetLocation(this.X, this.Y);
        }
    }
}
