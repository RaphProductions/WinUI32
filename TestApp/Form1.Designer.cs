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
            label1 = new Label();
            button1 = new Windows.UI.Controls.Button();
            textBlock1 = new Windows.UI.Controls.TextBlock();
            fontIcon1 = new Windows.UI.Controls.FontIcon();
            customProgressBar1 = new Windows.UI.Controls.ProgressBar();
            button4 = new Windows.UI.Controls.Button();
            acrylicBrush1 = new Windows.UI.Composition.BackdropBrushes.AcrylicBrush();
            textBox1 = new Windows.UI.Controls.TextBox();
            checkMark1 = new Windows.UI.Controls.CheckMark();
            checkBox1 = new CheckBox();
            button5 = new Windows.UI.Controls.Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ButtonText = "This is a WinUI button";
            button2.ElementTheme = Windows.UI.Theming.Theme.Dark;
            button2.ForeColor = Color.FromArgb(255, 255, 255);
            button2.Icon = 0U;
            button2.IconFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            button3.Icon = 0U;
            button3.IconFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(33, 147);
            button3.Name = "button3";
            button3.Size = new Size(170, 32);
            button3.TabIndex = 2;
            button3.ThemeChanged += button3_ThemeChanged;
            button3.Click += button3_Click;
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
            button1.Icon = 0U;
            button1.IconFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            fontIcon1.Location = new Point(826, 109);
            fontIcon1.Name = "fontIcon1";
            fontIcon1.Size = new Size(114, 119);
            fontIcon1.TabIndex = 9;
            fontIcon1.Text = "fontxIcon1";
            fontIcon1.TextAlign = HorizontalAlignment.Center;
            fontIcon1.TextAlignVertical = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            // 
            // customProgressBar1
            // 
            customProgressBar1.BackColor = Color.FromArgb(36, 36, 36);
            customProgressBar1.ElementTheme = Windows.UI.Theming.Theme.Dark;
            customProgressBar1.Error = false;
            customProgressBar1.Location = new Point(455, 334);
            customProgressBar1.Name = "customProgressBar1";
            customProgressBar1.Size = new Size(170, 24);
            customProgressBar1.Style = ProgressBarStyle.Marquee;
            customProgressBar1.TabIndex = 10;
            customProgressBar1.Value = 56;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.ButtonText = "Button Theme : ?";
            button4.ElementTheme = Windows.UI.Theming.Theme.Dark;
            button4.ForeColor = Color.FromArgb(255, 255, 255);
            button4.Icon = 52298U;
            button4.IconFont = new Font("Segoe Fluent Icons", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(434, 383);
            button4.Name = "button4";
            button4.Size = new Size(210, 40);
            button4.TabIndex = 11;
            button4.Click += button4_Click;
            // 
            // acrylicBrush1
            // 
            acrylicBrush1.ForceOldWay = false;
            acrylicBrush1.TargetWindow = this;
            acrylicBrush1.Tint = Color.Teal;
            acrylicBrush1.TintOpacity = 64;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Transparent;
            textBox1.ElementTheme = Windows.UI.Theming.Theme.Light;
            textBox1.Location = new Point(33, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 24);
            textBox1.TabIndex = 12;
            // 
            // checkMark1
            // 
            checkMark1.Checked = true;
            checkMark1.ElementTheme = Windows.UI.Theming.Theme.Light;
            checkMark1.Location = new Point(242, 147);
            checkMark1.Name = "checkMark1";
            checkMark1.Size = new Size(16, 16);
            checkMark1.TabIndex = 13;
            checkMark1.Text = "checkMark1";
            checkMark1.Click += checkMark1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(907, 442);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.ButtonText = "Show Context Menu";
            button5.ElementTheme = Windows.UI.Theming.Theme.Dark;
            button5.ForeColor = Color.FromArgb(255, 255, 255);
            button5.Icon = 59228U;
            button5.IconFont = new Font("Segoe Fluent Icons", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(434, 429);
            button5.Name = "button5";
            button5.Size = new Size(210, 32);
            button5.TabIndex = 15;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1175, 690);
            Controls.Add(button5);
            Controls.Add(checkBox1);
            Controls.Add(checkMark1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(customProgressBar1);
            Controls.Add(fontIcon1);
            Controls.Add(textBlock1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            DoubleBuffered = true;
            ExtendFrameIntoClientArea = true;
            ForeColor = Color.FromArgb(255, 255, 255);
            Glyph = 59245U;
            Name = "Form1";
            Text = "WinUI32 Desktop";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Windows.UI.Controls.Button button2;
        private Windows.UI.Controls.Button button3;
        private Label label1;
        private Windows.UI.Controls.Button button1;
        private Windows.UI.Controls.TextBlock textBlock1;
        private Windows.UI.Controls.FontIcon fontIcon1;
        private Windows.UI.Controls.ProgressBar customProgressBar1;
        private Windows.UI.Controls.Button button4;
        private Windows.UI.Composition.BackdropBrushes.AcrylicBrush acrylicBrush1;
        private Windows.UI.Controls.TextBox textBox1;
        private Windows.UI.Controls.CheckMark checkMark1;
        private CheckBox checkBox1;
        private Windows.UI.Controls.Button button5;
    }
}