namespace gestionDocBD
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerLeDocDansLaBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficheMesDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDocumentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDocumentToolStripMenuItem
            // 
            this.gestionDocumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauDocumentToolStripMenuItem,
            this.enregistrerLeDocDansLaBaseToolStripMenuItem,
            this.afficheMesDocumentsToolStripMenuItem});
            this.gestionDocumentToolStripMenuItem.Name = "gestionDocumentToolStripMenuItem";
            this.gestionDocumentToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.gestionDocumentToolStripMenuItem.Text = "Gestion Document";
            // 
            // nouveauDocumentToolStripMenuItem
            // 
            this.nouveauDocumentToolStripMenuItem.Name = "nouveauDocumentToolStripMenuItem";
            this.nouveauDocumentToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.nouveauDocumentToolStripMenuItem.Text = "Nouveau Document";
            this.nouveauDocumentToolStripMenuItem.Click += new System.EventHandler(this.nouveauDocumentToolStripMenuItem_Click);
            // 
            // enregistrerLeDocDansLaBaseToolStripMenuItem
            // 
            this.enregistrerLeDocDansLaBaseToolStripMenuItem.Name = "enregistrerLeDocDansLaBaseToolStripMenuItem";
            this.enregistrerLeDocDansLaBaseToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.enregistrerLeDocDansLaBaseToolStripMenuItem.Text = "Enregistrer le doc dans la base";
            this.enregistrerLeDocDansLaBaseToolStripMenuItem.Click += new System.EventHandler(this.enregistrerLeDocDansLaBaseToolStripMenuItem_Click);
            // 
            // afficheMesDocumentsToolStripMenuItem
            // 
            this.afficheMesDocumentsToolStripMenuItem.Name = "afficheMesDocumentsToolStripMenuItem";
            this.afficheMesDocumentsToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.afficheMesDocumentsToolStripMenuItem.Text = "Affiche Mes Documents";
            this.afficheMesDocumentsToolStripMenuItem.Click += new System.EventHandler(this.afficheMesDocumentsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox4);
            this.groupBox1.Controls.Add(this.richTextBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Document";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(135, 29);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(306, 36);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(135, 29);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proprietaire :";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(29, 106);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(667, 257);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Creation";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(576, 34);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(120, 29);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerLeDocDansLaBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficheMesDocumentsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox4;


    }
}

