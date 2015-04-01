using System;
using System.Drawing;

namespace Traffic_Light_Simulation
{
    [Serializable()]
    class CrossingWithPedestarian : Crossing
    {
        public CrossingWithPedestarian(Rectangle r, Image im,string type)
            : base(r, im,type)
        {

        }
     
            
     
       /* public override void paintSelf(System.Drawing.Graphics gr)
        {
            throw new NotImplementedException();
        }*/
// ReSharper disable once RedundantOverridenMember


        /* public override void CreateGroup(Point pos)
        {
            base.CreateGroup(pos);
        }*/
    }
}
