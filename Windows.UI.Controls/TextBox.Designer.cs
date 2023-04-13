namespace Windows.UI.Controls
{
    partial class TextBox
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            internalTextBox1 = new InternalControls.InternalTextBox();
            SuspendLayout();
            // 
            // internalTextBox1
            // 
            internalTextBox1.BackColor = Color.Black;
            internalTextBox1.BorderStyle = BorderStyle.None;
            internalTextBox1.Location = new Point(3, 3);
            internalTextBox1.Name = "internalTextBox1";
            internalTextBox1.Size = new Size(250, 16);
            internalTextBox1.TabIndex = 0;
            // 
            // TextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(internalTextBox1);
            Name = "TextBox";
            Size = new Size(256, 25);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private InternalControls.InternalTextBox internalTextBox1;
    }
}
