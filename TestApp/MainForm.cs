using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Composition.BackdropBrushes;
using Windows.UI.Controls;
using Windows.UI.Theming;

namespace TestApp
{
    public partial class MainForm : Window
    {
        MicaBrush _micaBrush;
        public MainForm()
        {
            InitializeComponent();
            BackdropApplied = true;
            InitializeComponent();
            _micaBrush = new MicaBrush();
            _micaBrush.TargetWindow = this;
            this.ThemeChanged += MainForm_ThemeChanged;
        }

        private void MainForm_ThemeChanged(object? sender, EventArgs e)
        {
            if (panel2.Controls.Count >= 1)
                ((Windows.UI.Controls.Window)panel2.Controls[0]).ElementTheme = this.ElementTheme;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _micaBrush.ApplyBackdrop();
            ElementTheme = SystemThemeHandler.AppTheme;
            SystemThemeHandler.OnThemeChanged += SystemThemeHandler_OnThemeChanged;
        }

        void Navigate(Window f)
        {
            foreach (System.Windows.Forms.Control c in panel2.Controls)
            {
                Controls.Remove(c);
            }
            f.TopMost = false;
            f.TopLevel = false;
            f.ElementTheme = this.ElementTheme;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void SystemThemeHandler_OnThemeChanged(object? sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                ElementTheme = SystemThemeHandler.AppTheme;
                ((Windows.UI.Controls.Window)panel2.Controls[0]).ElementTheme = SystemThemeHandler.AppTheme;
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigate(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navigate(new Form2());
        }
    }
}
