using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.UI.Controls
{
    public class GlyphRenderer
    {
        public static Icon CreateGlyphIcon(uint glyph, Font f)
        {
            using (var b = new Bitmap(16, 16))
            using (Graphics g = Graphics.FromImage(b))
            using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
                g.DrawString(((char)glyph).ToString(), f, Brushes.White, new Rectangle(0, 0, 16, 16), sf);

                return Icon.FromHandle(b.GetHicon());
            }
        }
        public static Icon CreateGlyphIcon(uint glyph)
        {
            using (var b = new Bitmap(16, 16))
            using (Graphics g = Graphics.FromImage(b))
            using (Font f = new Font("Segoe MDL2 Assets", 12, FontStyle.Regular))
            using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
                g.DrawString(((char)glyph).ToString(), f, Brushes.White, new Rectangle(0, 0, 16, 16), sf);

                return Icon.FromHandle(b.GetHicon());
            }
        }
        public static char GetGlyph(uint glyphCode)
        {
            return (char)glyphCode;
        }
    }
}
