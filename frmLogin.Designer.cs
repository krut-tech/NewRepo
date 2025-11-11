namespace mobile_store
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            lable2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(60, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 339);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(530, 24);
            label1.Name = "label1";
            label1.Size = new Size(150, 60);
            label1.TabIndex = 5;
            label1.Text = "loging";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(455, 224);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(291, 30);
            txtUser.TabIndex = 0;
            txtUser.Tag = "def";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(455, 317);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(291, 30);
            txtPass.TabIndex = 1;
            txtPass.Tag = "123";
            txtPass.UseSystemPasswordChar = true;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Location = new Point(455, 179);
            lable2.Name = "lable2";
            lable2.Size = new Size(90, 23);
            lable2.TabIndex = 3;
            lable2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 278);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 4;
            label3.Text = "PassWord";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(473, 391);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 52);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "loging";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 650);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(lable2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lable2;
        private Label label3;
        private Button btnLogin;
    }
}
