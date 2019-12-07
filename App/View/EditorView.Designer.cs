namespace App
{
    partial class EditorView
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
            this.logoLabel = new System.Windows.Forms.Label();
            this.headerPanelLogo = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.defaultSectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.favSectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.elementPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.resumeEditorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.headerPanelLogo.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(159, 6);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(145, 34);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "MyCV Creator";
            // 
            // headerPanelLogo
            // 
            this.headerPanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
            this.headerPanelLogo.Controls.Add(this.logoLabel);
            this.headerPanelLogo.Location = new System.Drawing.Point(0, 0);
            this.headerPanelLogo.Name = "headerPanelLogo";
            this.headerPanelLogo.Size = new System.Drawing.Size(337, 45);
            this.headerPanelLogo.TabIndex = 11;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.headerPanel.Controls.Add(this.headerPanelLogo);
            this.headerPanel.Controls.Add(this.minimizeButton);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1152, 45);
            this.headerPanel.TabIndex = 9;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(1049, 11);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 23);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(107)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1089, 11);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 582);
            this.panel3.TabIndex = 8;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.leftPanel.Controls.Add(this.favSectionPanel);
            this.leftPanel.Controls.Add(this.defaultSectionPanel);
            this.leftPanel.Controls.Add(this.panel3);
            this.leftPanel.Location = new System.Drawing.Point(0, 44);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(337, 582);
            this.leftPanel.TabIndex = 11;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.rightPanel.Controls.Add(this.elementPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(815, 45);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(337, 579);
            this.rightPanel.TabIndex = 12;
            // 
            // defaultSectionPanel
            // 
            this.defaultSectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultSectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultSectionPanel.ForeColor = System.Drawing.Color.White;
            this.defaultSectionPanel.Location = new System.Drawing.Point(16, 7);
            this.defaultSectionPanel.Name = "defaultSectionPanel";
            this.defaultSectionPanel.Size = new System.Drawing.Size(318, 280);
            this.defaultSectionPanel.TabIndex = 9;
            // 
            // favSectionPanel
            // 
            this.favSectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favSectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.favSectionPanel.Location = new System.Drawing.Point(16, 293);
            this.favSectionPanel.Name = "favSectionPanel";
            this.favSectionPanel.Size = new System.Drawing.Size(318, 275);
            this.favSectionPanel.TabIndex = 10;
            // 
            // elementPanel
            // 
            this.elementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementPanel.Location = new System.Drawing.Point(3, 7);
            this.elementPanel.Name = "elementPanel";
            this.elementPanel.Size = new System.Drawing.Size(331, 560);
            this.elementPanel.TabIndex = 0;
            // 
            // resumeEditorPanel
            // 
            this.resumeEditorPanel.Location = new System.Drawing.Point(343, 52);
            this.resumeEditorPanel.Name = "resumeEditorPanel";
            this.resumeEditorPanel.Size = new System.Drawing.Size(466, 535);
            this.resumeEditorPanel.TabIndex = 13;
            // 
            // EditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 624);
            this.Controls.Add(this.resumeEditorPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditorView";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.EditorView_Load);
            this.headerPanelLogo.ResumeLayout(false);
            this.headerPanelLogo.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Panel headerPanelLogo;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.FlowLayoutPanel favSectionPanel;
        private System.Windows.Forms.FlowLayoutPanel defaultSectionPanel;
        private System.Windows.Forms.FlowLayoutPanel elementPanel;
        private System.Windows.Forms.FlowLayoutPanel resumeEditorPanel;
    }
}

