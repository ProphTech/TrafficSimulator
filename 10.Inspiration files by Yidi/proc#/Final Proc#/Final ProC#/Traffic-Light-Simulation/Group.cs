using System;

namespace Traffic_Light_Simulation
{
    [Serializable]
    class Group  
    {
        public string Name;
     //   List<Lane> listOfLanes;
       public Lane[] ListOfLanes;
        

       public int _interval;


        /// <summary>
        /// create a lane with a given position and assigns name and default timer 20sec for the group
        /// </summary>
        /// <param name="nameofgroup"></param>
        /// <param name="laneInGroup"></param>
        public Group(string nameofgroup, params Lane[] laneInGroup)
        {
            Name = nameofgroup;
            ListOfLanes=new Lane[laneInGroup.Length];
            for(var i=0;i<laneInGroup.Length;i++)
            {
                ListOfLanes[i]=laneInGroup[i];
            }
            //Timer.Interval = 2000;
            _interval = 2000;

        }

        /// <summary>
        /// changes the color of light of lights in the group to green and Red according to timer
        /// </summary>
        /// <returns>it retuns true if all are changed to red</returns>
      
        public bool Changecolor()
       {
           return true;
           
       }
        /// <summary>
        /// sets the time length of each light in the group
        /// </summary>
        public void SetTime(int len)
        {
          //loops through all lanes and changes their green time length...
            _interval = len;
        }
        public int Getinterval()
        {
            return _interval;
        }
        
        
    }
}
