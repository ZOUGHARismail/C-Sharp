namespace Tborida
{
    partial class FormResponsableIns
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
            this.btnGererTroupe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGererTroupe
            // 
            this.btnGererTroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGererTroupe.Location = new System.Drawing.Point(473, 25);
            this.btnGererTroupe.Name = "btnGererTroupe";
            this.btnGererTroupe.Size = new System.Drawing.Size(262, 92);
            this.btnGererTroupe.TabIndex = 0;
            this.btnGererTroupe.Text = "Gerer les troupes";
            this.btnGererTroupe.UseVisualStyleBackColor = true;
            this.btnGererTroupe.Click += new System.EventHandler(this.btnGererTroupe_Click);
            // 
            // FormResponsableIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 723);
            this.Controls.Add(this.btnGererTroupe);
            this.Name = "FormResponsableIns";
            this.Text = "Formulaire Responsable Inscription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormResponsableIns_FormClosing);
            this.Load += new System.EventHandler(this.FormResponsableIns_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGererTroupe;
    }
}