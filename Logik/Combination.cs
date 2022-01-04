using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Combination
    {
        public Pin [] Pins { get; set; }
        public Combination()
        {
            Pins = new Pin[4] { new Pin(), 
                                new Pin(), 
                                new Pin(), 
                                new Pin()
            };
        }
        public void Draw(Graphics graphics,PointF location,int size)
        {
            foreach (var pin in Pins)
            {
                pin.Draw(graphics, Pens.Black, location, size);
            }
        }
    }
}
