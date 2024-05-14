namespace NewGenicPos.Views
{
    partial class FormLogin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            picClose = new PictureBox();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            picHide = new PictureBox();
            lblForgotPassword = new Label();
            btnLogIn = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            picShow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShow).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 22);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 0;
            label1.Text = "New Genic Computer| Log In";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(175, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 212);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // picClose
            // 
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(519, 12);
            picClose.Name = "picClose";
            picClose.Size = new Size(35, 35);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 3;
            picClose.TabStop = false;
            guna2HtmlToolTip1.SetToolTip(picClose, "Close");
            picClose.Click += picClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F);
            label2.Location = new Point(134, 271);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(137, 289);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(140, 349);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(269, 23);
            txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F);
            label3.Location = new Point(137, 331);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // picHide
            // 
            picHide.Image = (Image)resources.GetObject("picHide.Image");
            picHide.Location = new Point(405, 349);
            picHide.Name = "picHide";
            picHide.Size = new Size(23, 23);
            picHide.SizeMode = PictureBoxSizeMode.Zoom;
            picHide.TabIndex = 8;
            picHide.TabStop = false;
            guna2HtmlToolTip1.SetToolTip(picHide, "Hide Password");
            picHide.Visible = false;
            picHide.Click += picHide_Click;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Font = new Font("Segoe UI Semibold", 9F);
            lblForgotPassword.ForeColor = Color.DarkTurquoise;
            lblForgotPassword.Location = new Point(239, 387);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(100, 15);
            lblForgotPassword.TabIndex = 0;
            lblForgotPassword.Text = "Forgot Password?";
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(22, 67, 108);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI Semibold", 9F);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(137, 425);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(291, 38);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = btnLogIn;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2HtmlToolTip1
            // 
            guna2HtmlToolTip1.AllowLinksHandling = true;
            guna2HtmlToolTip1.MaximumSize = new Size(0, 0);
            // 
            // picShow
            // 
            picShow.Image = (Image)resources.GetObject("picShow.Image");
            picShow.Location = new Point(460, 323);
            picShow.Name = "picShow";
            picShow.Size = new Size(23, 23);
            picShow.SizeMode = PictureBoxSizeMode.Zoom;
            picShow.TabIndex = 9;
            picShow.TabStop = false;
            guna2HtmlToolTip1.SetToolTip(picShow, "Hide Password");
            picShow.Click += picShow_Click;
            // 
            // FormLogin1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(551, 505);
            Controls.Add(picShow);
            Controls.Add(btnLogIn);
            Controls.Add(lblForgotPassword);
            Controls.Add(picHide);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(picClose);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Genic Computers | Log In";
            Load += FormLogin1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox picClose;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private PictureBox picHide;
        private Label lblForgotPassword;
        private Button btnLogIn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private PictureBox picShow;
    }
}