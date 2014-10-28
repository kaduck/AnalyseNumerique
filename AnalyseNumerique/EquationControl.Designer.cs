namespace AnalyseNumerique
{
    partial class EquationControl
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
            this.tbAlpha = new System.Windows.Forms.TextBox();
            this.lbInconnu = new System.Windows.Forms.Label();
            this.cbFonction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbAlpha
            // 
            this.tbAlpha.Location = new System.Drawing.Point(4, 4);
            this.tbAlpha.Name = "tbAlpha";
            this.tbAlpha.Size = new System.Drawing.Size(24, 20);
            this.tbAlpha.TabIndex = 0;
            // 
            // lbInconnu
            // 
            this.lbInconnu.AutoSize = true;
            this.lbInconnu.Location = new System.Drawing.Point(87, 11);
            this.lbInconnu.Name = "lbInconnu";
            this.lbInconnu.Size = new System.Drawing.Size(14, 13);
            this.lbInconnu.TabIndex = 1;
            this.lbInconnu.Text = "X";
            // 
            // cbFonction
            // 
            this.cbFonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFonction.FormattingEnabled = true;
            this.cbFonction.Items.AddRange(new object[] {
            "log",
            "ln",
            "sin",
            "cos",
            "*"});
            this.cbFonction.Location = new System.Drawing.Point(34, 4);
            this.cbFonction.Name = "cbFonction";
            this.cbFonction.Size = new System.Drawing.Size(47, 21);
            this.cbFonction.TabIndex = 2;
            // 
            // EquationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbFonction);
            this.Controls.Add(this.lbInconnu);
            this.Controls.Add(this.tbAlpha);
            this.Name = "EquationControl";
            this.Size = new System.Drawing.Size(349, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAlpha;
        private System.Windows.Forms.Label lbInconnu;
        private System.Windows.Forms.ComboBox cbFonction;
    }
}
