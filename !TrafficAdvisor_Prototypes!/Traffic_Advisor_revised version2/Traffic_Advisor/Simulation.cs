using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Advisor
{
    class Simulation
    {
        public Grid Grid { get;private set; }
        public Status status { get;private set; }

        public static List<string> LogBook = new List<string>();


        public Simulation()
        {
            status = Status.initial;
        }

        public void SetGrid(Grid g)
        {
            this.Grid = g;
        }

        public void SetStatus(Status s)
        {
            this.status = s;
        }

        public bool SetUp()
        {
            foreach (Cell c in Grid.Cells)
            {
                if (c != null)
                    return true;
            }
            return false;
        }

        
        public void nextSecond()
        {
            foreach (Cell c in Grid.Cells)
            {
                if (c != null)
                {
                    //Crossing left, Crossing up, Crossing right, Crossing down
                    Crossing left = null;
                    Crossing up = null;
                    Crossing right = null;
                    Crossing down = null;
                    if (c.X > 0)
                        if (this.Grid.GetCellByPosition((c.X - 1) * 200, c.Y * 200) != null)
                            left = this.Grid.GetCellByPosition((c.X - 1) * 200, c.Y * 200).corssing;
                    if (c.Y > 0)
                        if (this.Grid.GetCellByPosition((c.X) * 200, (c.Y - 1) * 200) != null)
                            up = this.Grid.GetCellByPosition((c.X) * 200, (c.Y - 1) * 200).corssing;
                    if (c.X < 3)
                        if (this.Grid.GetCellByPosition((c.X + 1) * 200, c.Y * 200) != null)
                            right = this.Grid.GetCellByPosition((c.X + 1) * 200, c.Y * 200).corssing;
                    if (c.Y < 2)
                        if (this.Grid.GetCellByPosition((c.X) * 200, (c.Y + 1) * 200) != null)
                            down = this.Grid.GetCellByPosition((c.X) * 200, (c.Y + 1) * 200).corssing;

                    c.corssing.NextSecond(left, up, right, down);
                }
            }
        }


    }
}
