using Windows.UI.Composition.BackdropBrushes;
using Windows.UI.Controls;
using Windows.UI.Theming;

namespace TestApp
{
    public partial class Form1 : Window
    {
        /**Mica**/
        AcrylicBrush _micaBrush;
        public Form1()
        {
            BackdropApplied = true;
            InitializeComponent();
            _micaBrush = new /**Mica**/AcrylicBrush();
            _micaBrush.TargetWindow = this;
            //_micaBrush.Kind = MicaKind.MicaAlt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _micaBrush.ApplyBackdrop();
            ElementTheme = SystemThemeHandler.AppTheme;
            SystemThemeHandler.OnThemeChanged += SystemThemeHandler_OnThemeChanged;
        }

        private void SystemThemeHandler_OnThemeChanged(object? sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                ElementTheme = SystemThemeHandler.AppTheme;
            }));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ElementTheme == Theme.Dark)
                ElementTheme = Theme.Light;
            else
                ElementTheme = Theme.Dark;
        }

        private void button3_ThemeChanged(object sender, EventArgs e)
        {
            button1.Text = "theme : " + button3.ElementTheme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button3.ElementTheme == Theme.Dark)
                button3.ElementTheme = Theme.Light;
            else
                button3.ElementTheme = Theme.Dark;
        }
    }
}