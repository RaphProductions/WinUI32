using libmsstyle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Theming;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Windows.UI.Controls.Native.NativeMethods;

namespace Windows.UI.Controls
{
    public partial class TextBox : UserControl
    {
        private Theme _elementTheme = Theme.Dark;

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

        protected virtual void OnThemeChanged()
        {
            if (ThemeChanged != null)
                ThemeChanged.Invoke(this, EventArgs.Empty);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            bool UsingDarkMode = ElementTheme == Theme.Dark;

            if (DesignMode)
            {
                e.Graphics.FillRectangle(Brushes.Black, 0, 0, ClientSize.Width, ClientSize.Height);
            }
            else
            {
                var currentTheme = UsingDarkMode ? VisualStyleHandler.DarkStyle : VisualStyleHandler.LightStyle;

                var part = VisualStyleHandler.GetEditBorder(currentTheme);

                using var renderer2 = new PartRenderer(currentTheme, part);
                var tpart = internalTextBox1.Focused ? ThemeParts.Normal : ThemeParts.Pressed;
                var b = renderer2.RenderPreview(tpart, ClientSize.Width, ClientSize.Height);
                
                e.Graphics.DrawImage(b, new Point(0, 0));
                b.Dispose();
            }
        }

        public TextBox()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
    }
}
