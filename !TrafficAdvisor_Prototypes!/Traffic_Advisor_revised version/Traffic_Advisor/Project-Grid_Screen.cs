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
    public partial class Project_Grid_Screen : Form
    {
        private ProjectManager pm;
        private string filepath;
        Grid myGrid;
        bool saved;

        public Project_Grid_Screen(string path)
        {
            InitializeComponent();

            filepath = path;

            this.pbGrid.AllowDrop = true;//hidden function....

            myGrid = new Grid(new Point(0, 0), new Size(200, 200), 4, 3);

            pm = new ProjectManager();
            if (path != "")
            {
                pm = FileHelper.LoadFromFile(filepath);
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you realy want to Reset everything?", "Reset?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

            }
            else
            {
 
            }
        }

        private void pbtypeA_MouseDown(object sender, MouseEventArgs e)
        {
            pbtypeA.DoDragDrop(pbtypeA.Image, DragDropEffects.Copy);
        }

        private void pbtypeB_MouseDown(object sender, MouseEventArgs e)
        {
            pbtypeB.DoDragDrop(pbtypeB.Image, DragDropEffects.Copy);
        }

        private void pbGird_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Black, 2f);
            myGrid.Draw(e.Graphics, myPen);

            Graphics g = e.Graphics;

            foreach (Cell ce in myGrid.Cells)
            {
                if (ce != null)
                    g.DrawImage(ce.image, new Point(ce.X * 200, ce.Y * 200));
            } 
        }

        private void pbGird_DragEnter(object sender, DragEventArgs e)
        {
            //e.Effect = e.AllowedEffect;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pbGird_DragDrop(object sender, DragEventArgs e)
        {
            Image currentimmage = (Image)e.Data.GetData(DataFormats.Bitmap);
            Point newPoint = pbGrid.PointToClient(new Point(e.X, e.Y));
            Cell c = new Cell(newPoint.X,newPoint.Y);
            //MessageBox.Show(newPoint.X + " " + newPoint.Y);
            c.SetImage(currentimmage);
            if (myGrid.AddOneCell(c) == -1)
            {
                MessageBox.Show("You can not put the crossing here, it is occupied!");
                return;
            }
            pbGrid.Invalidate();
        }

        private void pbGird_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //Point newPoint = pbGrid.PointToClient(new Point(e.X, e.Y));
                if (myGrid.GetCellByPosition(e.X, e.Y) != null)
                {
                    //Declare the menu items and the shortcut menu.
                    MenuItem[] menuItems = new MenuItem[1];
                    menuItems[0] = new MenuItem("Delete");
                    ContextMenu buttonMenu = new ContextMenu(menuItems);

                    buttonMenu.Show(pbGrid, new Point(e.X, e.Y));

                    menuItems[0].Click += new EventHandler((obj, evargs) => Project_Grid_Screen_Click(obj, evargs, e.X, e.Y));
                }
            }
        }

        void Project_Grid_Screen_Click(object sender, EventArgs e,int x,int y)
        {
            myGrid.RemoveOneCell(myGrid.GetCellByPosition(x,y));
            MessageBox.Show("deleted");

            pbGrid.Invalidate();
        }





        private void mainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void Project_Grid_Screen_Paint(object sender, PaintEventArgs e)
        {}

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void newSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void Project_Grid_Screen_DragDrop(object sender, DragEventArgs e)
        {}

        private void Project_Grid_Screen_DragEnter(object sender, DragEventArgs e)
        {}

        private void pbtypeB_MouseClick(object sender, MouseEventArgs e)
        {}

        
    }
}
