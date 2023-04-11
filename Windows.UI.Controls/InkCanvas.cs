using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.UI.Controls
{
    public class InkCanvas : System.Windows.Forms.Control
    {
        private Bitmap b;
        private Graphics g;
        private bool moving = false;
        private int x, y = 0;
        private Color col = Color.Black;
        private int weight = 5;

        public InkCanvas()
        {
            this.BackColor = Color.White;

            b = new(ClientSize.Width, ClientSize.Height);
            g = Graphics.FromImage(b);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(b, 0, 0);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (moving && x != 0 && y != 0)
            {
                g.DrawLine(new Pen(col, weight), new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                Invalidate();
            }

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            moving = true;
            x = e.X;
            y = e.Y;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            moving = false;
            x = 0;
            y = 0;
        }
    }
}
