namespace mobile_store
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtPic = new PictureBox();
            txtName = new Label();
            txtRating = new Guna.UI2.WinForms.Guna2RatingStar();
            txtPrice = new Label();
            btnDetails = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)txtPic).BeginInit();
            SuspendLayout();
            // 
            // txtPic
            // 
            txtPic.BackColor = Color.WhiteSmoke;
            txtPic.Image = (Image)resources.GetObject("txtPic.Image");
            txtPic.Location = new Point(43, 3);
            txtPic.Name = "txtPic";
            txtPic.Size = new Size(120, 115);
            txtPic.SizeMode = PictureBoxSizeMode.Zoom;
            txtPic.TabIndex = 0;
            txtPic.TabStop = false;
            txtPic.Click += txtPic_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(47, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(116, 38);
            txtName.TabIndex = 1;
            txtName.Text = " Product Name";
            txtName.TextAlign = ContentAlignment.MiddleCenter;
            txtName.Click += label1_Click;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(43, 162);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(120, 38);
            txtRating.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Arial Narrow", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(43, 203);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(120, 39);
            txtPrice.TabIndex = 4;
            txtPrice.Text = "192,250";
            txtPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDetails
            // 
            btnDetails.AutoRoundedCorners = true;
            btnDetails.CustomizableEdges = customizableEdges1;
            btnDetails.DisabledState.BorderColor = Color.DarkGray;
            btnDetails.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDetails.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDetails.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnDetails.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDetails.Font = new Font("Segoe UI", 9F);
            btnDetails.ForeColor = Color.White;
            btnDetails.Location = new Point(43, 245);
            btnDetails.Name = "btnDetails";
            btnDetails.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDetails.Size = new Size(120, 39);
            btnDetails.TabIndex = 5;
            btnDetails.Text = "Details";
            btnDetails.Click += btnDetails_Click;
            // 
            // ucProduct
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(btnDetails);
            Controls.Add(txtPrice);
            Controls.Add(txtRating);
            Controls.Add(txtName);
            Controls.Add(txtPic);
            Name = "ucProduct";
            Size = new Size(192, 287);
            MouseEnter += ucProduct_MouseEnter;
            MouseLeave += ucProduct_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)txtPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox txtPic;
        private Label txtName;
        private Guna.UI2.WinForms.Guna2RatingStar txtRating;
        private Label txtPrice;
        private Guna.UI2.WinForms.Guna2GradientButton btnDetails;
    }
}
