namespace mobile_store
{
    partial class frmMain
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
            panel1 = new Panel();
            Centerpanel = new Panel();
            panel3 = new Panel();
            btnDashboard = new Button();
            btnSetting = new Button();
            btnPOS = new Button();
            btnProduct = new Button();
            btnPrintInvoice = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 45);
            panel1.TabIndex = 0;
            // 
            // Centerpanel
            // 
            Centerpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Centerpanel.Location = new Point(12, 63);
            Centerpanel.Name = "Centerpanel";
            Centerpanel.Size = new Size(1136, 453);
            Centerpanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(btnPrintInvoice);
            panel3.Controls.Add(btnDashboard);
            panel3.Controls.Add(btnSetting);
            panel3.Controls.Add(btnPOS);
            panel3.Controls.Add(btnProduct);
            panel3.Location = new Point(12, 522);
            panel3.Name = "panel3";
            panel3.Size = new Size(1136, 139);
            panel3.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DodgerBlue;
            btnDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(25, 27);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(124, 101);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.DodgerBlue;
            btnSetting.Location = new Point(511, 27);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(124, 101);
            btnSetting.TabIndex = 3;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnPOS
            // 
            btnPOS.BackColor = Color.DodgerBlue;
            btnPOS.Location = new Point(346, 27);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(124, 101);
            btnPOS.TabIndex = 2;
            btnPOS.Text = "POS";
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.DodgerBlue;
            btnProduct.Location = new Point(183, 27);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(124, 101);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = Color.DodgerBlue;
            btnPrintInvoice.Location = new Point(663, 27);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(124, 101);
            btnPrintInvoice.TabIndex = 4;
            btnPrintInvoice.Text = "btnPrintInvoice";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 673);
            Controls.Add(panel3);
            Controls.Add(Centerpanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Centerpanel;
        private Panel panel3;
        private Button btnDashboard;
        private Button btnSetting;
        private Button btnPOS;
        private Button btnProduct;
        private Button btnPrintInvoice;
    }
}