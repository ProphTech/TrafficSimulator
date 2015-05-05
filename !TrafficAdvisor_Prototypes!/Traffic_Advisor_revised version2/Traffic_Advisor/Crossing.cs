using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Advisor
{
    public abstract class Crossing
    {
        public List<Lane> Lanes { get;private set; }
        public int X { get;private set; }
        public int Y { get;private set; }

        public Crossing()
        {
            Lanes = new List<Lane>();
            for (int i = 0; i < 8; i++)
            {
                Lanes.Add(new Lane());
            }
            //go to state 1
            this.Lanes[2].SetCurrentLightToGreen();
            this.Lanes[7].SetCurrentLightToGreen();
        }

        public void Initialization()
        {
            for (int i = 0; i < 8; i++)
            {
                Lanes[i] = new Lane();
            }
            this.Lanes[2].SetCurrentLightToGreen();
            this.Lanes[7].SetCurrentLightToGreen();
        }

        public void SetLocation(int x, int y)
        {
            this.X = x; this.Y = y;
        }

        public void SetMaxFlowOfLanes(int L1, int L2, int U1, int U2, int R1, int R2, int D1, int D2)
        {
            Lanes[0].SetMaxFlow(L1);
            Lanes[1].SetMaxFlow(L2);
            Lanes[2].SetMaxFlow(U1);
            Lanes[3].SetMaxFlow(U2);
            Lanes[4].SetMaxFlow(R1);
            Lanes[5].SetMaxFlow(R2);
            Lanes[6].SetMaxFlow(D1);
            Lanes[7].SetMaxFlow(D2);
        }

        public void SetCurrentFlowOfLanes(int L1, int L2, int U1, int U2, int R1, int R2, int D1, int D2)
        {
            Lanes[0].SetCurrentFlow(L1);
            Lanes[1].SetCurrentFlow(L2);
            Lanes[2].SetCurrentFlow(U1);
            Lanes[3].SetCurrentFlow(U2);
            Lanes[4].SetCurrentFlow(R1);
            Lanes[5].SetCurrentFlow(R2);
            Lanes[6].SetCurrentFlow(D1);
            Lanes[7].SetCurrentFlow(D2);
        }

        public abstract void NextSecond(Crossing left, Crossing up, Crossing right, Crossing down);
    }
}
