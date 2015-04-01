using System;
using System.Drawing;

namespace Traffic_Light_Simulation
{
    [Serializable]
    class TrafficLight
    {
        readonly int _x;
        readonly int _y;
        readonly int _width;
        readonly int _height;
       // [NonSerialized]
       // SolidBrush _b = new SolidBrush(Color.Red);
        Rectangle _tl;

        [NonSerialized]
        private Brush _b = Brushes.Red;

        /// <summary>
        /// creates a light object
        /// </summary>
        
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public TrafficLight(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _height = height;
            _width = width;
            //_b = new SolidBrush(Color.Red);
           // _b = new SolidBrush(_colorforSolidbrush);
            _b = Brushes.Red;
            // _colorforSolidbrush= _b.Color;

        }

        /// <summary>
        /// paints the color green in the top of the light
        /// </summary>
        public void Paintgreen()
        {
            //_b = new SolidBrush(Color.Green);
           // _b = new SolidBrush(_colorforSolidbrush);
            _b = Brushes.Green;
//
        }
       
        /// <summary>
        /// paints red in the bottom of light
        /// </summary>
        public void PainttoRed()
        {
            // _b = new SolidBrush(Color.Red);
            _b = Brushes.Red;
           // _b = new SolidBrush(_colorforSolidbrush);
        }
        /// <summary>
        /// calls all paint methods in step first green, yellow, then red
        /// </summary>
        /// <param name="gr"></param>
        public void PaintItself(Graphics gr)
        {
            if (_b == null) { _b = Brushes.Red; }
           
            _tl = new Rectangle(_x, _y, _width, _height);
            var p = new Pen(Brushes.Black);
            

            gr.DrawRectangle(p, _tl);
            gr.FillRectangle(_b, _tl); 
           
        }
        /// <summary>
        /// this the length of green paint other than yellow
        /// </summary>
        /// <param name="len"></param>
        public void SetGreenLength(int len)
        {
            //set length value
        }

    }
}
