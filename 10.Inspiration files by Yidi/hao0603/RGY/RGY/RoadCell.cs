using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RGY
{
    class RoadCell
    {   private int edge = 136;
        public Point P;
        public Image Image;
        public bool empty = true;
        public bool usable = false;
        public int type;
        public string i;
        public RoadCell(Point p , Image IMAGE)
        {
            P = p;
            Image = IMAGE;
        }

        public RoadCell GetCell( Point p )
        {
            if (p.X>= P.X && p.Y >= P.Y && p.X < P.X+edge && p.Y < P.Y+edge)
            {
                return this;
            }
            return null;
        }

        public void changesOfEmpty()
        {
            this.empty = !this.empty;
        }
    }
}
