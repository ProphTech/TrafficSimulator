using System;
using System.Collections.Generic;
using System.Drawing;


namespace Traffic_Light_Simulation
{
    [Serializable]
    class Lane
    {
        public TrafficLight Tl;
        public List<MovingObject> ListOfCars= new List<MovingObject>(); //no of objects coming in the lane in some constant time
        public List<MovingObject> CarsforneighbourList = new List<MovingObject>();
        //List<MovingObject> cominginCars = new List<MovingObject>();
        //int NoOfcarForTrafficJam; //no of cars exceeding capacity
        readonly Point _startPoint;
        public int IncomingCars = 0;
         public bool Haveneighbour = false;
         
        Point _turning;
        Point _endPoint;
        Point _stopPoint;
        public int MyNumber;
        readonly string _direction;
        Point _post;
        const int BaseNumber=1;
        const int N = 1;
        const  int Speed =N*BaseNumber ;
        public int _myCars=3;
       // private bool _return;
        private readonly Rectangle _nrofcardisplay;
        Point _carPosition;

        
        
        
        //-----------------------------------------------
        public int MyCars { get { return _myCars; } set { _myCars = value; } }


        //---------------------------------------------


        public Lane(int laneNumber, Point startPoint, Point turning, Point endPoint, Point stopPoint, int capacity, string direction,Point pos)
        {
            _myCars = 3;
            _startPoint = startPoint;
            _turning = turning;
            _endPoint = endPoint;
            _stopPoint = stopPoint;
            MyNumber = laneNumber;
            _direction = direction;
            _post = pos;
            Maximumcapacity = capacity;
            
            //  int gap = 0;
            // List<Point> FFF = new List<Point>();

            CreateTrafficLight();
         
            CreateMovingObject(laneNumber,_myCars);
            var sz = new Size(10,10);
            

             _nrofcardisplay = new Rectangle(stopPoint,sz);

          
        }

        public int Maximumcapacity { get; set; }

//------------------------------------------------------------------
        /// <summary>
        /// creates a trafic light for each lane
        /// </summary>
          private void CreateTrafficLight()
        {

          
            if (_direction == "north-left")
            {
                Tl = new TrafficLight(_post.X + 9, _post.Y + 10, 11, 10);
            }
            else if (_direction == "north-center")
            {
                Tl = new TrafficLight(_post.X + 22, _post.Y + 10, 11, 10);
            }
            else if (_direction == "north-right")
            {
                Tl = new TrafficLight(_post.X + 35, _post.Y + 10, 11, 10);
            }
            else if (_direction == "east-top")
            {
                Tl = new TrafficLight(_post.X + 179, _post.Y + 8, 11, 10);
            }
            else if (_direction == "east-center")
            {
                Tl = new TrafficLight(_post.X + 179, _post.Y + 23, 11, 10);
            }
            else if (_direction == "east-bottom")
            {
                Tl = new TrafficLight(_post.X + 179, _post.Y + 35, 11, 10);
            }
            else if (_direction == "west-top")
            {
                Tl = new TrafficLight(_post.X + 9, _post.Y + 155, 11, 10);
            }
            else if (_direction == "west-center")
            {
                Tl = new TrafficLight(_post.X + 9, _post.Y + 168, 11, 10);
            }
            else if (_direction == "west-bottom")
            {
                Tl = new TrafficLight(_post.X + 9, _post.Y + 182, 11, 10);
            }
            else if (_direction == "south-left")
            {
                Tl = new TrafficLight(_post.X + 155, _post.Y + 180, 11, 10);
                //  tl = new TrafficLight(post.X + 155, post.Y + 165, 6, 10);
            }
            else if (_direction == "south-center")
            {
                Tl = new TrafficLight(_post.X + 169, _post.Y + 180, 11, 10);
            }
            else if (_direction == "south-right")
            {
                Tl = new TrafficLight(_post.X + 182, _post.Y + 180, 11, 10);
            }
                // for pedestri

                
            else if (_direction == "withpedestrian-north")
            {
                Tl = new TrafficLight(_post.X + 36, _post.Y + 37, 11, 10);
            }
            else if (_direction == "withpedestrian-east")
            {
                Tl = new TrafficLight(_post.X + 152, _post.Y + 37, 11, 10);
            }
            else if (_direction == "withpedestrian-west")
            {
                Tl = new TrafficLight(_post.X + 36, _post.Y + 153, 11, 10);
            }
            else if (_direction == "withpedestrian-south")
            {
                Tl = new TrafficLight(_post.X + 153, _post.Y + 153, 11, 10);
            }
           
        }

  /*-------------------------------------------------------------------------------------*/

        public void CreateMovingObject(int ln, int nocars)
        {
       
            
            _myCars = nocars;
            var i = 0;
            while (i < _myCars)
            {

                switch (ln)
                {
                    case 1:
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X - 2, _stopPoint.Y - 4);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.Y = _carPosition.Y - 8;
                            var tempo = new MovingObject(_carPosition, ln);
                            
                            ListOfCars.Add(tempo);
                            
                        }
                        break;
                    case 2:
                        
                        
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X - 2, _stopPoint.Y - 4);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.Y = _carPosition.Y - 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }
                        break;
                    case 3:
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X - 2, _stopPoint.Y - 4);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.Y = _carPosition.Y - 8;
                            var tempo = new MovingObject(_carPosition, MyNumber);

                            ListOfCars.Add(tempo);

                        }
                        break;
                    case 4:
                        
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X - 4, _stopPoint.Y - 2);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.X = _carPosition.X - 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }
                        break;
                    case 5:
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X - 4, _stopPoint.Y - 2);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.X = _carPosition.X - 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }
                        break;
                    case 6:
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X - 4, _stopPoint.Y - 2);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.X = _carPosition.X - 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }
                        break;
                    case 7:
                        
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X - 2, _stopPoint.Y);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.Y = _carPosition.Y + 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }
                        break;
                    case 8:
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X - 2, _stopPoint.Y);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.Y = _carPosition.Y + 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }
                        break;
                    case 9:
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X - 2, _stopPoint.Y);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.Y = _carPosition.Y + 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }
                        break;
                    case 10:
                        
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X, _stopPoint.Y-2);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.X = _carPosition.X + 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }
                        break;
                    case 11:
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X, _stopPoint.Y - 2);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.X = _carPosition.X + 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }

                        break;

                    case 12:
                        if (i == 0)
                        {
                            _carPosition = new Point(_stopPoint.X, _stopPoint.Y - 2);
                            ListOfCars.Add(new MovingObject(_carPosition, ln));
                            //MovingObject car = new MovingObject(carPosition);
                        }
                        else
                        {
                            _carPosition.X = _carPosition.X + 8;
                            var tempo = new MovingObject(_carPosition, ln);

                            ListOfCars.Add(tempo);

                        }
                        break;
                }
                  i++;
        }
        }

        /// <summary>
        /// This method paints the Lane object on a graphics 
        /// </summary>
        /// <param name="gr">The graphics that the lane should be painted on</param>
        public void PaintSelf(Graphics gr)
        {
             var pen = new Pen(Color.Blue);
            int cars = _myCars + IncomingCars;
            var text1 = cars.ToString();
            using (var font1 = new Font("Arial", 7, FontStyle.Regular))
            {
                gr.DrawRectangle(pen, _nrofcardisplay);
                gr.DrawString(text1,font1,Brushes.Black,_nrofcardisplay);
            }

           
            Tl.PaintItself(gr);


            for (int index = 0;index<ListOfCars.Count; index++)
            {
               // var movingObject = ListOfCars[index];
                if (ListOfCars.Count > Maximumcapacity)
                {
                    for (int x = 0; x < ListOfCars.Count; x++)
                    {
                        ListOfCars[x].ChangeColor(Color.Red);
                    }
                }
                ListOfCars[index].PaintSelf(gr);
            }
        }

        /*--------------------------------------------------------------------------------------------------*/
       
        /// <summary>
        /// This method is used to add a car to a lane by user
        /// </summary>
        /// <param name="numberofcars">The new number of cars of the lane</param>
        /// <returns>Returns true if the car object is successfully added</returns>
        public void AddCar(int numberofcars)
        {
            
            
           // var car = new MovingObject(_startPoint, MyNumber);
            for(var x=0; x<ListOfCars.Count; x++)
            {
               
            
               ListOfCars.Remove(ListOfCars[x]);
            }

            this._myCars = numberofcars;
            CreateMovingObject(MyNumber, _myCars);


        }
        /// <summary>
        /// This method is used to add a car to a lane coming from a neghibour
        /// </summary>
        /// <param name="numberofcars">The new number of cars of the lane</param>
        /// <returns>Returns true if the car object is successfully added</returns>
        public void IncomingCar(int numberofcars)
        {
            int temp = 0;
            temp += numberofcars;
            IncomingCars = temp;
            


        }
        /// <summary>
        /// This method removes a car from a lane when it reaches the end of the lane and there is no connection
        /// </summary>
        /// <param name="car">The car that is to be removed</param>
        /// <returns>Returns true if the car is successfully removed and false otherwise</returns>
        public bool RemoveCar(MovingObject car)
        {
           
           ListOfCars.Remove(car);

          return true;
        }
        /// <summary>
        /// This method checks the traffic to see if there is a jam or not by calculating noOfcarsFor
        /// </summary>
        /// <param name="l">The lane that is to be checked </param>
        /// <returns>Returns true if there's a traffic jam and false otherwise</returns>
        public bool CheckTrafficJam(Lane l)
        {
            //sets the NoOfcarForTrafficJam using the green/red time and the noofcars in lane and compare it withmaximum capacity
         return true;
        }
        public bool LoadnewCar(int lane)
        {


            if (ListOfCars.Count == 0)
            {
                CreateMovingObject(lane,3);
                return true;
            }
            return false;

        }

#region move Car

        /// <summary>
/// this method will set car position according go the dircetion of lane and removes car if out of lane
/// </summary>
        public bool Move()
{
    //_carsforneighbourList = new List<MovingObject>();
   bool check = false;
    switch (MyNumber)
    {
        case 1:


            for (var i = 0; i < ListOfCars.Count; i++)
            {

                if (ListOfCars[i].Pos.Y <= _turning.Y)
                {
                    //if (ListOfCars[hi].Pos.Y >)
                    if (IncomingCars > 0)
                    {
                        if (i == ListOfCars.Count - 1 && Haveneighbour)
                        {
                            if (ListOfCars[i].Pos.Y > _stopPoint.Y + 10 && ListOfCars[i].Pos.Y < _stopPoint.Y + 20)
                                CreateMovingObject(MyNumber, IncomingCars);
                            Haveneighbour = false;

                        }
                    }

                    ListOfCars[i].Pos.Y += Speed;
                }
                else
                    ListOfCars[i].Pos.X -= Speed;


                //to remove the car at end line
                if (ListOfCars[i].Pos.X < _endPoint.X)
                {
                    
                   check=true;

                    //listOfCars[i].setPosition(this.startPoint);
                    //AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[i]);
                   RemoveCar(ListOfCars[i]);
                }
              

            }
            

            break;
            

        case 2:
            for (var x = 0; x < ListOfCars.Count; x++)
            {



                if (ListOfCars[x].Pos.Y <= _turning.Y)
                {
                    if (IncomingCars > 0)
                    {
                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {
                            if (ListOfCars[x].Pos.Y > _stopPoint.Y + 10 && ListOfCars[x].Pos.Y < _stopPoint.Y + 20)
                                CreateMovingObject(MyNumber, IncomingCars);
                            Haveneighbour = false;

                        }
                    }

                    ListOfCars[x].Pos.Y += Speed;
                }
                if (ListOfCars[x].Pos.Y > _endPoint.Y)
                {
                    
                   check=true; 
                    //listOfCars[x].setPosition(this.startPoint);
                    //AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                 
                    
            }
            break;
        case 3:
            for (var x = 0; x < ListOfCars.Count; x++)
            {
                if (ListOfCars[x].Pos.Y <= _turning.Y)
                {

                    if (IncomingCars > 0)
                    {
                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {
                            if (ListOfCars[x].Pos.Y > _stopPoint.Y + 10 && ListOfCars[x].Pos.Y < _stopPoint.Y + 20)
                                CreateMovingObject(MyNumber, IncomingCars);
                            Haveneighbour = false;

                        }
                    }





                    ListOfCars[x].Pos.Y += Speed;
                }
                else if (ListOfCars[x].Pos.Y > _turning.Y)
                {
                    ListOfCars[x].Pos.X += Speed;
                }
                if (ListOfCars[x].Pos.X > _endPoint.X)
                {
                    
                   check=true;
                        
                    // listOfCars[x].setPosition(this.startPoint);
                    //AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
               
                   
            }
            break;
        case 4:
            for (var x = 0; x < ListOfCars.Count; x++)
            {
                if (ListOfCars[x].Pos.X <= _turning.X)
                {
                    if (IncomingCars > 0)
                    {
                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {
                            if (ListOfCars[x].Pos.X > _stopPoint.X + 10 && ListOfCars[x].Pos.X < _stopPoint.X + 20)
                                CreateMovingObject(MyNumber, IncomingCars);
                            Haveneighbour = false;

                        }
                    }

                    ListOfCars[x].Pos.X += Speed;
                }
                else if (ListOfCars[x].Pos.X > _turning.X)
                {
                    if (x == ListOfCars.Count)
                    { CreateMovingObject(MyNumber, IncomingCars);}
                    ListOfCars[x].Pos.Y -= Speed;
                }
                if (ListOfCars[x].Pos.Y < _endPoint.Y)
                {
                    
                   check=true;

                        
                    //listOfCars[x].setPosition(this.startPoint);
                    // AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                   
            }
            break;
        case 5:
            for (var x = 0; x < ListOfCars.Count; x++)
            {
                if (ListOfCars[x].Pos.X <= _turning.X)
                {

                    if (IncomingCars > 0)
                    {
                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {
                            if (ListOfCars[x].Pos.X > _stopPoint.X + 10 && ListOfCars[x].Pos.X < _stopPoint.X + 20)
                                CreateMovingObject(MyNumber, IncomingCars);
                            Haveneighbour = false;

                        }
                    }


                    ListOfCars[x].Pos.X += Speed;
                }
                if (ListOfCars[x].Pos.X > _endPoint.X)
                {
                    
                   check=true;
                    // listOfCars[x].setPosition(this.startPoint);
                    //AddCar(1);

                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                   
            }
            break;
        case 6:
            for (var x = 0; x < ListOfCars.Count; x++)
            {
                if (ListOfCars[x].Pos.X <= _turning.X)
                {
                    if (IncomingCars > 0)
                    {
                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {
                            if (ListOfCars[x].Pos.X > _stopPoint.X + 10 && ListOfCars[x].Pos.X < _stopPoint.X + 20)
                                CreateMovingObject(MyNumber, IncomingCars);
                            Haveneighbour = false;

                        }
                    }
                    ListOfCars[x].Pos.X += Speed;
                }
                else if (ListOfCars[x].Pos.X > _turning.X)
                {
                    ListOfCars[x].Pos.Y += Speed;
                }
                if (ListOfCars[x].Pos.Y > _endPoint.Y)
                {
                    
                   check=true;
                    // listOfCars[x].setPosition(this.startPoint);
                    //AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                   
            }
            break;
        case 7:
            for (var x = 0; x < ListOfCars.Count; x++)
            {
                if (ListOfCars[x].Pos.Y >= _turning.Y)
                {

                    if (IncomingCars > 0)
                    {
                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {
                            if (ListOfCars[x].Pos.Y < _stopPoint.Y - 10 && ListOfCars[x].Pos.Y > _stopPoint.Y - 20)
                                CreateMovingObject(MyNumber, IncomingCars);
                            Haveneighbour = false;

                        }
                    }

                    ListOfCars[x].Pos.Y -= Speed;
                }
                else if (ListOfCars[x].Pos.Y < _turning.Y)
                {
                    ListOfCars[x].Pos.X -= Speed;
                }

                if (ListOfCars[x].Pos.X < _endPoint.X)
                {
                    
                   check=true;
                    //listOfCars[x].setPosition(this.startPoint);
                    //AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                   
            }
            break;
        case 8:
            for (var x = 0; x < ListOfCars.Count; x++)
            {
                if (ListOfCars[x].Pos.Y >= _turning.Y)
                {
                    if (IncomingCars > 0)
                    {
                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {
                            if (ListOfCars[x].Pos.Y < _stopPoint.Y - 10 && ListOfCars[x].Pos.Y > _stopPoint.Y - 20)
                                CreateMovingObject(MyNumber, IncomingCars);
                            Haveneighbour = false;

                        }
                    }


                    ListOfCars[x].Pos.Y -= Speed;
                }
                if (ListOfCars[x].Pos.Y < _endPoint.Y)
                {
                    
                   check=true;
                    //listOfCars[x].setPosition(this.startPoint);
                    //AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                   
                   
            }
            break;
        case 9:
            for (var x = 0; x < ListOfCars.Count; x++)
            {
                if (ListOfCars[x].Pos.Y >= _turning.Y)
                {


                    if (IncomingCars > 0)
                    {
                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {
                            if (ListOfCars[x].Pos.Y < _stopPoint.Y - 10 && ListOfCars[x].Pos.Y > _stopPoint.Y - 20)
                                CreateMovingObject(MyNumber, IncomingCars);
                            Haveneighbour = false;

                        }
                    }
                    ListOfCars[x].Pos.Y -= Speed;
                }
                else if (ListOfCars[x].Pos.Y < _turning.Y)
                {
                    ListOfCars[x].Pos.X += Speed;
                }
                if (ListOfCars[x].Pos.X > _endPoint.X)
                {
                   
                   check=true;
                    //listOfCars[x].setPosition(this.startPoint);
                    //AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                  
            }
            break;
        case 10:
            for (var x = 0; x < ListOfCars.Count; x++)
            {
                

                if (ListOfCars[x].Pos.X >= _turning.X)
                {

                    if (IncomingCars > 0)
                    {

                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {

                            if (ListOfCars[x].Pos.X < _stopPoint.X - 10 && ListOfCars[x].Pos.X > _stopPoint.X - 20)
                            {

                                CreateMovingObject(MyNumber, IncomingCars);

                                Haveneighbour = false;


                                IncomingCars = 0;
                            }
                        }
                    }
                


                ListOfCars[x].Pos.X -= Speed;
                }
                else if (ListOfCars[x].Pos.X < _turning.X)
                {
                    ListOfCars[x].Pos.Y -= Speed;
                }
                if (ListOfCars[x].Pos.Y < _endPoint.Y)
                {
                   
                   check=true;
                    //listOfCars[x].setPosition(this.startPoint);
                    //AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                   
                    
            }
            break;
        case 11:
            for (var x = 0; x < ListOfCars.Count; x++)
            {
                

                if (ListOfCars[x].Pos.X >= _turning.X)
                {
                    if (IncomingCars > 0)
                    {

                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {

                            if (ListOfCars[x].Pos.X < _stopPoint.X - 10 && ListOfCars[x].Pos.X > _stopPoint.X - 20)
                            {

                                CreateMovingObject(MyNumber, IncomingCars);

                                Haveneighbour = false;



                            }
                        }
                    }
                    ListOfCars[x].Pos.X -= Speed;
                }
                if (ListOfCars[x].Pos.X < _endPoint.X)
                {
                   
                   check=true;
                    //listOfCars[x].setPosition(this.startPoint);
                    //AddCar(1);
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                  
                    
            }
            break;
        case 12:
            for (var x = 0; x < ListOfCars.Count; x++)
            {


                if (ListOfCars[x].Pos.X >= _turning.X)
                {
                    if (IncomingCars > 0)
                    {

                        if (x == ListOfCars.Count - 1 && Haveneighbour)
                        {

                            if (ListOfCars[x].Pos.X < _stopPoint.X - 10 && ListOfCars[x].Pos.X > _stopPoint.X - 20)
                            {

                                CreateMovingObject(MyNumber, IncomingCars);

                                Haveneighbour = false;


                               
                            }
                        }
                    }
                    ListOfCars[x].Pos.X -= Speed;
                }
                else if (ListOfCars[x].Pos.X < _turning.X)
                {
                    ListOfCars[x].Pos.Y += Speed;
                }
                if (ListOfCars[x].Pos.Y > _endPoint.Y)
                 {
                  
                  // listOfCars[x].setPosition(this.startPoint);
                   //AddCar(1);
                   check=true;
                   CarsforneighbourList.Add(ListOfCars[x]);
                   RemoveCar(ListOfCars[x]);
                }
                   
            }
       
            break;

            
    }
    return check;
}

        public bool Keepmoving()
        {
            CarsforneighbourList = new List<MovingObject>();
            //Point carPosition = new Point();
            bool check = false;
            switch (MyNumber)
            {
                case 1:
                    for (var i = 0; i < ListOfCars.Count; i++)
                    {
                        if (ListOfCars[i].Pos.Y > _stopPoint.Y)
                        {
                            if (ListOfCars[i].Pos.Y <= _turning.Y)
                                ListOfCars[i].Pos.Y += Speed;
                            else
                                ListOfCars[i].Pos.X -= Speed;
                        }

                        if (ListOfCars[i].Pos.X < _endPoint.X)
                        {

                            CarsforneighbourList.Add(ListOfCars[i]);
                           
                            check = true;
                            RemoveCar(ListOfCars[i]);
                        }
                    

                    }
                    break;
                case 2:
                    for (var i = 0; i < ListOfCars.Count; i++)
                    {
                        if (ListOfCars[i].Pos.Y > _stopPoint.Y)
                        {
                            if (ListOfCars[i].Pos.Y <= _turning.Y)
                            {
                                ListOfCars[i].Pos.Y += Speed;
                            }
                            if (ListOfCars[i].Pos.Y > _endPoint.Y)
                            {
                                
                                //listOfCars[i].setPosition(this.startPoint);
                                //AddCar(1);
                                check = true;
                               CarsforneighbourList.Add(ListOfCars[i]);
                               RemoveCar(ListOfCars[i]);
                            }
                      
                        }
                    }
                    break;
                case 3:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.Y > _stopPoint.Y)
                        {
                            if (ListOfCars[x].Pos.Y <= _turning.Y)
                            {
                                ListOfCars[x].Pos.Y += Speed;
                            }
                            else if (ListOfCars[x].Pos.Y > _turning.Y)
                            {
                                ListOfCars[x].Pos.X += Speed;
                            }
                            if (ListOfCars[x].Pos.X > _endPoint.X)
                            {
                                
                                check = true;
                                // listOfCars[x].setPosition(this.startPoint);
                                //AddCar(1);
                               CarsforneighbourList.Add(ListOfCars[x]);
                               RemoveCar(ListOfCars[x]);
                            }
                        
                        }
                    }
                    break;
                case 4:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.X > _stopPoint.X)
                        {
                            if (ListOfCars[x].Pos.X > _stopPoint.X)
                            {

                                if (ListOfCars[x].Pos.X <= _turning.X)
                                {
                                    ListOfCars[x].Pos.X += Speed;
                                }
                                else if (ListOfCars[x].Pos.X > _turning.X)
                                {
                                    ListOfCars[x].Pos.Y -= Speed;
                                }
                                if (ListOfCars[x].Pos.Y < _endPoint.Y)
                                {
                                   
                                    check = true;
                                    // listOfCars[x].setPosition(this.startPoint);
                                    //AddCar(1);
                                    CarsforneighbourList.Add(ListOfCars[x]);
                                    RemoveCar(ListOfCars[x]);
                                }
                            
                            }
                        }
                    }
                    break;
                case 5:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.X > _stopPoint.X)
                        {
                            if (ListOfCars[x].Pos.X <= _turning.X)
                            {
                                ListOfCars[x].Pos.X += Speed;
                            }
                            if (ListOfCars[x].Pos.X > _endPoint.X)
                            {
                                
                                check = true;
                                // listOfCars[x].setPosition(this.startPoint);
                                //AddCar(1);
                                CarsforneighbourList.Add(ListOfCars[x]);
                                RemoveCar(ListOfCars[x]);
                            }
                       
                        }
                    }
                    break;
                case 6:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.X > _stopPoint.X)
                        {
                            if (ListOfCars[x].Pos.X <= _turning.X)
                            {
                                ListOfCars[x].Pos.X += Speed;
                            }
                            else if (ListOfCars[x].Pos.X > _turning.X)
                            {
                                ListOfCars[x].Pos.Y += Speed;
                            }
                            if (ListOfCars[x].Pos.Y > _endPoint.Y)
                            {
                                
                                check = true;
                                // listOfCars[x].setPosition(this.startPoint);
                                //AddCar(1);
                               CarsforneighbourList.Add(ListOfCars[x]);
                               RemoveCar(ListOfCars[x]);
                            }
                       
                        }
                    }
                    break;
                case 7:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.Y < _stopPoint.Y)
                        {
                            if (ListOfCars[x].Pos.Y >= _turning.Y)
                            {
                                ListOfCars[x].Pos.Y -= Speed;
                            }
                            else if (ListOfCars[x].Pos.Y < _turning.Y)
                            {
                                ListOfCars[x].Pos.X -= Speed;
                            }

                            if (ListOfCars[x].Pos.X < _endPoint.X)
                            {
                                
                                check = true;
                                // listOfCars[x].setPosition(this.startPoint);
                                //AddCar(1);
                                CarsforneighbourList.Add(ListOfCars[x]);
                                RemoveCar(ListOfCars[x]);
                            }
                        
                        }
                    }
                    break;
                case 8:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.Y < _stopPoint.Y)
                        {
                            if (ListOfCars[x].Pos.Y >= _turning.Y)
                            {
                                ListOfCars[x].Pos.Y -= Speed;
                            }
                            if (ListOfCars[x].Pos.Y < _endPoint.Y)
                            {
                                
                                check = true;
                                // listOfCars[x].setPosition(this.startPoint);
                                //AddCar(1);
                                CarsforneighbourList.Add(ListOfCars[x]);
                                RemoveCar(ListOfCars[x]);
                            }
                       
                        }

                    }
                    break;
                case 9:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.Y < _stopPoint.Y)
                        {
                            if (ListOfCars[x].Pos.Y >= _turning.Y)
                            {
                                ListOfCars[x].Pos.Y -= Speed;
                            }
                            else if (ListOfCars[x].Pos.Y < _turning.Y)
                            {
                                ListOfCars[x].Pos.X += Speed;
                            }
                            if (ListOfCars[x].Pos.X > _endPoint.X)
                            {
                                
                                check = true;
                                // listOfCars[x].setPosition(this.startPoint);
                                //AddCar(1);
                               CarsforneighbourList.Add(ListOfCars[x]);
                               RemoveCar(ListOfCars[x]);
                            }
                       
                        }
                    }
                    break;
                case 10:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.X < _stopPoint.X)
                        {
                            if (ListOfCars[x].Pos.X >= _turning.X)
                            {
                                ListOfCars[x].Pos.X -= Speed;
                            }
                            else if (ListOfCars[x].Pos.X < _turning.X)
                            {
                                ListOfCars[x].Pos.Y -= Speed;
                            }
                            if (ListOfCars[x].Pos.Y < _endPoint.Y)
                            {
                                
                                check = true;
                                // listOfCars[x].setPosition(this.startPoint);
                                //AddCar(1);
                                CarsforneighbourList.Add(ListOfCars[x]);
                                RemoveCar(ListOfCars[x]);
                            }
                        
                        }
                    }
                    break;
                case 11:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.X < _stopPoint.X)
                        {
                            if (ListOfCars[x].Pos.X >= _turning.X)
                            {
                                ListOfCars[x].Pos.X -= Speed;
                            }
                            if (ListOfCars[x].Pos.X < _endPoint.X)
                            {
                                
                                check = true;
                                // listOfCars[x].setPosition(this.startPoint);
                                //AddCar(1);
                                CarsforneighbourList.Add(ListOfCars[x]);
                                RemoveCar(ListOfCars[x]);
                            }
                       
                        }
                    }
                    break;
                case 12:
                    for (var x = 0; x < ListOfCars.Count; x++)
                    {
                        if (ListOfCars[x].Pos.X < _stopPoint.X)
                        {
                            if (ListOfCars[x].Pos.X >= _turning.X)
                            {
                                ListOfCars[x].Pos.X -= Speed;
                            }
                            else if (ListOfCars[x].Pos.X < _turning.X)
                            {
                                ListOfCars[x].Pos.Y += Speed;
                            }
                            if (ListOfCars[x].Pos.Y > _endPoint.Y)
                            {
                                
                                check = true;
                                // listOfCars[x].setPosition(this.startPoint);
                                //AddCar(1);
                                CarsforneighbourList.Add(ListOfCars[x]);
                                RemoveCar(ListOfCars[x]);
                            }
                       
                        } 
                    }
                    break;
            }
            return check;
        }

#endregion

    }
}
