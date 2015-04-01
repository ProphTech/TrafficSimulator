using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RGY
{
    class Cell
    {
        private int edge = 136;
        public Point P;
        public Image Image;
        public bool empty = true;
        public bool usable = false;
        public int TYPE = -1;
        public string i;
        private List<Input> input = new List<Input>();
        Point a1 = new Point(0, 0);
        Point a2 = new Point(272, 0);
        Point a3 = new Point(544, 0);
        Point a4 = new Point(816, 0);
        Point a5 = new Point(0, 272);
        Point a6 = new Point(272, 272);
        Point a7 = new Point(544, 272);
        Point a8 = new Point(816, 272);
        Point a9 = new Point(0, 544);
        Point a10 = new Point(272, 544);
        Point a11 = new Point(544, 544);
        Point a12 = new Point(816, 544);

        public Cell(Point p , Image image, int type)
        {
            Image = image;
            P = p;
            this.TYPE = type;

            Input temp;
            if (p == a1)
            {
                if (this.TYPE == 1)
                {
                    temp = new Input(P.X, P.Y + 60, 0, 0, 1);
                    this.input.Add(temp);
                    temp = new Input(P.X, P.Y + 95, 0, 0, 2);
                    this.input.Add(temp);
                    temp = new Input(P.X + 42, P.Y, 1, 0, 3);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 2)
                {
                    temp = new Input(P.X, P.Y + 94, 0, 0, 7);
                    this.input.Add(temp);
                    temp = new Input(P.X + 60, P.Y, 1, 0, 8);
                    this.input.Add(temp);
                    temp = new Input(P.X + 25, P.Y, 1, 0, 9);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 3)
                {
                    temp = new Input(P.X, P.Y + 95, 0, 0, 7);
                    this.input.Add(temp);
                    temp = new Input(P.X + 60, P.Y, 1, 0, 8);
                    this.input.Add(temp);
                    temp = new Input(P.X + 25, P.Y, 1, 0, 9);
                    this.input.Add(temp);
                    temp = new Input(P.X, P.Y + 60, 0, 0, 10);
                    this.input.Add(temp);
                }
            }
            else if (p == a2 || p == a3)
            {
                if (this.TYPE == 1)
                {

                    temp = new Input(P.X + 42, P.Y, 1, 0, 3);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 2)
                {
                    temp = new Input(P.X + 60, P.Y, 1, 0, 8);
                    this.input.Add(temp);
                    temp = new Input(P.X + 25, P.Y, 1, 0, 9);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 3)
                {
                    temp = new Input(P.X + 25, P.Y, 1, 0, 9);
                    this.input.Add(temp);
                    temp = new Input(P.X + 60, P.Y, 1, 0, 9);
                    this.input.Add(temp);
                }
            }

            else if (p == a4)
            {
                if (this.TYPE == 1)
                {
                    temp = new Input(P.X + 42, P.Y, 1, 0, 3);
                    this.input.Add(temp);
                    temp = new Input(P.X + 136, P.Y + 60, 0, 1, 4);
                    this.input.Add(temp);
                    temp = new Input(P.X + 136, P.Y + 25, 0, 1, 5);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 2)
                {
                    temp = new Input(P.X + 60, P.Y, 1, 0, 8);
                    this.input.Add(temp);
                    temp = new Input(P.X + 25, P.Y, 1, 0, 9);
                    this.input.Add(temp);
                    temp = new Input(P.X + 136, P.Y + 42, 0, 1, 10);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 3)
                {
                    temp = new Input(P.X + 136, P.Y + 25, 0, 1, 10);
                    this.input.Add(temp);
                    temp = new Input(P.X + 136, P.Y + 60, 0, 1, 4);
                    this.input.Add(temp);
                    temp = new Input(P.X + 25, P.Y, 1, 0, 9);
                    this.input.Add(temp);
                    temp = new Input(P.X + 60, P.Y, 1, 0, 8);
                    this.input.Add(temp);
                }
            }
            if (p == a5)
            {
                if (this.TYPE == 1)
                {
                    temp = new Input(P.X, P.Y + 60, 0, 0, 1);
                    this.input.Add(temp);
                    temp = new Input(P.X, P.Y + 95, 0, 0, 2);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 2)
                {
                    temp = new Input(P.X, P.Y + 94, 0, 0, 7);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 3)
                {
                    temp = new Input(P.X, P.Y + 95, 0, 0, 7);
                    this.input.Add(temp);
                    temp = new Input(P.X, P.Y + 60, 0, 0, 7);
                    this.input.Add(temp);
                }
            }
            if (p == a8)
            {
                if (this.TYPE == 1)
                {
                    temp = new Input(P.X + 136, P.Y + 60, 0, 1, 4);
                    this.input.Add(temp);
                    temp = new Input(P.X + 136, P.Y + 25, 0, 1, 5);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 2)
                {
                    temp = new Input(P.X + 136, P.Y + 42, 0, 1, 4);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 3)
                {
                    temp = new Input(P.X + 136, P.Y + 25, 0, 1, 4);
                    this.input.Add(temp);
                    temp = new Input(P.X + 136, P.Y + 60, 0, 1, 4);
                    this.input.Add(temp);
                }
            }
            if (p == a9)
            {
                if (this.TYPE == 1)
                {
                    temp = new Input(P.X, P.Y + 60, 0, 0, 1);
                    this.input.Add(temp);
                    temp = new Input(P.X, P.Y + 95, 0, 0, 2);
                    this.input.Add(temp);
                    temp = new Input(P.X + 94, P.Y + 136, 1, 1, 6);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 2)
                {
                    temp = new Input(P.X, P.Y + 94, 0, 0, 7);
                    this.input.Add(temp);
                    temp = new Input(P.X + 60, P.Y + 136, 0, 1, 11);
                    this.input.Add(temp);
                    temp = new Input(P.X + 95, P.Y + 136, 0, 1, 12);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 3)
                {
                    temp = new Input(P.X, P.Y + 95, 0, 0, 7);
                    this.input.Add(temp);
                    temp = new Input(P.X + 60, P.Y + 136, 0, 1, 12);
                    this.input.Add(temp);
                    temp = new Input(P.X , P.Y + 60, 0, 1, 1);
                    this.input.Add(temp);
                    temp = new Input(P.X + 95, P.Y + 136, 0, 1, 12);
                    this.input.Add(temp);
                }
            }
            if (p == a10 || p == a11)
            {
                if (this.TYPE == 1)
                {
                    temp = new Input(P.X + 94, P.Y + 136, 1, 1, 6);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 2)
                {
                    temp = new Input(P.X + 60, P.Y + 136, 0, 1, 11);
                    this.input.Add(temp);
                    temp = new Input(P.X + 95, P.Y + 136, 0, 1, 12);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 3)
                {
                    temp = new Input(P.X + 60, P.Y + 136, 0, 1, 12);
                    this.input.Add(temp);
                    temp = new Input(P.X + 95, P.Y + 136, 0, 1, 12);
                    this.input.Add(temp);
                }
            }
            if (p == a12)
            {
                if (this.TYPE == 1)
                {
                    temp = new Input(P.X + 136, P.Y + 60, 0, 1, 4);
                    this.input.Add(temp);
                    temp = new Input(P.X + 136, P.Y + 25, 0, 1, 5);
                    this.input.Add(temp);
                    temp = new Input(P.X + 94, P.Y + 136, 1, 1, 6);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 2)
                {
                    temp = new Input(P.X + 136, P.Y + 42, 0, 1, 4);
                    this.input.Add(temp);
                    temp = new Input(P.X + 60, P.Y + 136, 0, 1, 11);
                    this.input.Add(temp);
                    temp = new Input(P.X + 95, P.Y + 136, 0, 1, 12);
                    this.input.Add(temp);
                }
                else if (this.TYPE == 3)
                {
                    temp = new Input(P.X + 60, P.Y + 136, 0, 1, 11);
                    this.input.Add(temp);
                    temp = new Input(P.X + 136, P.Y + 35, 0, 0, 4);
                    this.input.Add(temp);
                    temp = new Input(P.X + 136, P.Y + 60, 0, 1, 4);
                    this.input.Add(temp);
                    temp = new Input(P.X + 95, P.Y + 136, 0, 1, 12);
                    this.input.Add(temp);
                }
            }
        }

        public Cell(Point p, Image image)
        {
            Image = image;
            P = p;
        }

        public void ChangeImage(Image image)
        {
            this.Image = image;
        }


        public Cell GetCell( Point p )
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

        public List<Input> Input()
        {
            return this.input;
        }
    }
}
