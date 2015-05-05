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
        private Simulation simulation;
        private string filepath;
        Grid myGrid;
        string currentSelectedType = "";
        bool saved;

        public Project_Grid_Screen(string path)
        {
            InitializeComponent();

            filepath = path;

            this.pbGrid.AllowDrop = true;//hidden function....

            myGrid = new Grid(new Point(0, 0), new Size(200, 200), 4, 3);

            simulation = new Simulation();
            simulation.SetGrid(myGrid);

            if (path != "")
            {
                simulation = FileHelper.LoadFromFile(filepath);
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
            if (simulation.status != Status.initial)
                return;
            currentSelectedType = "A";
            pbtypeA.DoDragDrop(pbtypeA.Image, DragDropEffects.Copy);
        }

        private void pbtypeB_MouseDown(object sender, MouseEventArgs e)
        {
            if (simulation.status != Status.initial)
                return;
            currentSelectedType = "B";
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
                {
                    #region  //draw the traffic lights and the number of flow.

                    g.DrawImage(ce.image, new Point(ce.X * 200, ce.Y * 200));

                    g.DrawString(ce.corssing.Lanes[0].CurrentFlow.ToString(), new Font("April", 10), new SolidBrush(ce.corssing.Lanes[0].color), ce.X * 200 + 5, ce.Y * 200 + 100);
                    if (ce.corssing.Lanes[0].Light.CurrentLight == LightStatus.green)
                        g.FillRectangle(new SolidBrush(Color.Green), ce.X * 200 + 22, ce.Y * 200 + 100, 12, 12);
                    if (ce.corssing.Lanes[0].Light.CurrentLight == LightStatus.red)
                        g.FillRectangle(new SolidBrush(Color.Red), ce.X * 200 + 22, ce.Y * 200 + 100, 12, 12);
                    if (ce.corssing.Lanes[0].Light.CurrentLight == LightStatus.yellow)
                        g.FillRectangle(new SolidBrush(Color.Yellow), ce.X * 200 + 22, ce.Y * 200 + 100, 12, 12);
                    g.DrawString(ce.corssing.Lanes[1].CurrentFlow.ToString(), new Font("April", 10), new SolidBrush(ce.corssing.Lanes[1].color), ce.X * 200 + 5, ce.Y * 200 + 120);
                    if (ce.corssing.Lanes[1].Light.CurrentLight == LightStatus.green)
                        g.FillRectangle(new SolidBrush(Color.Green), ce.X * 200 + 22, ce.Y * 200 + 120, 12, 12);
                    if (ce.corssing.Lanes[1].Light.CurrentLight == LightStatus.red)
                        g.FillRectangle(new SolidBrush(Color.Red), ce.X * 200 + 22, ce.Y * 200 + 120, 12, 12);
                    if (ce.corssing.Lanes[1].Light.CurrentLight == LightStatus.yellow)
                        g.FillRectangle(new SolidBrush(Color.Yellow), ce.X * 200 + 22, ce.Y * 200 + 120, 12, 12);
                    g.DrawString(ce.corssing.Lanes[2].CurrentFlow.ToString(), new Font("April", 10), new SolidBrush(ce.corssing.Lanes[2].color), ce.X * 200 + 65, ce.Y * 200 + 5);
                    if (ce.corssing.Lanes[2].Light.CurrentLight == LightStatus.green)
                        g.FillRectangle(new SolidBrush(Color.Green), ce.X * 200 + 65, ce.Y * 200 + 22, 12, 12);
                    if (ce.corssing.Lanes[2].Light.CurrentLight == LightStatus.red)
                        g.FillRectangle(new SolidBrush(Color.Red), ce.X * 200 + 65, ce.Y * 200 + 22, 12, 12);
                    if (ce.corssing.Lanes[2].Light.CurrentLight == LightStatus.yellow)
                        g.FillRectangle(new SolidBrush(Color.Yellow), ce.X * 200 + 65, ce.Y * 200 + 22, 12, 12);
                    g.DrawString(ce.corssing.Lanes[3].CurrentFlow.ToString(), new Font("April", 10), new SolidBrush(ce.corssing.Lanes[3].color), ce.X * 200 + 85, ce.Y * 200 + 5);
                    if (ce.corssing.Lanes[3].Light.CurrentLight == LightStatus.green)
                        g.FillRectangle(new SolidBrush(Color.Green), ce.X * 200 + 85, ce.Y * 200 + 22, 12, 12);
                    if (ce.corssing.Lanes[3].Light.CurrentLight == LightStatus.red)
                        g.FillRectangle(new SolidBrush(Color.Red), ce.X * 200 + 85, ce.Y * 200 + 22, 12, 12);
                    if (ce.corssing.Lanes[3].Light.CurrentLight == LightStatus.yellow)
                        g.FillRectangle(new SolidBrush(Color.Yellow), ce.X * 200 + 85, ce.Y * 200 + 22, 12, 12);
                    g.DrawString(ce.corssing.Lanes[4].CurrentFlow.ToString(), new Font("April", 10), new SolidBrush(ce.corssing.Lanes[4].color), ce.X * 200 + 185, ce.Y * 200 + 60);
                    if (ce.corssing.Lanes[4].Light.CurrentLight == LightStatus.green)
                        g.FillRectangle(new SolidBrush(Color.Green), ce.X * 200 + 165, ce.Y * 200 + 62, 12, 12);
                    if (ce.corssing.Lanes[4].Light.CurrentLight == LightStatus.red)
                        g.FillRectangle(new SolidBrush(Color.Red), ce.X * 200 + 165, ce.Y * 200 + 62, 12, 12);
                    if (ce.corssing.Lanes[4].Light.CurrentLight == LightStatus.yellow)
                        g.FillRectangle(new SolidBrush(Color.Yellow), ce.X * 200 + 165, ce.Y * 200 + 62, 12, 12);
                    g.DrawString(ce.corssing.Lanes[5].CurrentFlow.ToString(), new Font("April", 10), new SolidBrush(ce.corssing.Lanes[5].color), ce.X * 200 + 185, ce.Y * 200 + 80);
                    if (ce.corssing.Lanes[5].Light.CurrentLight == LightStatus.green)
                        g.FillRectangle(new SolidBrush(Color.Green), ce.X * 200 + 165, ce.Y * 200 + 82, 12, 12);
                    if (ce.corssing.Lanes[5].Light.CurrentLight == LightStatus.red)
                        g.FillRectangle(new SolidBrush(Color.Red), ce.X * 200 + 165, ce.Y * 200 + 82, 12, 12);
                    if (ce.corssing.Lanes[5].Light.CurrentLight == LightStatus.yellow)
                        g.FillRectangle(new SolidBrush(Color.Yellow), ce.X * 200 + 165, ce.Y * 200 + 82, 12, 12);
                    g.DrawString(ce.corssing.Lanes[6].CurrentFlow.ToString(), new Font("April", 10), new SolidBrush(ce.corssing.Lanes[6].color), ce.X * 200 + 105, ce.Y * 200 + 180);
                    if (ce.corssing.Lanes[6].Light.CurrentLight == LightStatus.green)
                        g.FillRectangle(new SolidBrush(Color.Green), ce.X * 200 + 105, ce.Y * 200 + 165, 12, 12);
                    if (ce.corssing.Lanes[6].Light.CurrentLight == LightStatus.red)
                        g.FillRectangle(new SolidBrush(Color.Red), ce.X * 200 + 105, ce.Y * 200 + 165, 12, 12);
                    if (ce.corssing.Lanes[6].Light.CurrentLight == LightStatus.yellow)
                        g.FillRectangle(new SolidBrush(Color.Yellow), ce.X * 200 + 105, ce.Y * 200 + 165, 12, 12);
                    g.DrawString(ce.corssing.Lanes[7].CurrentFlow.ToString(), new Font("April", 10), new SolidBrush(ce.corssing.Lanes[7].color), ce.X * 200 + 125, ce.Y * 200 + 180);
                    if (ce.corssing.Lanes[7].Light.CurrentLight == LightStatus.green)
                        g.FillRectangle(new SolidBrush(Color.Green), ce.X * 200 + 125, ce.Y * 200 + 165, 12, 12);
                    if (ce.corssing.Lanes[7].Light.CurrentLight == LightStatus.red)
                        g.FillRectangle(new SolidBrush(Color.Red), ce.X * 200 + 125, ce.Y * 200 + 165, 12, 12);
                    if (ce.corssing.Lanes[7].Light.CurrentLight == LightStatus.yellow)
                        g.FillRectangle(new SolidBrush(Color.Yellow), ce.X * 200 + 125, ce.Y * 200 + 165, 12, 12);
                    #endregion
                }
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
            if (simulation.status != Status.initial)
                return;

            Point newPoint = pbGrid.PointToClient(new Point(e.X, e.Y));
            Cell c = new Cell(newPoint.X, newPoint.Y);

            if (myGrid.AddOneCell(c) == -1)
            {
                MessageBox.Show("You can not put the crossing here, it is occupied!");
                return;
            }

            Image currentimmage = (Image)e.Data.GetData(DataFormats.Bitmap);

            //MessageBox.Show(newPoint.X + " " + newPoint.Y);
            if (currentSelectedType == "A")
                c.SetImageAndCrossing(currentimmage, new CrossingA());
            else
                c.SetImageAndCrossing(currentimmage, new CrossingB());

            pbGrid.Invalidate();

            CrossingEditer ce = new CrossingEditer(c);
            ce.ShowDialog();

            //MessageBox.Show(c.Test);
        }

        private void pbGird_MouseClick(object sender, MouseEventArgs e)
        {
            if (simulation.status != Status.initial)
                return;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //Point newPoint = pbGrid.PointToClient(new Point(e.X, e.Y));
                if (myGrid.GetCellByPosition(e.X, e.Y) != null)
                {
                    //Declare the menu items and the shortcut menu.
                    MenuItem[] menuItems = new MenuItem[4];
                    menuItems[0] = new MenuItem("Delete");
                    menuItems[1] = new MenuItem("Alter max flow of lanes");
                    menuItems[2] = new MenuItem("Alter traffic lights Interval");
                    menuItems[3] = new MenuItem("Alter lane current flow");
                    ContextMenu buttonMenu = new ContextMenu(menuItems);

                    buttonMenu.Show(pbGrid, new Point(e.X, e.Y));

                    menuItems[0].Click += new EventHandler((obj, evargs) => Project_Grid_Screen_Click(obj, evargs, e.X, e.Y));
                    menuItems[1].Click += new EventHandler((obj, evargs) => Project_Grid_Screen_Click_AlterFlow(obj, evargs, e.X, e.Y));
                    menuItems[2].Click += new EventHandler((obj, evargs) => Project_Grid_Screen_Click_AlterInterval(obj, evargs, e.X, e.Y));
                    menuItems[3].Click += new EventHandler((obj, evargs) => Project_Grid_Screen_Click_AlterCurrentFlow(obj, evargs, e.X, e.Y));
                }
            }
        }

        void Project_Grid_Screen_Click(object sender, EventArgs e, int x, int y)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this crossing?", "Delete?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                myGrid.RemoveOneCell(myGrid.GetCellByPosition(x, y));
                //MessageBox.Show("deleted");

                pbGrid.Invalidate();
            }
            else
            {
                return;
            }
           
        }

        void Project_Grid_Screen_Click_AlterFlow(object sender, EventArgs e,int x,int y)
        {
            CrossingEditer ce = new CrossingEditer(simulation.Grid.GetCellByPosition(x, y));
            ce.ShowDialog();

            pbGrid.Invalidate();
        }

        void Project_Grid_Screen_Click_AlterInterval(object sender, EventArgs e, int x, int y)
        {
            TrafficLightSettings ce = new TrafficLightSettings(simulation.Grid.GetCellByPosition(x, y));
            ce.ShowDialog();

            pbGrid.Invalidate();
        }

        void Project_Grid_Screen_Click_AlterCurrentFlow(object sender, EventArgs e, int x, int y)
        {
            AlterFlow ce = new AlterFlow(simulation.Grid.GetCellByPosition(x, y));
            ce.ShowDialog();

            pbGrid.Invalidate();
        }

        #region nosence
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
        { }
        #endregion

        private void btPlay_Click(object sender, EventArgs e)
        {
            if (simulation.status!=Status.running)
            {
                btPlay.BackgroundImage = Properties.Resources.pauze;
                simulation.SetStatus(Status.running);
            }
            else
            {
                btPlay.BackgroundImage = Properties.Resources.play;
                simulation.SetStatus(Status.pauze);
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            btPlay.BackgroundImage = Properties.Resources.play;
            simulation.SetStatus(Status.initial);
        }

        private void timerUpdateInfo_Tick(object sender, EventArgs e)
        {
            if (simulation.status == Status.running)
            {
                simulation.nextSecond();
                pbGrid.Invalidate();
                lb_Statistics.Items.Clear();
                foreach (string s in Simulation.LogBook)
                {
                    lb_Statistics.Items.Add(s);
                }
                lb_Statistics.SelectedIndex = lb_Statistics.Items.Count - 1;
            }
            
        }

        private void btSetup_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (simulation.Grid.Cells[i, j]!=null)
                        foreach (Lane l in simulation.Grid.Cells[i, j].corssing.Lanes)
                        {
                            l.SetCurrentFlow(r.Next(0, 100));
                            l.Light.NextSecond();
                            pbGrid.Invalidate();
                        }
                }
                
            }
            
        }

        private void Project_Grid_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to Quit?", "Exit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //save file system here.
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
