namespace App.Widgets
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.oKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.descritpionLabel = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.leftHeadPanel = new System.Windows.Forms.Panel();
            this.warningIcon = new System.Windows.Forms.PictureBox();
            this.roundButton1 = new App.RoundButton();
            this.headPanel.SuspendLayout();
            this.leftHeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // oKButton
            // 
            this.oKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.oKButton.FlatAppearance.BorderSize = 0;
            this.oKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oKButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oKButton.ForeColor = System.Drawing.Color.White;
            this.oKButton.Location = new System.Drawing.Point(108, 177);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(110, 45);
            this.oKButton.TabIndex = 0;
            this.oKButton.Text = "CONFIRM";
            this.oKButton.UseVisualStyleBackColor = false;
            this.oKButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(247, 177);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 45);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // descritpionLabel
            // 
            this.descritpionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descritpionLabel.ForeColor = System.Drawing.Color.White;
            this.descritpionLabel.Location = new System.Drawing.Point(157, 67);
            this.descritpionLabel.Name = "descritpionLabel";
            this.descritpionLabel.Size = new System.Drawing.Size(216, 94);
            this.descritpionLabel.TabIndex = 2;
            this.descritpionLabel.Text = "Description de l\'action a valider";
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.headPanel.Controls.Add(this.roundButton1);
            this.headPanel.Controls.Add(this.leftHeadPanel);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(396, 40);
            this.headPanel.TabIndex = 3;
            this.headPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.headPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.headPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(45, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(89, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dialog title";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // leftHeadPanel
            // 
            this.leftHeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
            this.leftHeadPanel.Controls.Add(this.titleLabel);
            this.leftHeadPanel.Location = new System.Drawing.Point(0, 0);
            this.leftHeadPanel.Name = "leftHeadPanel";
            this.leftHeadPanel.Size = new System.Drawing.Size(181, 40);
            this.leftHeadPanel.TabIndex = 4;
            this.leftHeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.leftHeadPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.leftHeadPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // warningIcon
            // 
            this.warningIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("warningIcon.BackgroundImage")));
            this.warningIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.warningIcon.Location = new System.Drawing.Point(40, 76);
            this.warningIcon.Name = "warningIcon";
            this.warningIcon.Size = new System.Drawing.Size(85, 85);
            this.warningIcon.TabIndex = 4;
            this.warningIcon.TabStop = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(107)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Location = new System.Drawing.Point(360, 9);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(24, 23);
            this.roundButton1.TabIndex = 5;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(396, 248);
            this.Controls.Add(this.warningIcon);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.descritpionLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.oKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            this.headPanel.ResumeLayout(false);
            this.leftHeadPanel.ResumeLayout(false);
            this.leftHeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label descritpionLabel;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Panel leftHeadPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox warningIcon;
        private RoundButton roundButton1;
    }
}