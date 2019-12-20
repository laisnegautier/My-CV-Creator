namespace App.View
{
    partial class DateEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateEditor));
            this.titleLabel = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.leftHeadPanel = new System.Windows.Forms.Panel();
            this.warningIcon = new System.Windows.Forms.PictureBox();
            this.descritpionLabel = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.roundButton1 = new App.RoundButton();
            this.headPanel.SuspendLayout();
            this.leftHeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(81, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(90, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Date Editor";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.headPanel.Controls.Add(this.roundButton1);
            this.headPanel.Controls.Add(this.leftHeadPanel);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(393, 40);
            this.headPanel.TabIndex = 14;
            this.headPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.headPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.headPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // leftHeadPanel
            // 
            this.leftHeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
            this.leftHeadPanel.Controls.Add(this.titleLabel);
            this.leftHeadPanel.Controls.Add(this.warningIcon);
            this.leftHeadPanel.Location = new System.Drawing.Point(0, 3);
            this.leftHeadPanel.Name = "leftHeadPanel";
            this.leftHeadPanel.Size = new System.Drawing.Size(181, 40);
            this.leftHeadPanel.TabIndex = 11;
            this.leftHeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.leftHeadPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.leftHeadPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // warningIcon
            // 
            this.warningIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("warningIcon.BackgroundImage")));
            this.warningIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.warningIcon.Location = new System.Drawing.Point(43, 4);
            this.warningIcon.Name = "warningIcon";
            this.warningIcon.Size = new System.Drawing.Size(25, 30);
            this.warningIcon.TabIndex = 9;
            this.warningIcon.TabStop = false;
            this.warningIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.warningIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.warningIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // descritpionLabel
            // 
            this.descritpionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descritpionLabel.ForeColor = System.Drawing.Color.White;
            this.descritpionLabel.Location = new System.Drawing.Point(39, 68);
            this.descritpionLabel.Name = "descritpionLabel";
            this.descritpionLabel.Size = new System.Drawing.Size(325, 24);
            this.descritpionLabel.TabIndex = 16;
            this.descritpionLabel.Text = "Help description";
            // 
            // dayBox
            // 
            this.dayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBox.ForeColor = System.Drawing.Color.White;
            this.dayBox.Location = new System.Drawing.Point(86, 125);
            this.dayBox.MaxLength = 2;
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(75, 27);
            this.dayBox.TabIndex = 15;
            this.dayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_OnKeyPress);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(254, 182);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 45);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(122, 182);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 45);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.ForeColor = System.Drawing.Color.White;
            this.yearBox.Location = new System.Drawing.Point(267, 125);
            this.yearBox.MaxLength = 4;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(75, 27);
            this.yearBox.TabIndex = 17;
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_OnKeyPress);
            // 
            // monthBox
            // 
            this.monthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.monthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBox.ForeColor = System.Drawing.Color.White;
            this.monthBox.Location = new System.Drawing.Point(175, 125);
            this.monthBox.MaxLength = 2;
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(75, 27);
            this.monthBox.TabIndex = 18;
            this.monthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_OnKeyPress);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(102)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.roundButton1.Location = new System.Drawing.Point(361, 7);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(27, 27);
            this.roundButton1.TabIndex = 12;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(393, 243);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.descritpionLabel);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DateEditor";
            this.Text = "DateEditor";
            this.headPanel.ResumeLayout(false);
            this.leftHeadPanel.ResumeLayout(false);
            this.leftHeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Panel leftHeadPanel;
        private System.Windows.Forms.PictureBox warningIcon;
        private System.Windows.Forms.Label descritpionLabel;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox monthBox;
        private RoundButton roundButton1;
    }
}