namespace App.Widgets
{
    partial class ContainerDragItem
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
            this.ContDragItemNameLabel = new System.Windows.Forms.Label();
            this.ContDragItemDescp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContDragItemNameLabel
            // 
            this.ContDragItemNameLabel.AutoSize = true;
            this.ContDragItemNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContDragItemNameLabel.Location = new System.Drawing.Point(45, 9);
            this.ContDragItemNameLabel.Name = "ContDragItemNameLabel";
            this.ContDragItemNameLabel.Size = new System.Drawing.Size(110, 19);
            this.ContDragItemNameLabel.TabIndex = 0;
            this.ContDragItemNameLabel.Text = "Container Name";
            // 
            // ContDragItemDescp
            // 
            this.ContDragItemDescp.AutoSize = true;
            this.ContDragItemDescp.Location = new System.Drawing.Point(23, 53);
            this.ContDragItemDescp.Name = "ContDragItemDescp";
            this.ContDragItemDescp.Size = new System.Drawing.Size(152, 13);
            this.ContDragItemDescp.TabIndex = 1;
            this.ContDragItemDescp.Text = "Description du container choisi";
            // 
            // ContainerDragItem
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.ContDragItemDescp);
            this.Controls.Add(this.ContDragItemNameLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Name = "ContainerDragItem";
            this.Size = new System.Drawing.Size(196, 129);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContDragItemNameLabel;
        private System.Windows.Forms.Label ContDragItemDescp;
    }
}
