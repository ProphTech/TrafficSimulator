using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RGY
{
   public class Light
    {
        SolidBrush DRed = new SolidBrush(Color.Red);
        SolidBrush DYellow = new SolidBrush(Color.Yellow);
        SolidBrush DGreen = new SolidBrush(Color.Green);
        public Point ap;
        public int Red;
        public int Green;
        public int Yellow;
        public bool Lgreen = false;
        public bool Lyellow = false;
        public bool Lred = false;
        public bool startgreen;
        public int temp;
        public int counter = 0;
        public int redexit = 0;
        public Light(int red, int green, int yellow, bool lgreen)
        {

            Red = red;
            Green = green;
            Yellow = yellow;
            Lgreen = lgreen;
            temp = yellow + green + red;
            if (lgreen)
            {
                startgreen = true;
            }
        }
        //public Light(Point p,int red,int green,int yellow,bool lgreen)
        //{
        //   ap= p;
        //    Red = red;
        //    Green = green;
        //    Yellow = yellow;
        //    Lgreen = lgreen;
        //}
        public void Turnyellow()
        {
            Lgreen = false;
            Lyellow = true;
            Lred = false;
        }
        public void Turnred()
        {
            Lgreen = false;
            Lyellow = false;
            Lred = true;
        }
        public void Turngreen()
        {
            Lgreen = true;
            Lyellow = false;
            Lred = false;
        }
        //public void Drawred()
        //{
        //    gr.FillEllipse(DRed, ap.X, ap.Y, 20, 20);
        //}
        //public void Drawyellow()
        //{
        //    gr.FillEllipse(DYellow, ap.X, ap.Y, 20, 20);
        //}
        //public void Drawgreen(Graphics gr)
        //{
        //    gr.FillEllipse(DGreen, ap.X, ap.Y, 20, 20);
        //}


        //            Graphics gr;
        //    SolidBrush DRed = new SolidBrush(Color.Red);
        //    SolidBrush DYellow = new SolidBrush(Color.Yellow);
        //    SolidBrush DGreen = new SolidBrush(Color.Green);
        //public void Addlighttype1(Point p, int a1, int a2, int a3, int b1, int b2, int b3, int c1, int c2, int c3, bool a, bool b, bool c)
        //{
        //    Point ap =new Point (0,0);
        //    Point bp = new Point(0, 0);
        //    Point cp = new Point(0, 0);

        //    if(a == false)
        //    {
        //    gr.FillEllipse(Red, p.X+ap.X, p.Y+ap.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+ap.X, p.Y+ap.Y, 20, 20); 
        //    }

        //   if(b == false)
        //    {
        //    gr.FillEllipse(Red, p.X+bp.X, p.Y+bp.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+bp.X, p.Y+bp.Y, 20, 20); 
        //    }
        //    if(c == false)
        //    {
        //    gr.FillEllipse(Red, p.X+cp.X, p.Y+cp.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+cp.X, p.Y+cp.Y, 20, 20); 
        //    }
        //}
        //public void Addlighttype2(Point p, int a1, int a2, int a3, int b1, int b2, int b3, int c1, int c2, int c3, bool a, bool b, bool c)
        //{
        //    Point ap = new Point(0, 0);
        //    Point bp = new Point(0, 0);
        //    Point cp = new Point(0, 0);
        //    if(a == false)
        //    {
        //    gr.FillEllipse(Red, p.X+ap.X, p.Y+ap.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+ap.X, p.Y+ap.Y, 20, 20); 
        //    }

        //   if(b == false)
        //    {
        //    gr.FillEllipse(Red, p.X+bp.X, p.Y+bp.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+bp.X, p.Y+bp.Y, 20, 20); 
        //    }
        //    if(c == false)
        //    {
        //    gr.FillEllipse(Red, p.X+cp.X, p.Y+cp.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+cp.X, p.Y+cp.Y, 20, 20); 
        //    }
        //}
        //public void Addlighttype3(Point p, int a1, int a2, int a3, int b1, int b2, int b3, int c1, int c2, int c3, int d1, int d2, int d3, bool a, bool b, bool c, bool d)
        //{
        //    Point ap =new Point (0,0);
        //    Point bp = new Point(0, 0);
        //    Point cp = new Point(0, 0);
        //    Point dp= new Point(0, 0);
        //if(a == false)
        //    {
        //    gr.FillEllipse(Red, p.X+ap.X, p.Y+ap.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+ap.X, p.Y+ap.Y, 20, 20); 
        //    }

        //   if(b == false)
        //    {
        //    gr.FillEllipse(Red, p.X+bp.X, p.Y+bp.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+bp.X, p.Y+bp.Y, 20, 20); 
        //    }
        //    if(c == false)
        //    {
        //    gr.FillEllipse(Red, p.X+cp.X, p.Y+cp.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+cp.X, p.Y+cp.Y, 20, 20); 
        //    }
        //        if(d== false)
        //    {
        //    gr.FillEllipse(Red, p.X+dp.X, p.Y+dp.Y, 20, 20); 
        //    }
        //    else
        //    {
        //    gr.FillEllipse(Green, p.X+dp.X, p.Y+dp.Y, 20, 20); 
        //    }
        //}
    }
}
