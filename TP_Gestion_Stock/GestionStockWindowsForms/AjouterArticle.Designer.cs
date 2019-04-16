namespace GestionStockWindowsForms
{
    partial class AjouterArticle
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
            this.inputNum = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.inputNbr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNum
            // 
            this.inputNum.Location = new System.Drawing.Point(425, 113);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(167, 20);
            this.inputNum.TabIndex = 0;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(425, 182);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(167, 20);
            this.inputName.TabIndex = 1;
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(425, 253);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(167, 20);
            this.inputPrice.TabIndex = 2;
            // 
            // inputNbr
            // 
            this.inputNbr.Location = new System.Drawing.Point(425, 323);
            this.inputNbr.Name = "inputNbr";
            this.inputNbr.Size = new System.Drawing.Size(167, 20);
            this.inputNbr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(208, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numéro de Référence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(208, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom de l\'article";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(208, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prix de l\'article";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(208, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombres d\'exemplaires";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(270, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ajouter un article";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(563, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Valider l\'ajout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AjouterArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNbr);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputNum);
            this.Name = "AjouterArticle";
            this.Text = "AjouterArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNum;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.TextBox inputNbr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}