namespace GestionStockWindowsForms
{
    partial class ModifierArticlePrice
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
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValiderModifPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(235, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro de référence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(235, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nouveau prix";
            // 
            // txtNumRef
            // 
            this.txtNumRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNumRef.Location = new System.Drawing.Point(422, 160);
            this.txtNumRef.Name = "txtNumRef";
            this.txtNumRef.Size = new System.Drawing.Size(136, 20);
            this.txtNumRef.TabIndex = 2;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNewPrice.Location = new System.Drawing.Point(422, 211);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(136, 20);
            this.txtNewPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(193, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modifier le prix d\'un article";
            // 
            // btnValiderModifPrice
            // 
            this.btnValiderModifPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnValiderModifPrice.Location = new System.Drawing.Point(469, 275);
            this.btnValiderModifPrice.Name = "btnValiderModifPrice";
            this.btnValiderModifPrice.Size = new System.Drawing.Size(105, 30);
            this.btnValiderModifPrice.TabIndex = 5;
            this.btnValiderModifPrice.Text = "Valider";
            this.btnValiderModifPrice.UseVisualStyleBackColor = true;
            this.btnValiderModifPrice.Click += new System.EventHandler(this.btnValiderModifPrice_Click);
            // 
            // ModifierArticlePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValiderModifPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.txtNumRef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifierArticlePrice";
            this.Text = "ModifierArticlePrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumRef;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValiderModifPrice;
    }
}