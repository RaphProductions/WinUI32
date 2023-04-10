using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.UI.Controls
{
    public class RoundedCornersRenderer
    {
        public static System.Drawing.Drawing2D.GraphicsPath CreatePath(Rectangle rect, int nRadius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, nRadius, nRadius, 180f, 90f);
            path.AddArc((rect.Right - nRadius), rect.Y, nRadius, nRadius, 270f, 90f);
            path.AddArc((rect.Right - nRadius), (rect.Bottom - nRadius), nRadius, nRadius, 0f, 90f);
            path.AddArc(rect.X, (rect.Bottom - nRadius), nRadius, nRadius, 90f, 90f);
            path.CloseFigure();
            return path;
        }
    }
}
