using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Composition.Native;
using static Windows.UI.Composition.Native.User32;

namespace Windows.UI.Composition.BackdropBrushes
{
    public partial class AcrylicBrush : BackdropBrush
    {
        int Acrylic = 3;

        public bool ForceOldWay { get; set; } = false;

        public Color Tint { get; set; } = Color.Transparent;
        public byte TintOpacity { get; set; } = 128;

        public AcrylicBrush()
        {
            InitializeComponent();
        }

        public override void ApplyBackdrop()
        {
            base.ApplyBackdrop();

            if (TargetWindow == null)
                throw new NullReferenceException("Property 'TargetWindow' is null");

            if (Environment.OSVersion.Version.Build < 15063)
                throw new NotSupportedException("The APIs used for applying Acrylic backdrop needs Windows 10 1703 (aka. Creators Update) to work.");

            if (Environment.OSVersion.Version.Build >= 22621 && !ForceOldWay)
            { 
                DWMAPI.DwmSetWindowAttribute(TargetWindow.Handle, DWMAPI.DwmWindowAttribute.SystemBackdropType, ref Acrylic, sizeof(Int32));
            }
            else
            {
                var t = Color.FromArgb(TintOpacity, Tint);

                var accentPolicy = new AccentPolicy
                {
                    AccentState = ACCENT.ENABLE_ACRYLICBLURBEHIND,
                    GradientColor = ToAbgr(t)
                };

                unsafe
                {
                    SetWindowCompositionAttribute(
                        new HandleRef(TargetWindow, TargetWindow.Handle),
                        new WindowCompositionAttributeData
                        {
                            Attribute = WCA.ACCENT_POLICY,
                            Data = &accentPolicy,
                            DataLength = Marshal.SizeOf<AccentPolicy>()
                        });
                }
            }
        }
    }
}
