namespace ChatApp
{
    partial class POPUPWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POPUPWindow));
            this.DragPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.IPLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ThemeField = new System.Windows.Forms.DomainUpDown();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.MaskedTextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BoxIP = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PortBox = new System.Windows.Forms.NumericUpDown();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.DragPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DragPanel
            // 
            this.DragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.DragPanel.Controls.Add(this.panel5);
            this.DragPanel.Location = new System.Drawing.Point(250, 9);
            this.DragPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(99, 30);
            this.DragPanel.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.CloseWindowButton);
            this.panel5.Location = new System.Drawing.Point(17, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(82, 30);
            this.panel5.TabIndex = 5;
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseWindowButton.BackgroundImage")));
            this.CloseWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseWindowButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseWindowButton.FlatAppearance.BorderSize = 0;
            this.CloseWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindowButton.Location = new System.Drawing.Point(55, 7);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(20, 20);
            this.CloseWindowButton.TabIndex = 2;
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // IPLabel
            // 
            this.IPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IPLabel.AutoSize = true;
            this.IPLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IPLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.IPLabel.Location = new System.Drawing.Point(12, 129);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.IPLabel.Size = new System.Drawing.Size(146, 21);
            this.IPLabel.TabIndex = 4;
            this.IPLabel.Text = "Your IP address: ";
            // 
            // PortLabel
            // 
            this.PortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PortLabel.AutoSize = true;
            this.PortLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PortLabel.Location = new System.Drawing.Point(12, 96);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PortLabel.Size = new System.Drawing.Size(157, 21);
            this.PortLabel.TabIndex = 5;
            this.PortLabel.Text = "Port(1024-65535): ";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogoLabel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.ThemeField);
            this.panel1.Controls.Add(this.ThemeLabel);
            this.panel1.Controls.Add(this.NameField);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.BoxIP);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PortBox);
            this.panel1.Controls.Add(this.DragPanel);
            this.panel1.Controls.Add(this.PortLabel);
            this.panel1.Controls.Add(this.IPLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 199);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Location = new System.Drawing.Point(228, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 23);
            this.panel3.TabIndex = 17;
            // 
            // ThemeField
            // 
            this.ThemeField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThemeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ThemeField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThemeField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeField.ForeColor = System.Drawing.Color.Lime;
            this.ThemeField.Items.Add("Blue");
            this.ThemeField.Items.Add("Red");
            this.ThemeField.Items.Add("Orange");
            this.ThemeField.Items.Add("Green");
            this.ThemeField.Items.Add("Indigo");
            this.ThemeField.Location = new System.Drawing.Point(137, 162);
            this.ThemeField.Name = "ThemeField";
            this.ThemeField.ReadOnly = true;
            this.ThemeField.Size = new System.Drawing.Size(120, 23);
            this.ThemeField.TabIndex = 16;
            this.ThemeField.Text = "Blue";
            this.ThemeField.SelectedItemChanged += new System.EventHandler(this.ThemeField_SelectedItemChanged);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ThemeLabel.Location = new System.Drawing.Point(12, 162);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ThemeLabel.Size = new System.Drawing.Size(119, 21);
            this.ThemeLabel.TabIndex = 15;
            this.ThemeLabel.Text = "App theme: ";
            // 
            // NameField
            // 
            this.NameField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.NameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.ForeColor = System.Drawing.Color.Lime;
            this.NameField.Location = new System.Drawing.Point(123, 63);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(126, 20);
            this.NameField.TabIndex = 14;
            this.NameField.Text = "User";
            this.NameField.VisibleChanged += new System.EventHandler(this.NameField_VisibleChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.NameLabel.Location = new System.Drawing.Point(19, 63);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(104, 21);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Your name: ";
            // 
            // BoxIP
            // 
            this.BoxIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BoxIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BoxIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxIP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxIP.ForeColor = System.Drawing.Color.Lime;
            this.BoxIP.Location = new System.Drawing.Point(160, 129);
            this.BoxIP.Name = "BoxIP";
            this.BoxIP.Size = new System.Drawing.Size(126, 20);
            this.BoxIP.TabIndex = 12;
            this.BoxIP.TextChanged += new System.EventHandler(this.BoxIP_ValueChanged);
            this.BoxIP.Leave += new System.EventHandler(this.BoxIP_TextControl);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Location = new System.Drawing.Point(231, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 22);
            this.panel2.TabIndex = 10;
            // 
            // PortBox
            // 
            this.PortBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortBox.ForeColor = System.Drawing.Color.Lime;
            this.PortBox.Location = new System.Drawing.Point(175, 96);
            this.PortBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortBox.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(94, 22);
            this.PortBox.TabIndex = 9;
            this.PortBox.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.PortBox.ValueChanged += new System.EventHandler(this.PortBox_ValueChanged);
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LogoLabel.Location = new System.Drawing.Point(17, 16);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(119, 33);
            this.LogoLabel.TabIndex = 18;
            this.LogoLabel.Text = "WFChat";
            // 
            // POPUPWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(358, 199);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POPUPWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POPUPWindow";
            this.DragPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown PortBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox BoxIP;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.MaskedTextBox NameField;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.DomainUpDown ThemeField;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LogoLabel;
    }
}