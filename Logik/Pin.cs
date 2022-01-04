using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Pin
    {
        public PinState State { get; set; }
        public Pin()
        {
            State = PinState.Empty;
        }
        public void Draw(Graphics graphics, Pen pen, PointF point, int size)
        {
            Color color;
            switch(State)
            {
                case PinState.Color1:
                    color = Color.Tomato;
                    break;
                case PinState.Color2:
                    color = Color.Chocolate;
                    break;
                case PinState.Color3:
                    color = Color.Aqua;
                    break;
                case PinState.Color4:
                    color = Color.YellowGreen;
                    break;
                case PinState.Color5:
                    color = Color.WhiteSmoke;
                    break;
                case PinState.Color6:
                    color = Color.YellowGreen;
                    break;
                default:
                    color = Color.RosyBrown;
                    break;
            }
            Brush brush = new SolidBrush(color);
            graphics.FillEllipse(brush, point.X, point.Y, size, size);
            graphics.DrawEllipse(pen, point.X, point.Y, size, size);
        }
        public enum PinState 
        {
            Empty,
            Color1,
            Color2,
            Color3,
            Color4,
            Color5,
            Color6
        }
        
    }
}
