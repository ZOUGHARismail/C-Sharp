namespace Tborida
{
    partial class FormCavalierChevaux
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
            this.comboRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTroupe = new System.Windows.Forms.ComboBox();
            this.dataGridViewCavalier = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.comboRaces = new System.Windows.Forms.ComboBox();
            this.dataGridViewChevaux = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCavalier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChevaux)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(512, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Region";
            // 
            // comboRegion
            // 
            this.comboRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboRegion.FormattingEnabled = true;
            this.comboRegion.Location = new System.Drawing.Point(784, 52);
            this.comboRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboRegion.Name = "comboRegion";
            this.comboRegion.Size = new System.Drawing.Size(440, 37);
            this.comboRegion.TabIndex = 2;
            this.comboRegion.SelectedIndexChanged += new System.EventHandler(this.comboRegion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(512, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Troupe";
            // 
            // comboTroupe
            // 
            this.comboTroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboTroupe.FormattingEnabled = true;
            this.comboTroupe.Location = new System.Drawing.Point(784, 166);
            this.comboTroupe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTroupe.Name = "comboTroupe";
            this.comboTroupe.Size = new System.Drawing.Size(440, 37);
            this.comboTroupe.TabIndex = 4;
            this.comboTroupe.SelectedIndexChanged += new System.EventHandler(this.comboTroupe_SelectedIndexChanged);
            // 
            // dataGridViewCavalier
            // 
            this.dataGridViewCavalier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCavalier.Location = new System.Drawing.Point(195, 315);
            this.dataGridViewCavalier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCavalier.Name = "dataGridViewCavalier";
            this.dataGridViewCavalier.Size = new System.Drawing.Size(728, 231);
            this.dataGridViewCavalier.TabIndex = 6;
            this.dataGridViewCavalier.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewCavalier_CellBeginEdit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(454, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Liste des cavaliers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(1342, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Liste des chevaux";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEnregistrer.Location = new System.Drawing.Point(930, 603);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(170, 54);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // comboRaces
            // 
            this.comboRaces.FormattingEnabled = true;
            this.comboRaces.Location = new System.Drawing.Point(1602, 166);
            this.comboRaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboRaces.Name = "comboRaces";
            this.comboRaces.Size = new System.Drawing.Size(180, 28);
            this.comboRaces.TabIndex = 11;
            this.comboRaces.Visible = false;
            this.comboRaces.SelectedIndexChanged += new System.EventHandler(this.comboRaces_SelectedIndexChanged);
            // 
            // dataGridViewChevaux
            // 
            this.dataGridViewChevaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChevaux.Location = new System.Drawing.Point(1125, 315);
            this.dataGridViewChevaux.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewChevaux.Name = "dataGridViewChevaux";
            this.dataGridViewChevaux.Size = new System.Drawing.Size(627, 231);
            this.dataGridViewChevaux.TabIndex = 7;
            this.dataGridViewChevaux.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewChevaux_CellBeginEdit);
            this.dataGridViewChevaux.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChevaux_CellContentClick);
            this.dataGridViewChevaux.Click += new System.EventHandler(this.dataGridViewChevaux_Click);
            // 
            // FormCavalierChevaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 692);
            this.Controls.Add(this.comboRaces);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewChevaux);
            this.Controls.Add(this.dataGridViewCavalier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTroupe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboRegion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCavalierChevaux";
            this.Text = "FormCavalierChevaux";
            this.Load += new System.EventHandler(this.FormCavalierChevaux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCavalier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChevaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTroupe;
        private System.Windows.Forms.DataGridView dataGridViewCavalier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox comboRaces;
        private System.Windows.Forms.DataGridView dataGridViewChevaux;
    }
}