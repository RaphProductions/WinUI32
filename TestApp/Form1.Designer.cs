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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ButtonText = "This is a WinUI button";
            button2.ElementTheme = Windows.UI.Theming.Theme.Dark;
            button2.ForeColor = Color.FromArgb(255, 255, 255);
            button2.Location = new Point(334, 202);
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
            button3.Location = new Point(334, 240);
            button3.Name = "button3";
            button3.Size = new Size(170, 32);
            button3.TabIndex = 2;
            button3.ThemeChanged += button3_ThemeChanged;
            button3.Click += new EventHandler(button3_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.ForeColor = Color.FromArgb(255, 255, 255);
            pictureBox1.Location = new Point(495, 322);
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
            button1.Location = new Point(507, 138);
            button1.Name = "button1";
            button1.Size = new Size(170, 32);
            button1.TabIndex = 5;
            button1.Click += new EventHandler(button1_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            ElementTheme = Windows.UI.Theming.Theme.Dark;
            ExtendFrameIntoClientArea = true;
            ForeColor = Color.FromArgb(255, 255, 255);
            Name = "Form1";
            Text = "Form1";
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
    }
}