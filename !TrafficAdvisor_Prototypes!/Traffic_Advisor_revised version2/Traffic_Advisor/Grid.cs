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
    class Grid
    {
        //about creating the gird.
        private int HorizontalCells { get; set; }
        private int VerticalCells { get; set; }
        private Point Origin { get; set; }
        private Size GridCellSize { get; set; }

        public Cell[,] Cells { get;private set; }
        
        public Grid(Point p,Size s,int v,int h)
        {
            // Set some defaults
            Origin = p;
            GridCellSize = s;
            HorizontalCells=h;
            VerticalCells=v;

            Cells = new Cell[v, h];
        }
     

        public virtual void Draw(Graphics Graf, Pen pencil)
        {
            Point startP = new Point();
            Point endP = new Point();
            // Draw horizontals
            startP.X = Origin.X;
            endP.X = Origin.X + VerticalCells * GridCellSize.Width;
            for (int i = 0; i <= HorizontalCells; i++)
            {
                startP.Y = Origin.Y + i * GridCellSize.Height;
                endP.Y = startP.Y;
                Graf.DrawLine(pencil, startP, endP);
            }
            // Draw verticals
            startP.Y = Origin.Y;
            endP.Y = Origin.Y + HorizontalCells * GridCellSize.Height;
            for (int i = 0; i <= VerticalCells; i++)
            {
                startP.X = Origin.X + i * GridCellSize.Width;
                endP.X = startP.X;
                Graf.DrawLine(pencil, startP, endP);
            }
        }

        public int AddOneCell(Cell c)
        {
            foreach (Cell ce in Cells)
            {
                if (ce != null)
                    if (ce.X == c.X && ce.Y == c.Y)
                        return -1;
            }
            Cells[c.X, c.Y] = c;
            return 1;
        }

        public void RemoveOneCell(Cell c)
        {
            Cells[c.X, c.Y] = null;
        }

        public Cell GetCellByPosition(int x,int y)
        {
            int newX = x / 200;
            int newY = y / 200;
            foreach (Cell c in Cells)
            {
                if (c != null)
                    if (newX == c.X && newY == c.Y)
                        return c;
            }
            return null;
        }
    }
}
