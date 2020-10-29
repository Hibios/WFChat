namespace ChatApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MessageButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.HideWindowButton = new System.Windows.Forms.Button();
            this.ResizeWindowButton = new System.Windows.Forms.Button();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.UsersList = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.SendPanel = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.ServerTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SendPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.MenuPanel.Controls.Add(this.MessageButton);
            this.MenuPanel.Controls.Add(this.ProfileButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(60, 400);
            this.MenuPanel.TabIndex = 1;
            // 
            // MessageButton
            // 
            this.MessageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MessageButton.BackgroundImage")));
            this.MessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MessageButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MessageButton.FlatAppearance.BorderSize = 0;
            this.MessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageButton.Location = new System.Drawing.Point(14, 56);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(34, 34);
            this.MessageButton.TabIndex = 6;
            this.MessageButton.UseVisualStyleBackColor = true;
            this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileButton.BackgroundImage")));
            this.ProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Location = new System.Drawing.Point(14, 14);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(5);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(34, 34);
            this.ProfileButton.TabIndex = 1;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.HideWindowButton);
            this.panel5.Controls.Add(this.ResizeWindowButton);
            this.panel5.Controls.Add(this.CloseWindowButton);
            this.panel5.Location = new System.Drawing.Point(558, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(82, 30);
            this.panel5.TabIndex = 5;
            // 
            // HideWindowButton
            // 
            this.HideWindowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HideWindowButton.BackgroundImage")));
            this.HideWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HideWindowButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HideWindowButton.FlatAppearance.BorderSize = 0;
            this.HideWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideWindowButton.Location = new System.Drawing.Point(3, 7);
            this.HideWindowButton.Name = "HideWindowButton";
            this.HideWindowButton.Size = new System.Drawing.Size(20, 20);
            this.HideWindowButton.TabIndex = 4;
            this.HideWindowButton.UseVisualStyleBackColor = true;
            this.HideWindowButton.Click += new System.EventHandler(this.HideWindowButton_Click);
            // 
            // ResizeWindowButton
            // 
            this.ResizeWindowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResizeWindowButton.BackgroundImage")));
            this.ResizeWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResizeWindowButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResizeWindowButton.FlatAppearance.BorderSize = 0;
            this.ResizeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResizeWindowButton.Location = new System.Drawing.Point(29, 7);
            this.ResizeWindowButton.Name = "ResizeWindowButton";
            this.ResizeWindowButton.Size = new System.Drawing.Size(20, 20);
            this.ResizeWindowButton.TabIndex = 3;
            this.ResizeWindowButton.UseVisualStyleBackColor = true;
            this.ResizeWindowButton.Click += new System.EventHandler(this.ResizeWindowButton_Click);
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
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.DragPanel.Controls.Add(this.panel5);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(60, 0);
            this.DragPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(640, 30);
            this.DragPanel.TabIndex = 2;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.DragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ContentPanel.Controls.Add(this.StartServerButton);
            this.ContentPanel.Controls.Add(this.ConnectButton);
            this.ContentPanel.Controls.Add(this.panel2);
            this.ContentPanel.Controls.Add(this.UsersList);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContentPanel.Location = new System.Drawing.Point(60, 30);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(145, 370);
            this.ContentPanel.TabIndex = 3;
            // 
            // StartServerButton
            // 
            this.StartServerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartServerButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartServerButton.ForeColor = System.Drawing.Color.White;
            this.StartServerButton.Location = new System.Drawing.Point(6, 78);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(133, 30);
            this.StartServerButton.TabIndex = 9;
            this.StartServerButton.Text = "Start Server";
            this.ServerTip.SetToolTip(this.StartServerButton, "Start the server at your local address");
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Location = new System.Drawing.Point(6, 42);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(133, 30);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.NameBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AddUserButton);
            this.panel2.Controls.Add(this.PortBox);
            this.panel2.Controls.Add(this.AddressBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 211);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Friend name: ";
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Location = new System.Drawing.Point(6, 40);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(133, 20);
            this.NameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address: ";
            // 
            // AddUserButton
            // 
            this.AddUserButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserButton.ForeColor = System.Drawing.Color.White;
            this.AddUserButton.Location = new System.Drawing.Point(6, 175);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(133, 30);
            this.AddUserButton.TabIndex = 3;
            this.AddUserButton.Text = "Add friend";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // PortBox
            // 
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortBox.Location = new System.Drawing.Point(6, 134);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(133, 20);
            this.PortBox.TabIndex = 2;
            // 
            // AddressBox
            // 
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressBox.Location = new System.Drawing.Point(6, 87);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(133, 20);
            this.AddressBox.TabIndex = 1;
            // 
            // UsersList
            // 
            this.UsersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersList.FormattingEnabled = true;
            this.UsersList.Location = new System.Drawing.Point(7, 7);
            this.UsersList.MaxDropDownItems = 100;
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(132, 29);
            this.UsersList.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.SendPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(205, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 370);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.MessageBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(495, 331);
            this.panel3.TabIndex = 2;
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MessageBox.Location = new System.Drawing.Point(10, 10);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.Size = new System.Drawing.Size(475, 311);
            this.MessageBox.TabIndex = 1;
            this.MessageBox.Text = "";
            // 
            // SendPanel
            // 
            this.SendPanel.Controls.Add(this.SendButton);
            this.SendPanel.Controls.Add(this.MessageText);
            this.SendPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SendPanel.Location = new System.Drawing.Point(0, 331);
            this.SendPanel.Name = "SendPanel";
            this.SendPanel.Size = new System.Drawing.Size(495, 39);
            this.SendPanel.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SendButton.Location = new System.Drawing.Point(413, 0);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(82, 39);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.Location = new System.Drawing.Point(0, 0);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(414, 39);
            this.MessageText.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.MenuPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.DragPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.SendPanel.ResumeLayout(false);
            this.SendPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button MessageButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button HideWindowButton;
        private System.Windows.Forms.Button ResizeWindowButton;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SendPanel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.ComboBox UsersList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.ToolTip ServerTip;
        private System.Windows.Forms.RichTextBox MessageBox;
        private System.Windows.Forms.Panel panel3;
    }
}

