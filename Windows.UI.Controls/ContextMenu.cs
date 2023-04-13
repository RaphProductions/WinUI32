using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Controls.Native;
using static Windows.UI.Controls.ContextMenu;
using static Windows.UI.Controls.Native.NativeMethods;

namespace Windows.UI.Controls
{
    public partial class ContextMenu : Window
    {
        #region Native
        [DllImport("user32.dll")]
        static extern bool AdjustWindowRectEx(ref RECT lpRect, uint dwStyle, bool bMenu, uint dwExStyle);
        const int Rounded = 2;
        const int RoundedCornersPreference = 33;
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left, Top, Right, Bottom;

            public RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public RECT(System.Drawing.Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom) { }

            public int X
            {
                get { return Left; }
                set { Right -= (Left - value); Left = value; }
            }

            public int Y
            {
                get { return Top; }
                set { Bottom -= (Top - value); Top = value; }
            }

            public int Height
            {
                get { return Bottom - Top; }
                set { Bottom = value + Top; }
            }

            public int Width
            {
                get { return Right - Left; }
                set { Right = value + Left; }
            }

            public System.Drawing.Point Location
            {
                get { return new System.Drawing.Point(Left, Top); }
                set { X = value.X; Y = value.Y; }
            }

            public System.Drawing.Size Size
            {
                get { return new System.Drawing.Size(Width, Height); }
                set { Width = value.Width; Height = value.Height; }
            }

            public static implicit operator System.Drawing.Rectangle(RECT r)
            {
                return new System.Drawing.Rectangle(r.Left, r.Top, r.Width, r.Height);
            }

            public static implicit operator RECT(System.Drawing.Rectangle r)
            {
                return new RECT(r);
            }

            public static bool operator ==(RECT r1, RECT r2)
            {
                return r1.Equals(r2);
            }

            public static bool operator !=(RECT r1, RECT r2)
            {
                return !r1.Equals(r2);
            }

            public bool Equals(RECT r)
            {
                return r.Left == Left && r.Top == Top && r.Right == Right && r.Bottom == Bottom;
            }

            public override bool Equals(object obj)
            {
                if (obj is RECT)
                    return Equals((RECT)obj);
                else if (obj is System.Drawing.Rectangle)
                    return Equals(new RECT((System.Drawing.Rectangle)obj));
                return false;
            }

            public override int GetHashCode()
            {
                return ((System.Drawing.Rectangle)this).GetHashCode();
            }

            public override string ToString()
            {
                return string.Format(System.Globalization.CultureInfo.CurrentCulture, "{{Left={0},Top={1},Right={2},Bottom={3}}}", Left, Top, Right, Bottom);
            }
        }
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            if (m.Msg == 0x01 /**WM_CREATE event**/)
            {
                int r = Rounded;
                int a = 3;

                DWMAPI.DwmSetWindowAttribute(Handle, (DWMAPI.DwmWindowAttribute)RoundedCornersPreference, ref r, sizeof(int));
                DWMAPI.DwmSetWindowAttribute(Handle, DWMAPI.DwmWindowAttribute.SystemBackdropType, ref a, sizeof(Int32));
            }
        }
        #endregion

        private List<Button> Items;

        public void AddItem(Button item)
        {
            item.Dock = DockStyle.Fill;

            Panel p = new();
            p.Padding = new Padding(8, 8, 8, 4);
            p.Height = item.Height + 8 * 2;
            p.Dock = DockStyle.Top;
            p.Controls.Add(item);

            this.Controls.Add(p);

            var p2 = (Panel)this.Controls[0];
            p2.Padding = new Padding(8, 8, 8, 8);
            p2.Height = item.Height + (8*2);

            int h = 0;

            foreach (System.Windows.Forms.Control c in Controls)
            {
                h += c.Height;
            }
            Height = h;
        }

        public ContextMenu()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
