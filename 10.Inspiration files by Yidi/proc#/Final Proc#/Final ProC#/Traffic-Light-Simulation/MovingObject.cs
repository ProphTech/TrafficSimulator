using System;
using System.Drawing;

namespace Traffic_Light_Simulation
{
    [Serializable]
    class MovingObject
    {
        public Point Pos;
        private Color _color;
        private Rectangle _myrectangle;
        public int LaneNumber { get; set; }

        /// <summary>
        /// This is the constuctor of the class MovingObject
        /// </summary>
        public MovingObject(Point p, int lanenum)
        {
           _color = Color.Indigo;
           LaneNumber = lanenum;
            Pos = p;
          
        }

        /// <summary>
        /// This method is responsible for moving the moving objects
        /// </summary>
        public void ChangeColor(Color color)   //int speed
        {
            _color = color;
        }
        /// <summary>
        /// This method paints the moving objects on a graphics
        /// </summary>
        /// <param name="gr">The graphics on which the objects should be painted</param>
        public void PaintSelf(Graphics gr)
        {
            //draw here pictur box with some position
            var mypen = new Pen(Color.Green);
            const int width = 4;
            const int height = 4;
            var s = new Size(width, height);
            
                _myrectangle = new Rectangle(Pos, s); 
            
            
                gr.DrawRectangle(mypen, _myrectangle);
                //System.Drawing.Drawing2D.LinearGradientBrush
                   var lBrush = new SolidBrush(_color);
                gr.FillRectangle(lBrush, _myrectangle);

           
        }

        public void SetPosition(Point newp)
        {
            Pos = newp;
        }
   
    }
}
