using System;
using System.Drawing;

namespace Traffic_Light_Simulation
{
    [Serializable()]
    class CrossingWithoutPedestarian: Crossing
    {
        public CrossingWithoutPedestarian(Rectangle r, Image im,string type)
            : base(r, im,type)
        {

        }

        
    /*    public  override void paintSelf(System.Drawing.Graphics gr)
        {
            throw new NotImplementedException();
        }*/
// ReSharper disable once RedundantOverridenMember
        /// <summary>
        /// creates 4 groups of lanes
        /// </summary>
       

        /*public override void CreateGroup(Point pos)
        {
            base.CreateGroup(pos);
        }*/
    }
}
