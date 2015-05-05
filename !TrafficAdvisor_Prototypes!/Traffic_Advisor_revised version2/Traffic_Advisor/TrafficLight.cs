using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Advisor
{
    public enum LightStatus
    {
        red,yellow,green
    }

    public class TrafficLight
    {
        private int RedInterval;
        private int YellowInterval;
        private int GreenInterval;

        public int RedTimer { get;private set; }
        public int GreenTimer { get;private set; }
        public int YellowTimer { get;private set; }

        public LightStatus CurrentLight { get;private set; }

        public TrafficLight()
        {
            CurrentLight = LightStatus.red;
            this.RedInterval = this.RedTimer = 10;
            this.YellowInterval = this.YellowTimer = 2;
            this.GreenInterval = this.GreenTimer = 10;
        }

        public void SetInterval(int red, int yellow, int green)
        {
            this.RedInterval = this.RedTimer = red;
            this.YellowInterval = this.YellowTimer = yellow;
            this.GreenInterval = this.GreenTimer = green;
        }

        public void SetCurrentLightToGreen()
        {
            this.CurrentLight = LightStatus.green;
        }

        public void NextSecond()
        {
            if (CurrentLight == LightStatus.green)
            {
                GreenTimer--;
                if (GreenTimer == 0)
                {
                    GreenTimer = GreenInterval;
                    CurrentLight = LightStatus.yellow;
                    return;
                }
            }

            if (CurrentLight == LightStatus.yellow)
            {
                YellowTimer--;
                if (YellowTimer == 0)
                {
                    YellowTimer = YellowInterval;
                    CurrentLight = LightStatus.red;
                    return;
                }
            }

            if (CurrentLight == LightStatus.red)
            {
                RedTimer--;
                if (RedTimer == 0)
                {
                    RedTimer = RedInterval;
                    CurrentLight = LightStatus.green;
                    return;
                }
            }
            
        }
    }
}
