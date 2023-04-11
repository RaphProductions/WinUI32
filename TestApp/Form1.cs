using Windows.UI.Composition.BackdropBrushes;
using Windows.UI.Controls;
using Windows.UI.Theming;

namespace TestApp
{
    public partial class Form1 : Window
    {
        public Form1()
        {
            BackdropApplied = true;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acrylicBrush1.ApplyBackdrop();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (customProgressBar1.ElementTheme == Theme.Dark)
                customProgressBar1.ElementTheme = Theme.Light;
            else
                customProgressBar1.ElementTheme = Theme.Dark;
        }
    }
}