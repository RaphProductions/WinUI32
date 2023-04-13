using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.UI.Controls.InternalControls
{
    internal class InternalTextBox : System.Windows.Forms.TextBox
    {
        ThemedText tt;

        public new string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                tt.Text = value;
            }
        }

        public new Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                tt.Font = value;
            }
        }

        public new Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                tt.Color = value;
            }
        }

        public InternalTextBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            tt = new();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            tt.FormatFlags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;
            tt.Draw(e.Graphics, this.ClientRectangle);

        }
    }
}
