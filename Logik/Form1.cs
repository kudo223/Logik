using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logik
{
    public partial class Form1 : Form
    {
        private Combination[] combinations;
        public Form1()
        {
            InitializeComponent();
            SetDefaults();
        }
        private void SetDefaults()
        {
            combinations = new Combination[9];
            for (int i = 0; i < combinations.Length; i++)
            {
                combinations[i] = new Combination();
            }
        }


        private void pBox_Click(object sender, EventArgs e)
        {

        }

        private void pBox_Paint(object sender, PaintEventArgs e)
        {
            var size = 35;
            for(int i=0;i<combinations.Length;i++ )
            {
                combinations[i].Draw(e.Graphics, new PointF(10, 10 + i * size * 1.25F), size);
            }
        }

        private void pBox_MouseClick(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < combinations.Length; i++)
            {
                foreach (var pin in combinations[i].Pins)
                {
                    if (pin.Region.IsVisible(e.Location))
                    {
                        pin.State++;
                        if(pin.State>Pin.PinState.Color6)
                        {
                            pin.State = Pin.PinState.Color1;
                        }
                    }
                }
            }
            pBox.Refresh();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SetDefaults();
            pBox.Refresh();
        }
    }
}
