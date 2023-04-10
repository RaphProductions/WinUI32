using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static Windows.UI.Controls.Native.NativeMethods;

namespace Windows.UI.Controls
{
    public class TextBlock : Control
    {
        private ThemedText _themeText;

        protected override void OnHandleCreated(EventArgs e)
        {
            _themeText = new ThemedText();
            UpdateText();

            base.OnHandleCreated(e);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (_themeText != null)
            {
                _themeText.Dispose();
            }
            _themeText = null;

            base.OnHandleDestroyed(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Invalidate(false);
        }

        private void UpdateText()
        {
            if (_themeText != null)
            {
                _themeText.Text = Text;
                _themeText.Font = Font;
                _themeText.Padding = Padding;
                _themeText.Color = ForeColor;
                _themeText.FormatFlags = CreateFormatFlags();
            }

            Invalidate(false);
        }

        #region Control properties overriding

        public override string Text
        {
            set
            {
                base.Text = value;
                UpdateText();
            }
        }

        public override Font Font
        {
            set
            {
                base.Font = value;
                UpdateText();
            }
        }

        public new Padding Padding
        {
            get { return base.Padding; }
            set
            {
                base.Padding = value;
                UpdateText();
            }
        }

        public override Color ForeColor
        {
            set
            {
                base.ForeColor = value;
                UpdateText();
            }
        }

        [Browsable(false)]
        public new Color BackColor
        {
            get { return base.BackColor; }
            set { }
        }

        [Browsable(false)]
        public new Image BackgroundImage
        {
            get { return base.BackgroundImage; }
            set { }
        }

        [Browsable(false)]
        public new ImageLayout BackgroundImageLayout
        {
            get { return base.BackgroundImageLayout; }
            set { }
        }

        #endregion Control properties overriding

        #region Glow properties

        private int _glowSize = ThemedText.DefaultGlowSize;

        /// <summary>
        /// Size of the glow effect around the text.
        /// </summary>
        [
        Description("Size of the glow effect around the text."),
        Category("Appearance"),
        DefaultValue(ThemedText.DefaultGlowSize)
        ]
        public int GlowSize
        {
            get
            {
                return _glowSize;
            }
            set
            {
                _glowSize = value;
                UpdateText();
            }
        }

        private bool _glowEnabled = true;

        /// <summary>
        /// Enables or disables the glow effect around the text.
        /// </summary>
        [
        Description("Enables or disables the glow effect around the text."),
        Category("Appearance"),
        DefaultValue(true)
        ]
        public bool GlowEnabled
        {
            get
            {
                return _glowEnabled;
            }
            set
            {
                _glowEnabled = value;
                UpdateText();
            }
        }

        #endregion Glow properties

        #region Text format properties

        private HorizontalAlignment _horizontal = HorizontalAlignment.Left;

        /// <summary>
        /// Gets or sets the horizontal text alignment setting.
        /// </summary>
        [
        Description("Horizontal text alignment."),
        Category("Appearance"),
        DefaultValue(typeof(HorizontalAlignment), "Left")
        ]
        public HorizontalAlignment TextAlign
        {
            get { return _horizontal; }
            set
            {
                _horizontal = value;
                UpdateText();
            }
        }

        private VerticalAlignment _vertical = VerticalAlignment.Top;

        /// <summary>
        /// Gets or sets the vertical text alignment setting.
        /// </summary>
        [
        Description("Vertical text alignment."),
        Category("Appearance"),
        DefaultValue(typeof(VerticalAlignment), "Top")
        ]
        public VerticalAlignment TextAlignVertical
        {
            get { return _vertical; }
            set
            {
                _vertical = value;
                UpdateText();
            }
        }

        private bool _singleLine = true;

        /// <summary>
        /// Gets or sets whether the text will be laid out on a single line or on
        /// multiple lines.
        /// </summary>
        [
        Description("Single line text."),
        Category("Appearance"),
        DefaultValue(true)
        ]
        public bool SingleLine
        {
            get { return _singleLine; }
            set
            {
                _singleLine = value;
                UpdateText();
            }
        }

        private bool _endEllipsis = false;

        /// <summary>
        /// Gets or sets whether the text lines over the label's border should
        /// be trimmed with an ellipsis.
        /// </summary>
        [
        Description("Removes the end of trimmed lines and replaces them with an ellipsis."),
        Category("Appearance"),
        DefaultValue(false)
        ]
        public bool EndEllipsis
        {
            get { return _endEllipsis; }
            set
            {
                _endEllipsis = value;
                UpdateText();
            }
        }

        private bool _wordBreak = false;

        /// <summary>
        /// Gets or sets whether the text should break only at the end of a word.
        /// </summary>
        [
        Description("Break the text at the end of a word."),
        Category("Appearance"),
        DefaultValue(false)
        ]
        public bool WordBreak
        {
            get { return _wordBreak; }
            set
            {
                _wordBreak = value;
                UpdateText();
            }
        }

        private bool _wordEllipsis = false;

        /// <summary>
        /// Gets or sets whether the text should be trimmed to the last word
        /// and an ellipse should be placed at the end of the line.
        /// </summary>
        [
        Description("Trims the line to the nearest word and an ellipsis is placed at the end of a trimmed line."),
        Category("Appearance"),
        DefaultValue(false)
        ]
        public bool WordEllipsis
        {
            get { return _wordBreak; }
            set
            {
                _wordBreak = value;
                UpdateText();
            }
        }

        #endregion Text format properties

        #region Events

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (int)WindowMessage.WM_NCHITTEST && !DesignMode)
            {
                base.WndProc(ref m);

                m.Result = (IntPtr)HitTest.HTTRANSPARENT;

                return;
            }

            base.WndProc(ref m);
        }

        #endregion Events

        #region Drawing

        protected TextFormatFlags CreateFormatFlags()
        {
            TextFormatFlags ret = TextFormatFlags.Default;

            switch (_horizontal)
            {
                case HorizontalAlignment.Left:
                    ret |= TextFormatFlags.Left; break;
                case HorizontalAlignment.Center:
                    ret |= TextFormatFlags.HorizontalCenter; break;
                case HorizontalAlignment.Right:
                    ret |= TextFormatFlags.Right; break;
            }

            switch (_vertical)
            {
                case VerticalAlignment.Top:
                    ret |= TextFormatFlags.Top; break;
                case VerticalAlignment.Center:
                    ret |= TextFormatFlags.VerticalCenter; break;
                case VerticalAlignment.Bottom:
                    ret |= TextFormatFlags.Bottom; break;
            }

            if (_singleLine)
                ret |= TextFormatFlags.SingleLine;

            if (_endEllipsis)
                ret |= TextFormatFlags.EndEllipsis;

            if (_wordBreak)
                ret |= TextFormatFlags.WordBreak;
            if (_wordEllipsis)
                ret |= TextFormatFlags.WordEllipsis;

            if (RightToLeft == RightToLeft.Yes)
                ret |= TextFormatFlags.RightToLeft;

            return ret;
        }

        private StringFormat CreateStringFormat()
        {
            var sf = new StringFormat();

            switch (_horizontal)
            {
                case HorizontalAlignment.Left:
                    sf.Alignment = StringAlignment.Near; break;
                case HorizontalAlignment.Center:
                    sf.Alignment = StringAlignment.Center; break;
                case HorizontalAlignment.Right:
                    sf.Alignment = StringAlignment.Far; break;
            }

            switch (_vertical)
            {
                case VerticalAlignment.Top:
                    sf.LineAlignment = StringAlignment.Near; break;
                case VerticalAlignment.Center:
                    sf.LineAlignment = StringAlignment.Center; break;
                case VerticalAlignment.Bottom:
                    sf.LineAlignment = StringAlignment.Far; break;
            }

            return sf;
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);

            //Invalidate parent because of transparency
            if (Parent != null)
                Parent.Invalidate(ClientRectangle, false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (DesignMode)
            {
                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor),
                    new RectangleF(Padding.Left, Padding.Top, Size.Width - Padding.Horizontal, Size.Height - Padding.Vertical),
                    CreateStringFormat());
                return;
            }

            if (Visible)
            {
                _themeText.Draw(e.Graphics, 0, 0, Size.Width, Size.Height);
            }
        }

        #endregion Drawing
    }

    public class ThemedText : IDisposable
    {

        private static int _win32Black = ColorTranslator.ToWin32(Color.Black);

        private static VisualStyleRenderer renderer = new VisualStyleRenderer(VisualStyleElement.Window.Caption.Active);

        public ThemedText()
        {

        }

        private bool _invalidated = true;

        private string _text = string.Empty;

        public string Text
        {
            get { return _text; }
            set
            {
                if (_text != value)
                    _invalidated = true;
                _text = value;
            }
        }

        private Font _font = SystemFonts.CaptionFont;

        public Font Font
        {
            get { return _font; }
            set
            {
                if (_font != value)
                    _invalidated = true;
                _font = value;
            }
        }

        private Padding _padding = Padding.Empty;

        public Padding Padding
        {
            get { return _padding; }
            set
            {
                if (_padding != value)
                    _invalidated = true;
                _padding = value;
            }
        }

        private int _win32Color = ColorTranslator.ToWin32(Color.Black);

        public Color Color
        {
            get { return ColorTranslator.FromWin32(_win32Black); }
            set
            {
                _invalidated = true;
                _win32Color = ColorTranslator.ToWin32(value);
            }
        }

        private TextFormatFlags _formatFlags = TextFormatFlags.Default;

        public TextFormatFlags FormatFlags
        {
            get { return _formatFlags; }
            set
            {
                if (_formatFlags != value)
                    _invalidated = true;
                _formatFlags = value;
            }
        }

        /// <summary>
        /// Default glow size.
        /// </summary>
        public const int DefaultGlowSize = 10;

        /// <summary>
        /// Glow size used commonly by Office 2007 in titles.
        /// </summary>
        public const int Word2007GlowSize = 15;

        private int _glowSize = DefaultGlowSize;

        public int GlowSize
        {
            get
            {
                return _glowSize;
            }
            set
            {
                if (_glowSize != value)
                    _invalidated = true;
                _glowSize = value;
            }
        }

        private bool _glowEnabled = true;

        public bool GlowEnabled
        {
            get
            {
                return _glowEnabled;
            }
            set
            {
                if (_glowEnabled != value)
                    _invalidated = true;
                _glowEnabled = value;
            }
        }

        #region IDisposable Members

        ~ThemedText()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (_textHdc != IntPtr.Zero)
            {
                Methods.DeleteDC(_textHdc);
                _textHdc = IntPtr.Zero;
            }

            GC.SuppressFinalize(this);
        }

        #endregion

        public void Draw(Graphics g, System.Drawing.Point location, System.Drawing.Size size)
        {
            Draw(g, location.X, location.Y, size.Width, size.Height);
        }

        public void Draw(Graphics g, Rectangle rect)
        {
            Draw(g, rect.X, rect.Y, rect.Width, rect.Height);
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            var outputHdc = g.GetHdc();

            var sourceHdc = PrepareHdc(outputHdc, width, height);

            Methods.BitBlt(outputHdc,
                x, y, width, height,
                sourceHdc, 0, 0,
                BitBltOp.SRCCOPY);

            g.ReleaseHdc(outputHdc);

            System.Diagnostics.Debug.WriteLine("ThemedText.Draw");
        }

        private IntPtr _textHdc = IntPtr.Zero;
        private IntPtr _dibSectionRef;
        private int _lastHdcWidth = -1;
        private int _lastHdcHeight = -1;

        /// <summary>
        /// Ensures that a valid source HDC exists and has been rendered to.
        /// </summary>
        private IntPtr PrepareHdc(IntPtr outputHdc, int width, int height)
        {
            if (width == _lastHdcWidth && height == _lastHdcHeight && !_invalidated)
                return _textHdc;

            _lastHdcWidth = width;
            _lastHdcHeight = height;

            if (_textHdc != IntPtr.Zero)
            {
                Methods.DeleteObject(_dibSectionRef);
                Methods.DeleteDC(_textHdc);
            }
            _textHdc = Methods.CreateCompatibleDC(outputHdc);

            // Create a DIB-Bitmap on which to draw
            var info = new BitmapInfo()
            {
                biSize = Marshal.SizeOf(typeof(BitmapInfo)),
                biWidth = width,
                biHeight = -height, // DIB use top-down ref system, thus we set negative height
                biPlanes = 1,
                biBitCount = 32,
                biCompression = 0
            };
            _dibSectionRef = Methods.CreateDIBSection(outputHdc, ref info, 0, 0, IntPtr.Zero, 0);
            Methods.SelectObject(_textHdc, _dibSectionRef);

            // Create the Font to use
            IntPtr hFont = Font.ToHfont();
            Methods.SelectObject(_textHdc, hFont);

            // Prepare options
            var dttOpts = new DttOpts
            {
                dwSize = Marshal.SizeOf(typeof(DttOpts)),
                dwFlags = DttOptsFlags.DTT_COMPOSITED | DttOptsFlags.DTT_TEXTCOLOR,
                crText = _win32Color
            };
            if (_glowEnabled)
            {
                dttOpts.dwFlags |= DttOptsFlags.DTT_GLOWSIZE;
                dttOpts.iGlowSize = _glowSize;
            }

            // Set full bounds with padding
            Rect paddedBounds = new Rect(
                _padding.Left, _padding.Top,
                width - _padding.Right, height - _padding.Bottom
            );

            // Draw
            int ret = Methods.DrawThemeTextEx(renderer.Handle, _textHdc, 0, 0,
                _text, -1,
                (int)_formatFlags, ref paddedBounds, ref dttOpts);
            if (ret != 0)
                Marshal.ThrowExceptionForHR(ret);

            // Clean up
            Methods.DeleteObject(hFont);

            return _textHdc;
        }

    }

    internal static class Methods
    {

        #region Window manager

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int DrawThemeTextEx(IntPtr hTheme, IntPtr hdc,
            int iPartId, int iStateId, string text,
            int iCharCount, int dwFlags, ref Rect pRect, ref DttOpts pOptions);

        /// <summary>Returns the active windows on the current thread.</summary>
        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, out Rect rect);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        //TODO Remove these methods

        //[DllImport("user32.dll")]
        //public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        //[DllImport("user32.dll")]
        //public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, string lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public static IntPtr GetWindowLong(this IntPtr hWnd, WindowLong i)
        {
            if (IntPtr.Size == 8)
            {
                return GetWindowLongPtr64(hWnd, (int)i);
            }
            else
            {
                return new IntPtr(GetWindowLong32(hWnd, (int)i));
            }
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern int GetWindowLong32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
        private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

        public static IntPtr GetClassLongPtr(this IntPtr hWnd, ClassLong i)
        {
            if (IntPtr.Size == 8)
            {
                return GetClassLong64(hWnd, (int)i);
            }
            else
            {
                return new IntPtr(GetClassLong32(hWnd, (int)i));
            }
        }

        [DllImport("user32.dll", EntryPoint = "GetClassLongPtrW")]
        private static extern IntPtr GetClassLong64(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetClassLongW")]
        private static extern int GetClassLong32(IntPtr hWnd, int nIndex);

        #endregion

        #region GDI, DC and Blitting

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern bool DeleteDC(IntPtr hdc);

        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight,
            IntPtr hdcSrc, int nXSrc, int nYSrc, BitBltOp dwRop);

        [DllImport("user32.dll")]
        public static extern int FillRect(IntPtr hDC, [In] ref Rect lprc, IntPtr hbr);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateSolidBrush(int crColor);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDIBSection(IntPtr hdc, ref BitmapInfo pbmi,
            uint iUsage, int ppvBits, IntPtr hSection, uint dwOffset);

        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern bool DeleteObject(IntPtr hObject);

        #endregion

    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct Rect
    {

        public Rect(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public Rect(System.Drawing.Rectangle rect)
        {
            Left = rect.X;
            Top = rect.Y;
            Right = rect.Right;
            Bottom = rect.Bottom;
        }

        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        public int Width
        {
            get
            {
                return Right - Left;
            }
            set
            {
                Right = Left + value;
            }
        }

        public int Height
        {
            get
            {
                return Bottom - Top;
            }
            set
            {
                Bottom = Top + value;
            }
        }

        public System.Drawing.Rectangle ToRectangle()
        {
            return new System.Drawing.Rectangle(Left, Top, Right - Left, Bottom - Top);
        }

    }

    internal enum WindowLong : int
    {
        WndProc = (-4),
        HInstance = (-6),
        HwndParent = (-8),
        Style = (-16),
        ExStyle = (-20),
        UserData = (-21),
        Id = (-12)
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct BitmapInfo
    {
        public int biSize;
        public int biWidth;
        public int biHeight;
        public short biPlanes;
        public short biBitCount;
        public int biCompression;
        public int biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public int biClrUsed;
        public int biClrImportant;
        public byte bmiColors_rgbBlue;
        public byte bmiColors_rgbGreen;
        public byte bmiColors_rgbRed;
        public byte bmiColors_rgbReserved;
    }

    internal enum BitBltOp : uint
    {
        SRCCOPY = 0x00CC0020,   /* dest = source                   */
        SRCPAINT = 0x00EE0086,   /* dest = source OR dest           */
        SRCAND = 0x008800C6,   /* dest = source AND dest          */
        SRCINVERT = 0x00660046,   /* dest = source XOR dest          */
        SRCERASE = 0x00440328,   /* dest = source AND (NOT dest )   */
        NOTSRCCOPY = 0x00330008,   /* dest = (NOT source)             */
        NOTSRCERASE = 0x001100A6,   /* dest = (NOT src) AND (NOT dest) */
        MERGECOPY = 0x00C000CA,   /* dest = (source AND pattern)     */
        MERGEPAINT = 0x00BB0226,   /* dest = (NOT source) OR dest     */
        PATCOPY = 0x00F00021,   /* dest = pattern                  */
        PATPAINT = 0x00FB0A09,   /* dest = DPSnoo                   */
        PATINVERT = 0x005A0049,   /* dest = pattern XOR dest         */
        DSTINVERT = 0x00550009,   /* dest = (NOT dest)               */
        BLACKNESS = 0x00000042,   /* dest = BLACK                    */
        WHITENESS = 0x00FF0062,   /* dest = WHITE                    */

        NOMIRRORBITMAP = 0x80000000, /* Do not Mirror the bitmap in this call */
        CAPTUREBLT = 0x40000000      /* Include layered windows */
    }

    internal enum ClassLong : int
    {
        Icon = -14,
        IconSmall = -34
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct DttOpts
    {
        public int dwSize;
        public DttOptsFlags dwFlags;
        public int crText;
        public int crBorder;
        public int crShadow;
        public int iTextShadowType;
        public Point ptShadowOffset;
        public int iBorderSize;
        public int iFontPropId;
        public int iColorPropId;
        public int iStateId;
        public bool fApplyOverlay;
        public int iGlowSize;
        public int pfnDrawTextCallback;
        public IntPtr lParam;
    }

    [Flags]
    internal enum DttOptsFlags : int
    {
        DTT_TEXTCOLOR = 1,
        DTT_BORDERCOLOR = 2,
        DTT_SHADOWCOLOR = 4,
        DTT_SHADOWTYPE = 8,
        DTT_SHADOWOFFSET = 16,
        DTT_BORDERSIZE = 32,
        //DTT_FONTPROP = 64,		commented values are currently unused
        //DTT_COLORPROP = 128,
        //DTT_STATEID = 256,
        DTT_CALCRECT = 512,
        DTT_APPLYOVERLAY = 1024,
        DTT_GLOWSIZE = 2048,
        //DTT_CALLBACK = 4096,
        DTT_COMPOSITED = 8192
    }

    internal enum WindowMessage : uint
    {
        WM_NCHITTEST = 0x84
    }

    internal enum HitTest : int
    {
        HTTRANSPARENT = (-1)
    }
}
