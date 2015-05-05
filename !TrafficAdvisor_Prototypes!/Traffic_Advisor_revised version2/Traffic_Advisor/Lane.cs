using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Traffic_Advisor
{
    public class Lane
    {
        public int MaxFlow { get;private set; }
        public int CurrentFlow { get;private set; }
        public TrafficLight Light { get;private set; }
        public Color color { get; set; }

        public Lane()
        {
            this.MaxFlow = 20;
            Random r = new Random(DateTime.Now.Millisecond);
            CurrentFlow = r.Next(0, 5) + 5;
            this.Light = new TrafficLight();
            color = Color.Green;
        }

        public void SetMaxFlow(int max)
        {
            this.MaxFlow = max;
        }

        public void InreaseFlow()
        {
            CurrentFlow++;
            if (CurrentFlow > MaxFlow)
            {
                this.color = Color.Red;
                Simulation.LogBook.Add(DateTime.Now.ToString() + ", current flow is: " + CurrentFlow + ", Over maximum flow!! Traffic Jam here!!");
            }
            //else
                //Simulation.LogBook.Add(DateTime.Now.ToString() + ", current flow is: " + CurrentFlow);
        }

        public void DecreaseFlow()
        {
            if (CurrentFlow < 2)
                CurrentFlow = 5;
            CurrentFlow--;
            if (CurrentFlow < MaxFlow)
                this.color = Color.Green;

            //Simulation.LogBook.Add(DateTime.Now.ToString() + ", current flow is: " + CurrentFlow);
        }

        public void SetCurrentLightToGreen()
        {
            this.Light.SetCurrentLightToGreen();
        }

        //test method
        public void SetCurrentFlow(int i)
        {
            this.CurrentFlow = i;
            if (CurrentFlow < MaxFlow)
                this.color = Color.Green;
            if (CurrentFlow > MaxFlow)
                this.color = Color.Red;
        }

    }
}
