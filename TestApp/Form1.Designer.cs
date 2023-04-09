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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ButtonText = "This is a WinUI button";
            button2.ElementTheme = Windows.UI.Theming.Theme.Light;
            button2.ForeColor = Color.White;
            button2.Location = new Point(334, 202);
            button2.Name = "button2";
            button2.Size = new Size(170, 32);
            button2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.ButtonText = "Change Theme";
            button3.ElementTheme = Windows.UI.Theming.Theme.Light;
            button3.ForeColor = Color.White;
            button3.Location = new Point(334, 240);
            button3.Name = "button3";
            button3.Size = new Size(170, 32);
            button3.TabIndex = 2;
            button3.ThemeChanged += button3_ThemeChanged;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(495, 322);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 95);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            ExtendFrameIntoClientArea = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Windows.UI.Controls.Button button2;
        private Windows.UI.Controls.Button button3;
        private PictureBox pictureBox1;
    }
}