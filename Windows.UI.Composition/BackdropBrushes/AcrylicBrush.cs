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
    public partial class AcrylicBrush : BackdropBrush
    {
        int Acrylic = 3;

        public AcrylicBrush()
        {
            InitializeComponent();
        }

        public override void ApplyBackdrop()
        {
            base.ApplyBackdrop();

            if (TargetWindow == null)
                throw new NullReferenceException("Property 'TargetForm' is null");

            if (Environment.OSVersion.Version.Build < 22621)
                throw new NotSupportedException("The APIs used for applying backdrops needs Windows 11 22H2 to work.");

            DWMAPI.DwmSetWindowAttribute(TargetWindow.Handle, DWMAPI.DwmWindowAttribute.SystemBackdropType, ref Acrylic, sizeof(Int32));
        }
        public AcrylicBrush(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
