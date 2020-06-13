namespace DoneDoneDone
{
    partial class Form1
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
            FontAwesome.Sharp.IconButton btnAdmin;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnAboutUs = new FontAwesome.Sharp.IconButton();
            this.btnClassRoom = new FontAwesome.Sharp.IconButton();
            this.btnDocument = new FontAwesome.Sharp.IconButton();
            this.btnStudent = new FontAwesome.Sharp.IconButton();
            this.btnTeacher = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnAdmin = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdmin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            btnAdmin.ForeColor = System.Drawing.Color.White;
            btnAdmin.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnAdmin.IconColor = System.Drawing.Color.White;
            btnAdmin.IconSize = 32;
            btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAdmin.Location = new System.Drawing.Point(0, 124);
            btnAdmin.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Rotation = 0D;
            btnAdmin.Size = new System.Drawing.Size(146, 38);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnAboutUs);
            this.panelMenu.Controls.Add(this.btnClassRoom);
            this.panelMenu.Controls.Add(this.btnDocument);
            this.panelMenu.Controls.Add(this.btnStudent);
            this.panelMenu.Controls.Add(btnAdmin);
            this.panelMenu.Controls.Add(this.btnTeacher);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(146, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 314);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Rotation = 0D;
            this.btnLogout.Size = new System.Drawing.Size(146, 38);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Tag = "";
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.btnAboutUs.IconColor = System.Drawing.Color.White;
            this.btnAboutUs.IconSize = 32;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 276);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Rotation = 0D;
            this.btnAboutUs.Size = new System.Drawing.Size(146, 38);
            this.btnAboutUs.TabIndex = 7;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnClassRoom
            // 
            this.btnClassRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClassRoom.FlatAppearance.BorderSize = 0;
            this.btnClassRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassRoom.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClassRoom.ForeColor = System.Drawing.Color.White;
            this.btnClassRoom.IconChar = FontAwesome.Sharp.IconChar.Crosshairs;
            this.btnClassRoom.IconColor = System.Drawing.Color.White;
            this.btnClassRoom.IconSize = 32;
            this.btnClassRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassRoom.Location = new System.Drawing.Point(0, 238);
            this.btnClassRoom.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClassRoom.Name = "btnClassRoom";
            this.btnClassRoom.Rotation = 0D;
            this.btnClassRoom.Size = new System.Drawing.Size(146, 38);
            this.btnClassRoom.TabIndex = 6;
            this.btnClassRoom.Text = "ClassRoom";
            this.btnClassRoom.UseVisualStyleBackColor = true;
            this.btnClassRoom.Click += new System.EventHandler(this.btnClassRoom_Click);
            // 
            // btnDocument
            // 
            this.btnDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocument.FlatAppearance.BorderSize = 0;
            this.btnDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocument.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDocument.ForeColor = System.Drawing.Color.White;
            this.btnDocument.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnDocument.IconColor = System.Drawing.Color.White;
            this.btnDocument.IconSize = 32;
            this.btnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocument.Location = new System.Drawing.Point(0, 200);
            this.btnDocument.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.Rotation = 0D;
            this.btnDocument.Size = new System.Drawing.Size(146, 38);
            this.btnDocument.TabIndex = 5;
            this.btnDocument.Text = "Document";
            this.btnDocument.UseVisualStyleBackColor = true;
            this.btnDocument.Click += new System.EventHandler(this.btnDocument_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnStudent.IconColor = System.Drawing.Color.White;
            this.btnStudent.IconSize = 32;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 162);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Rotation = 0D;
            this.btnStudent.Size = new System.Drawing.Size(146, 38);
            this.btnStudent.TabIndex = 4;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnTeacher.IconColor = System.Drawing.Color.White;
            this.btnTeacher.IconSize = 32;
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Location = new System.Drawing.Point(0, 86);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Rotation = 0D;
            this.btnTeacher.Size = new System.Drawing.Size(146, 38);
            this.btnTeacher.TabIndex = 2;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Image = global::DoneDoneDone.Properties.Resources.document;
            this.btnLogo.Location = new System.Drawing.Point(12, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(124, 59);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.panelTitleBar.Controls.Add(this.iconPictureBox3);
            this.panelTitleBar.Controls.Add(this.iconPictureBox2);
            this.panelTitleBar.Controls.Add(this.iconPictureBox1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(146, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(654, 55);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconSize = 25;
            this.iconPictureBox3.Location = new System.Drawing.Point(575, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(25, 31);
            this.iconPictureBox3.TabIndex = 4;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(602, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(25, 31);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(629, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 31);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(51, 21);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Purple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Purple;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 10);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(146, 55);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(654, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(146, 65);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(654, 385);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DoneDoneDone.Properties.Resources.document;
            this.pictureBox1.Location = new System.Drawing.Point(265, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnLogo;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnAboutUs;
        private FontAwesome.Sharp.IconButton btnClassRoom;
        private FontAwesome.Sharp.IconButton btnDocument;
        private FontAwesome.Sharp.IconButton btnStudent;
        private FontAwesome.Sharp.IconButton btnTeacher;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}

