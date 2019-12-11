namespace App.Widgets
{
    partial class ParagraphDrop
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
            this.paragraphText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paragraphText
            // 
            this.paragraphText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paragraphText.Location = new System.Drawing.Point(15, 23);
            this.paragraphText.Margin = new System.Windows.Forms.Padding(5);
            this.paragraphText.Name = "paragraphText";
            this.paragraphText.Size = new System.Drawing.Size(619, 118);
            this.paragraphText.TabIndex = 0;
            // 
            // ParagraphDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.paragraphText);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ParagraphDrop";
            this.Size = new System.Drawing.Size(647, 169);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label paragraphText;
    }
}
