namespace App.Widgets
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerDrop));
            this.elementPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.containerNameLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.copyButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.favButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.addTip = new System.Windows.Forms.ToolTip(this.components);
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementPanel
            // 
            this.elementPanel.AllowDrop = true;
            this.elementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementPanel.BackColor = System.Drawing.Color.Transparent;
            this.elementPanel.Location = new System.Drawing.Point(36, 28);
            this.elementPanel.Name = "elementPanel";
            this.elementPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.elementPanel.Size = new System.Drawing.Size(482, 190);
            this.elementPanel.TabIndex = 0;
            this.elementPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.elementPanel.DragOver += new System.Windows.Forms.DragEventHandler(this.OnDragOver);
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
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.controlPanel.Controls.Add(this.copyButton);
            this.controlPanel.Controls.Add(this.upButton);
            this.controlPanel.Controls.Add(this.favButton);
            this.controlPanel.Controls.Add(this.deleteButton);
            this.controlPanel.Controls.Add(this.downButton);
            this.controlPanel.Location = new System.Drawing.Point(537, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(71, 230);
            this.controlPanel.TabIndex = 2;
            // 
            // copyButton
            // 
            this.copyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyButton.BackgroundImage")));
            this.copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Location = new System.Drawing.Point(18, 192);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(34, 33);
            this.copyButton.TabIndex = 5;
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.Transparent;
            this.upButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upButton.BackgroundImage")));
            this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upButton.FlatAppearance.BorderSize = 0;
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.Location = new System.Drawing.Point(18, 78);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(34, 34);
            this.upButton.TabIndex = 4;
            this.upButton.UseVisualStyleBackColor = false;
            // 
            // favButton
            // 
            this.favButton.BackColor = System.Drawing.Color.Transparent;
            this.favButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favButton.BackgroundImage")));
            this.favButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.favButton.FlatAppearance.BorderSize = 0;
            this.favButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favButton.Location = new System.Drawing.Point(18, 38);
            this.favButton.Name = "favButton";
            this.favButton.Size = new System.Drawing.Size(34, 34);
            this.favButton.TabIndex = 3;
            this.favButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(18, 151);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(34, 33);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downButton.BackgroundImage")));
            this.downButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.downButton.FlatAppearance.BorderSize = 0;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Location = new System.Drawing.Point(18, 115);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(34, 36);
            this.downButton.TabIndex = 1;
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // addTip
            // 
            this.addTip.AutoPopDelay = 5000;
            this.addTip.BackColor = System.Drawing.Color.DimGray;
            this.addTip.ForeColor = System.Drawing.Color.Black;
            this.addTip.InitialDelay = 100;
            this.addTip.ReshowDelay = 100;
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
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button favButton;
        private System.Windows.Forms.ToolTip addTip;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button copyButton;
    }
}
