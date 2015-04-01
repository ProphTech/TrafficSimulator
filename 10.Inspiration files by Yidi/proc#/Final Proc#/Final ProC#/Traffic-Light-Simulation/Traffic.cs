using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Traffic_Light_Simulation
{
    [Serializable]
    class Traffic
    {
// ReSharper disable once NotAccessedField.Local
        private readonly string _name;
        public List<Crossing> Traficsrossings = new List<Crossing>();
        public Rectangle[] Myrectangles = new Rectangle [12];
        


        /// <summary>
        /// This is the constructor of the traffic class
        /// </summary>
        public Traffic(String nm)
        {
            _name = nm;
            var initialX = 5;
            var initialY = 5;
            const int width = 200;
            const int height = 200;
            var s = new Size(width, height);
            var i = 0; //number of rectangles
            for(var y=0; y<3; y++)
            {
                for (var x = 0; x<4; x++)
                {
                    var pt = new Point(initialX, initialY);
                    Myrectangles[i] = new Rectangle(pt, s);
                    i++;
                    initialX += 200;
                }
                initialY += 200;
                initialX = 5;
                
            }
            
           
            //loop to add the lis
            /*
            */
        }


        /// <summary>
        /// This method will be called to add a crossing to the traffic system
        /// </summary>
        /// <param name="crossing"></param>
        /// <param name="pt">The position of the crossing tht the user wants to place the crossing</param>
        /// <returns>returns true if the crossing is successfully added and false otherwise</returns>
        public bool AddCrossing(Crossing crossing, Point pt)
        {
            //checks if no overlap
        
            
            //listOfCrossings.Add();
            // calls incomingandoutgoingcar(created crossing)
            switch (Traficsrossings.Count)
            {
                case 0:
                    Traficsrossings.Add(crossing);
                    return true;
                default:
                {
                    var size=Traficsrossings.Count;
                    for (var x = 0; x < size; x++)
                    {
                        if (pt == Traficsrossings[x].GetRectangle().Location)
                        {
                            // MessageBox.Show("the selected area have crossing, please select other place");
                            //dont put windows form bojects(msgs) here coz it might be used by other tools
                            return false;

                        }
                    }
                    

               
               
                    Traficsrossings.Add(crossing);
                    FindNeighbour(crossing);
                    return true;
                    


                
                }
            }
            //return true;
        }

        /// <summary>
        /// This method removes a crossing from the traffic system 
        /// </summary>
        /// <param name="position">The position where the crossing that shouldbe removed is</param>
        /// <returns>returns true if the crossing is successfully removed and false otherwise</returns>
        public bool RemoveCrossing(Point position)
        {
           // calculatePosition(position);
            var removed = false;
            for (var x = 0; x < Traficsrossings.Count; x++ )
            {
                if (position != Traficsrossings[x].Crossingrect.Location) continue;
                Traficsrossings.Remove(Traficsrossings[x]);
                removed= true;
            }
            return removed;
            
        }

        /// <summary>
        /// This method is called to start the simulation i.e,the cars start moving,the traffic lights start controlling..etc 
        /// </summary>
        public void StartSimulation(int index, string state)
        {
            switch (state)
            {
                case "keepmove":
                    foreach (var crossing in Traficsrossings)
                    {
                        crossing.BeRed(index); //keep moving for car that crossed stop point

                        // ourtraffic.traficsrossings[x].moveincoming();
                    }
                    break;
                case "move":
                    foreach (var crossing in Traficsrossings)
                    {
                        //crossing.BeRed(index);
                        crossing.BeGreen(index); //keep moving for car that crossed stop point

                        // ourtraffic.traficsrossings[x].moveincoming();
                    }
                    break;


                
            }
        }

       
        /// <summary>
        /// This method paints the list of crossings
        /// </summary>
        /// <param name="gr">The graphics on which the crossings will be painted</param>
        public void PaintAllCrossing(Graphics gr)
        {
            foreach (var crossing in Traficsrossings)
            {
                crossing.PaintSelf(gr);
            }
        }

        /// <summary>
        /// a method which checks the neighbours of a given crossing corresponding to their direction
        /// </summary>
        /// <param name="currentCrossing"> the crossing which its neighbours are to be found</param>
        /// <returns>a number of crossing which are neighbours to the parameter crossing</returns>
        public void FindNeighbour(Crossing currentCrossing)
        {
            foreach (Crossing crossing in Traficsrossings)
            {
//adding north
                if (currentCrossing.Position.Y - currentCrossing.Crossingrect.Height == crossing.Position.Y 
                    && currentCrossing.Position.X == crossing.Position.X)
                {
                    currentCrossing.Myneighbours.Insert(0, crossing);
                    // to add for the other existing neghbour

                   
                    crossing.Myneighbours.Insert(2, currentCrossing);
                    
                   
                }
                    //adding east
                else if (currentCrossing.Position.X + currentCrossing.Crossingrect.Width == crossing.Position.X 
                    && currentCrossing.Position.Y == crossing.Position.Y)
   
                {
                    currentCrossing.Myneighbours.Insert(1, crossing);
                   
                    crossing.Myneighbours.Insert(3, currentCrossing);
                }
                    // adding south
                else if (currentCrossing.Position.Y + currentCrossing.Crossingrect.Height == crossing.Position.Y
                    && currentCrossing.Position.X == crossing.Position.X)
   
                {
                    currentCrossing.Myneighbours.Insert(2, crossing);
                   
                    crossing.Myneighbours.Insert(0, currentCrossing);
                }
                    //  adding west
                else if (currentCrossing.Position.X - currentCrossing.Crossingrect.Width == crossing.Position.X 
                    && currentCrossing.Position.Y == crossing.Position.Y)
   
                {
                    currentCrossing.Myneighbours.Insert(3, crossing);
                   
                    crossing.Myneighbours.Insert(1, currentCrossing);
                }
            }
        }

        /// <summary>
        /// get the rectamgle which has same pointer with rh paramter
        /// </summary>
        /// <param name="pt">pointer</param>
        /// <returns>cell</returns>
        public Rectangle GetRectangle(Point pt)
        {

            var temporect = new Rectangle();
            foreach (var rectangle in Myrectangles)
            {
                if (rectangle.Location == pt)
                {
                    return rectangle;
                }
            }
            return temporect;
        }

        public void DrawZoom(Graphics g, Point p, float scale)
        {
            g.ScaleTransform(scale, scale);

            foreach (var c in Traficsrossings.Where(c => c.Position == p))
            {
                c.PaintSelf(g);
            }
        }
    }
}
