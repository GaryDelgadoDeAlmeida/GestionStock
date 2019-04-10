namespace GestionStockWindowsForms
{
    partial class HomeApplication
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
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherParUnNuméroDidentificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherParUnNomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherParUnIntervalleDePrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherTousLesArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.modifierUnArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomDeLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prixDeLarticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nbrExemplairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnArticleToolStripMenuItem,
            this.supprimerUnArticleToolStripMenuItem,
            this.modifierUnArticleToolStripMenuItem,
            this.rechercherParUnNuméroDidentificationToolStripMenuItem,
            this.rechercherParUnNomToolStripMenuItem,
            this.rechercherParUnIntervalleDePrixToolStripMenuItem,
            this.afficherTousLesArticlesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterUnArticleToolStripMenuItem
            // 
            this.ajouterUnArticleToolStripMenuItem.Name = "ajouterUnArticleToolStripMenuItem";
            this.ajouterUnArticleToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.ajouterUnArticleToolStripMenuItem.Text = "Ajouter un article";
            this.ajouterUnArticleToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnArticleToolStripMenuItem_Click);
            // 
            // supprimerUnArticleToolStripMenuItem
            // 
            this.supprimerUnArticleToolStripMenuItem.Name = "supprimerUnArticleToolStripMenuItem";
            this.supprimerUnArticleToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.supprimerUnArticleToolStripMenuItem.Text = "Supprimer un article";
            this.supprimerUnArticleToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnArticleToolStripMenuItem_Click);
            // 
            // rechercherParUnNuméroDidentificationToolStripMenuItem
            // 
            this.rechercherParUnNuméroDidentificationToolStripMenuItem.Name = "rechercherParUnNuméroDidentificationToolStripMenuItem";
            this.rechercherParUnNuméroDidentificationToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.rechercherParUnNuméroDidentificationToolStripMenuItem.Text = "Rechercher par un numéro d\'identification";
            this.rechercherParUnNuméroDidentificationToolStripMenuItem.Click += new System.EventHandler(this.rechercherParUnNuméroDidentificationToolStripMenuItem_Click);
            // 
            // rechercherParUnNomToolStripMenuItem
            // 
            this.rechercherParUnNomToolStripMenuItem.Name = "rechercherParUnNomToolStripMenuItem";
            this.rechercherParUnNomToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.rechercherParUnNomToolStripMenuItem.Text = "Rechercher par un nom";
            this.rechercherParUnNomToolStripMenuItem.Click += new System.EventHandler(this.rechercherParUnNomToolStripMenuItem_Click);
            // 
            // rechercherParUnIntervalleDePrixToolStripMenuItem
            // 
            this.rechercherParUnIntervalleDePrixToolStripMenuItem.Name = "rechercherParUnIntervalleDePrixToolStripMenuItem";
            this.rechercherParUnIntervalleDePrixToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.rechercherParUnIntervalleDePrixToolStripMenuItem.Text = "Rechercher par un intervalle de prix";
            this.rechercherParUnIntervalleDePrixToolStripMenuItem.Click += new System.EventHandler(this.rechercherParUnIntervalleDePrixToolStripMenuItem_Click);
            // 
            // afficherTousLesArticlesToolStripMenuItem
            // 
            this.afficherTousLesArticlesToolStripMenuItem.Name = "afficherTousLesArticlesToolStripMenuItem";
            this.afficherTousLesArticlesToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.afficherTousLesArticlesToolStripMenuItem.Text = "Afficher tous les articles";
            this.afficherTousLesArticlesToolStripMenuItem.Click += new System.EventHandler(this.afficherTousLesArticlesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(140, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Application de Gestion de Stock";
            // 
            // modifierUnArticleToolStripMenuItem
            // 
            this.modifierUnArticleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomDeLarticleToolStripMenuItem,
            this.prixDeLarticleToolStripMenuItem,
            this.nbrExemplairesToolStripMenuItem});
            this.modifierUnArticleToolStripMenuItem.Name = "modifierUnArticleToolStripMenuItem";
            this.modifierUnArticleToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.modifierUnArticleToolStripMenuItem.Text = "Modifier un article";
            // 
            // nomDeLarticleToolStripMenuItem
            // 
            this.nomDeLarticleToolStripMenuItem.Name = "nomDeLarticleToolStripMenuItem";
            this.nomDeLarticleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nomDeLarticleToolStripMenuItem.Text = "Nom de l\'article";
            this.nomDeLarticleToolStripMenuItem.Click += new System.EventHandler(this.nomDeLarticleToolStripMenuItem_Click);
            // 
            // prixDeLarticleToolStripMenuItem
            // 
            this.prixDeLarticleToolStripMenuItem.Name = "prixDeLarticleToolStripMenuItem";
            this.prixDeLarticleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prixDeLarticleToolStripMenuItem.Text = "Prix de l\'article";
            this.prixDeLarticleToolStripMenuItem.Click += new System.EventHandler(this.prixDeLarticleToolStripMenuItem_Click);
            // 
            // nbrExemplairesToolStripMenuItem
            // 
            this.nbrExemplairesToolStripMenuItem.Name = "nbrExemplairesToolStripMenuItem";
            this.nbrExemplairesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nbrExemplairesToolStripMenuItem.Text = "Nbr Exemplaires";
            this.nbrExemplairesToolStripMenuItem.Click += new System.EventHandler(this.nbrExemplairesToolStripMenuItem_Click);
            // 
            // HomeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeApplication";
            this.Text = "Application de Gestion de Stock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherParUnNuméroDidentificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherParUnNomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherParUnIntervalleDePrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherTousLesArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomDeLarticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prixDeLarticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nbrExemplairesToolStripMenuItem;
    }
}

