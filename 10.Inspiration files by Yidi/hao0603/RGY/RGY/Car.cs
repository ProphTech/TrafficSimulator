using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RGY
{
    class Car
    {
        public int x;
        public int y;
        public Image image;
        public Point position;
        public Input input;
        public string iwc;
        private Form1 frm;
        bool firstadd = true;
        public bool start = true;
        public int int1;
        public int int2;

        public string Checkposition()
        {
            if (this.x <= 136 && this.y <= 136)
            {
                iwc = "c1";
                return iwc;
            }
            else if (272 >= this.x&&this.x > 136 && this.y <= 136)
            {
                iwc = "r1";
                return iwc;
            }
            else if (408 >= this.x && this.x > 272 && this.y <= 136)
            {
                iwc = "c2";
                return iwc;
            }
            else if (544 >= this.x && this.x > 408 && this.y <= 136)
            {
                iwc = "r2";
                return iwc;
            }
            else if (608 >= this.x && this.x > 544 && this.y <= 136)
            {
                iwc = "c3";
                return iwc;
            }
            else if (816 >= this.x && this.x > 608 && this.y <= 136)
            {
                iwc = "r3";
                return iwc;
            }
            else if ( this.x > 816 && this.y <= 136)
            {
                iwc = "c4";
                return iwc;
            }
            else if (136 >= this.x && this.x > 0 && this.y <= 272&&this.y>136)
            {
                iwc = "r4";
                return iwc;
            }
            else if (408 >= this.x && this.x > 272 && this.y <= 272 && this.y > 136)
            {
                iwc = "r5";
                return iwc;
            }
            else if (608 >= this.x && this.x > 544 && this.y <= 272 && this.y > 136)
            {
                iwc = "r6";
                return iwc;
            }
            else if (9999 >= this.x && this.x > 816 && this.y <= 272 && this.y > 136)
            {
                iwc = "r7";
                return iwc;
            }
            else if (136 >= this.x && this.x > 0 && this.y <= 408 && this.y > 272)
            {
                iwc = "c5";
                return iwc;
            }
            else if (272>= this.x && this.x > 136 && this.y <= 408 && this.y > 272)
            {
                iwc = "r8";
                return iwc;
            }
            else if (408 >= this.x && this.x > 272 && this.y <= 408 && this.y > 272)
            {
                iwc = "c6";
                return iwc;
            }
            else if (544 >= this.x && this.x >408 && this.y <= 408 && this.y > 272)
            {
                iwc = "r9";
                return iwc;
            }
            else if (680 >= this.x && this.x > 544 && this.y <= 408 && this.y > 272)
            {
                iwc = "c7";
                return iwc;
            }
            else if (816 >= this.x && this.x > 680 && this.y <= 408 && this.y > 272)
            {
                iwc = "r10";
                return iwc;
            }
            else if (99999 >= this.x && this.x > 816 && this.y <= 408 && this.y > 272)
            {
                iwc = "c8";
                return iwc;
            }
            else if (136 >= this.x && this.x > 0 && this.y <= 544 && this.y > 408)
            {
                iwc = "r11";
                return iwc;
            }
            else if (408 >= this.x && this.x > 272 && this.y <= 544 && this.y > 408)
            {
                iwc = "r12";
                return iwc;
            }
            else if (680 >= this.x && this.x > 544 && this.y <= 544 && this.y > 408)
            {
                iwc = "r13";
                return iwc;
            }
            else if (99999 >= this.x && this.x > 816 && this.y <= 544 && this.y > 408)
            {
                iwc = "r14";
                return iwc;
            }
            else if (136 >= this.x && this.x > 0 && this.y > 544)
            {
                iwc = "C9";
                return iwc;
            }
            else if (272 >= this.x && this.x > 136 && this.y > 544)
            {
                iwc = "R15";
                return iwc;
            }
            else if (408 >= this.x && this.x > 272 && this.y > 544)
            {
                iwc = "C10";
                return iwc;
            }
            else if (544 >= this.x && this.x > 408 && this.y > 544)
            {
                iwc = "R16";
                return iwc;
            }
            else if (680 >= this.x && this.x > 544 && this.y > 544)
            {
                iwc = "C11";
                return iwc;
            }
            else if (816 >= this.x && this.x > 680 && this.y > 544)
            {
                iwc = "R17";
                return iwc;
            }
            else if (9999 >= this.x && this.x > 816 && this.y > 544)
            {
                iwc = "12";
                return iwc;
            }
            else
            {
                return "error";
            }
        }

        public Car(Point p, Image image, Input input,Form1 form)
        {
            this.x = p.X;
            this.y = p.Y;
            this.image = image;
            this.input = input;
            position = new Point(x,y);
            frm = form;
        }

        public void GetMove(int integer1, int integer2 )
        {
            //if (integer1 == 0)
            //{
            //    if (integer2 == 0)
            //    {
            //        this.x= this.x - 1;
            //    }
            //    else if (integer2 == 1)
            //    {
            //        this.x = this.x + 1;
            //    }
            //}
            //else if (integer1 == 1)
            //{
            //    if (integer2 == 0)
            //    {
            //        this.y = this.y - 1;
            //    }
            //    else if (integer2==1)
            //    {
            //        this.y = this.y + 1;
            //    }
            //}
            this.x = this.x + integer1;
            this.y = this.y + integer2;
            position = new Point(x, y);
            int ch = -1;
            for (int i = 0; i <frm.redpoint.Count; i++)
            {
                if (position == frm.redpoint[i]&&ch==-1)
                {
                    this.x = this.x - integer1;
                    this.y = this.y - integer2;
                    position = new Point(x, y);
                    ch = 1;
                }
                
            }
            if (ch == -1)
            {

                int xa; int ya;
                xa = this.x - integer1;
                ya = this.y - integer2;
                Point a = new Point(xa, ya);
                Point v = new Point(999,999);
                if (firstadd == false)
                {
                    int id = 0;

                    for (int it = 0; it < frm.redpoint.Count; it++)
                    {
                        if (frm.redpoint[it] == a)
                        {
                            //frm.redpoint[it]=v;
                            id = it;
                        }
                    }
                   //frm.redpoint.RemoveAt(id);
                   // frm.redpoint.Add(position);
                    if (frm.redpoint.Count != 0)
                    frm.redpoint[id] = position;
                }
                else
                {
                    firstadd = false;
                    frm.redpoint.Add(position);
                }
            }
            //foreach (Point p in frm.redpoint )
            //{
            //    if (position == p)
            //    {
            //        this.x = this.x - integer1;
            //        this.y = this.y - integer2;
            //        position = new Point(x, y);
            //    }
            //    else
            //    {
            //        frm.redpoint.Add(position);
            //        int xa; int ya;
            //        xa = this.x - integer1;
            //        ya = this.y - integer2;
            //        Point a = new Point(xa, ya);
            //        foreach (Point f in frm.redpoint)
            //        {
            //            if (a == f)
            //            {
            //                frm.redpoint.Remove(f);
            //            }
            //        }


            //    }
            //}
            this.int1 = integer1;
            this.int2 = integer2;
        }

        public void getmove()
        {
            this.x += int1;
            this.y += int2;
            position = new Point(x, y);
            int ch = -1;
            for (int i = 0; i < frm.redpoint.Count; i++)
            {
                if (position == frm.redpoint[i]&&ch==-1)
                {
                    this.x = this.x -int1;
                    this.y = this.y - int2;
                    position = new Point(x, y);
                    ch = 1;
                }

            }
            if (ch == -1)
            {

                int xa; int ya;
                xa = this.x - int1;
                ya = this.y - int2;
                Point a = new Point(xa, ya);
                Point v = new Point(999, 999);
                if (firstadd == false)
                {
                    int id = 0;

                    for (int it = 0; it < frm.redpoint.Count; it++)
                    {
                        if (frm.redpoint[it] == a)
                        {
                            //frm.redpoint[it]=v;
                            id = it;
                        }
                    }
                    //frm.redpoint.RemoveAt(id);
                    // frm.redpoint.Add(position);
                    if(frm.redpoint.Count!=0)
                    frm.redpoint[id] = position;
                }
                else
                {
                    firstadd = false;
                    frm.redpoint.Add(position);
                }
            }
        }
    }
}
