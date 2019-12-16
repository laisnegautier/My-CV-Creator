namespace App.Widgets
{
    partial class TextDrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextDrop));
            this.editableText = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.upButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editableText
            // 
            this.editableText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editableText.Location = new System.Drawing.Point(5, 5);
            this.editableText.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.editableText.Name = "editableText";
            this.editableText.Size = new System.Drawing.Size(596, 132);
            this.editableText.TabIndex = 0;
            this.editableText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.controlPanel.Controls.Add(this.upButton);
            this.controlPanel.Controls.Add(this.deleteButton);
            this.controlPanel.Controls.Add(this.downButton);
            this.controlPanel.Location = new System.Drawing.Point(611, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(35, 94);
            this.controlPanel.TabIndex = 3;
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.Transparent;
            this.upButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upButton.BackgroundImage")));
            this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upButton.FlatAppearance.BorderSize = 0;
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.Location = new System.Drawing.Point(7, 6);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(19, 22);
            this.upButton.TabIndex = 4;
            this.upButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(7, 59);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(19, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downButton.BackgroundImage")));
            this.downButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.downButton.FlatAppearance.BorderSize = 0;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Location = new System.Drawing.Point(7, 34);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(19, 19);
            this.downButton.TabIndex = 1;
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // TextDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.editableText);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Name = "TextDrop";
            this.Size = new System.Drawing.Size(649, 147);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label editableText;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button downButton;
    }
}
