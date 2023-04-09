using Windows.UI.Composition.BackdropBrushes;
using Windows.UI.Controls;
using Windows.UI.Theming;

namespace TestApp
{
    public partial class Form1 : Window
    {
        MicaBrush _micaBrush;

        public Form1()
        {
            InitializeComponent();
            _micaBrush = new MicaBrush();
            _micaBrush.TargetWindow = this;
            _micaBrush.Kind = MicaKind.MicaAlt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _micaBrush.ApplyBackdrop();
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
            pictureBox1.Image = button2.bp;
        }
    }
}