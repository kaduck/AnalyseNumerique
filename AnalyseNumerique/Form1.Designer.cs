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
            this.btCalculer = new System.Windows.Forms.Button();
            this.tbNombrePas = new System.Windows.Forms.TextBox();
            this.lbNombrePas = new System.Windows.Forms.Label();
            this.tbHauteurPas = new System.Windows.Forms.TextBox();
            this.lbHauteurPas = new System.Windows.Forms.Label();
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
            this.tbPrecision = new System.Windows.Forms.TextBox();
            this.lbPrecision = new System.Windows.Forms.Label();
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
            "Secantes"});
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
            this.groupBox1.Controls.Add(this.tbNombrePas);
            this.groupBox1.Controls.Add(this.lbNombrePas);
            this.groupBox1.Controls.Add(this.tbHauteurPas);
            this.groupBox1.Controls.Add(this.lbHauteurPas);
            this.groupBox1.Controls.Add(this.tbBorneSuperieure);
            this.groupBox1.Controls.Add(this.tbBorneInferieure);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.flpEquation);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonction";
            // 
            // btCalculer
            // 
            this.btCalculer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCalculer.Location = new System.Drawing.Point(382, 24);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(147, 23);
            this.btCalculer.TabIndex = 12;
            this.btCalculer.Text = "Calculer";
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // tbNombrePas
            // 
            this.tbNombrePas.Location = new System.Drawing.Point(232, 56);
            this.tbNombrePas.Name = "tbNombrePas";
            this.tbNombrePas.Size = new System.Drawing.Size(36, 20);
            this.tbNombrePas.TabIndex = 11;
            // 
            // lbNombrePas
            // 
            this.lbNombrePas.AutoSize = true;
            this.lbNombrePas.Location = new System.Drawing.Point(140, 58);
            this.lbNombrePas.Name = "lbNombrePas";
            this.lbNombrePas.Size = new System.Drawing.Size(86, 13);
            this.lbNombrePas.TabIndex = 10;
            this.lbNombrePas.Text = "nombre de pas =";
            // 
            // tbHauteurPas
            // 
            this.tbHauteurPas.Location = new System.Drawing.Point(98, 55);
            this.tbHauteurPas.Name = "tbHauteurPas";
            this.tbHauteurPas.Size = new System.Drawing.Size(36, 20);
            this.tbHauteurPas.TabIndex = 9;
            // 
            // lbHauteurPas
            // 
            this.lbHauteurPas.AutoSize = true;
            this.lbHauteurPas.Location = new System.Drawing.Point(8, 58);
            this.lbHauteurPas.Name = "lbHauteurPas";
            this.lbHauteurPas.Size = new System.Drawing.Size(87, 13);
            this.lbHauteurPas.TabIndex = 8;
            this.lbHauteurPas.Text = "hauteur de pas =";
            // 
            // tbBorneSuperieure
            // 
            this.tbBorneSuperieure.Location = new System.Drawing.Point(232, 26);
            this.tbBorneSuperieure.Name = "tbBorneSuperieure";
            this.tbBorneSuperieure.Size = new System.Drawing.Size(36, 20);
            this.tbBorneSuperieure.TabIndex = 7;
            // 
            // tbBorneInferieure
            // 
            this.tbBorneInferieure.Location = new System.Drawing.Point(98, 26);
            this.tbBorneInferieure.Name = "tbBorneInferieure";
            this.tbBorneInferieure.Size = new System.Drawing.Size(36, 20);
            this.tbBorneInferieure.TabIndex = 6;
            this.tbBorneInferieure.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 30);
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
            this.flpEquation.Location = new System.Drawing.Point(3, 82);
            this.flpEquation.Name = "flpEquation";
            this.flpEquation.Size = new System.Drawing.Size(539, 349);
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
            this.groupBox2.Location = new System.Drawing.Point(564, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 434);
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
            this.tbConsole.Location = new System.Drawing.Point(3, 82);
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.Size = new System.Drawing.Size(402, 349);
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
            // tbPrecision
            // 
            this.tbPrecision.Location = new System.Drawing.Point(341, 56);
            this.tbPrecision.Name = "tbPrecision";
            this.tbPrecision.Size = new System.Drawing.Size(36, 20);
            this.tbPrecision.TabIndex = 14;
            // 
            // lbPrecision
            // 
            this.lbPrecision.AutoSize = true;
            this.lbPrecision.Location = new System.Drawing.Point(274, 57);
            this.lbPrecision.Name = "lbPrecision";
            this.lbPrecision.Size = new System.Drawing.Size(61, 13);
            this.lbPrecision.TabIndex = 13;
            this.lbPrecision.Text = "précision = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 483);
            this.Controls.Add(this.tbDegree);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMethode);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox tbNombrePas;
        private System.Windows.Forms.Label lbNombrePas;
        private System.Windows.Forms.TextBox tbHauteurPas;
        private System.Windows.Forms.Label lbHauteurPas;
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

