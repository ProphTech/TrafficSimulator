using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace RGY
{
    class Input
    {
        public Point point;
        private int vertical = -1;
        private int add = -1;
        public int type = -1;

        public Input(int x,int y, int vertical , int add , int type)
        {
            this.point = new Point(x,y);
            this.vertical = vertical;
            this.add = add;
            this.type = type;
        }

    }
}
