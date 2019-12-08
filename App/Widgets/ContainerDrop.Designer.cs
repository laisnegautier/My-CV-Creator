﻿namespace App.Widgets
{
    partial class ContainerDrop
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.elementPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.containerNameLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.favButton = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementPanel
            // 
            this.elementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementPanel.BackColor = System.Drawing.Color.Transparent;
            this.elementPanel.Location = new System.Drawing.Point(36, 28);
            this.elementPanel.Name = "elementPanel";
            this.elementPanel.Size = new System.Drawing.Size(482, 190);
            this.elementPanel.TabIndex = 0;
            // 
            // containerNameLabel
            // 
            this.containerNameLabel.AutoSize = true;
            this.containerNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerNameLabel.Location = new System.Drawing.Point(64, 13);
            this.containerNameLabel.Name = "containerNameLabel";
            this.containerNameLabel.Size = new System.Drawing.Size(145, 25);
            this.containerNameLabel.TabIndex = 1;
            this.containerNameLabel.Text = "Container Name";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.controlPanel.Controls.Add(this.favButton);
            this.controlPanel.Controls.Add(this.deleteButton);
            this.controlPanel.Controls.Add(this.downButton);
            this.controlPanel.Controls.Add(this.upButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(537, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(71, 230);
            this.controlPanel.TabIndex = 2;
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(3, 157);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(65, 45);
            this.downButton.TabIndex = 1;
            this.downButton.Text = "V";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(3, 55);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(65, 45);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "^";
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(3, 106);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(65, 45);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // favButton
            // 
            this.favButton.Location = new System.Drawing.Point(3, 3);
            this.favButton.Name = "favButton";
            this.favButton.Size = new System.Drawing.Size(65, 45);
            this.favButton.TabIndex = 3;
            this.favButton.Text = "<>";
            this.favButton.UseVisualStyleBackColor = true;
            this.favButton.Click += new System.EventHandler(this.favButton_Click);
            // 
            // ContainerDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.containerNameLabel);
            this.Controls.Add(this.elementPanel);
            this.Name = "ContainerDrop";
            this.Size = new System.Drawing.Size(608, 230);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel elementPanel;
        private System.Windows.Forms.Label containerNameLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button favButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
