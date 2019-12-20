namespace App
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.dragPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.copyPicture = new System.Windows.Forms.PictureBox();
            this.deletePicture = new System.Windows.Forms.PictureBox();
            this.editPicture = new System.Windows.Forms.PictureBox();
            this.addPicture = new System.Windows.Forms.PictureBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.resumeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new App.RoundButton();
            this.minimizeButton = new App.RoundButton();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.dragPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).BeginInit();
            this.resumeLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dragPanel.Controls.Add(this.closeButton);
            this.dragPanel.Controls.Add(this.minimizeButton);
            this.dragPanel.Controls.Add(this.panel1);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(990, 45);
            this.dragPanel.TabIndex = 8;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.dragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 45);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "MyCV Creator";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.buttonPanel.Controls.Add(this.panel3);
            this.buttonPanel.Controls.Add(this.copyPicture);
            this.buttonPanel.Controls.Add(this.deletePicture);
            this.buttonPanel.Controls.Add(this.editPicture);
            this.buttonPanel.Controls.Add(this.addPicture);
            this.buttonPanel.Controls.Add(this.copyButton);
            this.buttonPanel.Controls.Add(this.deleteButton);
            this.buttonPanel.Controls.Add(this.editButton);
            this.buttonPanel.Controls.Add(this.addButton);
            this.buttonPanel.Location = new System.Drawing.Point(0, 44);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(175, 463);
            this.buttonPanel.TabIndex = 10;
            this.buttonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainView_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 463);
            this.panel3.TabIndex = 8;
            // 
            // copyPicture
            // 
            this.copyPicture.BackColor = System.Drawing.Color.Transparent;
            this.copyPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyPicture.BackgroundImage")));
            this.copyPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyPicture.Location = new System.Drawing.Point(23, 379);
            this.copyPicture.Name = "copyPicture";
            this.copyPicture.Size = new System.Drawing.Size(36, 38);
            this.copyPicture.TabIndex = 7;
            this.copyPicture.TabStop = false;
            this.copyPicture.Click += new System.EventHandler(this.CopyButton_Click);
            this.copyPicture.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.copyPicture.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // deletePicture
            // 
            this.deletePicture.BackColor = System.Drawing.Color.Transparent;
            this.deletePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletePicture.BackgroundImage")));
            this.deletePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletePicture.Location = new System.Drawing.Point(23, 264);
            this.deletePicture.Name = "deletePicture";
            this.deletePicture.Size = new System.Drawing.Size(36, 38);
            this.deletePicture.TabIndex = 6;
            this.deletePicture.TabStop = false;
            this.deletePicture.Click += new System.EventHandler(this.DeleteButton_Click);
            this.deletePicture.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.deletePicture.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // editPicture
            // 
            this.editPicture.BackColor = System.Drawing.Color.Transparent;
            this.editPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editPicture.BackgroundImage")));
            this.editPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editPicture.Location = new System.Drawing.Point(23, 146);
            this.editPicture.Name = "editPicture";
            this.editPicture.Size = new System.Drawing.Size(36, 38);
            this.editPicture.TabIndex = 5;
            this.editPicture.TabStop = false;
            this.editPicture.Click += new System.EventHandler(this.EditButton_Click);
            this.editPicture.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.editPicture.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // addPicture
            // 
            this.addPicture.BackColor = System.Drawing.Color.Transparent;
            this.addPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPicture.BackgroundImage")));
            this.addPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPicture.Location = new System.Drawing.Point(23, 37);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(36, 38);
            this.addPicture.TabIndex = 4;
            this.addPicture.TabStop = false;
            this.addPicture.Click += new System.EventHandler(this.AddButton_Click);
            this.addPicture.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.addPicture.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.Transparent;
            this.copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ForeColor = System.Drawing.Color.White;
            this.copyButton.Location = new System.Drawing.Point(0, 342);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(175, 110);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "      COPY";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            this.copyButton.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.copyButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(0, 222);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(175, 120);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "         DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.deleteButton.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(0, 108);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(175, 114);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "    EDIT";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            this.editButton.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.editButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 108);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "           ADD NEW";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            this.addButton.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.addButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // resumeLayoutPanel
            // 
            this.resumeLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.resumeLayoutPanel.Controls.Add(this.emptyLabel);
            this.resumeLayoutPanel.Location = new System.Drawing.Point(181, 51);
            this.resumeLayoutPanel.Name = "resumeLayoutPanel";
            this.resumeLayoutPanel.Size = new System.Drawing.Size(637, 453);
            this.resumeLayoutPanel.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Location = new System.Drawing.Point(824, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 463);
            this.panel2.TabIndex = 11;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(956, 11);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 22);
            this.closeButton.TabIndex = 13;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_Enter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_Leave);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(925, 11);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(22, 22);
            this.minimizeButton.TabIndex = 12;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_Enter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_Leave);
            // 
            // emptyLabel
            // 
            this.emptyLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel.ForeColor = System.Drawing.Color.White;
            this.emptyLabel.Location = new System.Drawing.Point(3, 0);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(634, 86);
            this.emptyLabel.TabIndex = 0;
            this.emptyLabel.Text = "Vous n\'avez pas de CV enregistés";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(990, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.resumeLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opening";
            this.dragPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.copyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).EndInit();
            this.resumeLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.FlowLayoutPanel resumeLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.PictureBox addPicture;
        private System.Windows.Forms.PictureBox copyPicture;
        private System.Windows.Forms.PictureBox deletePicture;
        private System.Windows.Forms.PictureBox editPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private RoundButton minimizeButton;
        private RoundButton closeButton;
        private System.Windows.Forms.Label emptyLabel;
    }
}