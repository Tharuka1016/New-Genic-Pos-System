namespace NewGenicPos.Views
{
    partial class FormForgotPassword
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPassword));
            btnResetPassword = new Button();
            txtPassword = new TextBox();
            txtEmail = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            picClose = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.FromArgb(22, 67, 108);
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI Semibold", 9F);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(140, 420);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(291, 38);
            btnResetPassword.TabIndex = 1;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 344);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(288, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Segoe UI Semibold", 9F);
            txtEmail.Location = new Point(140, 326);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(36, 15);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(140, 284);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 23);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F);
            label2.Location = new Point(137, 266);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(178, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 212);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 17);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 0;
            label1.Text = "New Genic Computer| Forgot Password";
            label1.Click += label1_Click;
            // 
            // guna2HtmlToolTip1
            // 
            guna2HtmlToolTip1.AllowLinksHandling = true;
            guna2HtmlToolTip1.MaximumSize = new Size(0, 0);
            // 
            // picClose
            // 
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(520, 7);
            picClose.Name = "picClose";
            picClose.Size = new Size(35, 35);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 19;
            picClose.TabStop = false;
            guna2HtmlToolTip1.SetToolTip(picClose, "Close");
            picClose.Click += picClose_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = btnResetPassword;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // FormForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(567, 580);
            Controls.Add(picClose);
            Controls.Add(btnResetPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Genic Computers | Forgot Password";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResetPassword;
        private TextBox txtPassword;
        private Label txtEmail;
        private TextBox txtUsername;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private PictureBox picClose;
    }
}