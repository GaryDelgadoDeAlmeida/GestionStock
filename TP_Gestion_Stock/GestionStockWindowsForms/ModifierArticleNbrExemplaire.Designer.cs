namespace GestionStockWindowsForms
{
    partial class ModifierArticleNbrExemplaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumRef = new System.Windows.Forms.TextBox();
            this.txtNbrExemplaire = new System.Windows.Forms.TextBox();
            this.btnValiderModifNbrExemplaire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier le nombre d\'exemplaires d\'un article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(201, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro de référence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(201, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre d\'exemplaires";
            // 
            // txtNumRef
            // 
            this.txtNumRef.Location = new System.Drawing.Point(393, 158);
            this.txtNumRef.Name = "txtNumRef";
            this.txtNumRef.Size = new System.Drawing.Size(134, 20);
            this.txtNumRef.TabIndex = 3;
            // 
            // txtNbrExemplaire
            // 
            this.txtNbrExemplaire.Location = new System.Drawing.Point(393, 247);
            this.txtNbrExemplaire.Name = "txtNbrExemplaire";
            this.txtNbrExemplaire.Size = new System.Drawing.Size(134, 20);
            this.txtNbrExemplaire.TabIndex = 4;
            // 
            // btnValiderModifNbrExemplaire
            // 
            this.btnValiderModifNbrExemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnValiderModifNbrExemplaire.Location = new System.Drawing.Point(506, 310);
            this.btnValiderModifNbrExemplaire.Name = "btnValiderModifNbrExemplaire";
            this.btnValiderModifNbrExemplaire.Size = new System.Drawing.Size(95, 31);
            this.btnValiderModifNbrExemplaire.TabIndex = 5;
            this.btnValiderModifNbrExemplaire.Text = "Valider";
            this.btnValiderModifNbrExemplaire.UseVisualStyleBackColor = true;
            this.btnValiderModifNbrExemplaire.Click += new System.EventHandler(this.btnValiderModifNbrExemplaire_Click);
            // 
            // ModifierArticleNbrExemplaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValiderModifNbrExemplaire);
            this.Controls.Add(this.txtNbrExemplaire);
            this.Controls.Add(this.txtNumRef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifierArticleNbrExemplaire";
            this.Text = "ModifierArticleNbrExemplaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumRef;
        private System.Windows.Forms.TextBox txtNbrExemplaire;
        private System.Windows.Forms.Button btnValiderModifNbrExemplaire;
    }
}