namespace GestionStockWindowsForms
{
    partial class SupprimerArticle
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
            this.txtSuppId = new System.Windows.Forms.TextBox();
            this.btnValiderSupp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppression d\'un article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(244, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro de référence de l\'article";
            // 
            // txtSuppId
            // 
            this.txtSuppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSuppId.Location = new System.Drawing.Point(290, 199);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(170, 23);
            this.txtSuppId.TabIndex = 2;
            // 
            // btnValiderSupp
            // 
            this.btnValiderSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnValiderSupp.Location = new System.Drawing.Point(416, 255);
            this.btnValiderSupp.Name = "btnValiderSupp";
            this.btnValiderSupp.Size = new System.Drawing.Size(97, 30);
            this.btnValiderSupp.TabIndex = 3;
            this.btnValiderSupp.Text = "Valider";
            this.btnValiderSupp.UseVisualStyleBackColor = true;
            this.btnValiderSupp.Click += new System.EventHandler(this.btnValiderSupp_Click);
            // 
            // SupprimerArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValiderSupp);
            this.Controls.Add(this.txtSuppId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupprimerArticle";
            this.Text = "SupprimerArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuppId;
        private System.Windows.Forms.Button btnValiderSupp;
    }
}