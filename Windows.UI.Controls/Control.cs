using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Theming;
using WFC = System.Windows.Forms.Control;

namespace Windows.UI.Controls
{
    public class Control : WFC
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

        protected virtual void OnThemeChanged()
        {
            if (ThemeChanged != null)
                ThemeChanged.Invoke(this, EventArgs.Empty);
        }
    }
}
