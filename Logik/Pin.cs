using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Pin
    {
        private Region region;
        public PinState State { get; set; }
        public Region Region { get => region; }
        public Pin()
        {
            State = PinState.Empty;
        }
        public void Draw(Graphics graphics, Pen pen, PointF point, int size)
        {
           
            Brush brush = new SolidBrush(GetColor());
            graphics.FillEllipse(brush, point.X, point.Y, size, size);
            graphics.DrawEllipse(pen, point.X, point.Y, size, size);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(point.X, point.Y, size, size);
            region = new Region(path);
        }
        private Color GetColor()
        {
            switch (State)
            {
                case PinState.Color1:
                    return Color.Tomato;
                case PinState.Color2:
                    return Color.Chocolate;
                case PinState.Color3:
                    return Color.Aqua;
                case PinState.Color4:
                    return Color.YellowGreen;
                case PinState.Color5:
                    return Color.WhiteSmoke;
                case PinState.Color6:
                    return Color.YellowGreen;
                default:
                    return Color.RosyBrown;
            }
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
