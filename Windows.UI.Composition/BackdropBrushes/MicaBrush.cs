using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Composition.Native;

namespace Windows.UI.Composition.BackdropBrushes
{
    public enum MicaKind
    {
        Mica,
        MicaAlt
    }

    public partial class MicaBrush : BackdropBrush
    {
        int Mica = 2;
        int MicaAlt = 4;

        public MicaKind Kind { get; set; }

        public override void ApplyBackdrop()
        {
            base.ApplyBackdrop();

            if (TargetWindow == null)
                throw new NullReferenceException("Property 'TargetForm' is null");

            if (Environment.OSVersion.Version.Build < 22621)
                throw new NotSupportedException("The APIs used for applying backdrops needs Windows 11 22H2 to work.");

            switch (Kind)
            {
                case MicaKind.Mica:
                    DWMAPI.DwmSetWindowAttribute(TargetWindow.Handle, DWMAPI.DwmWindowAttribute.SystemBackdropType, ref Mica, sizeof(Int32));
                    break;
                case MicaKind.MicaAlt:
                    DWMAPI.DwmSetWindowAttribute(TargetWindow.Handle, DWMAPI.DwmWindowAttribute.SystemBackdropType, ref MicaAlt, sizeof(Int32));
                    break;
                default:
                    DWMAPI.DwmSetWindowAttribute(TargetWindow.Handle, DWMAPI.DwmWindowAttribute.SystemBackdropType, ref Mica, sizeof(Int32));
                    break;
            }
        }

        public MicaBrush()
        {
            InitializeComponent();
        }

        public MicaBrush(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
