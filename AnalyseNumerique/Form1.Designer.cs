namespace AnalyseNumerique
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbMethode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrecision = new System.Windows.Forms.TextBox();
            this.lbPrecision = new System.Windows.Forms.Label();
            this.btCalculer = new System.Windows.Forms.Button();
            this.tbBorneSuperieure = new System.Windows.Forms.TextBox();
            this.tbBorneInferieure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flpEquation = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResultat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbConsole = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDegree = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMethode
            // 
            this.cbMethode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethode.FormattingEnabled = true;
            this.cbMethode.Items.AddRange(new object[] {
            "Dichotomie",
            "Newton",
            "Secante"});
            this.cbMethode.Location = new System.Drawing.Point(77, 9);
            this.cbMethode.Name = "cbMethode";
            this.cbMethode.Size = new System.Drawing.Size(121, 21);
            this.cbMethode.TabIndex = 0;
            this.cbMethode.SelectedIndexChanged += new System.EventHandler(this.cbMethode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Méthode : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tbPrecision);
            this.groupBox1.Controls.Add(this.lbPrecision);
            this.groupBox1.Controls.Add(this.btCalculer);
            this.groupBox1.Controls.Add(this.tbBorneSuperieure);
            this.groupBox1.Controls.Add(this.tbBorneInferieure);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.flpEquation);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonction";
            // 
            // tbPrecision
            // 
            this.tbPrecision.Location = new System.Drawing.Point(241, 28);
            this.tbPrecision.Name = "tbPrecision";
            this.tbPrecision.Size = new System.Drawing.Size(36, 20);
            this.tbPrecision.TabIndex = 14;
            this.tbPrecision.Validating += new System.ComponentModel.CancelEventHandler(this.tbBorneInferieure_Validating);
            // 
            // lbPrecision
            // 
            this.lbPrecision.AutoSize = true;
            this.lbPrecision.Location = new System.Drawing.Point(174, 29);
            this.lbPrecision.Name = "lbPrecision";
            this.lbPrecision.Size = new System.Drawing.Size(61, 13);
            this.lbPrecision.TabIndex = 13;
            this.lbPrecision.Text = "précision = ";
            // 
            // btCalculer
            // 
            this.btCalculer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCalculer.Location = new System.Drawing.Point(294, 24);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(147, 23);
            this.btCalculer.TabIndex = 12;
            this.btCalculer.Text = "Calculer";
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // tbBorneSuperieure
            // 
            this.tbBorneSuperieure.Location = new System.Drawing.Point(119, 26);
            this.tbBorneSuperieure.Name = "tbBorneSuperieure";
            this.tbBorneSuperieure.Size = new System.Drawing.Size(36, 20);
            this.tbBorneSuperieure.TabIndex = 7;
            this.tbBorneSuperieure.Validating += new System.ComponentModel.CancelEventHandler(this.tbBorneInferieure_Validating);
            // 
            // tbBorneInferieure
            // 
            this.tbBorneInferieure.Location = new System.Drawing.Point(40, 26);
            this.tbBorneInferieure.Name = "tbBorneInferieure";
            this.tbBorneInferieure.Size = new System.Drawing.Size(36, 20);
            this.tbBorneInferieure.TabIndex = 6;
            this.tbBorneInferieure.Validating += new System.ComponentModel.CancelEventHandler(this.tbBorneInferieure_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "a =";
            // 
            // flpEquation
            // 
            this.flpEquation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpEquation.Location = new System.Drawing.Point(3, 54);
            this.flpEquation.Name = "flpEquation";
            this.flpEquation.Size = new System.Drawing.Size(451, 377);
            this.flpEquation.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Résultat =";
            // 
            // tbResultat
            // 
            this.tbResultat.Location = new System.Drawing.Point(67, 26);
            this.tbResultat.Name = "tbResultat";
            this.tbResultat.ReadOnly = true;
            this.tbResultat.Size = new System.Drawing.Size(36, 20);
            this.tbResultat.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbConsole);
            this.groupBox2.Controls.Add(this.tbResultat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(476, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 434);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultat";
            // 
            // tbConsole
            // 
            this.tbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbConsole.Location = new System.Drawing.Point(3, 54);
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.Size = new System.Drawing.Size(269, 377);
            this.tbConsole.TabIndex = 14;
            this.tbConsole.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Degrée : ";
            // 
            // tbDegree
            // 
            this.tbDegree.Location = new System.Drawing.Point(272, 9);
            this.tbDegree.Name = "tbDegree";
            this.tbDegree.Size = new System.Drawing.Size(36, 20);
            this.tbDegree.TabIndex = 13;
            this.tbDegree.Validating += new System.ComponentModel.CancelEventHandler(this.tbDegree_Validating);
            this.tbDegree.Validated += new System.EventHandler(this.tbDegree_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(763, 483);
            this.Controls.Add(this.tbDegree);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMethode);
            this.Name = "Form1";
            this.Text = "Résolution d\'équation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMethode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBorneInferieure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpEquation;
        private System.Windows.Forms.TextBox tbBorneSuperieure;
        private System.Windows.Forms.Button btCalculer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResultat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox tbConsole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDegree;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbPrecision;
        private System.Windows.Forms.Label lbPrecision;
    }
}

