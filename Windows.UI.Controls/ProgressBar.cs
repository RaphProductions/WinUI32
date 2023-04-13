using libmsstyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Theming;

namespace Windows.UI.Controls
{
    // will be used later
    public class ProgressBar : System.Windows.Forms.ProgressBar
    {
        private Theme _elementTheme = Theme.Light;

        public event EventHandler ThemeChanged;

        public Theme ElementTheme
        {
            get => _elementTheme;
            set
            {
                _elementTheme = value;
                OnThemeChanged();
            }
        }

        protected void OnThemeChanged()
        {
            if (ThemeChanged != null)
                ThemeChanged.Invoke(this, EventArgs.Empty);
        }

        private bool _error = false;
        public bool Error
        {
            get => _error;
            set
            {
                _error = value;
                Invalidate();
            }
        }
        public ProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            if (ElementTheme == Theme.Dark)
            {
                BackColor = Color.FromArgb(36, 36, 36);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum));

            bool UsingDarkMode = ElementTheme == Theme.Dark;

            if (ElementTheme == Theme.Dark)
            {
                BackColor = Color.FromArgb(36, 36, 36);
            }

            /**if (DesignMode)
            {
                if (ProgressBarRenderer.IsSupported)
                    ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            }
            else
            {**/
                var currentTheme = UsingDarkMode ? VisualStyleHandler.DarkStyle : VisualStyleHandler.LightStyle;

                var part = VisualStyleHandler.GetProgressbarBg(currentTheme);
                var renderer2 = new PartRenderer(currentTheme, part);
                var b = renderer2.RenderPreview(ThemeParts.Normal, Width, Height);

                e.Graphics.DrawImage(b, new Point(0, 0));
            //}

            if (rec.Width == 0)
                return;

            if (DesignMode)
            {
                e.Graphics.FillRectangle(Brushes.Green, 0, 0, rec.Width, rec.Height);
            }
            else
            {
                var currentTheme2 = UsingDarkMode ? VisualStyleHandler.DarkStyle : VisualStyleHandler.LightStyle;

                var part2 = VisualStyleHandler.GetProgressbarFill(currentTheme);

                using var renderer3 = new PartRenderer(currentTheme2, part2);
                var tpart = Error ? ThemeParts.Pressed : ThemeParts.Normal;
                var b2 = renderer3.RenderPreview(tpart, rec.Width, rec.Height);

                e.Graphics.DrawImage(b2, new Point(0, 0));
                b.Dispose();
            }
        }
    }
}
