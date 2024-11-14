namespace QuanLiMayBay
{
    partial class ThemMayBay
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThemMayBay = new Button();
            txtTenMayBay = new TextBox();
            txtNamSanXuat = new TextBox();
            txtSoGioBay = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 45);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên máy bay:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 111);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Năm sản xuất:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 177);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Số giờ bay:";
            // 
            // btnThemMayBay
            // 
            btnThemMayBay.Location = new Point(129, 239);
            btnThemMayBay.Name = "btnThemMayBay";
            btnThemMayBay.Size = new Size(127, 46);
            btnThemMayBay.TabIndex = 3;
            btnThemMayBay.Text = "Thêm máy bay";
            btnThemMayBay.UseVisualStyleBackColor = true;
            btnThemMayBay.Click += btnThem_Click;
            // 
            // txtTenMayBay
            // 
            txtTenMayBay.Location = new Point(180, 41);
            txtTenMayBay.Name = "txtTenMayBay";
            txtTenMayBay.Size = new Size(177, 27);
            txtTenMayBay.TabIndex = 4;
            // 
            // txtNamSanXuat
            // 
            txtNamSanXuat.Location = new Point(180, 108);
            txtNamSanXuat.Name = "txtNamSanXuat";
            txtNamSanXuat.Size = new Size(177, 27);
            txtNamSanXuat.TabIndex = 5;
            // 
            // txtSoGioBay
            // 
            txtSoGioBay.Location = new Point(180, 174);
            txtSoGioBay.Name = "txtSoGioBay";
            txtSoGioBay.Size = new Size(177, 27);
            txtSoGioBay.TabIndex = 6;
            // 
            // ThemMayBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 317);
            Controls.Add(txtSoGioBay);
            Controls.Add(txtNamSanXuat);
            Controls.Add(txtTenMayBay);
            Controls.Add(btnThemMayBay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemMayBay";
            Text = "ThemMayBay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThemMayBay;
        private TextBox txtTenMayBay;
        private TextBox txtNamSanXuat;
        private TextBox txtSoGioBay;
    }
}