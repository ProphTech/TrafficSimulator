
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Traffic_Light_Simulation
{
    [Serializable]
   abstract class Crossing
    {

      // List<Lane> listOfLanes = new List<Lane>(12);
       readonly List<Lane> _listOfLanes = new List<Lane>();
      // List<Group> myGroup = new List<Group>(4);
      public List<Group> MyGroup = new List<Group>();
       public List<Crossing> Myneighbours = new List<Crossing>(4);


       public string Type;
       bool checkoutgoing = false;
        public Point Position;
        public Rectangle Crossingrect;
       readonly Point[] _startPoint = new Point[14];

       readonly Point[] _turning = new Point[12];
       readonly Point[] _endPoint = new Point[14];
       readonly Point[] _stopPoint = new Point[14];


       private const int Cap = 3;


       public  Image Crossingimg;
       public int Time;

        /// <summary>
        /// This is the constructor of the crossing class
        /// </summary>
        /// <param name="img"></param>
        /// <param name="type">This is the type of crossing</param>
        /// <param name="rect"></param>
        protected Crossing(Rectangle rect, Image img, string type)
        {

            Position = rect.Location;
            Crossingrect = rect;
            Crossingimg = img;
            Type = type;
            CreateGroup();

            for (var x = 0; x < 4; x++)
            {
                Myneighbours.Add(null);
            }
        }


        public void CreateGroup()
        {
            //***********************************************************************************
            //startPoint[0].X = position.X;
            

            _startPoint[0] = new Point(Position.X + 59, Position.Y);
            _endPoint[0] = new Point(Position.X, Position.Y + 72+2);
            _turning[0] = new Point(_startPoint[0].X, _endPoint[0].Y);
            _stopPoint[0] = new Point(Position.X + 59, Position.Y + 35);
            //Lane lane1 = new Lane(startPoint[0], turning[0],endPoint[0], cap);
            //**********************************************************************************

            _startPoint[1] = new Point(Position.X + 78, Position.Y);
            _endPoint[1] = new Point(Position.X + 78, Position.Y + 200);//
            _turning[1] = new Point(_startPoint[1].X, _endPoint[1].Y);
            _stopPoint[1] = new Point(Position.X + 78, Position.Y + 35);
            //Lane lane2 = new Lane(startPoint[1], turning[1], endPoint[1], cap);

            //************************************************************************************

            _startPoint[2] = new Point(Position.X + 97, Position.Y);
            _endPoint[2] = new Point(Position.X+200, Position.Y + 128-9);
            _turning[2] = new Point(_startPoint[2].X, _endPoint[2].Y);
            _stopPoint[2] = new Point(Position.X + 97, Position.Y + 35);
            // Lane lane3 = new Lane(startPoint[2], turning[2], endPoint[2], cap);
            //************************************************************************************

            _startPoint[3] = new Point(Position.X, Position.Y + 103);
            _endPoint[3] = new Point(Position.X + 128-9, Position.Y);
            _turning[3] = new Point(_endPoint[3].X, _startPoint[3].Y);
            _stopPoint[3] = new Point(Position.X + 35, Position.Y + 103);
            // Lane lane4 = new Lane(startPoint[3], turning[3], endPoint[3], cap);
            //**********************************************************************************
            _startPoint[4] = new Point(Position.X, Position.Y + 122);
            _endPoint[4] = new Point(Position.X + 200, Position.Y + 122);//
            _turning[4] = new Point(_endPoint[4].X, _startPoint[4].Y);
            _stopPoint[4] = new Point(Position.X + 35, Position.Y + 122);
            // Lane lane5 = new Lane(startPoint[4], turning[4], endPoint[4], cap);
            //************************************************************************************
            _startPoint[5] = new Point(Position.X, Position.Y + 141);
            _endPoint[5] = new Point(Position.X + 74, Position.Y + 200);
            _turning[5] = new Point(_endPoint[5].X, _startPoint[5].Y);
            _stopPoint[5] = new Point(Position.X + 35, Position.Y + 141);
            // Lane lane6 = new Lane(startPoint[5], turning[5], endPoint[5], cap);
            //*****************************************************************lljhgffdhasf
            _startPoint[6] = new Point(Position.X + 103, Position.Y + 200);
            _endPoint[6] = new Point(Position.X, Position.Y + 72+5);
            _turning[6] = new Point(_startPoint[6].X, _endPoint[6].Y);
            _stopPoint[6] = new Point(Position.X + 103, Position.Y + 165);
            // Lane lane7 = new Lane(startPoint[6], turning[6], endPoint[6], cap);
            //***************************************************************************
            _startPoint[7] = new Point(Position.X + 122, Position.Y + 200);
            _endPoint[7] = new Point(Position.X + 122, Position.Y);//
            _turning[7] = new Point(_startPoint[7].X, _endPoint[7].Y);
            _stopPoint[7] = new Point(Position.X + 122, Position.Y + 165);
            //Lane lane8 = new Lane(startPoint[7], turning[7], endPoint[7], cap);
            //*********************************************************************************
            _startPoint[8] = new Point(Position.X + 141, Position.Y + 200);
            _endPoint[8] = new Point(Position.X + 200, Position.Y + 128-6);
            _turning[8] = new Point(_startPoint[8].X, _endPoint[8].Y);
            _stopPoint[8] = new Point(Position.X + 141, Position.Y + 165);
            // Lane lane9 = new Lane(startPoint[8], turning[8], endPoint[8], cap);
            //********************************************************************************
            _startPoint[9] = new Point(Position.X + 200, Position.Y + 59);
            _endPoint[9] = new Point(Position.X + 128-6, Position.Y);
            _turning[9] = new Point(_endPoint[9].X, _startPoint[9].Y);
            _stopPoint[9] = new Point(Position.X + 165, Position.Y + 59);
            // Lane lane10 = new Lane(startPoint[9], turning[9], endPoint[9], cap);
            //******************************************************************************
            _startPoint[10] = new Point(Position.X + 200, Position.Y + 78);
            _endPoint[10] = new Point(Position.X, Position.Y + 78);
            _turning[10] = new Point(_endPoint[10].X, _startPoint[10].Y);
            _stopPoint[10] = new Point(Position.X + 165, Position.Y + 78);
            // Lane lane11 = new Lane(startPoint[10], turning[10], endPoint[10], cap);
            //******************************************************************************
            _startPoint[11] = new Point(Position.X + 200, Position.Y + 97);
            _endPoint[11] = new Point(Position.X + 72+5, Position.Y + 200);
            _turning[11] = new Point(_endPoint[11].X, _startPoint[11].Y);
            _stopPoint[11] = new Point(Position.X + 165, Position.Y + 97);
            //Lane lane12 = new Lane(startPoint[11], turning[11], endPoint[11], cap);
            //******************************************************************************************
            _startPoint[12] = new Point(Position.X + 50, Position.Y + 160);
            _endPoint[12] = new Point(Position.X + 150 , Position.Y + 160);
           _stopPoint[12] = new Point(Position.X+ 70, Position.Y+150);
           //************************************************************************************
            _startPoint[13] = new Point(Position.X + 150, Position.Y + 40);
            _endPoint[13] = new Point(Position.X + 50, Position.Y + 40);
            _stopPoint[13] = new Point(Position.X + 125, Position.Y + 40);
            //************************************************************************************
          
           // for (int i = 0; i < 12; i++)
           // {
                //listOfLanes[i] = new Lane(i + 1, startPoint[i], turning[i], endPoint[i], stopPoint[i], cap, "", endPoint[i]);
            //}
           // .....
           //List<Lane> listOfLanes = new List<Lane>();
            var tempocrossingrect = new Point(Crossingrect.X, Crossingrect.Y);
            


                
                var a = new Lane(1, _startPoint[0], _turning[0], _endPoint[0], _stopPoint[0], Cap, "north-left", tempocrossingrect);
                var b = new Lane(2, _startPoint[1], _turning[1], _endPoint[1], _stopPoint[1], Cap, "north-center", tempocrossingrect);
                var c = new Lane(3, _startPoint[2], _turning[2], _endPoint[2], _stopPoint[2], Cap, "north-right", tempocrossingrect);
                var d = new Lane(4, _startPoint[3], _turning[3], _endPoint[3], _stopPoint[3], Cap, "west-top", tempocrossingrect);
                var e = new Lane(5, _startPoint[4], _turning[4], _endPoint[4], _stopPoint[4], Cap, "west-center", tempocrossingrect);
                var f = new Lane(6, _startPoint[5], _turning[5], _endPoint[5], _stopPoint[5], Cap, "west-bottom", tempocrossingrect);
                var g = new Lane(7, _startPoint[6], _turning[6], _endPoint[6], _stopPoint[6], Cap, "south-left", tempocrossingrect);
                var h = new Lane(8, _startPoint[7], _turning[7], _endPoint[7], _stopPoint[7], Cap, "south-center", tempocrossingrect);
                var j = new Lane(9, _startPoint[8], _turning[8], _endPoint[8], _stopPoint[8], Cap, "south-right", tempocrossingrect);
                var k = new Lane(10, _startPoint[9], _turning[9], _endPoint[9], _stopPoint[9], Cap, "east-top", tempocrossingrect);
                var l = new Lane(11, _startPoint[10], _turning[10], _endPoint[10], _stopPoint[10], Cap, "east-center", tempocrossingrect);
                var m = new Lane(12, _startPoint[11], _turning[11], _endPoint[11], _stopPoint[11], Cap, "east-bottom", tempocrossingrect);
             

                _listOfLanes.Add(a);
                _listOfLanes.Add(b);
                _listOfLanes.Add(c);
                _listOfLanes.Add(d);
                _listOfLanes.Add(e);
                _listOfLanes.Add(f);
                _listOfLanes.Add(g);
                _listOfLanes.Add(h);
                _listOfLanes.Add(j);
                _listOfLanes.Add(k);
                _listOfLanes.Add(l);
                _listOfLanes.Add(m);
            MyGroup.Add(new Group("Group1", _listOfLanes[0], _listOfLanes[1], _listOfLanes[7], _listOfLanes[8]));

            MyGroup.Add(new Group("Group2", _listOfLanes[4], _listOfLanes[5], _listOfLanes[9], _listOfLanes[10]));
            MyGroup.Add(new Group("Group3", _listOfLanes[0], _listOfLanes[3], _listOfLanes[11]));
            MyGroup.Add(new Group("Group4", _listOfLanes[2], _listOfLanes[5], _listOfLanes[6]));

           if (Type != "with-pedestrian") return;
          // var pt12 = new Point(0, 0);
           var n = new Lane(13, _startPoint[12], _startPoint[12], _endPoint[12], _stopPoint[12], Cap, "withpedestrian-north", tempocrossingrect);
           var o = new Lane(14, _startPoint[13], _startPoint[13], _endPoint[13],_stopPoint[13], Cap, "withpedestrian-south", tempocrossingrect);
           var p = new Lane(15, _startPoint[12], _startPoint[12], _endPoint[12], _stopPoint[12], Cap, "withpedestrian-east", tempocrossingrect);
           var q = new Lane(16, _startPoint[13], _startPoint[13], _endPoint[13], _stopPoint[13], Cap, "withpedestrian-west", tempocrossingrect);

                
           _listOfLanes.Add(n);
           _listOfLanes.Add(o);
           _listOfLanes.Add(p);
          _listOfLanes.Add(q);
          MyGroup.Add(new Group("Group5", _listOfLanes[4], _listOfLanes[10], _listOfLanes[12], _listOfLanes[13], _listOfLanes[14], _listOfLanes[15]));

        }
       

       /// <summary>
       /// This method will be called to tell a group to change to green in sequence of group list
       /// </summary>
       public void BeRed(int groupindex)
       {
           foreach (var currentGroup in MyGroup)
           {

               foreach (var lane in currentGroup.ListOfLanes)
               {
                   lane.Tl.PainttoRed();
                   
                   if (lane.Keepmoving())
                   {
                       NoOfOutgoingCar(currentGroup.Name);
                   }
               }
               
           }
       }

        public void BeGreen(int groupindex)
        {
            for (var x = 0; x < MyGroup.Count; x++)
            {
                if (groupindex != x) continue;
                foreach (var lane in MyGroup[x].ListOfLanes)
                {
                    lane.Tl.Paintgreen();

                    if (lane.Move())
                    {
                        NoOfOutgoingCar(MyGroup[x].Name);
                    }

                }
            }
        }


        /// <summary>
                /// This method will be used to adjust the time of the green light 
                /// </summary>
                /// <param name="group">The name of the group</param>
                /// <param name="time">The time it is being adjusted to</param>
            public
            void AdjustTime(string group,int time)
        {
           // find the  group and set the time length
            for (var i = 0; i < MyGroup.Count; i++)
            {
                if (MyGroup[i].Name == group)
                {
                    MyGroup[i].SetTime(time);
                }
            }
        }
       /// <summary>
        /// This method will be used to adjust the number of cars in a lane 
       /// </summary>
       /// <param name="laneNo">The position of lane in the list whose number of cars is being adjusted</param>
       /// <param name="car">The number of cars the lane is being adjusted to</param>
        public void AdjustNrOfCars(int laneNo, int car)
        {
            //finds the lane from list and set number of cars
            for (var i = 0; i < _listOfLanes.Count; i++)
            {
                if (_listOfLanes[i].MyNumber == laneNo)
                {
                    

                    //_listOfLanes[i].CreateMovingObject(laneNo, car);
                    _listOfLanes[i].AddCar(car);

                    //_listOfLanes[i]._myCars = car;
                    
                }
            }
        }
       
       /// <summary>
       /// This method paints a crossing object
       /// </summary>
       /// <param name="gr">The graphics to that the crossing should be painted on</param>
        public void PaintSelf(Graphics gr)
        {

            gr.DrawImage(Crossingimg, Crossingrect);
            try
            {

                    foreach (var lane in _listOfLanes)
                    {
                        lane.PaintSelf(gr);

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
             
           
        }
       /// <summary>
       /// This method paint a crossing on separate graphics than the traffic
       /// </summary>
        /// <param name="gr">The graphics to that the crossing should be painted on</param>
       /// <param name="x"> the size that every parameter of the objects should change</param>
        public void PaintBigger(Graphics gr, int x)
        {
            //........
        }
        /// <summary>
        /// creates 4 groups of lanes, and if type2 it adds one more
        /// </summary>
        public virtual Group Getgroup(string name)
        {
            for (var x = 0; x < MyGroup.Count; x++ )
            {
               if(MyGroup[x].Name==name)
                   return MyGroup[x];
            }
            return null;

        }

        public void NoOfOutgoingCar(string groupName)
        {
            var myincomicars = new List<int>();

            // first check if there are neighbours, then their positions
            switch (groupName)
            {
                   
                case "Group1":
                    if (Myneighbours[3] != null)
                    {
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[0].ListOfCars.Count));
                        Myneighbours[3]._listOfLanes[9].Haveneighbour = true;
                        Myneighbours[3]._listOfLanes[10].Haveneighbour = true;
                        Myneighbours[3]._listOfLanes[11].Haveneighbour = true;
                        
                        Myneighbours[3]._listOfLanes[9].IncomingCar(myincomicars[0]);
                        Myneighbours[3]._listOfLanes[10].IncomingCar(myincomicars[1]);
                        Myneighbours[3]._listOfLanes[11].IncomingCar(myincomicars[2]);
                        if (Myneighbours[3]._listOfLanes[9].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[9].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[9].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[3]._listOfLanes[10].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[10].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[10].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[3]._listOfLanes[11].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[11].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[11].MyNumber, myincomicars[2]);
                        }
                        
                    }
                    if (Myneighbours[2] != null)
                    {
                        Myneighbours[2]._listOfLanes[0].Haveneighbour = true;
                        Myneighbours[2]._listOfLanes[1].Haveneighbour = true;
                        Myneighbours[2]._listOfLanes[2].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[1].ListOfCars.Count));
                        Myneighbours[2]._listOfLanes[0].IncomingCar(myincomicars[0]);
                        Myneighbours[2]._listOfLanes[1].IncomingCar(myincomicars[1]);
                        Myneighbours[2]._listOfLanes[2].IncomingCar(myincomicars[2]);
                        if (Myneighbours[2]._listOfLanes[0].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[0].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[0].MyNumber, myincomicars[0]);
                        }
                        if (Myneighbours[2]._listOfLanes[1].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[1].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[1].MyNumber, myincomicars[1]);
                        }
                         if (Myneighbours[2]._listOfLanes[2].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[2].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[2].MyNumber, myincomicars[2]);
                        }
                        
                    }
                    else
                    {
                        _listOfLanes[7].LoadnewCar(8);
                        _listOfLanes[8].LoadnewCar(9);
                        //listOfLanes[2].LoadnewCar(3);
                    }
                    if (Myneighbours[0] != null)
                    {
                        Myneighbours[0]._listOfLanes[6].Haveneighbour = true;
                        Myneighbours[0]._listOfLanes[7].Haveneighbour = true;
                        Myneighbours[0]._listOfLanes[8].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[2].ListOfCars.Count));
                        Myneighbours[0]._listOfLanes[6].IncomingCar(myincomicars[0]);
                        Myneighbours[0]._listOfLanes[7].IncomingCar(myincomicars[1]);
                        Myneighbours[0]._listOfLanes[8].IncomingCar(myincomicars[2]);

                        if (Myneighbours[0]._listOfLanes[6].ListOfCars.Count == 0)
                        {
                            Myneighbours[0]._listOfLanes[6].CreateMovingObject(
                                Myneighbours[0]._listOfLanes[6].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[0]._listOfLanes[7].ListOfCars.Count == 0)
                        {
                            Myneighbours[0]._listOfLanes[7].CreateMovingObject(
                                Myneighbours[0]._listOfLanes[7].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[0]._listOfLanes[8].ListOfCars.Count == 0)
                        {
                            Myneighbours[0]._listOfLanes[8].CreateMovingObject(
                                Myneighbours[0]._listOfLanes[8].MyNumber, myincomicars[2]);
                        }
                    }
                    else
                    {
                        _listOfLanes[0].LoadnewCar(1);
                        _listOfLanes[1].LoadnewCar(2);
                        // listOfLanes[8].LoadnewCar(9);
                    }
                    if (Myneighbours[1] != null)
                    {
                        Myneighbours[1]._listOfLanes[3].Haveneighbour = true;
                        Myneighbours[1]._listOfLanes[4].Haveneighbour = true;
                        Myneighbours[1]._listOfLanes[5].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[3].ListOfCars.Count));
                        Myneighbours[1]._listOfLanes[3].IncomingCar(myincomicars[0]);
                        Myneighbours[1]._listOfLanes[4].IncomingCar(myincomicars[1]);
                        Myneighbours[1]._listOfLanes[5].IncomingCar(myincomicars[2]);


                        if (Myneighbours[1]._listOfLanes[3].ListOfCars.Count == 0)
                        {
                            Myneighbours[1]._listOfLanes[3].CreateMovingObject(
                                Myneighbours[1]._listOfLanes[3].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[1]._listOfLanes[4].ListOfCars.Count == 0)
                        {
                            Myneighbours[1]._listOfLanes[4].CreateMovingObject(
                                Myneighbours[1]._listOfLanes[4].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[1]._listOfLanes[5].ListOfCars.Count == 0)
                        {
                            Myneighbours[1]._listOfLanes[5].CreateMovingObject(
                                Myneighbours[1]._listOfLanes[5].MyNumber, myincomicars[2]);
                        }
                    }
                    checkoutgoing = true;
                    break;

            
           
                case "Group2":
                    if (Myneighbours[3] != null)
                    {
                       

                        Myneighbours[3]._listOfLanes[9].Haveneighbour = true;
                        Myneighbours[3]._listOfLanes[10].Haveneighbour = true;
                        Myneighbours[3]._listOfLanes[11].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[3].ListOfCars.Count));
                       
                        Myneighbours[3]._listOfLanes[9].IncomingCar(myincomicars[0]);
                        Myneighbours[3]._listOfLanes[10].IncomingCar(myincomicars[1]);
                        Myneighbours[3]._listOfLanes[11].IncomingCar(myincomicars[2]);
                        if (Myneighbours[3]._listOfLanes[9].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[9].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[9].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[3]._listOfLanes[10].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[10].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[10].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[3]._listOfLanes[11].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[11].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[11].MyNumber, myincomicars[2]);
                        }
                    }
                    else
                    {
                        _listOfLanes[4].LoadnewCar(5);
                        _listOfLanes[5].LoadnewCar(6);
                        //listOfLanes[11].LoadnewCar(12);
                    }
                    if (Myneighbours[2] != null)
                    {
                        Myneighbours[2]._listOfLanes[0].Haveneighbour = true;
                        Myneighbours[2]._listOfLanes[1].Haveneighbour = true;
                        Myneighbours[2]._listOfLanes[2].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[1].ListOfCars.Count));
                        Myneighbours[2]._listOfLanes[0].IncomingCar(myincomicars[0]);
                        Myneighbours[2]._listOfLanes[1].IncomingCar(myincomicars[1]);
                        Myneighbours[2]._listOfLanes[2].IncomingCar(myincomicars[2]);
                        if (Myneighbours[2]._listOfLanes[0].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[0].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[0].MyNumber, myincomicars[0]);
                        }
                        if (Myneighbours[2]._listOfLanes[1].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[1].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[1].MyNumber, myincomicars[1]);
                        }
                        if (Myneighbours[2]._listOfLanes[2].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[2].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[2].MyNumber, myincomicars[2]);
                        }
                    }
                    if (Myneighbours[0] != null)
                    {
                        Myneighbours[0]._listOfLanes[6].Haveneighbour = true;
                        Myneighbours[0]._listOfLanes[7].Haveneighbour = true;
                        Myneighbours[0]._listOfLanes[8].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[2].ListOfCars.Count));
                        Myneighbours[0]._listOfLanes[6].IncomingCar(myincomicars[0]);
                        Myneighbours[0]._listOfLanes[7].IncomingCar(myincomicars[1]);
                        Myneighbours[0]._listOfLanes[8].IncomingCar(myincomicars[2]);


                        if (Myneighbours[0]._listOfLanes[6].ListOfCars.Count == 0)
                        {
                            Myneighbours[0]._listOfLanes[6].CreateMovingObject(
                                Myneighbours[0]._listOfLanes[6].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[0]._listOfLanes[7].ListOfCars.Count == 0)
                        {
                            Myneighbours[0]._listOfLanes[7].CreateMovingObject(
                                Myneighbours[0]._listOfLanes[7].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[0]._listOfLanes[8].ListOfCars.Count == 0)
                        {
                            Myneighbours[0]._listOfLanes[8].CreateMovingObject(
                                Myneighbours[0]._listOfLanes[8].MyNumber, myincomicars[2]);
                        }
                    }
                    if (Myneighbours[1] != null)
                    {
                        Myneighbours[1]._listOfLanes[3].Haveneighbour = true;
                        Myneighbours[1]._listOfLanes[4].Haveneighbour = true;
                        Myneighbours[1]._listOfLanes[5].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[0].ListOfCars.Count));
                        Myneighbours[1]._listOfLanes[3].IncomingCar(myincomicars[0]);
                        Myneighbours[1]._listOfLanes[4].IncomingCar(myincomicars[1]);
                        Myneighbours[1]._listOfLanes[5].IncomingCar(myincomicars[2]);


                        if (Myneighbours[1]._listOfLanes[3].ListOfCars.Count == 0)
                        {
                            Myneighbours[1]._listOfLanes[3].CreateMovingObject(
                                Myneighbours[1]._listOfLanes[3].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[1]._listOfLanes[4].ListOfCars.Count == 0)
                        {
                            Myneighbours[1]._listOfLanes[4].CreateMovingObject(
                                Myneighbours[1]._listOfLanes[4].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[1]._listOfLanes[5].ListOfCars.Count == 0)
                        {
                            Myneighbours[1]._listOfLanes[5].CreateMovingObject(
                                Myneighbours[1]._listOfLanes[5].MyNumber, myincomicars[2]);
                        }
                    }
                    else
                    {
                        _listOfLanes[9].LoadnewCar(10);
                        _listOfLanes[10].LoadnewCar(11);
                        // listOfLanes[5].LoadnewCar(6);
                    }
                    checkoutgoing = true;
                    break;

            case "Group3":
                    if (Myneighbours[3] != null)
                    {
                        
                        Myneighbours[3]._listOfLanes[9].Haveneighbour = true;
                        Myneighbours[3]._listOfLanes[10].Haveneighbour = true;
                        Myneighbours[3]._listOfLanes[11].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[0].ListOfCars.Count));
                        Myneighbours[3]._listOfLanes[9].IncomingCar(myincomicars[0]);
                        Myneighbours[3]._listOfLanes[10].IncomingCar(myincomicars[1]);
                        Myneighbours[3]._listOfLanes[11].IncomingCar(myincomicars[2]);
                        if (Myneighbours[3]._listOfLanes[9].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[9].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[9].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[3]._listOfLanes[10].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[10].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[10].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[3]._listOfLanes[11].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[11].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[11].MyNumber, myincomicars[2]);
                        }
                    }
                    else
                    {
                        _listOfLanes[3].LoadnewCar(4);
                        //listOfLanes[10].LoadnewCar(11);
                        //listOfLanes[11].LoadnewCar(12);
                    }
                    if (Myneighbours[2] != null)
                    {
                        Myneighbours[2]._listOfLanes[0].Haveneighbour = true;
                        Myneighbours[2]._listOfLanes[1].Haveneighbour = true;
                        Myneighbours[2]._listOfLanes[2].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[2].ListOfCars.Count));
                        Myneighbours[2]._listOfLanes[0].IncomingCar(myincomicars[0]);
                        Myneighbours[2]._listOfLanes[1].IncomingCar(myincomicars[1]);
                        Myneighbours[2]._listOfLanes[2].IncomingCar(myincomicars[2]);
                        if (Myneighbours[2]._listOfLanes[0].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[0].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[0].MyNumber, myincomicars[0]);
                        }
                        if (Myneighbours[2]._listOfLanes[1].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[1].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[1].MyNumber, myincomicars[1]);
                        }
                        if (Myneighbours[2]._listOfLanes[2].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[2].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[2].MyNumber, myincomicars[2]);
                        }
                    }
                    if (Myneighbours[0] != null)
                    {
                        Myneighbours[0]._listOfLanes[6].Haveneighbour = true;
                        Myneighbours[0]._listOfLanes[7].Haveneighbour = true;
                        Myneighbours[0]._listOfLanes[8].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[1].ListOfCars.Count));
                        Myneighbours[0]._listOfLanes[6].IncomingCar(myincomicars[0]);
                        Myneighbours[0]._listOfLanes[7].IncomingCar(myincomicars[1]);
                        Myneighbours[0]._listOfLanes[8].IncomingCar(myincomicars[2]);
                        if (Myneighbours[0]._listOfLanes[6].ListOfCars.Count == 0)
                        {
                            Myneighbours[0]._listOfLanes[6].CreateMovingObject(
                                Myneighbours[0]._listOfLanes[6].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[0]._listOfLanes[7].ListOfCars.Count == 0)
                        {
                            Myneighbours[0]._listOfLanes[7].CreateMovingObject(
                                Myneighbours[0]._listOfLanes[7].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[0]._listOfLanes[8].ListOfCars.Count == 0)
                        {
                            Myneighbours[0]._listOfLanes[8].CreateMovingObject(
                                Myneighbours[0]._listOfLanes[8].MyNumber, myincomicars[2]);
                        }
                    }
                    else
                    {
                        _listOfLanes[0].LoadnewCar(1);
                        // listOfLanes[7].LoadnewCar(8);
                        // listOfLanes[8].LoadnewCar(9);
                    }
                    if (Myneighbours[1] != null)
                    {
                       // Myneighbours[1]._listOfLanes[3].haveneighbour = true;
                      //  Myneighbours[1]._listOfLanes[4].haveneighbour = true;
                      //  Myneighbours[1]._listOfLanes[5].haveneighbour = true;
                       /*  
                        Myneighbours[1]._listOfLanes[3].IncomingCar(2);
                        Myneighbours[1]._listOfLanes[4].IncomingCar(2);
                        Myneighbours[1]._listOfLanes[5].IncomingCar(2);*/
                    }
                    else
                    {
                        _listOfLanes[11].LoadnewCar(12);  
                    }
                    checkoutgoing = true;
                    break;
            
                case "Group4":
                    if (Myneighbours[3] != null)
                    {
                        
                        Myneighbours[3]._listOfLanes[9].Haveneighbour = true;
                        Myneighbours[3]._listOfLanes[10].Haveneighbour = true;
                        Myneighbours[3]._listOfLanes[11].Haveneighbour = true;

                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[2].ListOfCars.Count));
                        Myneighbours[3]._listOfLanes[9].IncomingCar(myincomicars[0]);
                        Myneighbours[3]._listOfLanes[10].IncomingCar(myincomicars[1]);
                        Myneighbours[3]._listOfLanes[11].IncomingCar(myincomicars[2]);
                        if (Myneighbours[3]._listOfLanes[9].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[9].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[9].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[3]._listOfLanes[10].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[10].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[10].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[3]._listOfLanes[11].ListOfCars.Count == 0)
                        {
                            Myneighbours[3]._listOfLanes[11].CreateMovingObject(
                                Myneighbours[3]._listOfLanes[11].MyNumber, myincomicars[2]);
                        }
                    }
                    else
                    {
                        _listOfLanes[5].LoadnewCar(6); 
                    }
                    if (Myneighbours[2] != null)
                    {
                        Myneighbours[2]._listOfLanes[0].Haveneighbour = true;
                        Myneighbours[2]._listOfLanes[1].Haveneighbour = true;
                        Myneighbours[2]._listOfLanes[2].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[1].ListOfCars.Count));
                        Myneighbours[2]._listOfLanes[0].IncomingCar(myincomicars[0]);
                        Myneighbours[2]._listOfLanes[1].IncomingCar(myincomicars[1]);
                        Myneighbours[2]._listOfLanes[2].IncomingCar(myincomicars[2]);
                        if (Myneighbours[2]._listOfLanes[0].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[0].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[0].MyNumber, myincomicars[0]);
                        }
                        if (Myneighbours[2]._listOfLanes[1].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[1].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[1].MyNumber, myincomicars[1]);
                        }
                        if (Myneighbours[2]._listOfLanes[2].ListOfCars.Count == 0)
                        {
                            Myneighbours[2]._listOfLanes[2].CreateMovingObject(
                                Myneighbours[2]._listOfLanes[2].MyNumber, myincomicars[2]);
                        }
                    }
                    else
                    {
                        _listOfLanes[6].LoadnewCar(7);
                        //listOfLanes[1].LoadnewCar(2);
                        //listOfLanes[2].LoadnewCar(3);
                    }
                    if (Myneighbours[1] != null)
                    {
                        Myneighbours[1]._listOfLanes[3].Haveneighbour = true;
                        Myneighbours[1]._listOfLanes[4].Haveneighbour = true;
                        Myneighbours[1]._listOfLanes[5].Haveneighbour = true;
                        myincomicars = DivideincomingarsInRatio((Getgroup(groupName).ListOfLanes[0].ListOfCars.Count));
                        Myneighbours[1]._listOfLanes[3].IncomingCar(myincomicars[0]);
                        Myneighbours[1]._listOfLanes[4].IncomingCar(myincomicars[1]);
                        Myneighbours[1]._listOfLanes[5].IncomingCar(myincomicars[2]);


                        if (Myneighbours[1]._listOfLanes[3].ListOfCars.Count == 0)
                        {
                            Myneighbours[1]._listOfLanes[3].CreateMovingObject(
                                Myneighbours[1]._listOfLanes[3].MyNumber, myincomicars[0]);
                        }

                        if (Myneighbours[1]._listOfLanes[4].ListOfCars.Count == 0)
                        {
                            Myneighbours[1]._listOfLanes[4].CreateMovingObject(
                                Myneighbours[1]._listOfLanes[4].MyNumber, myincomicars[1]);
                        }

                        if (Myneighbours[1]._listOfLanes[5].ListOfCars.Count == 0)
                        {
                            Myneighbours[1]._listOfLanes[5].CreateMovingObject(
                                Myneighbours[1]._listOfLanes[5].MyNumber, myincomicars[2]);
                        }
                    }
                    if (Myneighbours[0] != null)
                    {
                      /*  Myneighbours[0]._listOfLanes[6].IncomingCar(2);
                        Myneighbours[0]._listOfLanes[7].IncomingCar(2);
                        Myneighbours[0]._listOfLanes[8].IncomingCar(2);
                       */
                    }
                    else
                    {
                        _listOfLanes[2].LoadnewCar(3);
                        // listOfLanes[7].LoadnewCar(8);
                        // listOfLanes[8].LoadnewCar(9);
                    }
                    checkoutgoing = true;
                    break;
            }
        }

     
        /// <summary>
        /// it divides the in coming cars according to ratio of 1:2 for 1st and 2nd lane, and the remaing  to 3rd lane
        /// </summary>
        /// <param name="incomingcars"> number of coming in to to the road</param>
        public List<int> DivideincomingarsInRatio(int incomingcars)
        {
            int car = incomingcars;
        //calculates where each lane are and add cars according to ratio
           var ratioInts= new List<int>(3) {car/3, (car/3) + ((car%3)/2),};
            ratioInts.Add((car-ratioInts[0]-ratioInts[1]));
            return ratioInts;
       }
       /// <summary>
       /// returns the rectangle where the crossing is found
       /// </summary>
       /// <returns>rectangle</returns>

       public Rectangle GetRectangle()
       {
           return Crossingrect;
       }
    }
}
