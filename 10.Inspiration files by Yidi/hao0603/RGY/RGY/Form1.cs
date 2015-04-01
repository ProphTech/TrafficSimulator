using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGY
{
    public partial class Form1 : Form
    {
        public List<Point> redpoint = new List<Point>();

        List<Light> lightlist = new List<Light>();
        List<Input> intpulist = new List<Input>();
        int index;
        public Light l1;
        public Light l2;
        public Light l3;
        public Light l4;
        public Light l5;
        public Light l6;
        public Light l7;
        public Light l8;
        List<PictureBox> lightpicturebox = new List<PictureBox>();
        string action;
        int type;
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
        //--------------------------road cell
        Point b1 = new Point(136, 0);
        Point b2 = new Point(408, 0);
        Point b3 = new Point(680, 0);
        //------------------------------------
        Point b4 = new Point(0, 136);
        Point b5 = new Point(272, 136);
        Point b6 = new Point(544, 136);
        Point b7 = new Point(816, 136);
        //------------------------------------
        Point b8 = new Point(136, 272);
        Point b9 = new Point(408, 272);
        Point b10 = new Point(680, 272);
        //------------------------------------
        Point b11 = new Point(0, 408);
        Point b12 = new Point(272, 408);
        Point b13 = new Point(544, 408);
        Point b14 = new Point(816, 408);
        //--------------------------------------
        Point b15 = new Point(136, 544);
        Point b16 = new Point(408, 544);
        Point b17 = new Point(680, 544);
        Cell cell1, cell2, cell3, cell4, cell5, cell6, cell7, cell8, cell9, cell10, cell11, cell12;
        RoadCell Rcell1, Rcell2, Rcell3, Rcell4, Rcell5, Rcell6, Rcell7, Rcell8, Rcell9, Rcell10, Rcell11, Rcell12, Rcell13, Rcell14, Rcell15, Rcell16, Rcell17;
        List<Cell> cellList = new List<Cell>();
        List<Cell> cellListNew = new List<Cell>();

        List<RoadCell> RoadcellList = new List<RoadCell>();
        List<RoadCell> RoadcellListNew = new List<RoadCell>();
        Graphics grapgics;
        List<PictureBox> carlist;
        List<Car> cars = new List<Car>();
        PictureBox[] pic = new PictureBox[99999999];


        public Form1()
        {
            InitializeComponent();
            index = 0;
            carlist = new List<PictureBox>();
            type = -1;
            cell1 = new Cell(a1, this.imageList1.Images[0], -1);
            cell2 = new Cell(a2, this.imageList1.Images[0], -1);
            cell3 = new Cell(a3, this.imageList1.Images[0], -1);
            cell4 = new Cell(a4, this.imageList1.Images[0], -1);
            cell5 = new Cell(a5, this.imageList1.Images[0], -1);
            cell6 = new Cell(a6, this.imageList1.Images[0], -1);
            cell7 = new Cell(a7, this.imageList1.Images[0], -1);
            cell8 = new Cell(a8, this.imageList1.Images[0], -1);
            cell9 = new Cell(a9, this.imageList1.Images[0], -1);
            cell10 = new Cell(a10, this.imageList1.Images[0], -1);
            cell11 = new Cell(a11, this.imageList1.Images[0], -1);
            cell12 = new Cell(a12, this.imageList1.Images[0], -1);
            cell1.i = "c1";
            cell2.i = "c2";
            cell3.i = "c3";
            cell4.i = "c4";
            cell5.i = "c5";
            cell6.i = "c6";
            cell7.i = "c7";
            cell8.i = "c8";
            cell9.i = "c9";
            cell10.i = "c10";
            cell11.i = "c11";
            cell12.i = "c12";
            cellList.Add(cell1);
            cellList.Add(cell2);
            cellList.Add(cell3);
            cellList.Add(cell4);
            cellList.Add(cell5);
            cellList.Add(cell6);
            cellList.Add(cell7);
            cellList.Add(cell8);
            cellList.Add(cell9);
            cellList.Add(cell10);
            cellList.Add(cell11);
            cellList.Add(cell12);
            Rcell1 = new RoadCell(b1, this.imageList1.Images[1]);
            Rcell2 = new RoadCell(b2, this.imageList1.Images[1]);
            Rcell3 = new RoadCell(b3, this.imageList1.Images[1]);
            Rcell4 = new RoadCell(b4, this.imageList1.Images[1]);
            Rcell5 = new RoadCell(b5, this.imageList1.Images[1]);
            Rcell6 = new RoadCell(b6, this.imageList1.Images[1]);
            Rcell7 = new RoadCell(b7, this.imageList1.Images[1]);
            Rcell8 = new RoadCell(b8, this.imageList1.Images[1]);
            Rcell9 = new RoadCell(b9, this.imageList1.Images[1]);
            Rcell10 = new RoadCell(b10, this.imageList1.Images[1]);
            Rcell11 = new RoadCell(b11, this.imageList1.Images[1]);
            Rcell12 = new RoadCell(b12, this.imageList1.Images[1]);
            Rcell13 = new RoadCell(b13, this.imageList1.Images[1]);
            Rcell14 = new RoadCell(b14, this.imageList1.Images[1]);
            Rcell15 = new RoadCell(b15, this.imageList1.Images[1]);
            Rcell16 = new RoadCell(b16, this.imageList1.Images[1]);
            Rcell17 = new RoadCell(b17, this.imageList1.Images[1]);
            Rcell1.i = "r1";
            Rcell2.i = "r2";
            Rcell3.i = "r3";
            Rcell4.i = "r4";
            Rcell5.i = "r5";
            Rcell6.i = "r6";
            Rcell7.i = "r7";

            Rcell8.i = "r8";
            Rcell9.i = "r9";
            Rcell10.i = "r10";
            Rcell11.i = "r11";
            Rcell12.i = "r12";
            Rcell13.i = "r13";
            Rcell14.i = "r14";
            Rcell15.i = "r15";
            Rcell16.i = "r16";
            Rcell17.i = "r17";
            RoadcellListNew.Add(Rcell1);
            RoadcellListNew.Add(Rcell2);
            RoadcellListNew.Add(Rcell3);
            RoadcellListNew.Add(Rcell4);
            RoadcellListNew.Add(Rcell5);
            RoadcellListNew.Add(Rcell6);
            RoadcellListNew.Add(Rcell7);
            RoadcellListNew.Add(Rcell8);
            RoadcellListNew.Add(Rcell9);
            RoadcellListNew.Add(Rcell10);
            RoadcellListNew.Add(Rcell11);
            RoadcellListNew.Add(Rcell12);
            RoadcellListNew.Add(Rcell13);
            RoadcellListNew.Add(Rcell14);
            RoadcellListNew.Add(Rcell15);
            RoadcellListNew.Add(Rcell16);
            RoadcellListNew.Add(Rcell17);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            grapgics = e.Graphics;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightGray);
            System.Drawing.Graphics formGraphics = panel1.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(136, 136, 136, 136));
            formGraphics.FillRectangle(myBrush, new Rectangle(408, 136, 136, 136));
            formGraphics.FillRectangle(myBrush, new Rectangle(680, 136, 136, 136));
            formGraphics.FillRectangle(myBrush, new Rectangle(136, 408, 136, 136));
            formGraphics.FillRectangle(myBrush, new Rectangle(408, 408, 136, 136));
            formGraphics.FillRectangle(myBrush, new Rectangle(680, 408, 136, 136));

            this.PaintCR(cell1, grapgics);
            this.PaintCR(cell2, grapgics);
            this.PaintCR(cell3, grapgics);
            this.PaintCR(cell4, grapgics);
            this.PaintCR(cell5, grapgics);
            this.PaintCR(cell6, grapgics);
            this.PaintCR(cell7, grapgics);
            this.PaintCR(cell8, grapgics);
            this.PaintCR(cell9, grapgics);
            this.PaintCR(cell10, grapgics);
            this.PaintCR(cell11, grapgics);
            this.PaintCR(cell12, grapgics);
            //--------------------------------------
            this.PaintRoad(RoadcellListNew[0], grapgics);
            this.PaintRoad(RoadcellListNew[1], grapgics);
            this.PaintRoad(RoadcellListNew[2], grapgics);
            this.PaintRoad(RoadcellListNew[3], grapgics);
            this.PaintRoad(RoadcellListNew[4], grapgics);
            this.PaintRoad(RoadcellListNew[5], grapgics);
            this.PaintRoad(RoadcellListNew[6], grapgics);
            this.PaintRoad(RoadcellListNew[7], grapgics);
            this.PaintRoad(RoadcellListNew[8], grapgics);
            this.PaintRoad(RoadcellListNew[9], grapgics);
            this.PaintRoad(RoadcellListNew[10], grapgics);
            this.PaintRoad(RoadcellListNew[11], grapgics);
            this.PaintRoad(RoadcellListNew[12], grapgics);
            this.PaintRoad(RoadcellListNew[13], grapgics);
            this.PaintRoad(RoadcellListNew[14], grapgics);
            this.PaintRoad(RoadcellListNew[15], grapgics);
            this.PaintRoad(RoadcellListNew[16], grapgics);


            Rectangle rect = this.Bounds;
            int col = rect.Width;
            int row = rect.Height;

            //Pen p = new Pen(Brushes.Green);
            //p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            //for (int i = 0; i <= row; i++)
            //{
            //    e.Graphics.DrawLine(p, 5, drawCol, rect.Width, drawCol);
            //    drawCol += x;
            //}
            //for (int j = 0; j <= col; j++)
            //{
            //    e.Graphics.DrawLine(p, drawRow, 5, drawRow, drawCol);
            //    drawRow += x;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = this.Size.Width - 980;
            p.Y = this.panel1.Location.Y;
            this.panel1.Location = p;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.action = "add";
            this.type = 1;
            //Type1 FM2 = new Type1();
            // FM2.Show();
            Type1 form2 = new Type1();

            form2.Owner = this;

            form2.ShowDialog();

            form2.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.action = "remove";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.action = "add";
            this.type = 3;

            Tpye3 form2 = new Tpye3();
            form2.Owner = this;

            form2.ShowDialog();

            form2.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.action = "add";
            this.type = 2;

            Type2 form2 = new Type2();
            form2.Owner = this;

            form2.ShowDialog();

            form2.Dispose();
        }

        private void PaintCR(Cell a, Graphics gr)
        {
            Rectangle destrec = new Rectangle(a.P.X, a.P.Y, 136, 136);
            gr.DrawImage(a.Image, destrec);
        }

        private void PaintRoad(RoadCell a, Graphics gr)
        {
            Rectangle destrec = new Rectangle(a.P.X, a.P.Y, 136, 136);
            gr.DrawImage(a.Image, destrec);
        }

        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (action == "add")
            {
                if (cell1.usable == false && cell2.usable == false && cell3.usable == false && cell4.usable == false && cell5.usable == false && cell6.usable == false && cell7.usable == false && cell8.usable == false && cell9.usable == false && cell10.usable == false && cell11.usable == false && cell12.usable == false)
                {
                    Point p = new Point(e.X, e.Y);
                    Point a = new Point(-1, -1);
                    Cell temp = new Cell(a, this.imageList1.Images[0], -1);

                    if (cellListNew.Count > 0)
                    {
                        foreach (Cell item in cellListNew)
                        {
                            if (item.GetCell(p) != null)
                            {
                                temp = item;
                            }
                        }
                    }
                    else
                    {
                        foreach (Cell item in cellList)
                        {
                            if (item.GetCell(p) != null)
                            {
                                temp = item;
                            }
                        }
                    }

                    //----------------------row 1
                    if (temp == cell1 && cell1.empty == true)
                    {
                        cell1.TYPE = this.type;
                        if (cell1.TYPE == 1)
                        {
                            cell1 = new Cell(a1, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(44, 60);
                            l2.ap = new Point(10, 95);
                            l3.ap = new Point(94, 109);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(110, 60);
                            l6.ap = new Point(119, 25);
                            l7.ap = new Point(42, 19);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            //PictureBox p1 = new PictureBox();
                            //p1.Location = l1.ap;
                            //p1.Parent = this.panel1;
                            //p1.Image = imagelistlight.Images[0];

                        }
                        else if (cell1.TYPE == 2)
                        {
                            cell1 = new Cell(a1, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(25, 27);
                            l2.ap = new Point(10, 94);
                            l3.ap = new Point(60, 92);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(95, 111);
                            l6.ap = new Point(109, 42);
                            l7.ap = new Point(60, 27);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell1.TYPE == 3)
                        {
                            cell1 = new Cell(a1, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(35, 60);
                            l2.ap = new Point(10, 95);
                            l3.ap = new Point(60, 75);
                            l4.ap = new Point(95, 111);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(85, 60);
                            l6.ap = new Point(120, 25);
                            l7.ap = new Point(60, 29);
                            l8.ap = new Point(25, 10);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            //    l8.ap = new Point(60, 20);
                            lightlist.Add(l8);
                        }

                        foreach (Input item in cell1.Input())
                        {
                            this.intpulist.Add(item);
                        }




                        cell1.empty = false;
                        cell1.usable = true;
                        cell2.usable = true;
                        cell5.usable = true;
                    }
                    else if (temp == cell2 && cell2.empty == true)
                    {
                        cell2.TYPE = this.type;
                        if (cell2.TYPE == 1)
                        {
                            cell2 = new Cell(a2, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(316, 60);
                            l2.ap = new Point(282, 95);
                            l3.ap = new Point(366, 109);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(382, 60);
                            l6.ap = new Point(391, 25);
                            l7.ap = new Point(314, 19);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell2.TYPE == 2)
                        {
                            cell2 = new Cell(a2, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(297, 27);
                            l2.ap = new Point(282, 94);
                            l3.ap = new Point(332, 92);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(367, 111);
                            l6.ap = new Point(381, 42);
                            l7.ap = new Point(332, 27);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell2.TYPE == 3)
                        {
                            cell2 = new Cell(a2, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(307, 60);
                            l2.ap = new Point(282, 95);
                            l3.ap = new Point(332, 75);
                            l4.ap = new Point(367, 111);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(357, 60);
                            l6.ap = new Point(392, 25);
                            l7.ap = new Point(332, 29);
                            l8.ap = new Point(297, 10);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            //  l8.ap = new Point(332, 20);
                            lightlist.Add(l8);
                        }

                        foreach (Input item in cell2.Input())
                        {
                            this.intpulist.Add(item);
                        }



                        cell2.empty = false;
                        cell2.usable = true;
                        cell1.usable = true;
                        cell3.usable = true;
                        cell6.usable = true;
                    }
                    else if (temp == cell3 && cell3.empty == true)
                    {
                        cell3.TYPE = this.type;
                        if (cell3.TYPE == 1)
                        {
                            cell3 = new Cell(a3, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(588, 60);
                            l2.ap = new Point(554, 95);
                            l3.ap = new Point(638, 109);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(654, 60);
                            l6.ap = new Point(663, 25);
                            l7.ap = new Point(586, 19);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell3.TYPE == 2)
                        {
                            cell3 = new Cell(a3, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(569, 27);
                            l2.ap = new Point(554, 94);
                            l3.ap = new Point(604, 92);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(639, 111);
                            l6.ap = new Point(653, 42);
                            l7.ap = new Point(604, 27);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell3.TYPE == 3)
                        {
                            cell3 = new Cell(a3, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(579, 60);
                            l2.ap = new Point(554, 95);
                            l3.ap = new Point(604, 75);
                            l4.ap = new Point(639, 111);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(629, 60);
                            l6.ap = new Point(664, 25);
                            l7.ap = new Point(604, 29);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(569, 10);
                            lightlist.Add(l8);
                        }


                        foreach (Input item in cell3.Input())
                        {
                            this.intpulist
                                .Add(item);
                        }




                        cell3.empty = false;
                        cell3.usable = true;
                        cell2.usable = true;
                        cell4.usable = true;
                        cell7.usable = true;
                    }
                    else if (temp == cell4 && cell4.empty == true)
                    {
                        cell4.TYPE = this.type;
                        if (cell4.TYPE == 1)
                        {
                            cell4 = new Cell(a4, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(860, 60);
                            l2.ap = new Point(826, 95);
                            l3.ap = new Point(910, 109);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(926, 60);
                            l6.ap = new Point(935, 25);
                            l7.ap = new Point(858, 19);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell4.TYPE == 2)
                        {
                            cell4 = new Cell(a4, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(841, 27);
                            l2.ap = new Point(826, 94);
                            l3.ap = new Point(876, 92);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(911, 111);
                            l6.ap = new Point(925, 42);
                            l7.ap = new Point(876, 27);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell4.TYPE == 3)
                        {
                            cell4 = new Cell(a4, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(851, 60);
                            l2.ap = new Point(826, 95);
                            l3.ap = new Point(876, 75);
                            l4.ap = new Point(911, 111);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(901, 60);
                            l6.ap = new Point(936, 25);
                            l7.ap = new Point(876, 29);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(841, 10);
                            lightlist.Add(l8);
                        }

                        foreach (Input item in cell4.Input())
                        {
                            this.intpulist.Add(item);
                        }



                        cell4.empty = false;
                        cell4.usable = true;
                        cell3.usable = true;
                        cell8.usable = true;
                    }
                    //------------------------row 2
                    if (temp == cell5 && cell5.empty == true)
                    {
                        cell5.TYPE = this.type;
                        if (cell5.TYPE == 1)
                        {
                            cell5 = new Cell(a5, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(44, 332);
                            l2.ap = new Point(10, 367);
                            l3.ap = new Point(94, 381);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(110, 332);
                            l6.ap = new Point(119, 297);
                            l7.ap = new Point(42, 291);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell5.TYPE == 2)
                        {
                            cell5 = new Cell(a5, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(25, 299);
                            l2.ap = new Point(10, 366);
                            l3.ap = new Point(60, 364);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(95, 383);
                            l6.ap = new Point(109, 314);
                            l7.ap = new Point(60, 299);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell5.TYPE == 3)
                        {
                            cell5 = new Cell(a5, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(35, 332);
                            l2.ap = new Point(10, 367);
                            l3.ap = new Point(60, 347);
                            l4.ap = new Point(95, 383);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(85, 332);
                            l6.ap = new Point(120, 297);
                            l7.ap = new Point(60, 301);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(25, 282);
                            lightlist.Add(l8);
                        }
                        foreach (Input item in cell5.Input())
                        {
                            this.intpulist.Add(item);
                        }
                        cell5.empty = false;
                        cell5.usable = true;
                        cell1.usable = true;
                        cell6.usable = true;
                        cell9.usable = true;
                    }
                    else if (temp == cell6 && cell6.empty == true)
                    {
                        cell6.TYPE = this.type;
                        if (cell6.TYPE == 1)
                        {
                            cell6 = new Cell(a6, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(316, 332);
                            l2.ap = new Point(282, 367);
                            l3.ap = new Point(366, 381);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(382, 332);
                            l6.ap = new Point(391, 297);
                            l7.ap = new Point(314, 291);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell6.TYPE == 2)
                        {
                            cell6 = new Cell(a6, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(297, 299);
                            l2.ap = new Point(282, 366);
                            l3.ap = new Point(332, 364);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(367, 383);
                            l6.ap = new Point(381, 314);
                            l7.ap = new Point(332, 299);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell6.TYPE == 3)
                        {
                            cell6 = new Cell(a6, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(307, 332);
                            l2.ap = new Point(282, 367);
                            l3.ap = new Point(332, 347);
                            l4.ap = new Point(367, 383);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(357, 332);
                            l6.ap = new Point(392, 297);
                            l7.ap = new Point(332, 301);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(297, 282);
                            lightlist.Add(l8);
                        }
                        foreach (Input item in cell6.Input())
                        {
                            this.intpulist.Add(item);
                        }
                        cell6.empty = false;
                        cell6.usable = true;
                        cell2.usable = true;
                        cell5.usable = true;
                        cell7.usable = true;
                        cell10.usable = true;
                    }
                    else if (temp == cell7 && cell7.empty == true)
                    {
                        cell7.TYPE = this.type;
                        if (cell7.TYPE == 1)
                        {
                            cell7 = new Cell(a7, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(588, 332);
                            l2.ap = new Point(554, 367);
                            l3.ap = new Point(638, 381);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(654, 332);
                            l6.ap = new Point(663, 297);
                            l7.ap = new Point(586, 291);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell7.TYPE == 2)
                        {
                            cell7 = new Cell(a7, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(569, 299);
                            l2.ap = new Point(554, 366);
                            l3.ap = new Point(604, 364);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(639, 383);
                            l6.ap = new Point(653, 314);
                            l7.ap = new Point(604, 299);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell7.TYPE == 3)
                        {
                            cell7 = new Cell(a7, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(579, 332);
                            l2.ap = new Point(554, 367);
                            l3.ap = new Point(604, 347);
                            l4.ap = new Point(639, 383);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(629, 332);
                            l6.ap = new Point(664, 297);
                            l7.ap = new Point(604, 301);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(569, 282);
                            lightlist.Add(l8);
                        }
                        foreach (Input item in cell7.Input())
                        {
                            this.intpulist.Add(item);
                        }
                        cell7.empty = false;
                        cell7.usable = true;
                        cell3.usable = true;
                        cell6.usable = true;
                        cell8.usable = true;
                        cell11.usable = true;
                    }
                    else if (temp == cell8 && cell8.empty == true)
                    {
                        cell8.TYPE = this.type;
                        if (cell8.TYPE == 1)
                        {
                            cell8 = new Cell(a8, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(860, 332);
                            l2.ap = new Point(826, 367);
                            l3.ap = new Point(910, 381);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(926, 332);
                            l6.ap = new Point(935, 297);
                            l7.ap = new Point(858, 291);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell8.TYPE == 2)
                        {
                            cell8 = new Cell(a8, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(841, 299);
                            l2.ap = new Point(826, 366);
                            l3.ap = new Point(876, 364);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(911, 383);
                            l6.ap = new Point(925, 314);
                            l7.ap = new Point(876, 299);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell8.TYPE == 3)
                        {
                            cell8 = new Cell(a8, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(851, 332);
                            l2.ap = new Point(826, 367);
                            l3.ap = new Point(876, 347);
                            l4.ap = new Point(911, 383);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(901, 332);
                            l6.ap = new Point(936, 297);
                            l7.ap = new Point(876, 301);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(841, 282);
                            lightlist.Add(l8);
                        }
                        foreach (Input item in cell8.Input())
                        {
                            this.intpulist.Add(item);
                        }
                        cell8.empty = false;
                        cell8.usable = true;
                        cell4.usable = true;
                        cell7.usable = true;
                        cell12.usable = true;
                    }
                    //----------------------row 3
                    else if (temp == cell9 && cell9.empty == true)
                    {
                        cell9.TYPE = this.type;
                        if (cell9.TYPE == 1)
                        {
                            cell9 = new Cell(a9, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(44, 604);
                            l2.ap = new Point(10, 639);
                            l3.ap = new Point(94, 653);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(110, 604);
                            l6.ap = new Point(119, 569);
                            l7.ap = new Point(42, 563);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell9.TYPE == 2)
                        {
                            cell9 = new Cell(a9, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(25, 571);
                            l2.ap = new Point(10, 638);
                            l3.ap = new Point(60, 636);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(95, 655);
                            l6.ap = new Point(109, 586);
                            l7.ap = new Point(60, 571);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell9.TYPE == 3)
                        {
                            cell9 = new Cell(a9, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(35, 604);
                            l2.ap = new Point(10, 639);
                            l3.ap = new Point(60, 619);
                            l4.ap = new Point(95, 655);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(85, 604);
                            l6.ap = new Point(120, 569);
                            l7.ap = new Point(60, 573);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(25, 554);
                            lightlist.Add(l8);
                        }
                        foreach (Input item in cell9.Input())
                        {
                            this.intpulist.Add(item);
                        }
                        cell9.empty = false;
                        cell9.usable = true;
                        cell5.usable = true;
                        cell10.usable = true;
                    }
                    else if (temp == cell10 && cell10.empty == true)
                    {
                        cell10.TYPE = this.type;
                        if (cell10.TYPE == 1)
                        {
                            cell10 = new Cell(a10, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(316, 604);
                            l2.ap = new Point(282, 639);
                            l3.ap = new Point(366, 553);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(382, 604);
                            l6.ap = new Point(391, 569);
                            l7.ap = new Point(314, 563);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell10.TYPE == 2)
                        {
                            cell10 = new Cell(a10, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(297, 571);
                            l2.ap = new Point(282, 638);
                            l3.ap = new Point(332, 636);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(367, 655);
                            l6.ap = new Point(381, 586);
                            l7.ap = new Point(332, 571);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell10.TYPE == 3)
                        {
                            cell10 = new Cell(a10, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(307, 604);
                            l2.ap = new Point(282, 639);
                            l3.ap = new Point(332, 619);
                            l4.ap = new Point(367, 655);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(357, 604);
                            l6.ap = new Point(392, 569);
                            l7.ap = new Point(332, 573);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(297, 554);
                            lightlist.Add(l8);
                        }
                        foreach (Input item in cell10.Input())
                        {
                            this.intpulist.Add(item);
                        }
                        cell10.empty = false;
                        cell10.usable = true;
                        cell6.usable = true;
                        cell9.usable = true;
                        cell11.usable = true;
                    }
                    else if (temp == cell11 && cell11.empty == true)
                    {
                        cell11.TYPE = this.type;
                        if (cell11.TYPE == 1)
                        {
                            cell11 = new Cell(a11, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(608, 564);
                            l2.ap = new Point(554, 639);
                            l3.ap = new Point(638, 653);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(654, 604);
                            l6.ap = new Point(663, 569);
                            l7.ap = new Point(586, 603);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell11.TYPE == 2)
                        {
                            cell11 = new Cell(a11, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(569, 571);
                            l2.ap = new Point(554, 638);
                            l3.ap = new Point(604, 636);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(639, 655);
                            l6.ap = new Point(653, 586);
                            l7.ap = new Point(604, 571);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell11.TYPE == 3)
                        {
                            cell11 = new Cell(a11, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(579, 604);
                            l2.ap = new Point(554, 639);
                            l3.ap = new Point(604, 619);
                            l4.ap = new Point(639, 655);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(629, 604);
                            l6.ap = new Point(664, 569);
                            l7.ap = new Point(604, 573);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(569, 554);
                            lightlist.Add(l8);
                        }
                        foreach (Input item in cell11.Input())
                        {
                            this.intpulist.Add(item);
                        }
                        cell11.empty = false;
                        cell11.usable = true;
                        cell7.usable = true;
                        cell10.usable = true;
                        cell12.usable = true;
                    }
                    else if (temp == cell12 && cell12.empty == true)
                    {
                        cell12.TYPE = this.type;
                        if (cell12.TYPE == 1)
                        {
                            cell12 = new Cell(a12, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(860, 604);
                            l2.ap = new Point(826, 639);
                            l3.ap = new Point(910, 553);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(926, 604);
                            l6.ap = new Point(935, 569);
                            l7.ap = new Point(858, 563);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell12.TYPE == 2)
                        {
                            cell12 = new Cell(a12, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(841, 571);
                            l2.ap = new Point(826, 638);
                            l3.ap = new Point(876, 636);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(911, 655);
                            l6.ap = new Point(925, 586);
                            l7.ap = new Point(876, 571);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell12.TYPE == 3)
                        {
                            cell12 = new Cell(a12, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(851, 604);
                            l2.ap = new Point(826, 639);
                            l3.ap = new Point(876, 619);
                            l4.ap = new Point(911, 655);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(901, 604);
                            l6.ap = new Point(936, 569);
                            l7.ap = new Point(876, 573);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(841, 554);
                            lightlist.Add(l8);
                        }
                        foreach (Input item in cell12.Input())
                        {
                            this.intpulist.Add(item);
                        }
                        cell12.empty = false;
                        cell12.usable = true;
                        cell8.usable = true;
                        cell11.usable = true;
                    }
                    temp = new Cell(a, this.imageList1.Images[0], -1);
                }
                else
                {
                    Point p = new Point(e.X, e.Y);
                    Point a = new Point(-1, -1);
                    Cell temp = new Cell(a, this.imageList1.Images[0], -1);
                    if (cellListNew.Count > 0)
                    {
                        foreach (Cell item in cellListNew)
                        {
                            if (item.GetCell(p) != null)
                            {
                                temp = item;
                            }
                        }
                    }
                    else
                    {
                        foreach (Cell item in cellList)
                        {
                            if (item.GetCell(p) != null)
                            {
                                temp = item;
                            }
                        }
                    }
                    //----------------------row 1
                    if (temp == cell1 && cell1.empty == true && cell1.usable == true)
                    {
                        cell1.TYPE = this.type;
                        if (cell1.TYPE == 1)
                        {
                            cell1 = new Cell(a1, this.ILCR.Images[0], this.type);
                            cell1.TYPE = 1;
                            l1.ap = new Point(44, 60);
                            l2.ap = new Point(10, 95);
                            l3.ap = new Point(94, 109);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(110, 60);
                            l6.ap = new Point(119, 25);
                            l7.ap = new Point(42, 19);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell1.TYPE == 2)
                        {
                            cell1 = new Cell(a1, this.ILCR.Images[1], this.type);
                            cell1.TYPE = 2;
                            l1.ap = new Point(25, 27);
                            l2.ap = new Point(10, 94);
                            l3.ap = new Point(60, 92);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(95, 111);
                            l6.ap = new Point(109, 42);
                            l7.ap = new Point(60, 27);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                        }
                        else if (cell1.TYPE == 3)
                        {
                            cell1 = new Cell(a1, this.ILCR.Images[2], this.type);
                            cell1.TYPE = 3;
                            l1.ap = new Point(35, 60);
                            l2.ap = new Point(10, 95);
                            l3.ap = new Point(60, 75);
                            l4.ap = new Point(95, 111);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(85, 60);
                            l6.ap = new Point(120, 25);
                            l7.ap = new Point(60, 29);
                            l8.ap = new Point(25, 10);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            //    l8.ap = new Point(60, 20);
                            lightlist.Add(l8);

                        }


                        cell1.empty = false;
                        cell1.usable = true;
                        cell2.usable = true;
                        cell5.usable = true;
                        if (cell2.Image != this.imageList1.Images[0])
                        {
                            if (cell1.TYPE == 1)
                            {
                                if (cell2.TYPE == 1)
                                {
                                    this.Rcell1 = new RoadCell(b1, this.ILR.Images[2]);
                                    Rcell1.type = 2;
                                }
                                else if (cell2.TYPE == 2)
                                {
                                    this.Rcell1.Image = this.ILR.Images[6];
                                    Rcell1.type = 6;
                                }
                                else if (cell2.TYPE == 3)
                                {
                                    this.Rcell1.Image = this.ILR.Images[2];
                                    Rcell1.type = 2;
                                }
                            }
                            else if (cell1.TYPE == 2)
                            {
                                if (cell2.TYPE == 1)
                                {
                                    this.Rcell1.Image = this.ILR.Images[4];
                                    Rcell1.type = 4;
                                }
                                else if (cell2.TYPE == 2)
                                {
                                    this.Rcell1.Image = this.ILR.Images[0];
                                    Rcell1.type = 0;
                                }
                                else if (cell2.TYPE == 3)
                                {
                                    this.Rcell1.Image = this.ILR.Images[4];
                                    Rcell1.type = 4;
                                }
                            }
                            else if (cell1.TYPE == 3)
                            {
                                if (cell2.TYPE == 1)
                                {
                                    this.Rcell1.Image = this.ILR.Images[2];
                                    Rcell1.type = 2;
                                }
                                else if (cell2.TYPE == 2)
                                {
                                    this.Rcell1.Image = this.ILR.Images[4];
                                    Rcell1.type = 4;
                                }
                                else if (cell2.TYPE == 3)
                                {
                                    this.Rcell1.Image = this.ILR.Images[2];
                                    Rcell1.type = 2;
                                }
                            }
                        }
                        if (cell5.Image != this.imageList1.Images[0])
                        {
                            if (cell1.TYPE == 1)
                            {
                                if (cell5.TYPE == 1)
                                {
                                    this.Rcell4.Image = this.ILR.Images[1];
                                    Rcell4.type = 1;
                                }
                                else if (cell5.TYPE == 2)
                                {
                                    this.Rcell4.Image = this.ILR.Images[5];
                                    Rcell4.type = 5;
                                }
                                else if (cell5.TYPE == 3)
                                {
                                    this.Rcell4.Image = this.ILR.Images[5];
                                    Rcell4.type = 5;
                                }
                            }
                            else if (cell1.TYPE == 2)
                            {
                                if (cell5.TYPE == 1)
                                {
                                    this.Rcell4.Image = this.ILR.Images[7];
                                    Rcell4.type = 7;
                                }
                                else if (cell5.TYPE == 2)
                                {
                                    this.Rcell4.Image = this.ILR.Images[3];
                                    Rcell4.type = 3;
                                }
                                else if (cell5.TYPE == 3)
                                {
                                    this.Rcell4.Image = this.ILR.Images[3];
                                    Rcell4.type = 3;
                                }
                            }
                            else if (cell1.TYPE == 3)
                            {
                                if (cell5.TYPE == 1)
                                {
                                    this.Rcell4.Image = this.ILR.Images[7];
                                    Rcell4.type = 7;
                                }
                                else if (cell5.TYPE == 2)
                                {
                                    this.Rcell4.Image = this.ILR.Images[3];
                                    Rcell4.type = 3;
                                }
                                else if (cell5.TYPE == 3)
                                {
                                    this.Rcell4.Image = this.ILR.Images[3];
                                    Rcell4.type = 3;
                                }
                            }
                        }

                        foreach (Input item in cell1.Input())
                        {
                            this.intpulist.Add(item);
                        }

                    }
                    else if (temp == cell2 && cell2.empty == true && cell2.usable == true)
                    {
                        cell2.TYPE = this.type;
                        if (cell2.TYPE == 1)
                        {
                            cell2 = new Cell(a2, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(316, 60);
                            l2.ap = new Point(282, 95);
                            l3.ap = new Point(366, 109);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(382, 60);
                            l6.ap = new Point(391, 25);
                            l7.ap = new Point(314, 19);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);


                        }
                        else if (cell2.TYPE == 2)
                        {
                            cell2 = new Cell(a2, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(297, 27);
                            l2.ap = new Point(282, 94);
                            l3.ap = new Point(332, 92);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(367, 111);
                            l6.ap = new Point(381, 42);
                            l7.ap = new Point(332, 27);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell2.TYPE == 3)
                        {
                            cell2 = new Cell(a2, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(307, 60);
                            l2.ap = new Point(282, 95);
                            l3.ap = new Point(332, 75);
                            l4.ap = new Point(367, 111);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(357, 60);
                            l6.ap = new Point(392, 25);
                            l7.ap = new Point(332, 29);
                            l8.ap = new Point(297, 10);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            //  l8.ap = new Point(332, 20);
                            lightlist.Add(l8);

                        }
                        cell2.empty = false;
                        cell2.usable = true;
                        cell1.usable = true;
                        cell3.usable = true;
                        cell6.usable = true;
                        if (cell1.Image != this.imageList1.Images[0])
                        {
                            if (cell2.TYPE == 1)
                            {
                                if (cell1.TYPE == 1)
                                {
                                    this.Rcell1.Image = this.ILR.Images[2];
                                    Rcell1.type = 2;
                                }
                                else if (cell1.TYPE == 2)
                                {
                                    this.Rcell1.Image = this.ILR.Images[4];
                                    Rcell1.type = 4;
                                }
                                else if (cell1.TYPE == 3)
                                {
                                    this.Rcell1.Image = this.ILR.Images[2];
                                    Rcell1.type = 2;
                                }
                            }
                            else if (cell2.TYPE == 2)
                            {
                                if (cell1.TYPE == 1)
                                {
                                    this.Rcell1.Image = this.ILR.Images[6];
                                    Rcell1.type = 6;
                                }
                                else if (cell1.TYPE == 2)
                                {
                                    this.Rcell1.Image = this.ILR.Images[0];
                                    Rcell1.type = 0;
                                }
                                else if (cell1.TYPE == 3)
                                {
                                    this.Rcell1.Image = this.ILR.Images[6];
                                    Rcell1.type = 6;
                                }
                            }
                            else if (cell2.TYPE == 3)
                            {
                                if (cell1.TYPE == 1)
                                {
                                    this.Rcell1.Image = this.ILR.Images[2];
                                    Rcell1.type = 2;
                                }
                                else if (cell1.TYPE == 2)
                                {
                                    this.Rcell1.Image = this.ILR.Images[4];
                                    Rcell1.type = 4;
                                }
                                else if (cell1.TYPE == 3)
                                {
                                    this.Rcell1.Image = this.ILR.Images[2];
                                    Rcell1.type = 2;
                                }
                            }
                        }
                        if (cell3.Image != this.imageList1.Images[0])
                        {
                            if (cell2.TYPE == 1)
                            {
                                if (cell3.TYPE == 1)
                                {
                                    this.Rcell2.Image = this.ILR.Images[2];
                                    Rcell2.type = 2;
                                }
                                else if (cell3.TYPE == 2)
                                {
                                    this.Rcell2.Image = this.ILR.Images[6];
                                    Rcell2.type = 6;
                                }
                                else if (cell3.TYPE == 3)
                                {
                                    this.Rcell2.Image = this.ILR.Images[2];
                                    Rcell2.type = 2;
                                }
                            }
                            else if (cell2.TYPE == 2)
                            {
                                if (cell3.TYPE == 1)
                                {
                                    this.Rcell2.Image = this.ILR.Images[4];
                                    Rcell2.type = 4;
                                }
                                else if (cell3.TYPE == 2)
                                {
                                    this.Rcell2.Image = this.ILR.Images[0];
                                    Rcell2.type = 0;
                                }
                                else if (cell3.TYPE == 3)
                                {
                                    this.Rcell2.Image = this.ILR.Images[4];
                                    Rcell2.type = 4;
                                }
                            }
                            else if (cell2.TYPE == 3)
                            {
                                if (cell3.TYPE == 1)
                                {
                                    this.Rcell2.Image = this.ILR.Images[2];
                                    Rcell2.type = 2;
                                }
                                else if (cell3.TYPE == 2)
                                {
                                    this.Rcell2.Image = this.ILR.Images[6];
                                    Rcell2.type = 6;
                                }
                                else if (cell3.TYPE == 3)
                                {
                                    this.Rcell2.Image = this.ILR.Images[2];
                                    Rcell2.type = 2;
                                }
                            }
                        }
                        if (cell6.Image != this.imageList1.Images[0])
                        {
                            if (cell2.TYPE == 1)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell5.Image = this.ILR.Images[1];
                                    Rcell5.type = 1;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell5.Image = this.ILR.Images[5];
                                    Rcell5.type = 5;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell5.Image = this.ILR.Images[5];
                                    Rcell5.type = 5;
                                }
                            }
                            else if (cell2.TYPE == 2)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell5.Image = this.ILR.Images[7];
                                    Rcell5.type = 7;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell5.Image = this.ILR.Images[3];
                                    Rcell5.type = 3;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell5.Image = this.ILR.Images[3];
                                    Rcell5.type = 3;
                                }
                            }
                            else if (cell2.TYPE == 3)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell5.Image = this.ILR.Images[8];
                                    Rcell5.type = 8;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell5.Image = this.ILR.Images[3];
                                    Rcell5.type = 3;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell5.Image = this.ILR.Images[3];
                                    Rcell5.type = 3;
                                }
                            }
                        }

                        foreach (Input item in cell2.Input())
                        {
                            this.intpulist.Add(item);
                        }

                    }
                    else if (temp == cell3 && cell3.empty == true && cell3.usable == true)
                    {
                        cell3.TYPE = this.type;
                        if (cell3.TYPE == 1)
                        {
                            cell3 = new Cell(a3, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(588, 60);
                            l2.ap = new Point(554, 95);
                            l3.ap = new Point(638, 109);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(654, 60);
                            l6.ap = new Point(663, 25);
                            l7.ap = new Point(586, 19);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell3.TYPE == 2)
                        {
                            cell3 = new Cell(a3, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(569, 27);
                            l2.ap = new Point(554, 94);
                            l3.ap = new Point(604, 92);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(639, 111);
                            l6.ap = new Point(653, 42);
                            l7.ap = new Point(604, 27);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell3.TYPE == 3)
                        {
                            cell3 = new Cell(a3, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(579, 60);
                            l2.ap = new Point(554, 95);
                            l3.ap = new Point(604, 75);
                            l4.ap = new Point(639, 111);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(629, 60);
                            l6.ap = new Point(664, 25);
                            l7.ap = new Point(604, 29);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(569, 10);
                            lightlist.Add(l8);

                        }
                        cell3.empty = false;
                        cell3.usable = true;
                        cell2.usable = true;
                        cell4.usable = true;
                        cell7.usable = true;
                        if (cell2.Image != this.imageList1.Images[0])
                        {
                            if (cell3.TYPE == 1)
                            {
                                if (cell2.TYPE == 1)
                                {
                                    this.Rcell2.Image = this.ILR.Images[2];
                                    Rcell2.type = 2;
                                }
                                else if (cell2.TYPE == 2)
                                {
                                    this.Rcell2.Image = this.ILR.Images[4];
                                    Rcell2.type = 4;
                                }
                                else if (cell2.TYPE == 3)
                                {
                                    this.Rcell2.Image = this.ILR.Images[2];
                                    Rcell2.type = 2;
                                }
                            }
                            else if (cell3.TYPE == 2)
                            {
                                if (cell2.TYPE == 1)
                                {
                                    this.Rcell2.Image = this.ILR.Images[6];
                                    Rcell2.type = 6;
                                }
                                else if (cell2.TYPE == 2)
                                {
                                    this.Rcell2.Image = this.ILR.Images[0];
                                    Rcell2.type = 0;
                                }
                                else if (cell2.TYPE == 3)
                                {
                                    this.Rcell2.Image = this.ILR.Images[6];
                                    Rcell2.type = 6;
                                }
                            }
                            else if (cell3.TYPE == 3)
                            {
                                if (cell2.TYPE == 1)
                                {
                                    this.Rcell2.Image = this.ILR.Images[2];
                                    Rcell2.type = 2;
                                }
                                else if (cell2.TYPE == 2)
                                {
                                    this.Rcell2.Image = this.ILR.Images[4];
                                    Rcell2.type = 4;
                                }
                                else if (cell2.TYPE == 3)
                                {
                                    this.Rcell2.Image = this.ILR.Images[2];
                                    Rcell2.type = 2;
                                }
                            }
                        }
                        if (cell4.Image != this.imageList1.Images[0])
                        {
                            if (cell3.TYPE == 1)
                            {
                                if (cell4.TYPE == 1)
                                {
                                    this.Rcell3.Image = this.ILR.Images[2];
                                    Rcell3.type = 2;
                                }
                                else if (cell4.TYPE == 2)
                                {
                                    this.Rcell3.Image = this.ILR.Images[6];
                                    Rcell3.type = 6;
                                }
                                else if (cell4.TYPE == 3)
                                {
                                    this.Rcell3.Image = this.ILR.Images[2];
                                    Rcell3.type = 2;
                                }
                            }
                            else if (cell3.TYPE == 2)
                            {
                                if (cell4.TYPE == 1)
                                {
                                    this.Rcell3.Image = this.ILR.Images[4];
                                    Rcell3.type = 4;
                                }
                                else if (cell4.TYPE == 2)
                                {
                                    this.Rcell3.Image = this.ILR.Images[0];
                                    Rcell3.type = 0;
                                }
                                else if (cell4.TYPE == 3)
                                {
                                    this.Rcell3.Image = this.ILR.Images[4];
                                    Rcell3.type = 4;
                                }
                            }
                            else if (cell3.TYPE == 3)
                            {
                                if (cell4.TYPE == 1)
                                {
                                    this.Rcell3.Image = this.ILR.Images[2];
                                    Rcell3.type = 2;
                                }
                                else if (cell4.TYPE == 2)
                                {
                                    this.Rcell3.Image = this.ILR.Images[6];
                                    Rcell3.type = 6;
                                }
                                else if (cell4.TYPE == 3)
                                {
                                    this.Rcell3.Image = this.ILR.Images[2];
                                    Rcell3.type = 2;
                                }
                            }
                        }
                        if (cell7.Image != this.imageList1.Images[0])
                        {
                            if (cell3.TYPE == 1)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell6.Image = this.ILR.Images[1];
                                    Rcell6.type = 1;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell6.Image = this.ILR.Images[5];
                                    Rcell6.type = 5;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell6.Image = this.ILR.Images[5];
                                    Rcell6.type = 5;
                                }
                            }
                            else if (cell3.TYPE == 2)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell6.Image = this.ILR.Images[7];
                                    Rcell6.type = 7;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell6.Image = this.ILR.Images[3];
                                    Rcell6.type = 3;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell6.Image = this.ILR.Images[3];
                                    Rcell6.type = 3;
                                }
                            }
                            else if (cell3.TYPE == 3)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell6.Image = this.ILR.Images[7];
                                    Rcell6.type = 7;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell6.Image = this.ILR.Images[3];
                                    Rcell6.type = 3;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell6.Image = this.ILR.Images[3];
                                    Rcell6.type = 3;
                                }
                            }
                        }

                        foreach (Input item in cell3.Input())
                        {
                            this.intpulist.Add(item);
                        }
                    }
                    else if (temp == cell4 && cell4.empty == true && cell4.usable == true)
                    {
                        cell4.TYPE = this.type;
                        if (cell4.TYPE == 1)
                        {
                            cell4 = new Cell(a4, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(860, 60);
                            l2.ap = new Point(826, 95);
                            l3.ap = new Point(910, 109);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(926, 60);
                            l6.ap = new Point(935, 25);
                            l7.ap = new Point(858, 19);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell4.TYPE == 2)
                        {
                            cell4 = new Cell(a4, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(841, 27);
                            l2.ap = new Point(826, 94);
                            l3.ap = new Point(876, 92);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(911, 111);
                            l6.ap = new Point(925, 42);
                            l7.ap = new Point(876, 27);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell4.TYPE == 3)
                        {
                            cell4 = new Cell(a4, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(851, 60);
                            l2.ap = new Point(826, 95);
                            l3.ap = new Point(876, 75);
                            l4.ap = new Point(911, 111);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(901, 60);
                            l6.ap = new Point(936, 25);
                            l7.ap = new Point(876, 29);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(841, 10);
                            lightlist.Add(l8);

                        }
                        cell4.empty = false;
                        cell4.usable = true;
                        cell3.usable = true;
                        cell8.usable = true;
                        if (cell3.Image != this.imageList1.Images[0])
                        {
                            if (cell4.TYPE == 1)
                            {
                                if (cell3.TYPE == 1)
                                {
                                    this.Rcell3.Image = this.ILR.Images[2];
                                    Rcell3.type = 2;
                                }
                                else if (cell3.TYPE == 2)
                                {
                                    this.Rcell3.Image = this.ILR.Images[4];
                                    Rcell3.type = 4;
                                }
                                else if (cell3.TYPE == 3)
                                {
                                    this.Rcell3.Image = this.ILR.Images[2];
                                    Rcell3.type = 2;
                                }
                            }
                            else if (cell4.TYPE == 2)
                            {
                                if (cell3.TYPE == 1)
                                {
                                    this.Rcell3.Image = this.ILR.Images[6];
                                    Rcell3.type = 6;
                                }
                                else if (cell3.TYPE == 2)
                                {
                                    this.Rcell3.Image = this.ILR.Images[0];
                                    Rcell3.type = 0;
                                }
                                else if (cell3.TYPE == 3)
                                {
                                    this.Rcell3.Image = this.ILR.Images[6];
                                    Rcell3.type = 6;
                                }
                            }
                            else if (cell4.TYPE == 3)
                            {
                                if (cell3.TYPE == 1)
                                {
                                    this.Rcell3.Image = this.ILR.Images[2];
                                    Rcell3.type = 2;
                                }
                                else if (cell3.TYPE == 2)
                                {
                                    this.Rcell3.Image = this.ILR.Images[4];
                                    Rcell3.type = 4;
                                }
                                else if (cell3.TYPE == 3)
                                {
                                    this.Rcell3.Image = this.ILR.Images[2];
                                    Rcell3.type = 2;
                                }
                            }
                        }
                        if (cell8.Image != this.imageList1.Images[0])
                        {
                            if (cell4.TYPE == 1)
                            {
                                if (cell8.TYPE == 1)
                                {
                                    this.Rcell7.Image = this.ILR.Images[1];
                                    Rcell7.type = 1;
                                }
                                else if (cell8.TYPE == 2)
                                {
                                    this.Rcell7.Image = this.ILR.Images[5];
                                    Rcell7.type = 5;
                                }
                                else if (cell8.TYPE == 3)
                                {
                                    this.Rcell7.Image = this.ILR.Images[5];
                                    Rcell7.type = 5;
                                }
                            }
                            else if (cell4.TYPE == 2)
                            {
                                if (cell8.TYPE == 1)
                                {
                                    this.Rcell7.Image = this.ILR.Images[7];
                                    Rcell7.type = 7;
                                }
                                else if (cell8.TYPE == 2)
                                {
                                    this.Rcell7.Image = this.ILR.Images[3];
                                    Rcell7.type = 3;
                                }
                                else if (cell8.TYPE == 3)
                                {
                                    this.Rcell7.Image = this.ILR.Images[3];
                                    Rcell7.type = 3;
                                }
                            }
                            else if (cell4.TYPE == 3)
                            {
                                if (cell8.TYPE == 1)
                                {
                                    this.Rcell7.Image = this.ILR.Images[7];
                                    Rcell7.type = 7;
                                }
                                else if (cell8.TYPE == 2)
                                {
                                    this.Rcell7.Image = this.ILR.Images[3];
                                    Rcell7.type = 3;
                                }
                                else if (cell8.TYPE == 3)
                                {
                                    this.Rcell7.Image = this.ILR.Images[3];
                                    Rcell7.type = 3;
                                }
                            }
                        }

                        foreach (Input item in cell4.Input())
                        {
                            this.intpulist.Add(item);
                        }

                    }
                    //------------------------row 2
                    if (temp == cell5 && cell5.empty == true && cell5.usable == true)
                    {
                        cell5.TYPE = this.type;
                        if (cell5.TYPE == 1)
                        {
                            cell5 = new Cell(a5, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(44, 332);
                            l2.ap = new Point(10, 367);
                            l3.ap = new Point(94, 381);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(110, 332);
                            l6.ap = new Point(119, 297);
                            l7.ap = new Point(42, 291);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell5.TYPE == 2)
                        {
                            cell5 = new Cell(a5, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(25, 299);
                            l2.ap = new Point(10, 366);
                            l3.ap = new Point(60, 364);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(95, 383);
                            l6.ap = new Point(109, 314);
                            l7.ap = new Point(60, 299);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell5.TYPE == 3)
                        {
                            cell5 = new Cell(a5, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(35, 332);
                            l2.ap = new Point(10, 367);
                            l3.ap = new Point(60, 347);
                            l4.ap = new Point(95, 383);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(85, 332);
                            l6.ap = new Point(120, 297);
                            l7.ap = new Point(60, 301);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(25, 282);
                            lightlist.Add(l8);

                        }
                        cell5.empty = false;
                        cell5.usable = true;
                        cell1.usable = true;
                        cell6.usable = true;
                        cell9.usable = true;
                        if (cell1.Image != this.imageList1.Images[0])
                        {
                            if (cell5.TYPE == 1)
                            {
                                if (cell1.TYPE == 1)
                                {
                                    this.Rcell4.Image = this.ILR.Images[1];
                                    Rcell4.type = 1;
                                }
                                else if (cell1.TYPE == 2)
                                {
                                    this.Rcell4.Image = this.ILR.Images[7];
                                    Rcell4.type = 7;
                                }
                                else if (cell1.TYPE == 3)
                                {
                                    this.Rcell4.Image = this.ILR.Images[7];
                                    Rcell4.type = 7;
                                }
                            }
                            else if (cell5.TYPE == 2)
                            {
                                if (cell1.TYPE == 1)
                                {
                                    this.Rcell4.Image = this.ILR.Images[5];
                                    Rcell4.type = 5;
                                }
                                else if (cell1.TYPE == 2)
                                {
                                    this.Rcell4.Image = this.ILR.Images[3];
                                    Rcell4.type = 3;
                                }
                                else if (cell1.TYPE == 3)
                                {
                                    this.Rcell4.Image = this.ILR.Images[3];
                                    Rcell4.type = 3;
                                }
                            }
                            else if (cell5.TYPE == 3)
                            {
                                if (cell1.TYPE == 1)
                                {
                                    this.Rcell4.Image = this.ILR.Images[5];
                                    Rcell4.type = 5;
                                }
                                else if (cell1.TYPE == 2)
                                {
                                    this.Rcell4.Image = this.ILR.Images[3];
                                    Rcell4.type = 3;
                                }
                                else if (cell1.TYPE == 3)
                                {
                                    this.Rcell4.Image = this.ILR.Images[3];
                                    Rcell4.type = 3;
                                }
                            }
                        }
                        if (cell6.Image != this.imageList1.Images[0])
                        {
                            if (cell5.TYPE == 1)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell8.Image = this.ILR.Images[2];
                                    Rcell8.type = 2;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell8.Image = this.ILR.Images[6];
                                    Rcell8.type = 6;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell8.Image = this.ILR.Images[2];
                                    Rcell8.type = 2;
                                }
                            }
                            else if (cell5.TYPE == 2)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell8.Image = this.ILR.Images[4];
                                    Rcell8.type = 4;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell8.Image = this.ILR.Images[0];
                                    Rcell8.type = 0;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell8.Image = this.ILR.Images[4];
                                    Rcell8.type = 4;
                                }
                            }
                            else if (cell5.TYPE == 3)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell8.Image = this.ILR.Images[2];
                                    Rcell8.type = 2;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell8.Image = this.ILR.Images[6];
                                    Rcell8.type = 6;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell8.Image = this.ILR.Images[2];
                                    Rcell8.type = 2;
                                }
                            }
                        }
                        if (cell9.Image != this.imageList1.Images[0])
                        {
                            if (cell5.TYPE == 1)
                            {
                                if (cell9.TYPE == 1)
                                {
                                    this.Rcell11.Image = this.ILR.Images[1];
                                    Rcell11.type = 1;
                                }
                                else if (cell9.TYPE == 2)
                                {
                                    this.Rcell11.Image = this.ILR.Images[5];
                                    Rcell11.type = 5;
                                }
                                else if (cell9.TYPE == 3)
                                {
                                    this.Rcell11.Image = this.ILR.Images[5];
                                    Rcell11.type = 5;
                                }
                            }
                            else if (cell5.TYPE == 2)
                            {
                                if (cell9.TYPE == 1)
                                {
                                    this.Rcell11.Image = this.ILR.Images[7];
                                    Rcell11.type = 7;
                                }
                                else if (cell9.TYPE == 2)
                                {
                                    this.Rcell11.Image = this.ILR.Images[3];
                                    Rcell11.type = 3;
                                }
                                else if (cell9.TYPE == 3)
                                {
                                    this.Rcell11.Image = this.ILR.Images[3];
                                    Rcell11.type = 3;
                                }
                            }
                            else if (cell5.TYPE == 3)
                            {
                                if (cell9.TYPE == 1)
                                {
                                    this.Rcell11.Image = this.ILR.Images[7];
                                    Rcell11.type = 7;
                                }
                                else if (cell9.TYPE == 2)
                                {
                                    this.Rcell11.Image = this.ILR.Images[3];
                                    Rcell11.type = 3;
                                }
                                else if (cell9.TYPE == 3)
                                {
                                    this.Rcell11.Image = this.ILR.Images[3];
                                    Rcell11.type = 3;
                                }
                            }
                        }

                        foreach (Input item in cell5.Input())
                        {
                            this.intpulist.Add(item);
                        }

                    }
                    else if (temp == cell6 && cell6.empty == true && cell6.usable == true)
                    {
                        cell6.TYPE = this.type;
                        if (cell6.TYPE == 1)
                        {
                            cell6 = new Cell(a6, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(316, 332);
                            l2.ap = new Point(282, 367);
                            l3.ap = new Point(366, 381);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(382, 332);
                            l6.ap = new Point(391, 297);
                            l7.ap = new Point(314, 291);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell6.TYPE == 2)
                        {
                            cell6 = new Cell(a6, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(297, 299);
                            l2.ap = new Point(282, 366);
                            l3.ap = new Point(332, 364);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(367, 383);
                            l6.ap = new Point(381, 314);
                            l7.ap = new Point(332, 299);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell6.TYPE == 3)
                        {
                            cell6 = new Cell(a6, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(307, 332);
                            l2.ap = new Point(282, 367);
                            l3.ap = new Point(332, 347);
                            l4.ap = new Point(367, 383);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(357, 332);
                            l6.ap = new Point(392, 297);
                            l7.ap = new Point(332, 301);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(297, 282);
                            lightlist.Add(l8);

                        }
                        cell6.empty = false;
                        cell6.usable = true;
                        cell2.usable = true;
                        cell5.usable = true;
                        cell7.usable = true;
                        cell10.usable = true;
                        if (cell2.Image != this.imageList1.Images[0])
                        {
                            if (cell6.TYPE == 1)
                            {
                                if (cell2.TYPE == 1)
                                {
                                    this.Rcell5.Image = this.ILR.Images[1];
                                    Rcell5.type = 1;
                                }
                                else if (cell2.TYPE == 2)
                                {
                                    this.Rcell5.Image = this.ILR.Images[7];
                                    Rcell5.type = 7;
                                }
                                else if (cell2.TYPE == 3)
                                {
                                    this.Rcell5.Image = this.ILR.Images[7];
                                    Rcell5.type = 7;
                                }
                            }
                            else if (cell6.TYPE == 2)
                            {
                                if (cell2.TYPE == 1)
                                {
                                    this.Rcell5.Image = this.ILR.Images[5];
                                    Rcell5.type = 5;
                                }
                                else if (cell2.TYPE == 2)
                                {
                                    this.Rcell5.Image = this.ILR.Images[3];
                                    Rcell5.type = 3;
                                }
                                else if (cell2.TYPE == 3)
                                {
                                    this.Rcell5.Image = this.ILR.Images[3];
                                    Rcell5.type = 3;
                                }
                            }
                            else if (cell6.TYPE == 3)
                            {
                                if (cell2.TYPE == 1)
                                {
                                    this.Rcell5.Image = this.ILR.Images[5];
                                    Rcell5.type = 5;
                                }
                                else if (cell2.TYPE == 2)
                                {
                                    this.Rcell5.Image = this.ILR.Images[3];
                                    Rcell5.type = 3;
                                }
                                else if (cell2.TYPE == 3)
                                {
                                    this.Rcell5.Image = this.ILR.Images[3];
                                    Rcell5.type = 3;
                                }
                            }
                        }
                        if (cell5.Image != this.imageList1.Images[0])
                        {
                            if (cell6.TYPE == 1)
                            {
                                if (cell5.TYPE == 1)
                                {
                                    this.Rcell8.Image = this.ILR.Images[2];
                                    Rcell8.type = 2;
                                }
                                else if (cell5.TYPE == 2)
                                {
                                    this.Rcell8.Image = this.ILR.Images[4];
                                    Rcell8.type = 4;
                                }
                                else if (cell5.TYPE == 3)
                                {
                                    this.Rcell8.Image = this.ILR.Images[2];
                                    Rcell8.type = 2;
                                }
                            }
                            else if (cell6.TYPE == 2)
                            {
                                if (cell5.TYPE == 1)
                                {
                                    this.Rcell8.Image = this.ILR.Images[6];
                                    Rcell8.type = 6;
                                }
                                else if (cell5.TYPE == 2)
                                {
                                    this.Rcell8.Image = this.ILR.Images[0];
                                    Rcell8.type = 0;
                                }
                                else if (cell5.TYPE == 3)
                                {
                                    this.Rcell8.Image = this.ILR.Images[2];
                                    Rcell8.type = 2;
                                }
                            }
                            else if (cell6.TYPE == 3)
                            {
                                if (cell5.TYPE == 1)
                                {
                                    this.Rcell8.Image = this.ILR.Images[2];
                                    Rcell8.type = 2;
                                }
                                else if (cell5.TYPE == 2)
                                {
                                    this.Rcell8.Image = this.ILR.Images[4];
                                    Rcell8.type = 4;
                                }
                                else if (cell5.TYPE == 3)
                                {
                                    this.Rcell8.Image = this.ILR.Images[2];
                                    Rcell8.type = 2;
                                }
                            }
                        }
                        if (cell7.Image != this.imageList1.Images[0])
                        {
                            if (cell6.TYPE == 1)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell9.Image = this.ILR.Images[2];
                                    Rcell9.type = 2;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell9.Image = this.ILR.Images[6];
                                    Rcell9.type = 6;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell9.Image = this.ILR.Images[2];
                                    Rcell9.type = 2;
                                }
                            }
                            else if (cell6.TYPE == 2)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell9.Image = this.ILR.Images[4];
                                    Rcell9.type = 4;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell9.Image = this.ILR.Images[0];
                                    Rcell9.type = 0;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell9.Image = this.ILR.Images[4];
                                    Rcell9.type = 4;
                                }
                            }
                            else if (cell6.TYPE == 3)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell9.Image = this.ILR.Images[2];
                                    Rcell9.type = 2;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell9.Image = this.ILR.Images[6];
                                    Rcell9.type = 6;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell9.Image = this.ILR.Images[2];
                                    Rcell9.type = 2;
                                }
                            }
                        }
                        if (cell10.Image != this.imageList1.Images[0])
                        {
                            if (cell6.TYPE == 1)
                            {
                                if (cell10.TYPE == 1)
                                {
                                    this.Rcell12.Image = this.ILR.Images[1];
                                    Rcell12.type = 1;
                                }
                                else if (cell10.TYPE == 2)
                                {
                                    this.Rcell12.Image = this.ILR.Images[5];
                                    Rcell12.type = 5;
                                }
                                else if (cell10.TYPE == 3)
                                {
                                    this.Rcell12.Image = this.ILR.Images[5];
                                    Rcell12.type = 5;
                                }
                            }
                            else if (cell6.TYPE == 2)
                            {
                                if (cell10.TYPE == 1)
                                {
                                    this.Rcell12.Image = this.ILR.Images[7];
                                    Rcell12.type = 7;
                                }
                                else if (cell10.TYPE == 2)
                                {
                                    this.Rcell12.Image = this.ILR.Images[3];
                                    Rcell12.type = 3;
                                }
                                else if (cell10.TYPE == 3)
                                {
                                    this.Rcell12.Image = this.ILR.Images[3];
                                    Rcell12.type = 3;
                                }
                            }
                            else if (cell6.TYPE == 3)
                            {
                                if (cell10.TYPE == 1)
                                {
                                    this.Rcell12.Image = this.ILR.Images[7];
                                    Rcell12.type = 7;
                                }
                                else if (cell10.TYPE == 2)
                                {
                                    this.Rcell12.Image = this.ILR.Images[3];
                                    Rcell12.type = 3;
                                }
                                else if (cell10.TYPE == 3)
                                {
                                    this.Rcell12.Image = this.ILR.Images[3];
                                    Rcell12.type = 3;
                                }
                            }
                        }

                        foreach (Input item in cell6.Input())
                        {
                            this.intpulist.Add(item);
                        }
                    }
                    else if (temp == cell7 && cell7.empty == true && cell7.usable == true)
                    {
                        cell7.TYPE = this.type;
                        if (cell7.TYPE == 1)
                        {
                            cell7 = new Cell(a7, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(588, 332);
                            l2.ap = new Point(554, 367);
                            l3.ap = new Point(638, 381);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(654, 332);
                            l6.ap = new Point(663, 297);
                            l7.ap = new Point(586, 291);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);


                        }
                        else if (cell7.TYPE == 2)
                        {
                            cell7 = new Cell(a7, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(569, 299);
                            l2.ap = new Point(554, 366);
                            l3.ap = new Point(604, 364);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(639, 383);
                            l6.ap = new Point(653, 314);
                            l7.ap = new Point(604, 299);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);


                        }
                        else if (cell7.TYPE == 3)
                        {
                            cell7 = new Cell(a7, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(579, 332);
                            l2.ap = new Point(554, 367);
                            l3.ap = new Point(604, 347);
                            l4.ap = new Point(639, 383);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(629, 332);
                            l6.ap = new Point(664, 297);
                            l7.ap = new Point(604, 301);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(569, 282);
                            lightlist.Add(l8);

                        }
                        cell7.empty = false;
                        cell7.usable = true;
                        cell3.usable = true;
                        cell6.usable = true;
                        cell8.usable = true;
                        cell11.usable = true;
                        if (cell3.Image != this.imageList1.Images[0])
                        {
                            if (cell7.TYPE == 1)
                            {
                                if (cell3.TYPE == 1)
                                {
                                    this.Rcell6.Image = this.ILR.Images[1];
                                    Rcell6.type = 1;
                                }
                                else if (cell3.TYPE == 2)
                                {
                                    this.Rcell6.Image = this.ILR.Images[7];
                                    Rcell6.type = 7;
                                }
                                else if (cell3.TYPE == 3)
                                {
                                    this.Rcell6.Image = this.ILR.Images[7];
                                    Rcell6.type = 7;
                                }
                            }
                            else if (cell7.TYPE == 2)
                            {
                                if (cell3.TYPE == 1)
                                {
                                    this.Rcell6.Image = this.ILR.Images[5];
                                    Rcell6.type = 5;
                                }
                                else if (cell3.TYPE == 2)
                                {
                                    this.Rcell6.Image = this.ILR.Images[3];
                                    Rcell6.type = 3;
                                }
                                else if (cell3.TYPE == 3)
                                {
                                    this.Rcell6.Image = this.ILR.Images[3];
                                    Rcell6.type = 3;
                                }
                            }
                            else if (cell7.TYPE == 3)
                            {
                                if (cell3.TYPE == 1)
                                {
                                    this.Rcell6.Image = this.ILR.Images[5];
                                    Rcell6.type = 5;
                                }
                                else if (cell3.TYPE == 2)
                                {
                                    this.Rcell6.Image = this.ILR.Images[3];
                                    Rcell6.type = 3;
                                }
                                else if (cell3.TYPE == 3)
                                {
                                    this.Rcell6.Image = this.ILR.Images[3];
                                    Rcell6.type = 3;
                                }
                            }
                        }
                        if (cell6.Image != this.imageList1.Images[0])
                        {
                            if (cell7.TYPE == 1)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell9.Image = this.ILR.Images[2];
                                    Rcell9.type = 2;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell9.Image = this.ILR.Images[4];
                                    Rcell9.type = 4;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell9.Image = this.ILR.Images[2];
                                    Rcell9.type = 2;
                                }
                            }
                            else if (cell7.TYPE == 2)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell9.Image = this.ILR.Images[6];
                                    Rcell9.type = 6;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell9.Image = this.ILR.Images[0];
                                    Rcell9.type = 0;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell9.Image = this.ILR.Images[2];
                                    Rcell9.type = 2;
                                }
                            }
                            else if (cell7.TYPE == 3)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell9.Image = this.ILR.Images[2];
                                    Rcell9.type = 2;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell9.Image = this.ILR.Images[4];
                                    Rcell9.type = 4;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell9.Image = this.ILR.Images[2];
                                    Rcell9.type = 2;
                                }
                            }
                        }
                        if (cell8.Image != this.imageList1.Images[0])
                        {
                            if (cell7.TYPE == 1)
                            {
                                if (cell8.TYPE == 1)
                                {
                                    this.Rcell10.Image = this.ILR.Images[2];
                                    Rcell10.type = 2;
                                }
                                else if (cell8.TYPE == 2)
                                {
                                    this.Rcell10.Image = this.ILR.Images[6];
                                    Rcell10.type = 6;
                                }
                                else if (cell8.TYPE == 3)
                                {
                                    this.Rcell10.Image = this.ILR.Images[2];
                                    Rcell10.type = 2;
                                }
                            }
                            else if (cell7.TYPE == 2)
                            {
                                if (cell8.TYPE == 1)
                                {
                                    this.Rcell10.Image = this.ILR.Images[4];
                                    Rcell10.type = 4;
                                }
                                else if (cell8.TYPE == 2)
                                {
                                    this.Rcell10.Image = this.ILR.Images[0];
                                    Rcell10.type = 0;
                                }
                                else if (cell8.TYPE == 3)
                                {
                                    this.Rcell10.Image = this.ILR.Images[4];
                                    Rcell10.type = 4;
                                }
                            }
                            else if (cell7.TYPE == 3)
                            {
                                if (cell8.TYPE == 1)
                                {
                                    this.Rcell10.Image = this.ILR.Images[2];
                                    Rcell10.type = 2;
                                }
                                else if (cell8.TYPE == 2)
                                {
                                    this.Rcell10.Image = this.ILR.Images[6];
                                    Rcell10.type = 6;
                                }
                                else if (cell8.TYPE == 3)
                                {
                                    this.Rcell10.Image = this.ILR.Images[2];
                                    Rcell10.type = 2;
                                }
                            }
                        }
                        if (cell11.Image != this.imageList1.Images[0])
                        {
                            if (cell7.TYPE == 1)
                            {
                                if (cell11.TYPE == 1)
                                {
                                    this.Rcell13.Image = this.ILR.Images[1];
                                    Rcell13.type = 1;
                                }
                                else if (cell11.TYPE == 2)
                                {
                                    this.Rcell13.Image = this.ILR.Images[5];
                                    Rcell13.type = 5;
                                }
                                else if (cell11.TYPE == 3)
                                {
                                    this.Rcell13.Image = this.ILR.Images[5];
                                    Rcell13.type = 5;
                                }
                            }
                            else if (cell7.TYPE == 2)
                            {
                                if (cell11.TYPE == 1)
                                {
                                    this.Rcell13.Image = this.ILR.Images[7];
                                    Rcell13.type = 7;
                                }
                                else if (cell11.TYPE == 2)
                                {
                                    this.Rcell13.Image = this.ILR.Images[3];
                                    Rcell13.type = 3;
                                }
                                else if (cell11.TYPE == 3)
                                {
                                    this.Rcell13.Image = this.ILR.Images[3];
                                    Rcell13.type = 3;
                                }
                            }
                            else if (cell7.TYPE == 3)
                            {
                                if (cell11.TYPE == 1)
                                {
                                    this.Rcell13.Image = this.ILR.Images[7];
                                    Rcell13.type = 7;
                                }
                                else if (cell11.TYPE == 2)
                                {
                                    this.Rcell13.Image = this.ILR.Images[3];
                                    Rcell13.type = 3;
                                }
                                else if (cell11.TYPE == 3)
                                {
                                    this.Rcell13.Image = this.ILR.Images[3];
                                    Rcell13.type = 3;
                                }
                            }
                        }

                        foreach (Input item in cell7.Input())
                        {
                            this.intpulist.Add(item);
                        }

                    }
                    else if (temp == cell8 && cell8.empty == true && cell8.usable == true)
                    {
                        cell8.TYPE = this.type;
                        if (cell8.TYPE == 1)
                        {
                            cell8 = new Cell(a8, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(860, 332);
                            l2.ap = new Point(826, 367);
                            l3.ap = new Point(910, 381);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(926, 332);
                            l6.ap = new Point(935, 297);
                            l7.ap = new Point(858, 291);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell8.TYPE == 2)
                        {
                            cell8 = new Cell(a8, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(841, 299);
                            l2.ap = new Point(826, 366);
                            l3.ap = new Point(876, 364);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(911, 383);
                            l6.ap = new Point(925, 314);
                            l7.ap = new Point(876, 299);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell8.TYPE == 3)
                        {
                            cell8 = new Cell(a8, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(851, 332);
                            l2.ap = new Point(826, 367);
                            l3.ap = new Point(876, 347);
                            l4.ap = new Point(911, 383);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(901, 332);
                            l6.ap = new Point(936, 297);
                            l7.ap = new Point(876, 301);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(841, 282);
                            lightlist.Add(l8);

                        }
                        cell8.empty = false;
                        cell8.usable = true;
                        cell4.usable = true;
                        cell7.usable = true;
                        cell12.usable = true;
                        if (cell4.Image != this.imageList1.Images[0])
                        {
                            if (cell8.TYPE == 1)
                            {
                                if (cell4.TYPE == 1)
                                {
                                    this.Rcell7.Image = this.ILR.Images[1];
                                    Rcell7.type = 1;
                                }
                                else if (cell4.TYPE == 2)
                                {
                                    this.Rcell7.Image = this.ILR.Images[7];
                                    Rcell7.type = 7;
                                }
                                else if (cell4.TYPE == 3)
                                {
                                    this.Rcell7.Image = this.ILR.Images[7];
                                    Rcell7.type = 7;
                                }
                            }
                            else if (cell8.TYPE == 2)
                            {
                                if (cell4.TYPE == 1)
                                {
                                    this.Rcell7.Image = this.ILR.Images[5];
                                    Rcell7.type = 5;
                                }
                                else if (cell4.TYPE == 2)
                                {
                                    this.Rcell7.Image = this.ILR.Images[3];
                                    Rcell7.type = 3;
                                }
                                else if (cell4.TYPE == 3)
                                {
                                    this.Rcell7.Image = this.ILR.Images[3];
                                    Rcell7.type = 3;
                                }
                            }
                            else if (cell8.TYPE == 3)
                            {
                                if (cell4.TYPE == 1)
                                {
                                    this.Rcell7.Image = this.ILR.Images[5];
                                    Rcell7.type = 5;
                                }
                                else if (cell4.TYPE == 2)
                                {
                                    this.Rcell7.Image = this.ILR.Images[3];
                                    Rcell7.type = 3;
                                }
                                else if (cell4.TYPE == 3)
                                {
                                    this.Rcell7.Image = this.ILR.Images[3];
                                    Rcell7.type = 3;
                                }
                            }
                        }
                        if (cell7.Image != this.imageList1.Images[0])
                        {
                            if (cell8.TYPE == 1)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell10.Image = this.ILR.Images[2];
                                    Rcell10.type = 2;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell10.Image = this.ILR.Images[4];
                                    Rcell10.type = 4;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell10.Image = this.ILR.Images[2];
                                    Rcell10.type = 2;
                                }
                            }
                            else if (cell8.TYPE == 2)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell10.Image = this.ILR.Images[6];
                                    Rcell10.type = 6;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell10.Image = this.ILR.Images[0];
                                    Rcell10.type = 0;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell10.Image = this.ILR.Images[6];
                                    Rcell10.type = 6;
                                }
                            }
                            else if (cell8.TYPE == 3)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell10.Image = this.ILR.Images[2];
                                    Rcell10.type = 2;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell10.Image = this.ILR.Images[4];
                                    Rcell10.type = 4;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell10.Image = this.ILR.Images[2];
                                    Rcell10.type = 2;
                                }
                            }
                        }
                        if (cell12.Image != this.imageList1.Images[0])
                        {
                            if (cell8.TYPE == 1)
                            {
                                if (cell12.TYPE == 1)
                                {
                                    this.Rcell14.Image = this.ILR.Images[1];
                                    Rcell14.type = 1;
                                }
                                else if (cell12.TYPE == 2)
                                {
                                    this.Rcell14.Image = this.ILR.Images[5];
                                    Rcell14.type = 5;
                                }
                                else if (cell12.TYPE == 3)
                                {
                                    this.Rcell14.Image = this.ILR.Images[5];
                                    Rcell14.type = 5;
                                }
                            }
                            else if (cell8.TYPE == 2)
                            {
                                if (cell12.TYPE == 1)
                                {
                                    this.Rcell14.Image = this.ILR.Images[7];
                                    Rcell14.type = 7;
                                }
                                else if (cell12.TYPE == 2)
                                {
                                    this.Rcell14.Image = this.ILR.Images[3];
                                    Rcell14.type = 3;
                                }
                                else if (cell12.TYPE == 3)
                                {
                                    this.Rcell14.Image = this.ILR.Images[3];
                                    Rcell14.type = 3;
                                }
                            }
                            else if (cell8.TYPE == 3)
                            {
                                if (cell12.TYPE == 1)
                                {
                                    this.Rcell14.Image = this.ILR.Images[7];
                                    Rcell14.type = 7;
                                }
                                else if (cell12.TYPE == 2)
                                {
                                    this.Rcell14.Image = this.ILR.Images[3];
                                    Rcell14.type = 3;
                                }
                                else if (cell12.TYPE == 3)
                                {
                                    this.Rcell14.Image = this.ILR.Images[3];
                                    Rcell14.type = 3;
                                }
                            }
                        }
                        foreach (Input item in cell8.Input())
                        {
                            this.intpulist.Add(item);
                        }
                    }
                    //----------------------row 3
                    if (temp == cell9 && cell9.empty == true && cell9.usable == true)
                    {
                        cell9.TYPE = this.type;
                        if (cell9.TYPE == 1)
                        {
                            cell9 = new Cell(a9, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(44, 604);
                            l2.ap = new Point(10, 639);
                            l3.ap = new Point(94, 653);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(110, 604);
                            l6.ap = new Point(119, 569);
                            l7.ap = new Point(42, 563);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell9.TYPE == 2)
                        {
                            cell9 = new Cell(a9, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(25, 571);
                            l2.ap = new Point(10, 638);
                            l3.ap = new Point(60, 636);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(95, 655);
                            l6.ap = new Point(109, 586);
                            l7.ap = new Point(60, 571);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell9.TYPE == 3)
                        {
                            cell9 = new Cell(a9, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(35, 604);
                            l2.ap = new Point(10, 639);
                            l3.ap = new Point(60, 619);
                            l4.ap = new Point(95, 655);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(85, 604);
                            l6.ap = new Point(120, 569);
                            l7.ap = new Point(60, 573);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(25, 554);
                            lightlist.Add(l8);

                        }
                        cell9.empty = false;
                        cell9.usable = true;
                        cell5.usable = true;
                        cell10.usable = true;
                        if (cell5.Image != this.imageList1.Images[0])
                        {
                            if (cell9.TYPE == 1)
                            {
                                if (cell5.TYPE == 1)
                                {
                                    this.Rcell11.Image = this.ILR.Images[1];
                                    Rcell11.type = 1;
                                }
                                else if (cell5.TYPE == 2)
                                {
                                    this.Rcell11.Image = this.ILR.Images[7];
                                    Rcell11.type = 7;
                                }
                                else if (cell5.TYPE == 3)
                                {
                                    this.Rcell11.Image = this.ILR.Images[7];
                                    Rcell11.type = 7;
                                }
                            }
                            else if (cell9.TYPE == 2)
                            {
                                if (cell5.TYPE == 1)
                                {
                                    this.Rcell11.Image = this.ILR.Images[5];
                                    Rcell11.type = 5;
                                }
                                else if (cell5.TYPE == 2)
                                {
                                    this.Rcell11.Image = this.ILR.Images[3];
                                    Rcell11.type = 3;
                                }
                                else if (cell5.TYPE == 3)
                                {
                                    this.Rcell11.Image = this.ILR.Images[3];
                                    Rcell11.type = 3;
                                }
                            }
                            else if (cell9.TYPE == 3)
                            {
                                if (cell5.TYPE == 1)
                                {
                                    this.Rcell11.Image = this.ILR.Images[5];
                                    Rcell11.type = 5;
                                }
                                else if (cell5.TYPE == 2)
                                {
                                    this.Rcell11.Image = this.ILR.Images[3];
                                    Rcell11.type = 3;
                                }
                                else if (cell5.TYPE == 3)
                                {
                                    this.Rcell11.Image = this.ILR.Images[3];
                                    Rcell11.type = 3;
                                }
                            }
                        }
                        if (cell10.Image != this.imageList1.Images[0])
                        {
                            if (cell9.TYPE == 1)
                            {
                                if (cell10.TYPE == 1)
                                {
                                    this.Rcell15.Image = this.ILR.Images[2];
                                    Rcell15.type = 2;
                                }
                                else if (cell10.TYPE == 2)
                                {
                                    this.Rcell15.Image = this.ILR.Images[6];
                                    Rcell15.type = 6;
                                }
                                else if (cell10.TYPE == 3)
                                {
                                    this.Rcell15.Image = this.ILR.Images[2];
                                    Rcell15.type = 2;
                                }
                            }
                            else if (cell9.TYPE == 2)
                            {
                                if (cell10.TYPE == 1)
                                {
                                    this.Rcell15.Image = this.ILR.Images[4];
                                    Rcell15.type = 4;
                                }
                                else if (cell10.TYPE == 2)
                                {
                                    this.Rcell15.Image = this.ILR.Images[0];
                                    Rcell15.type = 0;
                                }
                                else if (cell10.TYPE == 3)
                                {
                                    this.Rcell15.Image = this.ILR.Images[4];
                                    Rcell15.type = 4;
                                }
                            }
                            else if (cell9.TYPE == 3)
                            {
                                if (cell10.TYPE == 1)
                                {
                                    this.Rcell15.Image = this.ILR.Images[2];
                                    Rcell15.type = 2;
                                }
                                else if (cell10.TYPE == 2)
                                {
                                    this.Rcell15.Image = this.ILR.Images[6];
                                    Rcell15.type = 6;
                                }
                                else if (cell10.TYPE == 3)
                                {
                                    this.Rcell15.Image = this.ILR.Images[2];
                                    Rcell15.type = 2;
                                }
                            }
                        }

                        foreach (Input item in cell9.Input())
                        {
                            this.intpulist.Add(item);
                        }

                    }
                    else if (temp == cell10 && cell10.empty == true && cell10.usable == true)
                    {
                        cell10.TYPE = this.type;
                        if (cell10.TYPE == 1)
                        {
                            cell10 = new Cell(a10, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(316, 604);
                            l2.ap = new Point(282, 639);
                            l3.ap = new Point(366, 553);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(382, 604);
                            l6.ap = new Point(391, 569);
                            l7.ap = new Point(314, 563);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell10.TYPE == 2)
                        {
                            cell10 = new Cell(a10, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(297, 571);
                            l2.ap = new Point(282, 638);
                            l3.ap = new Point(332, 636);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(367, 655);
                            l6.ap = new Point(381, 586);
                            l7.ap = new Point(332, 571);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell10.TYPE == 3)
                        {
                            cell10 = new Cell(a10, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(307, 604);
                            l2.ap = new Point(282, 639);
                            l3.ap = new Point(332, 619);
                            l4.ap = new Point(367, 655);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(357, 604);
                            l6.ap = new Point(392, 569);
                            l7.ap = new Point(332, 573);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(297, 554);
                            lightlist.Add(l8);

                        }
                        cell10.empty = false;
                        cell10.usable = true;
                        cell6.usable = true;
                        cell9.usable = true;
                        cell11.usable = true;
                        if (cell6.Image != this.imageList1.Images[0])
                        {
                            if (cell10.TYPE == 1)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell12.Image = this.ILR.Images[1];
                                    Rcell12.type = 1;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell12.Image = this.ILR.Images[7];
                                    Rcell12.type = 7;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell12.Image = this.ILR.Images[7];
                                    Rcell12.type = 7;
                                }
                            }
                            else if (cell10.TYPE == 2)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell12.Image = this.ILR.Images[5];
                                    Rcell12.type = 5;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell12.Image = this.ILR.Images[3];
                                    Rcell12.type = 3;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell12.Image = this.ILR.Images[3];
                                    Rcell12.type = 3;
                                }
                            }
                            else if (cell10.TYPE == 3)
                            {
                                if (cell6.TYPE == 1)
                                {
                                    this.Rcell12.Image = this.ILR.Images[5];
                                    Rcell12.type = 5;
                                }
                                else if (cell6.TYPE == 2)
                                {
                                    this.Rcell12.Image = this.ILR.Images[3];
                                    Rcell12.type = 3;
                                }
                                else if (cell6.TYPE == 3)
                                {
                                    this.Rcell12.Image = this.ILR.Images[3];
                                    Rcell12.type = 3;
                                }
                            }
                        }
                        if (cell9.Image != this.imageList1.Images[0])
                        {
                            if (cell10.TYPE == 1)
                            {
                                if (cell9.TYPE == 1)
                                {
                                    this.Rcell15.Image = this.ILR.Images[2];
                                    Rcell15.type = 2;
                                }
                                else if (cell9.TYPE == 2)
                                {
                                    this.Rcell15.Image = this.ILR.Images[4];
                                    Rcell15.type = 4;
                                }
                                else if (cell9.TYPE == 3)
                                {
                                    this.Rcell15.Image = this.ILR.Images[2];
                                    Rcell15.type = 2;
                                }
                            }
                            else if (cell10.TYPE == 2)
                            {
                                if (cell9.TYPE == 1)
                                {
                                    this.Rcell15.Image = this.ILR.Images[6];
                                    Rcell15.type = 6;
                                }
                                else if (cell9.TYPE == 2)
                                {
                                    this.Rcell15.Image = this.ILR.Images[0];
                                    Rcell15.type = 0;
                                }
                                else if (cell9.TYPE == 3)
                                {
                                    this.Rcell15.Image = this.ILR.Images[6];
                                    Rcell15.type = 6;
                                }
                            }
                            else if (cell10.TYPE == 3)
                            {
                                if (cell9.TYPE == 1)
                                {
                                    this.Rcell15.Image = this.ILR.Images[2];
                                    Rcell15.type = 2;
                                }
                                else if (cell9.TYPE == 2)
                                {
                                    this.Rcell15.Image = this.ILR.Images[4];
                                    Rcell15.type = 4;
                                }
                                else if (cell9.TYPE == 3)
                                {
                                    this.Rcell15.Image = this.ILR.Images[2];
                                    Rcell15.type = 2;
                                }
                            }
                        }
                        if (cell11.Image != this.imageList1.Images[0])
                        {
                            if (cell10.TYPE == 1)
                            {
                                if (cell11.TYPE == 1)
                                {
                                    this.Rcell16.Image = this.ILR.Images[2];
                                    Rcell16.type = 2;
                                }
                                else if (cell11.TYPE == 2)
                                {
                                    this.Rcell16.Image = this.ILR.Images[6];
                                    Rcell16.type = 6;
                                }
                                else if (cell11.TYPE == 3)
                                {
                                    this.Rcell16.Image = this.ILR.Images[2];
                                    Rcell16.type = 2;
                                }
                            }
                            else if (cell10.TYPE == 2)
                            {
                                if (cell11.TYPE == 1)
                                {
                                    this.Rcell16.Image = this.ILR.Images[4];
                                    Rcell16.type = 4;
                                }
                                else if (cell11.TYPE == 2)
                                {
                                    this.Rcell16.Image = this.ILR.Images[0];
                                    Rcell16.type = 0;
                                }
                                else if (cell11.TYPE == 3)
                                {
                                    this.Rcell16.Image = this.ILR.Images[4];
                                    Rcell16.type = 4;
                                }
                            }
                            else if (cell10.TYPE == 3)
                            {
                                if (cell11.TYPE == 1)
                                {
                                    this.Rcell16.Image = this.ILR.Images[2];
                                    Rcell16.type = 2;
                                }
                                else if (cell11.TYPE == 2)
                                {
                                    this.Rcell16.Image = this.ILR.Images[6];
                                    Rcell16.type = 6;
                                }
                                else if (cell11.TYPE == 3)
                                {
                                    this.Rcell16.Image = this.ILR.Images[2];
                                    Rcell16.type = 2;
                                }
                            }
                        }
                        foreach (Input item in cell10.Input())
                        {
                            this.intpulist.Add(item);
                        }
                    }
                    else if (temp == cell11 && cell11.empty == true && cell11.usable == true)
                    {
                        cell11.TYPE = this.type;
                        if (cell11.TYPE == 1)
                        {
                            cell11 = new Cell(a11, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(608, 564);
                            l2.ap = new Point(554, 639);
                            l3.ap = new Point(638, 653);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(654, 604);
                            l6.ap = new Point(663, 569);
                            l7.ap = new Point(586, 603);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell11.TYPE == 2)
                        {
                            cell11 = new Cell(a11, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(569, 571);
                            l2.ap = new Point(554, 638);
                            l3.ap = new Point(604, 636);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(639, 655);
                            l6.ap = new Point(653, 586);
                            l7.ap = new Point(604, 571);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell11.TYPE == 3)
                        {
                            cell11 = new Cell(a11, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(579, 604);
                            l2.ap = new Point(554, 639);
                            l3.ap = new Point(604, 619);
                            l4.ap = new Point(639, 655);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(629, 604);
                            l6.ap = new Point(664, 569);
                            l7.ap = new Point(604, 573);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(569, 554);
                            lightlist.Add(l8);

                        }
                        cell11.empty = false;
                        cell11.usable = true;
                        cell7.usable = true;
                        cell10.usable = true;
                        cell12.usable = true;
                        if (cell7.Image != this.imageList1.Images[0])
                        {
                            if (cell11.TYPE == 1)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell13.Image = this.ILR.Images[1];
                                    Rcell13.type = 1;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell13.Image = this.ILR.Images[7];
                                    Rcell13.type = 7;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell13.Image = this.ILR.Images[7];
                                    Rcell13.type = 7;
                                }
                            }
                            else if (cell11.TYPE == 2)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell13.Image = this.ILR.Images[5];
                                    Rcell13.type = 5;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell13.Image = this.ILR.Images[3];
                                    Rcell13.type = 3;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell13.Image = this.ILR.Images[3];
                                    Rcell13.type = 3;
                                }
                            }
                            else if (cell11.TYPE == 3)
                            {
                                if (cell7.TYPE == 1)
                                {
                                    this.Rcell13.Image = this.ILR.Images[5];
                                    Rcell13.type = 5;
                                }
                                else if (cell7.TYPE == 2)
                                {
                                    this.Rcell13.Image = this.ILR.Images[3];
                                    Rcell13.type = 3;
                                }
                                else if (cell7.TYPE == 3)
                                {
                                    this.Rcell13.Image = this.ILR.Images[3];
                                    Rcell13.type = 3;
                                }
                            }
                        }
                        if (cell10.Image != this.imageList1.Images[0])
                        {
                            if (cell11.TYPE == 1)
                            {
                                if (cell10.TYPE == 1)
                                {
                                    this.Rcell16.Image = this.ILR.Images[2];
                                    Rcell16.type = 2;
                                }
                                else if (cell10.TYPE == 2)
                                {
                                    this.Rcell16.Image = this.ILR.Images[4];
                                    Rcell16.type = 4;
                                }
                                else if (cell10.TYPE == 3)
                                {
                                    this.Rcell16.Image = this.ILR.Images[4];
                                    Rcell16.type = 4;
                                }
                            }
                            else if (cell11.TYPE == 2)
                            {
                                if (cell10.TYPE == 1)
                                {
                                    this.Rcell16.Image = this.ILR.Images[6];
                                    Rcell16.type = 6;
                                }
                                else if (cell10.TYPE == 2)
                                {
                                    this.Rcell16.Image = this.ILR.Images[0];
                                    Rcell16.type = 0;
                                }
                                else if (cell10.TYPE == 3)
                                {
                                    this.Rcell16.Image = this.ILR.Images[6];
                                    Rcell16.type = 6;
                                }
                            }
                            else if (cell11.TYPE == 3)
                            {
                                if (cell10.TYPE == 1)
                                {
                                    this.Rcell16.Image = this.ILR.Images[2];
                                    Rcell16.type = 2;
                                }
                                else if (cell10.TYPE == 2)
                                {
                                    this.Rcell16.Image = this.ILR.Images[4];
                                    Rcell16.type = 4;
                                }
                                else if (cell10.TYPE == 3)
                                {
                                    this.Rcell16.Image = this.ILR.Images[2];
                                    Rcell16.type = 2;
                                }
                            }
                        }
                        if (cell12.Image != this.imageList1.Images[0])
                        {
                            if (cell11.TYPE == 1)
                            {
                                if (cell12.TYPE == 1)
                                {
                                    this.Rcell17.Image = this.ILR.Images[2];
                                    Rcell17.type = 2;
                                }
                                else if (cell12.TYPE == 2)
                                {
                                    this.Rcell17.Image = this.ILR.Images[6];
                                    Rcell17.type = 6;
                                }
                                else if (cell12.TYPE == 3)
                                {
                                    this.Rcell17.Image = this.ILR.Images[2];
                                    Rcell17.type = 2;
                                }
                            }
                            else if (cell11.TYPE == 2)
                            {
                                if (cell12.TYPE == 1)
                                {
                                    this.Rcell17.Image = this.ILR.Images[4];
                                    Rcell17.type = 4;
                                }
                                else if (cell12.TYPE == 2)
                                {
                                    this.Rcell17.Image = this.ILR.Images[0];
                                    Rcell17.type = 0;
                                }
                                else if (cell12.TYPE == 3)
                                {
                                    this.Rcell17.Image = this.ILR.Images[4];
                                    Rcell17.type = 4;
                                }
                            }
                            else if (cell11.TYPE == 3)
                            {
                                if (cell12.TYPE == 1)
                                {
                                    this.Rcell17.Image = this.ILR.Images[2];
                                    Rcell17.type = 2;
                                }
                                else if (cell12.TYPE == 2)
                                {
                                    this.Rcell17.Image = this.ILR.Images[6];
                                    Rcell17.type = 6;
                                }
                                else if (cell12.TYPE == 3)
                                {
                                    this.Rcell17.Image = this.ILR.Images[2];
                                    Rcell17.type = 2;
                                }
                            }
                        }
                        foreach (Input item in cell11.Input())
                        {
                            this.intpulist.Add(item);
                        }
                    }
                    else if (temp == cell12 && cell12.empty == true && cell12.usable == true)
                    {
                        cell12.TYPE = this.type;
                        if (cell12.TYPE == 1)
                        {
                            cell12 = new Cell(a12, this.ILCR.Images[0], this.type);
                            l1.ap = new Point(860, 604);
                            l2.ap = new Point(826, 639);
                            l3.ap = new Point(910, 553);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(926, 604);
                            l6.ap = new Point(935, 569);
                            l7.ap = new Point(858, 563);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell12.TYPE == 2)
                        {
                            cell12 = new Cell(a12, this.ILCR.Images[1], this.type);
                            l1.ap = new Point(841, 571);
                            l2.ap = new Point(826, 638);
                            l3.ap = new Point(876, 636);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            l5.ap = new Point(911, 655);
                            l6.ap = new Point(925, 586);
                            l7.ap = new Point(876, 571);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);

                        }
                        else if (cell12.TYPE == 3)
                        {
                            cell12 = new Cell(a12, this.ILCR.Images[2], this.type);
                            l1.ap = new Point(851, 604);
                            l2.ap = new Point(826, 639);
                            l3.ap = new Point(876, 619);
                            l4.ap = new Point(911, 655);
                            lightlist.Add(l1);
                            lightlist.Add(l2);
                            lightlist.Add(l3);
                            lightlist.Add(l4);
                            l5.ap = new Point(901, 604);
                            l6.ap = new Point(936, 569);
                            l7.ap = new Point(876, 573);
                            lightlist.Add(l5);
                            lightlist.Add(l6);
                            lightlist.Add(l7);
                            l8.ap = new Point(841, 554);
                            lightlist.Add(l8);

                        }
                        cell12.empty = false;
                        cell12.usable = true;
                        cell8.usable = true;
                        cell11.usable = true;
                        if (cell8.Image != this.imageList1.Images[0])
                        {
                            if (cell12.TYPE == 1)
                            {
                                if (cell8.TYPE == 1)
                                {
                                    this.Rcell14.Image = this.ILR.Images[1];
                                    Rcell14.type = 1;
                                }
                                else if (cell8.TYPE == 2)
                                {
                                    this.Rcell14.Image = this.ILR.Images[7];
                                    Rcell14.type = 7;
                                }
                                else if (cell8.TYPE == 3)
                                {
                                    this.Rcell14.Image = this.ILR.Images[7];
                                    Rcell14.type = 7;
                                }
                            }
                            else if (cell12.TYPE == 2)
                            {
                                if (cell8.TYPE == 1)
                                {
                                    this.Rcell14.Image = this.ILR.Images[5];
                                    Rcell14.type = 5;
                                }
                                else if (cell8.TYPE == 2)
                                {
                                    this.Rcell14.Image = this.ILR.Images[3];
                                    Rcell14.type = 3;
                                }
                                else if (cell8.TYPE == 3)
                                {
                                    this.Rcell14.Image = this.ILR.Images[3];
                                    Rcell14.type = 3;
                                }
                            }
                            else if (cell12.TYPE == 3)
                            {
                                if (cell8.TYPE == 1)
                                {
                                    this.Rcell14.Image = this.ILR.Images[5];
                                    Rcell14.type = 5;
                                }
                                else if (cell8.TYPE == 2)
                                {
                                    this.Rcell14.Image = this.ILR.Images[3];
                                    Rcell14.type = 3;
                                }
                                else if (cell8.TYPE == 3)
                                {
                                    this.Rcell14.Image = this.ILR.Images[3];
                                    Rcell14.type = 3;
                                }
                            }
                        }
                        if (cell11.Image != this.imageList1.Images[0])
                        {
                            if (cell12.TYPE == 1)
                            {
                                if (cell11.TYPE == 1)
                                {
                                    this.Rcell17.Image = this.ILR.Images[2];
                                    Rcell17.type = 2;
                                }
                                else if (cell11.TYPE == 2)
                                {
                                    this.Rcell17.Image = this.ILR.Images[4];
                                    Rcell17.type = 4;
                                }
                                else if (cell11.TYPE == 3)
                                {
                                    this.Rcell17.Image = this.ILR.Images[2];
                                    Rcell17.type = 2;
                                }
                            }
                            else if (cell12.TYPE == 2)
                            {
                                if (cell11.TYPE == 1)
                                {
                                    this.Rcell17.Image = this.ILR.Images[6];
                                    Rcell17.type = 6;
                                }
                                else if (cell11.TYPE == 2)
                                {
                                    this.Rcell17.Image = this.ILR.Images[0];
                                    Rcell17.type = 0;
                                }
                                else if (cell11.TYPE == 3)
                                {
                                    this.Rcell17.Image = this.ILR.Images[6];
                                    Rcell17.type = 6;
                                }
                            }
                            else if (cell12.TYPE == 3)
                            {
                                if (cell11.TYPE == 1)
                                {
                                    this.Rcell17.Image = this.ILR.Images[2];
                                    Rcell17.type = 2;
                                }
                                else if (cell11.TYPE == 2)
                                {
                                    this.Rcell17.Image = this.ILR.Images[4];
                                    Rcell17.type = 4;
                                }
                                else if (cell11.TYPE == 3)
                                {
                                    this.Rcell17.Image = this.ILR.Images[2];
                                    Rcell17.type = 2;
                                }
                            }
                            foreach (Input item in cell12.Input())
                            {
                                this.intpulist.Add(item);
                            }
                        }
                        temp = new Cell(a, this.imageList1.Images[0], -1);
                    }
                }
                this.type = -1;
            }
            //--------------------------------------remove
            else if (action == "remove")
            {

                Point p = new Point(e.X, e.Y);
                Point a = new Point(-1, -1);
                Cell temp = new Cell(a, this.imageList1.Images[0]);
                foreach (Cell item in cellListNew)
                {
                    if (item.GetCell(p) != null)
                    {
                        temp = item;
                    }
                }

                int num = 0;
                foreach (Cell item in cellListNew)
                {
                    if (item.empty == false)
                    {
                        num++;
                    }
                }

                if (num <= 1)
                {
                    if (temp == cell1)
                    {
                        cell1.Image = imageList1.Images[0];
                        cell1.empty = true;
                        cell1.TYPE = -1;
                    }
                    else if (temp == cell2)
                    {
                        cell2.Image = imageList1.Images[0];
                        cell2.empty = true;
                        cell2.TYPE = -1;
                    }
                    if (temp == cell3)
                    {
                        cell3.Image = imageList1.Images[0];
                        cell3.empty = true;
                        cell3.TYPE = -1;
                    }
                    if (temp == cell4)
                    {
                        cell4.Image = imageList1.Images[0];
                        cell4.empty = true;
                        cell4.TYPE = -1;
                    }
                    if (temp == cell5)
                    {
                        cell5.Image = imageList1.Images[0];
                        cell5.empty = true;
                        cell5.TYPE = -1;
                    }
                    if (temp == cell6)
                    {
                        cell6.Image = imageList1.Images[0];
                        cell6.empty = true;
                        cell6.TYPE = -1;
                    }
                    if (temp == cell7)
                    {
                        cell7.Image = imageList1.Images[0];
                        cell7.empty = true;
                        cell7.TYPE = -1;
                    }
                    if (temp == cell8)
                    {
                        cell8.Image = imageList1.Images[0];
                        cell8.empty = true;
                        cell8.TYPE = -1;
                    }
                    if (temp == cell9)
                    {
                        cell9.Image = imageList1.Images[0];
                        cell9.empty = true;
                        cell9.TYPE = -1;
                    }
                    if (temp == cell10)
                    {
                        cell10.Image = imageList1.Images[0];
                        cell10.empty = true;
                        cell10.TYPE = -1;
                    }
                    if (temp == cell11)
                    {
                        cell11.Image = imageList1.Images[0];
                        cell11.empty = true;
                        cell11.TYPE = -1;
                    }
                    if (temp == cell12)
                    {
                        cell12.Image = imageList1.Images[0];
                        cell12.empty = true;
                        cell12.TYPE = -1;
                    }
                    foreach (Cell item in cellList)
                    {
                        item.Image = imageList1.Images[0];
                        item.usable = true;
                    }
                    foreach (Cell item in cellListNew)
                    {
                        item.Image = imageList1.Images[0];
                        item.usable = true;
                    }

                }
                else
                {
                    if (temp == cell1)
                    {
                        if (cell2.empty == false || cell5.empty == false)
                        {
                            cell1.Image = imageList1.Images[0];
                            if (cell2.empty == false)
                            {
                                Rcell1.Image = imageList1.Images[1];

                            }
                            if (cell5.empty == false)
                            {
                                Rcell4.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell1.Image = imageList1.Images[1];
                            cell1.usable = false;
                        }
                        if (cell3.empty == true && cell5.empty == true && cell2.empty == true)
                        {
                            cell2.usable = false;
                        }
                        if (cell9.empty == true && cell6.empty == true && cell5.empty == true)
                        {
                            cell5.usable = false;
                        }
                        cell1.empty = true;
                        cell1.TYPE = -1;
                    }

                    else if (temp == cell2)
                    {
                        if (cell1.empty == false || cell3.empty == false || cell6.empty == false)
                        {
                            cell2.Image = imageList1.Images[0];
                            if (cell1.empty == false)
                            {
                                Rcell1.Image = imageList1.Images[1];
                            }
                            if (cell3.empty == false)
                            {
                                Rcell2.Image = imageList1.Images[1];
                            }
                            if (cell6.empty == false)
                            {
                                Rcell5.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell2.Image = imageList1.Images[1];
                            cell2.usable = false;
                        }

                        if (cell5.empty == true && cell1.empty == true)
                        {
                            cell1.usable = false;
                        }
                        if (cell4.empty == true && cell7.empty == true && cell3.empty == true)
                        {
                            cell3.usable = false;
                        }
                        if (cell10.empty == true && cell5.empty == true && cell7.empty == true && cell6.empty == true)
                        {
                            cell6.usable = false;
                        }
                        cell2.empty = true;
                        cell2.TYPE = -1;
                    }
                    else if (temp == cell3)
                    {
                        if (cell2.empty == false || cell4.empty == false || cell7.empty == false)
                        {
                            cell3.Image = imageList1.Images[0];
                            if (cell2.empty == false)
                            {
                                Rcell2.Image = imageList1.Images[1];
                            }
                            if (cell4.empty == false)
                            {
                                Rcell3.Image = imageList1.Images[1];
                            }
                            if (cell7.empty == false)
                            {
                                Rcell6.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell3.Image = imageList1.Images[1];
                            cell3.usable = false;
                        }

                        if (cell1.empty == true && cell6.empty == true && cell2.empty == true)
                        {
                            cell2.usable = false;
                        }
                        if (cell11.empty == true && cell6.empty == true && cell8.empty == true && cell7.empty == true)
                        {
                            cell7.usable = false;
                        }
                        cell3.empty = true;
                        cell3.TYPE = -1;
                    }
                    else if (temp == cell4)
                    {
                        if (cell3.empty == false || cell8.empty == false)
                        {
                            cell4.Image = imageList1.Images[0];
                            if (cell3.empty == false)
                            {
                                Rcell3.Image = imageList1.Images[1];
                            }
                            if (cell8.empty == false)
                            {
                                Rcell7.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell4.Image = imageList1.Images[1];
                            cell4.usable = false;
                        }

                        if (cell12.empty == true && cell7.empty == true && cell8.empty == true)
                        {
                            cell8.usable = false;
                        }
                        if (cell2.empty == true && cell7.empty == true && cell3.empty == true)
                        {
                            cell3.usable = false;
                        }
                        cell4.empty = true;
                        cell4.TYPE = -1;
                    }

                    else if (temp == cell5)
                    {
                        if (cell1.empty == false || cell6.empty == false || cell9.empty == false)
                        {
                            cell5.Image = imageList1.Images[0];
                            if (cell1.empty == false)
                            {
                                Rcell4.Image = imageList1.Images[1];
                            }
                            if (cell6.empty == false)
                            {
                                Rcell8.Image = imageList1.Images[1];
                            }
                            if (cell9.empty == false)
                            {
                                Rcell11.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell5.Image = imageList1.Images[1];
                            cell5.usable = false;
                        }
                        if (cell2.empty == true && cell1.empty == true)
                        {
                            cell1.usable = false;
                        }
                        if (cell10.empty == true && cell9.empty == true)
                        {
                            cell9.usable = false;
                        }
                        if (cell7.empty == true && cell2.empty == true && cell10.empty == true && cell6.empty == true)
                        {
                            cell6.usable = false;
                        }
                        cell5.empty = true;
                        cell5.TYPE = -1;
                    }

                    else if (temp == cell6)
                    {
                        if (cell2.empty == false || cell5.empty == false || cell7.empty == false || cell10.empty == false)
                        {
                            cell6.Image = imageList1.Images[0];
                            if (cell2.empty == false)
                            {
                                Rcell5.Image = imageList1.Images[1];
                            }
                            if (cell5.empty == false)
                            {
                                Rcell8.Image = imageList1.Images[1];
                            }
                            if (cell7.empty == false)
                            {
                                Rcell9.Image = imageList1.Images[1];
                            }
                            if (cell10.empty == false)
                            {
                                Rcell12.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell6.Image = imageList1.Images[1];
                            cell6.usable = false;
                        }
                        if (cell1.empty == true && cell3.empty == true && cell2.empty == true)
                        {
                            cell2.usable = false;
                        }
                        if (cell1.empty == true && cell5.empty == true && cell9.empty == true)
                        {
                            cell5.usable = false;
                        }
                        if (cell7.empty == true && cell3.empty == true && cell8.empty == true && cell11.empty)
                        {
                            cell7.usable = false;
                        }
                        if (cell10.empty == true && cell9.empty == true && cell11.empty == true)
                        {
                            cell10.usable = false;
                        }
                        cell6.empty = true;
                        cell6.TYPE = -1;
                    }

                    else if (temp == cell7)
                    {
                        if (cell3.empty == false || cell6.empty == false || cell8.empty == false || cell11.empty == false)
                        {
                            cell7.Image = imageList1.Images[0];
                            if (cell3.empty == false)
                            {
                                Rcell6.Image = imageList1.Images[1];
                            }
                            if (cell6.empty == false)
                            {
                                Rcell9.Image = imageList1.Images[1];
                            }
                            if (cell8.empty == false)
                            {
                                Rcell10.Image = imageList1.Images[1];
                            }
                            if (cell11.empty == false)
                            {
                                Rcell13.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell7.Image = imageList1.Images[1];
                            cell7.usable = false;
                        }

                        if (cell4.empty == true && cell2.empty == true && cell3.empty == true)
                        {
                            cell3.usable = false;
                        }
                        if (cell2.empty == true && cell5.empty == true && cell10.empty == true && cell6.empty == true)
                        {
                            cell6.usable = false;
                        }
                        if (cell8.empty == true && cell4.empty == true && cell12.empty == true)
                        {
                            cell8.usable = false;
                        }
                        if (cell10.empty == true && cell11.empty == true && cell12.empty == true)
                        {
                            cell11.usable = false;
                        }
                        cell7.empty = true;
                        cell7.TYPE = -1;
                    }
                    else if (temp == cell8)
                    {
                        if (cell4.empty == false || cell7.empty == false || cell12.empty == false)
                        {
                            cell8.Image = imageList1.Images[0];
                            if (cell4.empty == false)
                            {
                                Rcell7.Image = imageList1.Images[1];
                            }
                            if (cell7.empty == false)
                            {
                                Rcell10.Image = imageList1.Images[1];
                            }
                            if (cell12.empty == false)
                            {
                                Rcell14.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell8.Image = imageList1.Images[1];
                            cell8.usable = false;
                        }

                        if (cell3.empty == true && cell4.empty == true)
                        {
                            cell4.usable = false;
                        }
                        if (cell3.empty == true && cell6.empty == true && cell11.empty == true && cell7.empty == true)
                        {
                            cell7.usable = false;
                        }
                        if (cell12.empty == true && cell11.empty == true)
                        {
                            cell12.usable = false;
                        }
                        cell8.empty = true;
                        cell8.TYPE = -1;
                    }

                    else if (temp == cell9)
                    {
                        if (cell5.empty == false || cell10.empty == false)
                        {
                            cell9.Image = imageList1.Images[0];
                            if (cell5.empty == false)
                            {
                                Rcell11.Image = imageList1.Images[1];
                            }
                            if (cell10.empty == false)
                            {
                                Rcell15.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell9.Image = imageList1.Images[1];
                            cell9.usable = false;
                        }

                        if (cell5.empty == true && cell1.empty == true && cell6.empty == true)
                        {
                            cell5.usable = false;
                        }
                        if (cell6.empty == true && cell11.empty == true && cell10.empty == true)
                        {
                            cell10.usable = false;
                        }
                        cell9.empty = true;
                        cell9.TYPE = -1;
                    }
                    else if (temp == cell10)
                    {
                        if (cell9.empty == false || cell11.empty == false || cell6.empty == false)
                        {
                            cell10.Image = imageList1.Images[0];
                            if (cell9.empty == false)
                            {
                                Rcell15.Image = imageList1.Images[1];
                            }
                            if (cell6.empty == false)
                            {
                                Rcell12.Image = imageList1.Images[1];
                            }
                            if (cell11.empty == false)
                            {
                                Rcell16.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell10.Image = imageList1.Images[1];
                            cell10.usable = false;
                        }

                        if (cell9.empty == true && cell5.empty == true)
                        {
                            cell9.usable = false;
                        }
                        if (cell6.empty == true && cell12.empty == true && cell5.empty == true && cell7.empty == true)
                        {
                            cell6.usable = false;
                        }
                        if (cell1.empty == true && cell12.empty == true && cell7.empty == true)
                        {
                            cell11.usable = false;
                        }
                        cell10.empty = true;
                        cell10.TYPE = -1;
                    }
                    else if (temp == cell11)
                    {
                        if (cell10.empty == false || cell7.empty == false || cell12.empty == false)
                        {
                            cell11.Image = imageList1.Images[0];
                            if (cell10.empty == false)
                            {
                                Rcell16.Image = imageList1.Images[1];
                            }
                            if (cell7.empty == false)
                            {
                                Rcell13.Image = imageList1.Images[1];
                            }
                            if (cell12.empty == false)
                            {
                                Rcell17.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell11.Image = imageList1.Images[1];
                            cell11.usable = false;
                        }

                        if (cell10.empty == true && cell9.empty == true && cell6.empty == true)
                        {
                            cell10.usable = false;
                        }
                        if (cell7.empty == true && cell3.empty == true && cell6.empty == true && cell8.empty == true)
                        {
                            cell7.usable = false;
                        }
                        if (cell12.empty == true && cell8.empty == true)
                        {
                            cell12.usable = false;
                        }
                        cell11.empty = true;
                        cell11.TYPE = -1;
                    }
                    else if (temp == cell12)
                    {
                        if (cell11.empty == false || cell8.empty == false)
                        {
                            cell12.Image = imageList1.Images[0];
                            if (cell8.empty == false)
                            {
                                Rcell14.Image = imageList1.Images[1];
                            }
                            if (cell11.empty == false)
                            {
                                Rcell17.Image = imageList1.Images[1];
                            }
                        }
                        else
                        {
                            cell12.Image = imageList1.Images[1];
                            cell12.usable = false;
                        }

                        if (cell7.empty == true && cell10.empty == true && cell11.empty == true)
                        {
                            cell11.usable = false;
                        }
                        if (cell7.empty == true && cell4.empty == true && cell8.empty == true)
                        {
                            cell8.usable = false;
                        }
                        cell12.empty = true;
                        cell12.TYPE = -1;
                    }
                }
                num = 0;
            }
            bool usable = false;
            if (cellListNew.Count > 0)
            {
                foreach (Cell a in cellListNew)
                {
                    if (a.usable == true)
                    {
                        usable = true;
                    }
                }
            }
            else
            {
                foreach (Cell a in cellList)
                {
                    if (a.usable == true)
                    {
                        usable = true;
                    }
                }
            }

            if (usable == true)
            {
                if (cellListNew.Count > 0)
                {
                    foreach (Cell item in cellListNew)
                    {
                        if (item.usable == false)
                        {
                            item.Image = imageList1.Images[1];
                        }
                        else if (item.usable == true && item.TYPE == -1)
                        {
                            item.Image = imageList1.Images[0];
                        }
                    }
                }
                else
                {
                    foreach (Cell item in cellList)
                    {
                        if (item.usable == false)
                        {
                            item.Image = imageList1.Images[1];
                        }
                        else if (item.usable == true && item.TYPE == -1)
                        {
                            item.Image = imageList1.Images[0];
                        }
                    }
                }
            }

            this.cellListNew = new List<Cell>();
            this.cellListNew.Add(cell1);
            this.cellListNew.Add(cell2);
            this.cellListNew.Add(cell3);
            this.cellListNew.Add(cell4);
            this.cellListNew.Add(cell5);
            this.cellListNew.Add(cell6);
            this.cellListNew.Add(cell7);
            this.cellListNew.Add(cell8);
            this.cellListNew.Add(cell9);
            this.cellListNew.Add(cell10);
            this.cellListNew.Add(cell11);
            this.cellListNew.Add(cell12);
            this.RoadcellListNew = new List<RoadCell>();
            RoadcellListNew.Add(Rcell1);
            RoadcellListNew.Add(Rcell2);
            RoadcellListNew.Add(Rcell3);
            RoadcellListNew.Add(Rcell4);
            RoadcellListNew.Add(Rcell5);
            RoadcellListNew.Add(Rcell6);
            RoadcellListNew.Add(Rcell7);
            RoadcellListNew.Add(Rcell8);
            RoadcellListNew.Add(Rcell9);
            RoadcellListNew.Add(Rcell10);
            RoadcellListNew.Add(Rcell11);
            RoadcellListNew.Add(Rcell12);
            RoadcellListNew.Add(Rcell13);
            RoadcellListNew.Add(Rcell14);
            RoadcellListNew.Add(Rcell15);
            RoadcellListNew.Add(Rcell16);
            RoadcellListNew.Add(Rcell17);
            DrawLight();
            this.panel1.Refresh();
            this.action = "";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void Addcar()
        {
            int a = this.intpulist.Count;
            Random randomizer = new Random();
            int b = randomizer.Next(0, a);
            List<Input> inputTemp = this.intpulist;
            Car car = new Car(inputTemp[b].point, this.imageList1.Images[2], inputTemp[b],this);
            this.cars.Add(car);
            pic[index] = new PictureBox();
            pic[index].Image = this.imageList1.Images[2];
            pic[index].Location = car.position;
            pic[index].Size = new Size(18, 13);
            this.panel1.Controls.Add(pic[index]);
            this.carlist.Add(pic[index]);
            index++;
            inputTemp = new List<Input>();
        }



        private void button8_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void Addredlight()
        {
            foreach (Light l in lightlist)
            {
                if (l.redexit == 0)
                {
                    if (l.Lgreen == false)
                    {
                        redpoint.Add(l.ap);
                        l.redexit = 1;
                    }
                }
                else
                {
                    if (l.Lgreen == true)
                    {
                        //redpoint.Remove(l.ap);
                        int id=0;
                        for (int i = 0; i < redpoint.Count; i++)
                        {
                            if (redpoint[i] == l.ap)
                            {
                                id = i;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(id);
                        l.redexit = 0;
                    }

                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Addredlight();
            foreach (Car item in cars)
            {
                if (item.start)
                {
                    if (item.input.type == 1 || item.input.type == 2 || item.input.type == 7 || item.input.type == 10)
                    {
                        item.GetMove(1, 0);
                    }
                    else if (item.input.type == 3 || item.input.type == 8 || item.input.type == 9)
                    {
                        item.GetMove(0, 1);
                    }
                    else if (item.input.type == 4 || item.input.type == 5 )//|| item.input.type == 10)
                    {
                        item.GetMove(-1, 0);
                    }
                    else if (item.input.type == 6 || item.input.type == 11 || item.input.type == 12)
                    {
                        item.GetMove(0, -1);
                    }
                    else if (item.input.type == 13)
                    {
                        item.GetMove(1, 1);
                    }
                    else if (item.input.type == 14)
                    {
                        item.GetMove(-1, -1);
                    }
                    else if (item.input.type == 15)
                    {
                        item.GetMove(1, -1);
                    }
                    else if (item.input.type == 16)
                    {
                        item.GetMove(-1, 1);
                    }
                    else if (item.input.type == 0)
                    {
                        item.GetMove(0, 0);
                    }
                    item.start = !item.start;
                }
                else
                {
                    item.getmove();
                }
                
            }

            for (int i = 0; i < cars.Count; i++)
            {
                carlist[i].Location = cars[i].position;
            }

            for (int i = 0; i < carlist.Count; i++)
            {
                if (carlist[i].Location.X < 0 || carlist[i].Location.Y < 0 || carlist[i].Location.X > this.panel1.Width || carlist[i].Location.Y > this.panel1.Height)
                {
                    int a = this.intpulist.Count;
                    Random randomizer = new Random();
                    int b = randomizer.Next(0, a);
                    int m = 0;
                    for (int w = 0; w < redpoint.Count; w++)
                    {
                        if (redpoint[w] == carlist[i].Location)
                        {
                            m = w;
                        }
                    }
                                            if(redpoint.Count!=0)redpoint.RemoveAt(m);
                    cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                    pic[i].Image = this.imageList1.Images[2];
                    pic[i].Location = cars[i].position;
                    pic[i].Size = new Size(18, 13);
                }
                //=============================cell1
                if (cell1.empty == false && cell2.empty == true)
                {
                    if (carlist[i].Location.X > 118 && carlist[i].Location.Y < 136)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell1.empty == false && cell5.empty == true)
                {
                    if (carlist[i].Location.X <= 136 && carlist[i].Location.Y > 120)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //====================cell2
                if (cell2.empty == false && cell1.empty == true)
                {
                    if (carlist[i].Location.X < 272 && carlist[i].Location.Y < 136)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell2.empty == false && cell3.empty == true)
                {
                    if (carlist[i].Location.X > 390 && carlist[i].Location.Y < 136)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell2.empty == false && cell6.empty == true)
                {
                    if (carlist[i].Location.X > 272 && carlist[i].Location.Y > 120 && carlist[i].Location.X < 408)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //=======================cell3
                if (cell3.empty == false && cell7.empty == true)
                {
                    if (carlist[i].Location.X > 544 && carlist[i].Location.Y > 120 && carlist[i].Location.X < 680)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell3.empty == false && cell2.empty == true)
                {
                    if (carlist[i].Location.X < 544 && carlist[i].Location.Y < 136)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell3.empty == false && cell4.empty == true)
                {
                    if (carlist[i].Location.X > 662 && carlist[i].Location.Y < 136)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //==============================cell4
                if (cell4.empty == false && cell3.empty == true)
                {
                    if (carlist[i].Location.X < 816 && carlist[i].Location.Y < 136)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell4.empty == false && cell8.empty == true)
                {
                    if (carlist[i].Location.X > 816 && carlist[i].Location.Y > 120 && carlist[i].Location.X < 952)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //=================cell5
                if (cell5.empty == false && cell1.empty == true)
                {
                    if (carlist[i].Location.X < 136 && carlist[i].Location.Y < 272)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell5.empty == false && cell6.empty == true)
                {
                    if (carlist[i].Location.X > 118 && carlist[i].Location.Y > 272 && carlist[i].Location.Y < 408)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell5.empty == false && cell9.empty == true)
                {
                    if (carlist[i].Location.X < 136 && carlist[i].Location.Y > 392 )
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //=================cell6
                if (cell6.empty == false && cell2.empty == true)
                {
                    if (carlist[i].Location.X > 272 && carlist[i].Location.X < 408 && carlist[i].Location.Y < 272)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell6.empty == false && cell7.empty == true)
                {
                    if (carlist[i].Location.X > 390 && carlist[i].Location.Y > 272 && carlist[i].Location.Y < 408)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell6.empty == false && cell10.empty == true)
                {
                    if (carlist[i].Location.X > 272 && carlist[i].Location.X < 408 && carlist[i].Location.Y > 392)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell6.empty == false && cell5.empty == true)
                {
                    if (carlist[i].Location.X < 272 && carlist[i].Location.Y > 272 && carlist[i].Location.Y < 408)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //=================cell7
                if (cell7.empty == false && cell3.empty == true)
                {
                    if (carlist[i].Location.X > 544 && carlist[i].Location.X < 680 && carlist[i].Location.Y < 272)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell7.empty == false && cell11.empty == true)
                {
                    if (carlist[i].Location.X > 544 && carlist[i].Location.X < 680 && carlist[i].Location.Y > 392)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell7.empty == false && cell6.empty == true)
                {
                    if (carlist[i].Location.X < 544 && carlist[i].Location.Y > 272 && carlist[i].Location.Y < 408)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell7.empty == false && cell8.empty == true)
                {
                    if (carlist[i].Location.X > 662 && carlist[i].Location.Y > 272 && carlist[i].Location.Y < 408)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //=================cell8
                if (cell8.empty == false && cell4.empty == true)
                {
                    if (carlist[i].Location.X > 816 && carlist[i].Location.X < 952 && carlist[i].Location.Y < 272)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell8.empty == false && cell12.empty == true)
                {
                    if (carlist[i].Location.X > 816 && carlist[i].Location.X < 952 && carlist[i].Location.Y > 392)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell8.empty == false && cell7.empty == true)
                {
                    if (carlist[i].Location.X < 816 && carlist[i].Location.Y > 272 && carlist[i].Location.Y < 408)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //=================cell9
                if (cell9.empty == false && cell5.empty == true)
                {
                    if (carlist[i].Location.X < 136 && carlist[i].Location.Y < 544)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell9.empty == false && cell10.empty == true)
                {
                    if (carlist[i].Location.X > 118 && carlist[i].Location.Y > 408)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //=================cell10
                if (cell10.empty == false && cell9.empty == true)
                {
                    if (carlist[i].Location.X < 272 && carlist[i].Location.Y > 544)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell10.empty == false && cell11.empty == true)
                {
                    if (carlist[i].Location.X > 392 && carlist[i].Location.Y > 544)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell10.empty == false && cell6.empty == true)
                {
                    if (carlist[i].Location.X > 272 && carlist[i].Location.X < 408 && carlist[i].Location.Y < 544)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //=================cell11
                if (cell11.empty == false && cell7.empty == true)
                {
                    if (carlist[i].Location.X > 544 && carlist[i].Location.X < 680 && carlist[i].Location.Y < 544)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell11.empty == false && cell10.empty == true)
                {
                    if (carlist[i].Location.X < 544 && carlist[i].Location.Y > 544)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell11.empty == false && cell12.empty == true)
                {
                    if (carlist[i].Location.X > 662 && carlist[i].Location.Y > 544)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                //=================cell12
                if (cell12.empty == false && cell8.empty == true)
                {
                    if (carlist[i].Location.X > 816 && carlist[i].Location.Y < 544)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                if (cell12.empty == false && cell11.empty == true)
                {
                    if (carlist[i].Location.X < 816 && carlist[i].Location.Y > 544)
                    {
                        int a = this.intpulist.Count;
                        Random randomizer = new Random();
                        int b = randomizer.Next(0, a);
                        int m = 0;
                        for (int w = 0; w < redpoint.Count; w++)
                        {
                            if (redpoint[w] == carlist[i].Location)
                            {
                                m = w;
                            }
                        }
                                                if(redpoint.Count!=0)redpoint.RemoveAt(m);
                        cars[i] = new Car(this.intpulist[b].point, this.imageList1.Images[2], this.intpulist[b], this);
                        pic[i].Image = this.imageList1.Images[2];
                        pic[i].Location = cars[i].position;
                        pic[i].Size = new Size(18, 13);
                    }
                }
                foreach (Light item in lightlist)
                {
                    if (item.counter <= item.temp)
                    {
                        //---------------  red
                        if (item.startgreen == false)
                        {
                            if (item.counter < item.temp - item.Green - item.Yellow)
                            {
                                item.counter++;
                                item.Turnred();
                                Changelight(item.ap, 1);
                            }
                            else if (item.counter >= item.Red && item.counter <= item.temp - item.Yellow)
                            {
                                item.Turngreen();
                                item.counter++;
                                Changelight(item.ap, 0);
                            }
                            else if (item.counter > item.temp - item.Yellow && item.counter < item.temp)
                            {
                                item.Turnyellow();
                                item.counter++;
                                Changelight(item.ap, 2);
                            }
                            else if (item.counter == item.temp)
                            {
                                item.Turnred();
                                item.counter = 0;
                                Changelight(item.ap, 1);
                            }
                        }
                        //---------------------Green
                        if (item.startgreen)
                        {
                            if (item.counter < item.temp - item.Red - item.Yellow)
                            {
                                item.counter++;
                                item.Turngreen();
                                Changelight(item.ap, 0);
                            }
                            else if (item.counter >= item.Green && item.counter <= item.temp - item.Red)
                            {
                                item.Turnyellow();
                                item.counter++;
                                Changelight(item.ap, 2);
                            }
                            else if (item.counter > item.temp - item.Red && item.counter < item.temp)
                            {
                                item.Turnred();
                                item.counter++;
                                Changelight(item.ap, 1);
                            }
                            else if (item.counter == item.temp)
                            {
                                item.Turngreen();
                                item.counter = 0;
                                Changelight(item.ap, 0);
                            }
                        }
                    }
                }
            }
            //Roadcellltype();
            Turnarround();
            Turnroad();
        }


        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics gr = e.Graphics;
        //       foreach (Light l in lightlist)
        //       {
        //           l.Drawgreen(gr);
        //       }
        //}
        private void DrawLight()
        {
            foreach (Light l in lightlist)
            {
                PictureBox p1 = new PictureBox();


                Size size = new Size(17, 17);
                p1.Size = size;

                p1.Location = l.ap;
                p1.Parent = this.panel1;
                if (l.Lgreen)
                {
                    p1.Image = imagelistlight.Images[0];
                }
                else if (l.Lyellow == false)
                {
                    p1.Image = imagelistlight.Images[1];

                }
                else
                {
                    p1.Image = imagelistlight.Images[2];
                }
                lightpicturebox.Add(p1);
            }
        }
        public void Changelight(Point p, int ab)
        {
            foreach (PictureBox item in lightpicturebox)
            {
                if (item.Location == p)
                {
                    if (ab == 0)
                        item.Image = imagelistlight.Images[0];
                    else if (ab == 1)
                        item.Image = imagelistlight.Images[1];


                    else if (ab == 2)
                        item.Image = imagelistlight.Images[2];
                }


            }
        }
        public void Turnarround()
        {
            foreach (Car item in cars)
            {

                foreach (Cell c in cellList)
                {
                    if (item.Checkposition() == c.i)
                    {
                        if (c.TYPE == 1)
                        {
                            int x = c.P.X;
                            int y = c.P.Y;
                            //if (item.position.X == x + 94 && item.position.Y == y + 60 && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            //{
                            //    item.GetMove(0, -1);
                            //   // item.GetMove
                            //}
                            if (item.position.X == x + 44 && item.position.Y == y + 60)
                            {
                                item.GetMove(1,-1);
                            }
                            if (item.position.X == x + 94 && item.position.Y == y+10)
                            {
                                item.GetMove(0, -1);
                            }
                            //if (item.position.X == x + 42 && item.position.Y == y + 60 && (item.input.type == 4 || item.input.type == 5 || item.input.type == 10))
                            //{
                            //    item.GetMove(0, 1);
                            //}
                            if (item.position.X == x + 110 && item.position.Y == y + 60)
                            {
                                item.GetMove(-1, 1);
                            }
                            if (item.position.X == x + 42 && item.position.Y == y+128)
                            {
                                item.GetMove(0, 1);
                            }


                            if (item.position.X == x + 10 && item.position.Y == y + 95)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    item.GetMove(1, 0);
                                }
                                else
                                {
                                    item.GetMove(1, 1);
                                }
                            }
                            if (item.position.X == x + 42 && item.position.Y == y + 127)
                            {
                                item.GetMove(0, 1);
                            }


                            if (item.position.X == x + 94 && item.position.Y == y + 109)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 3);
                                if (b == 0)
                                {
                                    item.GetMove(-1, -1);
                                }
                                else if (b == 1)
                                {
                                    item.GetMove(0, -1);
                                }
                                else
                                {
                                    item.GetMove(1,-1);
                                }
                            }
                            if (item.position.X == x + 10 && item.position.Y == y + 25)
                            {
                                item.GetMove(-1, 0);
                            }
                            if (item.position.X == x + 118 && item.position.Y == y +85)
                            {
                                item.GetMove(1, 0);
                            }


                            //if (item.position.X == x + 94 && item.position.Y == y + 95 && (item.input.type == 6 || item.input.type == 11 || item.input.type == 12))
                            //{
                            //    Random a = new Random();
                            //    int b = a.Next(0, 3);
                            //    if (b == 0)
                            //    {
                            //        item.GetMove(1, 0);
                            //    }
                            //    else
                            //    {
                            //        item.GetMove(0, -1);
                            //    }
                            //}
                            //if (item.position.X == x + 42 && item.position.Y == y + 25 && (item.input.type == 3 || item.input.type == 8 || item.input.type == 9))
                            //{
                            //    Random a = new Random();
                            //    int b = a.Next(0, 3);
                            //    if (b == 0)
                            //    {
                            //        item.GetMove(-1, 0);
                            //    }
                            //    else
                            //    {
                            //        item.GetMove(0, 1);
                            //    }
                            //}

                            if (item.position.X == x + 119 && item.position.Y == y + 25)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    item.GetMove(-1, 0);
                                }
                                else
                                {
                                    item.GetMove(-1, -1);
                                }
                            }
                            if (item.position.X == x + 99 && item.position.Y == y+5)
                            {
                                item.GetMove(0, -1);
                            }


                            if (item.position.X == x + 42 && item.position.Y == y + 19)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 3);
                                if (b == 0)
                                {
                                    item.GetMove(-1, 1);
                                }
                                else if (b == 1)
                                {
                                    item.GetMove(0, 1);
                                }
                                else
                                {
                                    item.GetMove(1, 1);
                                }
                            }
                            if (item.position.X == x + 36 && item.position.Y == y + 25)
                            {
                                item.GetMove(-1, 0);
                            }
                            if (item.position.X == x + 118 && item.position.Y == y + 95)
                            {
                                item.GetMove(1, 0);
                            }
                        }
                        else if(c.TYPE==2)
                        {
                            int x = c.P.X;
                            int y = c.P.Y;
                            if (item.position.X == x + 60 && item.position.Y == y + 27 )//&& (item.input.type == 3 || item.input.type == 8 || item.input.type == 9))
                            {
                                item.GetMove(1, 1);
                                // item.GetMove
                            }
                            if (item.position.X == x + 127 && item.position.Y == y + 94)
                            {
                                item.GetMove(1, 0);
                            }


                            //if (item.position.X == x + 60 && item.position.Y == y + 42 && (item.input.type == 6 || item.input.type == 11 || item.input.type == 12))
                            //{
                            //    item.GetMove(-1, 0);
                            //}
                            if (item.position.X == x + 60 && item.position.Y == y + 92)
                            {
                                item.GetMove(-1, -1);
                            }
                            if (item.position.X == x +10 && item.position.Y == y + 42)
                            {
                                item.GetMove(-1, 0);
                            }


                            if (item.position.X == x + 25 && item.position.Y == y + 27)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    item.GetMove(-1, 1);
                                }
                                else
                                {
                                    item.GetMove(0, 1);
                                }
                            }
                            if (item.position.X == x + 25 && item.position.Y == y + 27)
                            {
                                item.GetMove(-1, 0);
                            }


                            if (item.position.X == x + 95 && item.position.Y == y + 111)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    item.GetMove(0, -1);
                                }
                                else
                                {
                                    item.GetMove(1,-1);
                                }
                            }
                            if (item.position.X == x + 112 && item.position.Y == y + 94)
                            {
                                item.GetMove(1, 0);
                            }


                            if (item.position.X == x + 10 && item.position.Y == y + 94)// && (item.input.type == 2 || item.input.type == 1 || item.input.type == 7))
                            {
                                Random a = new Random();
                                int b = a.Next(0, 3);
                                if (b == 0)
                                {
                                    item.GetMove(1,-1);
                                }
                                else if (b == 1)
                                {
                                    item.GetMove(1, 0);
                                }
                                else
                                {
                                    item.GetMove(1, 1);
                                }
                            }
                            if (item.position.X == x + 25 && item.position.Y == y +109)
                            {
                                item.GetMove(0, 1);
                            }
                            if (item.position.X == x + 95 && item.position.Y == y + 9)
                            {
                                item.GetMove(0, -1);
                            }


                            //if (item.position.X == x + 95 && item.position.Y == y + 42 && (item.input.type == 4 || item.input.type == 5 || item.input.type == 10))
                            //{
                            //    Random a = new Random();
                            //    int b = a.Next(0, 3);
                            //    if (b == 0)
                            //    {
                            //        item.GetMove(0, -1);
                            //    }
                            //    else
                            //    {
                            //        item.GetMove(-1, 0);
                            //    }
                            //}
                            if (item.position.X == x + 109 && item.position.Y == y + 42)// && (item.input.type == 2 || item.input.type == 1 || item.input.type == 7))
                            {
                                Random a = new Random();
                                int b = a.Next(0, 3);
                                if (b == 0)
                                {
                                    item.GetMove(-1, 0);
                                }
                                else if (b == 1)
                                {
                                    item.GetMove(-1, -1);
                                }
                                else
                                {
                                    item.GetMove(-1, 1);
                                }
                            }
                            if (item.position.X == x + 95 && item.position.Y == y + 28)
                            {
                                item.GetMove(0, -1);
                            }
                            if (item.position.X == x +25&& item.position.Y == y + 126)
                            {
                                item.GetMove(0, 1);
                            }

                        }
                        else if (c.TYPE == 3)
                        {
                            int x = c.P.X;
                            int y = c.P.Y;
                            if (item.position.X == x + 35 && item.position.Y == y + 60)// && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            {
                                item.GetMove(1,-1);
                            }
                            if (item.position.X == x + 90 && item.position.Y == y+5)// && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            {
                                item.GetMove(0, -1);
                            }


                            if (item.position.X == x + 85 && item.position.Y == y + 60 && (item.input.type == 4 || item.input.type == 5 || item.input.type == 10))
                            {
                                item.GetMove(-1, 1);
                            }
                            if (item.position.X == x + 25 && item.position.Y == y + 120)// && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            {
                                item.GetMove(0, 1);
                            }


                            if (item.position.X == x + 60 && item.position.Y == y + 29)// && (item.input.type == 3|| item.input.type == 8 || item.input.type == 9))
                            {
                                item.GetMove(1, 1);
                            }
                            if (item.position.X == x + 126 && item.position.Y == y + 95)// && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            {
                                item.GetMove(1, 0);
                            }


                            if (item.position.X == x + 60 && item.position.Y == y + 75 && (item.input.type == 11 || item.input.type == 12 || item.input.type == 6))
                            {
                                item.input.type =14;
                            }
                            if (item.position.X == x + 10 && item.position.Y == y + 25)// && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            {
                                item.GetMove(-1, 0);
                            }


                            if (item.position.X == x + 10 && item.position.Y == y + 95)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    item.GetMove(1, 0);
                                }
                                else
                                {
                                    item.GetMove(1, 1);
                                }
                            }
                            if (item.position.X == x + 25 && item.position.Y == y +110)// && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            {
                                item.GetMove(0, 1);
                            }


                            if (item.position.X == x + 95 && item.position.Y == y + 111)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    item.GetMove(1,-1);
                                }
                                else
                                {
                                    item.GetMove(0, -1);
                                }
                            }
                            if (item.position.X == x + 111 && item.position.Y == y + 95)// && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            {
                                item.GetMove(1, 0);
                            }


                            if (item.position.X == x + 120 && item.position.Y == y + 25)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    item.GetMove(-1, 0);
                                }
                                else
                                {
                                    item.GetMove(-1, -1);
                                }
                            }
                            if (item.position.X == x + 105 && item.position.Y == y+10)// && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            {
                                item.GetMove(0, -1);
                            }


                            if (item.position.X == x + 25 && item.position.Y == y+10)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    item.GetMove(0, 1);
                                }
                                else
                                {
                                    item.GetMove(-1, 1);
                                }
                            }
                            if (item.position.X == x + 10 && item.position.Y == y+25)// && (item.input.type == 1 || item.input.type == 2 || item.input.type == 7))
                            {
                                item.GetMove(-1, 0);
                            }
                        }
                    }
                }
            }
        }
        public void Turnroad()
        {
            foreach (Car item in cars)
            {
                foreach (RoadCell r in RoadcellListNew)
                {
                    if (item.Checkposition() == r.i)
                    {
                        int x = r.P.X;
                        int y = r.P.Y;
                        if (r.type == 4)
                        {
                            if (item.position.X == x + 74 && item.position.Y == y + 94 )
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {

                                    int n=-1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 95;
                                    item.x = x + 75;
                                }
                                else
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 60;
                                    item.x = x + 75;
                                }

                            }
                            if (item.position.X == x + 90 && item.position.Y == y + 25)
                            {
                                int n = -1;
                                for (int i = 0; i < redpoint.Count; i++)
                                {
                                    if (redpoint[i] == item.position)
                                    {
                                        n = i;
                                    }
                                }
                                if(n!=-1)
                                                        if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                item.y = y + 42;
                                item.x = x + 89;
                            }
                        }
                        if (r.type == 6)
                        {
                            if (item.position.X == x + 54 && item.position.Y == y + 42)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y= y + 60;
                                    item.x = x + 53;
                                }
                                else
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 25;
                                    item.x = x + 53;
                                }
                            }
                            if (item.position.X == x + 90 && item.position.Y == y + 25)
                            {
                                int n = -1;
                                for (int i = 0; i < redpoint.Count; i++)
                                {
                                    if (redpoint[i] == item.position)
                                    {
                                        n = i;
                                    }
                                }
                                if (n != -1)
                                                        if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                item.y = y + 42;
                                item.x = x + 91;
                            }
                        }
                        if (r.type == 5)
                        {
                            if (item.position.X == x + 42 && item.position.Y == y + 54)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 55;
                                    item.x = x + 25;
                                }
                                else
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 55;
                                    item.x= x + 60;
                                }
                            }
                            if (item.position.X == x + 95 && item.position.Y == y + 54)
                            {
                                int n = -1;
                                for (int i = 0; i < redpoint.Count; i++)
                                {
                                    if (redpoint[i] == item.position)
                                    {
                                        n = i;
                                    }
                                }
                                if (n != -1)
                                                        if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                item.y = y + 53;
                                item.x = x + 94;
                            }
                        }
                        if (r.type == 7)
                        {
                            if (item.position.X == x + 94 && item.position.Y == y + 77)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 76;
                                    item.x = x + 95;
                                }
                                else
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 76;
                                    item.x = x + 60;
                                }
                            }
                            if (item.position.X == x + 25 && item.position.Y == y + 54)
                            {
                                int n = -1;
                                for (int i = 0; i < redpoint.Count; i++)
                                {
                                    if (redpoint[i] == item.position)
                                    {
                                        n = i;
                                    }
                                }
                                if (n != -1)
                                                        if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                item.y = y + 55;
                                item.x = x + 42;
                            }
                        }
                        if (r.type == 2)
                        {
                            if (item.position.X == x + 60 && item.position.Y == y + 95)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 60;
                                    item.x = x + 61;
                                }
                                else
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 95;
                                    item.x = x + 61;
                                }
                            }
                            if (item.position.X == x + 64 && item.position.Y == y + 25)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 60;
                                    item.x = x + 63;
                                }
                                else
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 25;
                                    item.x = x + 63;
                                }
                            }
                        }
                        if (r.type == 3)
                        {
                            if (item.position.X == x + 25 && item.position.Y == y + 66)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 67;
                                    item.x = x + 25;
                                }
                                else
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 67;
                                    item.x = x + 60;
                                }
                            }
                            if (item.position.X == x + 95 && item.position.Y == y + 77)
                            {
                                Random a = new Random();
                                int b = a.Next(0, 2);
                                if (b == 0)
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 76;
                                    item.x = x + 95;
                                }
                                else
                                {
                                    int n = -1;
                                    for (int i = 0; i < redpoint.Count; i++)
                                    {
                                        if (redpoint[i] == item.position)
                                        {
                                            n = i;
                                        }
                                    }
                                    if (n != -1)
                                                            if(redpoint.Count!=0)redpoint.RemoveAt(n);
                                    item.y = y + 76;
                                    item.x = x + 60;
                                }
                            }
                        }
                    }
                }
            }
        }
        public void Roadcellltype()
        {
            foreach (RoadCell r in RoadcellListNew)
            {
                if (r.Image == ILR.Images[0])
                {
                    r.type = 0;
                }
                else if (r.Image == ILR.Images[1])
                {
                    r.type = 1;
                }
                else if (r.Image == ILR.Images[2])
                {
                    r.type = 2;
                }
                else if (r.Image == ILR.Images[3])
                {
                    r.type = 3;
                }
                else if (r.Image == ILR.Images[4])
                {
                    r.type = 4;
                }
                else if (r.Image == ILR.Images[5])
                {
                    r.type = 5;
                }
                else if (r.Image == ILR.Images[6])
                {
                    r.type = 6;
                }
                else if (r.Image == ILR.Images[7])
                {
                    r.type = 7;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Addcar();
        }


    }
}
