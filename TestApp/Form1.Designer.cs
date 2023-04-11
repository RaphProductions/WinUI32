namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Windows.UI.Controls.Button();
            button3 = new Windows.UI.Controls.Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Windows.UI.Controls.Button();
            textBlock1 = new Windows.UI.Controls.TextBlock();
            fontIcon1 = new Windows.UI.Controls.FontIcon();
            customProgressBar1 = new Windows.UI.Controls.ProgressBar();
            button4 = new Windows.UI.Controls.Button();
            acrylicBrush1 = new Windows.UI.Composition.BackdropBrushes.AcrylicBrush();
            inkCanvas1 = new Windows.UI.Controls.InkCanvas();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ButtonText = "This is a WinUI button";
            button2.ElementTheme = Windows.UI.Theming.Theme.Dark;
            button2.ForeColor = Color.FromArgb(255, 255, 255);
            button2.Location = new Point(33, 109);
            button2.Name = "button2";
            button2.Size = new Size(170, 32);
            button2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.ButtonText = "Change Theme";
            button3.ElementTheme = Windows.UI.Theming.Theme.Dark;
            button3.ForeColor = Color.FromArgb(255, 255, 255);
            button3.Location = new Point(33, 147);
            button3.Name = "button3";
            button3.Size = new Size(170, 32);
            button3.TabIndex = 2;
            button3.ThemeChanged += button3_ThemeChanged;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ForeColor = Color.FromArgb(255, 255, 255);
            pictureBox1.Location = new Point(253, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 95);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 255, 255);
            label1.Location = new Point(316, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ButtonText = "Button Theme : ?";
            button1.ElementTheme = Windows.UI.Theming.Theme.Dark;
            button1.ForeColor = Color.FromArgb(255, 255, 255);
            button1.Location = new Point(33, 185);
            button1.Name = "button1";
            button1.Size = new Size(170, 32);
            button1.TabIndex = 5;
            button1.Click += button1_Click;
            // 
            // textBlock1
            // 
            textBlock1.ElementTheme = Windows.UI.Theming.Theme.Light;
            textBlock1.Font = new Font("Segoe UI Variable Text Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBlock1.ForeColor = Color.White;
            textBlock1.Location = new Point(33, 34);
            textBlock1.Name = "textBlock1";
            textBlock1.Size = new Size(126, 58);
            textBlock1.TabIndex = 8;
            textBlock1.Text = "Home";
            // 
            // fontIcon1
            // 
            fontIcon1.ElementTheme = Windows.UI.Theming.Theme.Light;
            fontIcon1.Font = new Font("Segoe Fluent Icons", 70F, FontStyle.Regular, GraphicsUnit.Point);
            fontIcon1.Glyph = 59228U;
            fontIcon1.Location = new Point(682, 98);
            fontIcon1.Name = "fontIcon1";
            fontIcon1.Size = new Size(131, 128);
            fontIcon1.TabIndex = 9;
            fontIcon1.Text = "fontxIcon1";
            fontIcon1.TextAlign = HorizontalAlignment.Center;
            fontIcon1.TextAlignVertical = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            // 
            // customProgressBar1
            // 
            customProgressBar1.ElementTheme = Windows.UI.Theming.Theme.Light;
            customProgressBar1.Error = false;
            customProgressBar1.Location = new Point(455, 314);
            customProgressBar1.Name = "customProgressBar1";
            customProgressBar1.Size = new Size(170, 24);
            customProgressBar1.Style = ProgressBarStyle.Marquee;
            customProgressBar1.TabIndex = 10;
            customProgressBar1.Value = 50;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.ButtonText = "Button Theme : ?";
            button4.ElementTheme = Windows.UI.Theming.Theme.Dark;
            button4.ForeColor = Color.FromArgb(255, 255, 255);
            button4.Location = new Point(455, 376);
            button4.Name = "button4";
            button4.Size = new Size(170, 32);
            button4.TabIndex = 11;
            button4.Click += button4_Click;
            // 
            // acrylicBrush1
            // 
            acrylicBrush1.ForceOldWay = true;
            acrylicBrush1.TargetWindow = this;
            acrylicBrush1.Tint = Color.Teal;
            acrylicBrush1.TintOpacity = 64;
            // 
            // inkCanvas1
            // 
            inkCanvas1.BackColor = Color.White;
            inkCanvas1.Location = new Point(715, 354);
            inkCanvas1.Name = "inkCanvas1";
            inkCanvas1.Size = new Size(233, 222);
            inkCanvas1.TabIndex = 12;
            inkCanvas1.Text = "inkCanvas1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1175, 690);
            Controls.Add(inkCanvas1);
            Controls.Add(button4);
            Controls.Add(customProgressBar1);
            Controls.Add(fontIcon1);
            Controls.Add(textBlock1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            ForeColor = Color.FromArgb(255, 255, 255);
            Glyph = 59245U;
            Name = "Form1";
            Text = "WinUI32 Desktop";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Windows.UI.Controls.Button button2;
        private Windows.UI.Controls.Button button3;
        private PictureBox pictureBox1;
        private Label label1;
        private Windows.UI.Controls.Button button1;
        private Windows.UI.Controls.TextBlock textBlock1;
        private Windows.UI.Controls.FontIcon fontIcon1;
        private Windows.UI.Controls.ProgressBar customProgressBar1;
        private Windows.UI.Controls.Button button4;
        private Windows.UI.Composition.BackdropBrushes.AcrylicBrush acrylicBrush1;
        private Windows.UI.Controls.InkCanvas inkCanvas1;
    }
}