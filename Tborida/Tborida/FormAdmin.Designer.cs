namespace Tborida
{
    partial class FormAdmin
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
            this.btnGestionUsers = new System.Windows.Forms.Button();
            this.btnGestionRaces = new System.Windows.Forms.Button();
            this.btnGestionRegion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionUsers
            // 
            this.btnGestionUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGestionUsers.Location = new System.Drawing.Point(453, 68);
            this.btnGestionUsers.Name = "btnGestionUsers";
            this.btnGestionUsers.Size = new System.Drawing.Size(208, 59);
            this.btnGestionUsers.TabIndex = 0;
            this.btnGestionUsers.Text = "Gestion des utilisateurs";
            this.btnGestionUsers.UseVisualStyleBackColor = true;
            this.btnGestionUsers.Click += new System.EventHandler(this.btnGestionUsers_Click);
            // 
            // btnGestionRaces
            // 
            this.btnGestionRaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGestionRaces.Location = new System.Drawing.Point(453, 185);
            this.btnGestionRaces.Name = "btnGestionRaces";
            this.btnGestionRaces.Size = new System.Drawing.Size(208, 59);
            this.btnGestionRaces.TabIndex = 1;
            this.btnGestionRaces.Text = "Gestion des races";
            this.btnGestionRaces.UseVisualStyleBackColor = true;
            this.btnGestionRaces.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGestionRegion
            // 
            this.btnGestionRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGestionRegion.Location = new System.Drawing.Point(453, 318);
            this.btnGestionRegion.Name = "btnGestionRegion";
            this.btnGestionRegion.Size = new System.Drawing.Size(208, 59);
            this.btnGestionRegion.TabIndex = 2;
            this.btnGestionRegion.Text = "Gestion des Régions";
            this.btnGestionRegion.UseVisualStyleBackColor = true;
            this.btnGestionRegion.Click += new System.EventHandler(this.btnGestionRegion_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 450);
            this.Controls.Add(this.btnGestionRegion);
            this.Controls.Add(this.btnGestionRaces);
            this.Controls.Add(this.btnGestionUsers);
            this.Name = "FormAdmin";
            this.Text = "Formulaire Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionUsers;
        private System.Windows.Forms.Button btnGestionRaces;
        private System.Windows.Forms.Button btnGestionRegion;
    }
}

