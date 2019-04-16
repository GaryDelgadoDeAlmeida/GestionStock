namespace GestionStockWindowsForms
{
    partial class ModifierArticleNom
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
            this.txtNumRef = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValiderModifName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(187, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro de référence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(187, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nouveau Nom";
            // 
            // txtNumRef
            // 
            this.txtNumRef.Location = new System.Drawing.Point(373, 185);
            this.txtNumRef.Name = "txtNumRef";
            this.txtNumRef.Size = new System.Drawing.Size(160, 20);
            this.txtNumRef.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(373, 241);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(192, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modifier le nom d\'un article";
            // 
            // btnValiderModifName
            // 
            this.btnValiderModifName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnValiderModifName.Location = new System.Drawing.Point(497, 292);
            this.btnValiderModifName.Name = "btnValiderModifName";
            this.btnValiderModifName.Size = new System.Drawing.Size(81, 31);
            this.btnValiderModifName.TabIndex = 5;
            this.btnValiderModifName.Text = "Valider";
            this.btnValiderModifName.UseVisualStyleBackColor = true;
            this.btnValiderModifName.Click += new System.EventHandler(this.btnValiderModifName_Click);
            // 
            // ModifierArticleNom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValiderModifName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumRef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifierArticleNom";
            this.Text = "ModifierArticleNom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumRef;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValiderModifName;
    }
}