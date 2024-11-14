namespace QuanLiMayBay
{
    partial class SuaMayBay
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
            txtNamSanXuat = new TextBox();
            txtTenMayBay = new TextBox();
            btnSuaMayBay = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSoGioBay = new TextBox();
            SuspendLayout();
            // 
            // txtNamSanXuat
            // 
            txtNamSanXuat.Location = new Point(200, 118);
            txtNamSanXuat.Name = "txtNamSanXuat";
            txtNamSanXuat.Size = new Size(177, 27);
            txtNamSanXuat.TabIndex = 12;
            // 
            // txtTenMayBay
            // 
            txtTenMayBay.Location = new Point(200, 51);
            txtTenMayBay.Name = "txtTenMayBay";
            txtTenMayBay.Size = new Size(177, 27);
            txtTenMayBay.TabIndex = 11;
            // 
            // btnSuaMayBay
            // 
            btnSuaMayBay.Location = new Point(149, 249);
            btnSuaMayBay.Name = "btnSuaMayBay";
            btnSuaMayBay.Size = new Size(127, 46);
            btnSuaMayBay.TabIndex = 10;
            btnSuaMayBay.Text = "Sửa máy bay";
            btnSuaMayBay.UseVisualStyleBackColor = true;
            btnSuaMayBay.Click += btnSua_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 187);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 9;
            label3.Text = "Số giờ bay:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 121);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 8;
            label2.Text = "Năm sản xuất:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 55);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên máy bay:";
            // 
            // txtSoGioBay
            // 
            txtSoGioBay.Location = new Point(200, 184);
            txtSoGioBay.Name = "txtSoGioBay";
            txtSoGioBay.Size = new Size(177, 27);
            txtSoGioBay.TabIndex = 13;
            // 
            // SuaMayBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 322);
            Controls.Add(txtSoGioBay);
            Controls.Add(txtNamSanXuat);
            Controls.Add(txtTenMayBay);
            Controls.Add(btnSuaMayBay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SuaMayBay";
            Text = "SuaMayBay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNamSanXuat;
        private TextBox txtTenMayBay;
        private Button btnSuaMayBay;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSoGioBay;
    }
}