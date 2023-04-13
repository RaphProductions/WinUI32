using libmsstyle;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Theming;

namespace Windows.UI.Controls
{
    public class CheckMark : Control
    {
        public bool Checked { get; set; } = false;

        public CheckMark()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (Checked)
                Checked = false;
            else
                Checked = true;
            Invalidate();
        }

        public new Size Size { get { return new(16, 16); } set { base.Size = new(16, 16); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            bool UsingDarkMode = ElementTheme == Theme.Dark;

            if (DesignMode)
            {
                e.Graphics.FillRectangle(Brushes.Green, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            }
            else
            {
                var currentTheme = UsingDarkMode ? VisualStyleHandler.DarkStyle : VisualStyleHandler.LightStyle;

                var part = VisualStyleHandler.GetCheckBoxPart(currentTheme);

                using var renderer2 = new PartRenderer(currentTheme, part);
                var tpart = Checked ? ThemeParts.Defaulted : ThemeParts.Normal;
                var b = renderer2.RenderPreview(tpart, ClientRectangle.Width, ClientRectangle.Height);

                e.Graphics.DrawImage(b, new Point(0, 0));
                b.Dispose();
            }
        }
    }
}
