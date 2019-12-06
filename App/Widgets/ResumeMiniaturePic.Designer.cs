namespace App
{
    partial class ResumeMiniaturePic
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
            this.resumeTitle = new System.Windows.Forms.Label();
            this.containerLabel = new System.Windows.Forms.Label();
            this.elementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resumeTitle
            // 
            this.resumeTitle.AutoSize = true;
            this.resumeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeTitle.Location = new System.Drawing.Point(24, 13);
            this.resumeTitle.Name = "resumeTitle";
            this.resumeTitle.Size = new System.Drawing.Size(96, 25);
            this.resumeTitle.TabIndex = 0;
            this.resumeTitle.Text = "CV_Titre";
            // 
            // containerLabel
            // 
            this.containerLabel.AutoSize = true;
            this.containerLabel.Location = new System.Drawing.Point(13, 62);
            this.containerLabel.Name = "containerLabel";
            this.containerLabel.Size = new System.Drawing.Size(62, 13);
            this.containerLabel.TabIndex = 1;
            this.containerLabel.Text = "containers :";
            // 
            // elementLabel
            // 
            this.elementLabel.AutoSize = true;
            this.elementLabel.Location = new System.Drawing.Point(13, 112);
            this.elementLabel.Name = "elementLabel";
            this.elementLabel.Size = new System.Drawing.Size(55, 13);
            this.elementLabel.TabIndex = 2;
            this.elementLabel.Text = "elements :";
            // 
            // ResumeMiniaturePic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.elementLabel);
            this.Controls.Add(this.containerLabel);
            this.Controls.Add(this.resumeTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ResumeMiniaturePic";
            this.Size = new System.Drawing.Size(139, 191);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resumeTitle;
        private System.Windows.Forms.Label containerLabel;
        private System.Windows.Forms.Label elementLabel;
    }
}
