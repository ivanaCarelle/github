namespace github
{
    partial class HelloGitHubForm
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
            this.HelloButton = new System.Windows.Forms.Button();
            this.modifierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloButton
            // 
            this.HelloButton.BackColor = System.Drawing.Color.IndianRed;
            this.HelloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloButton.Location = new System.Drawing.Point(266, 109);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(142, 43);
            this.HelloButton.TabIndex = 0;
            this.HelloButton.Text = "HelloGitHub";
            this.HelloButton.UseVisualStyleBackColor = false;
            this.HelloButton.Click += new System.EventHandler(this.HelloButton_Click);
            // 
            // modifierButton
            // 
            this.modifierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierButton.Location = new System.Drawing.Point(266, 201);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(142, 71);
            this.modifierButton.TabIndex = 1;
            this.modifierButton.Text = "Modifier la couleur de l\'arriere plan du formulaire";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // HelloGitHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.HelloButton);
            this.Name = "HelloGitHubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub et Git pour Visual Studio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Button modifierButton;
    }
}

