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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResumeMiniaturePic));
            this.resumeTitle = new System.Windows.Forms.Label();
            this.containerLabel = new System.Windows.Forms.Label();
            this.elementLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.favButton = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resumeTitle
            // 
            this.resumeTitle.AutoSize = true;
            this.resumeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeTitle.Location = new System.Drawing.Point(24, 16);
            this.resumeTitle.Name = "resumeTitle";
            this.resumeTitle.Size = new System.Drawing.Size(96, 25);
            this.resumeTitle.TabIndex = 0;
            this.resumeTitle.Text = "CV_Titre";
            this.resumeTitle.MouseEnter += new System.EventHandler(this.Pic_OnMouseEnter);
            this.resumeTitle.MouseLeave += new System.EventHandler(this.Pic_OnMouseLeave);
            // 
            // containerLabel
            // 
            this.containerLabel.AutoSize = true;
            this.containerLabel.Location = new System.Drawing.Point(13, 65);
            this.containerLabel.Name = "containerLabel";
            this.containerLabel.Size = new System.Drawing.Size(62, 13);
            this.containerLabel.TabIndex = 1;
            this.containerLabel.Text = "containers :";
            this.containerLabel.MouseEnter += new System.EventHandler(this.Pic_OnMouseEnter);
            this.containerLabel.MouseLeave += new System.EventHandler(this.Pic_OnMouseLeave);
            // 
            // elementLabel
            // 
            this.elementLabel.AutoSize = true;
            this.elementLabel.Location = new System.Drawing.Point(13, 115);
            this.elementLabel.Name = "elementLabel";
            this.elementLabel.Size = new System.Drawing.Size(55, 13);
            this.elementLabel.TabIndex = 2;
            this.elementLabel.Text = "elements :";
            this.elementLabel.MouseEnter += new System.EventHandler(this.Pic_OnMouseEnter);
            this.elementLabel.MouseLeave += new System.EventHandler(this.Pic_OnMouseLeave);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.controlPanel.Controls.Add(this.favButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 147);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(139, 44);
            this.controlPanel.TabIndex = 3;
            // 
            // favButton
            // 
            this.favButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favButton.BackgroundImage")));
            this.favButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.favButton.FlatAppearance.BorderSize = 0;
            this.favButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favButton.Location = new System.Drawing.Point(101, 3);
            this.favButton.Name = "favButton";
            this.favButton.Size = new System.Drawing.Size(35, 38);
            this.favButton.TabIndex = 0;
            this.favButton.UseVisualStyleBackColor = true;
            this.favButton.Click += new System.EventHandler(this.FavButton_Click);
            // 
            // ResumeMiniaturePic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.elementLabel);
            this.Controls.Add(this.containerLabel);
            this.Controls.Add(this.resumeTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ResumeMiniaturePic";
            this.Size = new System.Drawing.Size(139, 191);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resumeTitle;
        private System.Windows.Forms.Label containerLabel;
        private System.Windows.Forms.Label elementLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button favButton;
    }
}
