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

        public Cell(int x,int y)
        {
            this.X = x / 200;
            this.Y = y / 200; ;
        }

        //public void SetType(string type)
        //{
        //    this.Type = type;
        //}

        public void SetImage(Image i)
        {
            this.image = i;
        }
    }
}
