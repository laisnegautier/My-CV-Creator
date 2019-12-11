namespace App.Widgets
{
    partial class ElementDragItem
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
            this.ElementDragName = new System.Windows.Forms.Label();
            this.ElemDragItemDescp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ElementDragName
            // 
            this.ElementDragName.AutoSize = true;
            this.ElementDragName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementDragName.Location = new System.Drawing.Point(45, 9);
            this.ElementDragName.Name = "ElementDragName";
            this.ElementDragName.Size = new System.Drawing.Size(100, 19);
            this.ElementDragName.TabIndex = 0;
            this.ElementDragName.Text = "Element Name";
            // 
            // ElemDragItemDescp
            // 
            this.ElemDragItemDescp.AutoSize = true;
            this.ElemDragItemDescp.Location = new System.Drawing.Point(23, 53);
            this.ElemDragItemDescp.Name = "ElemDragItemDescp";
            this.ElemDragItemDescp.Size = new System.Drawing.Size(152, 13);
            this.ElemDragItemDescp.TabIndex = 1;
            this.ElemDragItemDescp.Text = "Description du container choisi";
            // 
            // ElementDragItem
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.ElemDragItemDescp);
            this.Controls.Add(this.ElementDragName);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Name = "ElementDragItem";
            this.Size = new System.Drawing.Size(196, 129);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ElementDragName;
        private System.Windows.Forms.Label ElemDragItemDescp;
    }
}
