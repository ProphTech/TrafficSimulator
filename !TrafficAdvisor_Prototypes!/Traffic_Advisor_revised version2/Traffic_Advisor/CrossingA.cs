using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Advisor
{
    enum crossingStateTypeA
    {
        lane3and8=1,lane4and7=2,lane2and5=3,lane1and6=4
    }

    class CrossingA:Crossing
    {
        public crossingStateTypeA statusA { get;private set; }

        public CrossingA():base()
        {
            statusA = crossingStateTypeA.lane3and8;
        }

        public override void NextSecond(Crossing left, Crossing up, Crossing right, Crossing down)
        {
            switch (statusA)
            {
                case crossingStateTypeA.lane3and8:
                    {
                        #region lane 3 and lane 8 decrease flow and increase flow
                        //lane 3
                        //flow decrease.
                        Lanes[2].DecreaseFlow();

                        //where the car goes.
                        if (Jackpot())
                        {
                            if (down != null)
                            {
                                if (Jackpot())
                                    down.Lanes[2].InreaseFlow();
                                else
                                    down.Lanes[3].InreaseFlow();
                            }
                        }
                        else
                        {
                            if (left != null)
                            {
                                if (Jackpot())
                                    left.Lanes[4].InreaseFlow();
                                else
                                    left.Lanes[5].InreaseFlow();
                            }
                        }

                        //lane 8
                        Lanes[7].DecreaseFlow();

                        if (Jackpot())
                        {
                            if (up != null)
                            {
                                if (Jackpot())
                                    up.Lanes[6].InreaseFlow();
                                else
                                    up.Lanes[7].InreaseFlow();
                            }
                        }
                        else
                        {
                            if (right != null)
                            {
                                if (Jackpot())
                                    right.Lanes[0].InreaseFlow();
                                else
                                    right.Lanes[1].InreaseFlow();

                            }
                        }
                        # endregion

                        Lanes[2].Light.NextSecond();
                        Lanes[7].Light.NextSecond();

                        if (Lanes[2].Light.CurrentLight == LightStatus.red)
                        {
                            statusA = crossingStateTypeA.lane4and7;
                            Lanes[3].SetCurrentLightToGreen();
                            Lanes[6].SetCurrentLightToGreen();
                        }
                    }
                    break;

                case crossingStateTypeA.lane4and7:
                    {
                        #region lane 4 and 7 decrease flow and increase flow

                        Lanes[3].DecreaseFlow();

                        if (right != null)
                        {
                            if (Jackpot())
                                right.Lanes[0].InreaseFlow();
                            else
                                right.Lanes[1].InreaseFlow();
                        }
                      

                        Lanes[6].DecreaseFlow();


                        if (left != null)
                        {
                            if (Jackpot())
                                left.Lanes[4].InreaseFlow();
                            else
                                left.Lanes[5].InreaseFlow();
                        }
                       
                        
                        #endregion

                        Lanes[3].Light.NextSecond();
                        Lanes[6].Light.NextSecond();

                        if (Lanes[3].Light.CurrentLight == LightStatus.red)
                        {
                            statusA = crossingStateTypeA.lane2and5;
                            Lanes[1].SetCurrentLightToGreen();
                            Lanes[4].SetCurrentLightToGreen();
                        }
                    }
                    break;

                case crossingStateTypeA.lane2and5:
                    {
                        #region lane 2 and lane 5 increase flow and decrease flow

                        Lanes[1].DecreaseFlow();

                        if (Jackpot())
                        {
                            if (right != null)
                            {
                                if (Jackpot())
                                    right.Lanes[0].InreaseFlow();
                                else
                                    right.Lanes[1].InreaseFlow();
                            }
                        }
                        else
                        {
                            if (down != null)
                            {
                                if (Jackpot())
                                    down.Lanes[2].InreaseFlow();
                                else
                                    down.Lanes[3].InreaseFlow();
                            }
                        }

                        Lanes[4].DecreaseFlow();

                        if (Jackpot())
                        {
                            if (left != null)
                            {
                                if (Jackpot())
                                    left.Lanes[4].InreaseFlow();
                                else
                                    left.Lanes[5].InreaseFlow();
                            }
                        }
                        else
                        {
                            if (up != null)
                            {
                                if (Jackpot())
                                    up.Lanes[6].InreaseFlow();
                                else
                                    up.Lanes[7].InreaseFlow();
                            }
                        }

                        #endregion

                        Lanes[1].Light.NextSecond();
                        Lanes[4].Light.NextSecond();

                        if (Lanes[1].Light.CurrentLight == LightStatus.red)
                        {
                            statusA = crossingStateTypeA.lane1and6;
                            Lanes[0].SetCurrentLightToGreen();
                            Lanes[5].SetCurrentLightToGreen();
                        }
                    }
                    break;

                case crossingStateTypeA.lane1and6:
                    {
                        #region lane 1 and lane 6 increase and decrease flow

                        Lanes[0].DecreaseFlow();


                        if (up != null)
                        {
                            if (Jackpot())
                                up.Lanes[6].InreaseFlow();
                            else
                                up.Lanes[7].InreaseFlow();
                        }
                     

                        Lanes[5].DecreaseFlow();

                        if (down != null)
                        {
                            if (Jackpot())
                                down.Lanes[2].InreaseFlow();
                            else
                                down.Lanes[3].InreaseFlow();
                        }
                     

                        #endregion 

                        Lanes[0].Light.NextSecond();
                        Lanes[5].Light.NextSecond();

                        if (Lanes[0].Light.CurrentLight == LightStatus.red)
                        {
                            statusA = crossingStateTypeA.lane3and8;
                            Lanes[2].SetCurrentLightToGreen();
                            Lanes[7].SetCurrentLightToGreen();
                        }
                    }
                    break;
            }
        }

        //50% random method.
        private bool Jackpot()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            if (r.Next(0, 10) < 5)
                return true;
            else
                return false;
        }

    }
}
