using System;
using System.Data;

namespace GestionActivitePlanificateur
{
    partial class FormGestionEnfant
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
            this.dataGridViewListeEnfant = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTablePlan = new System.Data.DataTable();
            this.lstBoxStatutEnfant = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxInformationsEnfant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPrenomEnfant = new System.Windows.Forms.TextBox();
            this.lblNomEnfant = new System.Windows.Forms.Label();
            this.txtBoxNomEnfant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNumParent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDateInscription = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinInscription = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerJourConcerne = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjouterEnfant = new System.Windows.Forms.Button();
            this.btnSupprimerEnfant = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEnfant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePlan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListeEnfant
            // 
            this.dataGridViewListeEnfant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeEnfant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Informations,
            this.Column4,
            this.Column5});
            this.dataGridViewListeEnfant.Location = new System.Drawing.Point(319, 27);
            this.dataGridViewListeEnfant.MultiSelect = false;
            this.dataGridViewListeEnfant.Name = "dataGridViewListeEnfant";
            this.dataGridViewListeEnfant.RowTemplate.Height = 24;
            this.dataGridViewListeEnfant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListeEnfant.Size = new System.Drawing.Size(946, 503);
            this.dataGridViewListeEnfant.TabIndex = 4;
            this.dataGridViewListeEnfant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListeEnfant_CellClick);
            // 
            // Column0
            // 
            this.Column0.Frozen = true;
            this.Column0.HeaderText = "Id";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Prénom";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Téléphone Parent";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Statut";
            this.Column7.Name = "Column7";
            // 
            // Informations
            // 
            this.Informations.HeaderText = "Informations";
            this.Informations.Name = "Informations";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date d\'inscription";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date de fin de l\'inscription";
            this.Column5.Name = "Column5";
            // 
            // lstBoxStatutEnfant
            // 
            this.lstBoxStatutEnfant.FormattingEnabled = true;
            this.lstBoxStatutEnfant.ItemHeight = 16;
            this.lstBoxStatutEnfant.Items.AddRange(new object[] {
            "Occasionnel",
            "Régulier"});
            this.lstBoxStatutEnfant.Location = new System.Drawing.Point(12, 249);
            this.lstBoxStatutEnfant.Name = "lstBoxStatutEnfant";
            this.lstBoxStatutEnfant.Size = new System.Drawing.Size(248, 20);
            this.lstBoxStatutEnfant.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Informations de l\'enfant :";
            // 
            // txtBoxInformationsEnfant
            // 
            this.txtBoxInformationsEnfant.Location = new System.Drawing.Point(12, 204);
            this.txtBoxInformationsEnfant.Name = "txtBoxInformationsEnfant";
            this.txtBoxInformationsEnfant.Size = new System.Drawing.Size(248, 22);
            this.txtBoxInformationsEnfant.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prenom de l\'enfant :";
            // 
            // txtBoxPrenomEnfant
            // 
            this.txtBoxPrenomEnfant.Location = new System.Drawing.Point(12, 159);
            this.txtBoxPrenomEnfant.Name = "txtBoxPrenomEnfant";
            this.txtBoxPrenomEnfant.Size = new System.Drawing.Size(248, 22);
            this.txtBoxPrenomEnfant.TabIndex = 18;
            // 
            // lblNomEnfant
            // 
            this.lblNomEnfant.AutoSize = true;
            this.lblNomEnfant.Location = new System.Drawing.Point(9, 94);
            this.lblNomEnfant.Name = "lblNomEnfant";
            this.lblNomEnfant.Size = new System.Drawing.Size(115, 17);
            this.lblNomEnfant.TabIndex = 21;
            this.lblNomEnfant.Text = "Nom de l\'enfant :";
            // 
            // txtBoxNomEnfant
            // 
            this.txtBoxNomEnfant.Location = new System.Drawing.Point(12, 114);
            this.txtBoxNomEnfant.Name = "txtBoxNomEnfant";
            this.txtBoxNomEnfant.Size = new System.Drawing.Size(248, 22);
            this.txtBoxNomEnfant.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Statut de l\'enfant :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Numéro de téléphone des parents :";
            // 
            // txtBoxNumParent
            // 
            this.txtBoxNumParent.Location = new System.Drawing.Point(12, 292);
            this.txtBoxNumParent.Name = "txtBoxNumParent";
            this.txtBoxNumParent.Size = new System.Drawing.Size(248, 22);
            this.txtBoxNumParent.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date d\'inscription de l\'enfant :";
            // 
            // dateTimePickerDateInscription
            // 
            this.dateTimePickerDateInscription.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDateInscription.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateInscription.Location = new System.Drawing.Point(12, 337);
            this.dateTimePickerDateInscription.Name = "dateTimePickerDateInscription";
            this.dateTimePickerDateInscription.Size = new System.Drawing.Size(248, 22);
            this.dateTimePickerDateInscription.TabIndex = 28;
            this.dateTimePickerDateInscription.Value = new System.DateTime(2019, 4, 22, 17, 13, 31, 0);
            // 
            // dateTimePickerFinInscription
            // 
            this.dateTimePickerFinInscription.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFinInscription.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFinInscription.Location = new System.Drawing.Point(12, 382);
            this.dateTimePickerFinInscription.Name = "dateTimePickerFinInscription";
            this.dateTimePickerFinInscription.Size = new System.Drawing.Size(248, 22);
            this.dateTimePickerFinInscription.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Date de fin d\'inscription de l\'enfant :";
            // 
            // dateTimePickerJourConcerne
            // 
            this.dateTimePickerJourConcerne.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerJourConcerne.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerJourConcerne.Location = new System.Drawing.Point(36, 27);
            this.dateTimePickerJourConcerne.Name = "dateTimePickerJourConcerne";
            this.dateTimePickerJourConcerne.Size = new System.Drawing.Size(248, 22);
            this.dateTimePickerJourConcerne.TabIndex = 32;
            this.dateTimePickerJourConcerne.ValueChanged += new System.EventHandler(this.dateTimePickerJourConcerne_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Date du jour concerné :";
            // 
            // btnAjouterEnfant
            // 
            this.btnAjouterEnfant.Location = new System.Drawing.Point(12, 416);
            this.btnAjouterEnfant.Name = "btnAjouterEnfant";
            this.btnAjouterEnfant.Size = new System.Drawing.Size(112, 54);
            this.btnAjouterEnfant.TabIndex = 33;
            this.btnAjouterEnfant.Text = "Ajouter";
            this.btnAjouterEnfant.UseVisualStyleBackColor = true;
            this.btnAjouterEnfant.Click += new System.EventHandler(this.btnAjouterEnfant_Click);
            // 
            // btnSupprimerEnfant
            // 
            this.btnSupprimerEnfant.Location = new System.Drawing.Point(12, 476);
            this.btnSupprimerEnfant.Name = "btnSupprimerEnfant";
            this.btnSupprimerEnfant.Size = new System.Drawing.Size(247, 54);
            this.btnSupprimerEnfant.TabIndex = 34;
            this.btnSupprimerEnfant.Text = "Supprimer";
            this.btnSupprimerEnfant.UseVisualStyleBackColor = true;
            this.btnSupprimerEnfant.Click += new System.EventHandler(this.btnSupprimerEnfant_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nombre d\'enfant ce jour :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 416);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 54);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormGestionEnfant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1319, 547);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSupprimerEnfant);
            this.Controls.Add(this.btnAjouterEnfant);
            this.Controls.Add(this.dateTimePickerJourConcerne);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerFinInscription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerDateInscription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNumParent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNomEnfant);
            this.Controls.Add(this.txtBoxNomEnfant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPrenomEnfant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxInformationsEnfant);
            this.Controls.Add(this.lstBoxStatutEnfant);
            this.Controls.Add(this.dataGridViewListeEnfant);
            this.Name = "FormGestionEnfant";
            this.Text = "Gestion des enfants";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeEnfant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewListeEnfant;
        private System.Windows.Forms.ListBox lstBoxStatutEnfant;
        private DataTable dataTablePlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxInformationsEnfant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPrenomEnfant;
        private System.Windows.Forms.Label lblNomEnfant;
        private System.Windows.Forms.TextBox txtBoxNomEnfant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNumParent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateInscription;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinInscription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerJourConcerne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAjouterEnfant;
        private System.Windows.Forms.Button btnSupprimerEnfant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Informations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
    }
}

