using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Controls;

namespace Windows.UI.Composition
{
    public partial class BackdropBrush : Component
    {
        public Window TargetWindow { get; set; }

        public virtual void ApplyBackdrop()
        {
            if (TargetWindow != null)
                TargetWindow.BackdropApplied = true;
        }

        public BackdropBrush()
        {
            InitializeComponent();
        }

        public BackdropBrush(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
