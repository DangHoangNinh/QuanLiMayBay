namespace QuanLiMayBay
{
    partial class MayBay
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
            dataGridViewMayBay = new DataGridView();
            btnThemMayBay = new Button();
            btnSuaMayBay = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMayBay).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMayBay
            // 
            dataGridViewMayBay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMayBay.Location = new Point(12, 57);
            dataGridViewMayBay.Name = "dataGridViewMayBay";
            dataGridViewMayBay.RowHeadersWidth = 51;
            dataGridViewMayBay.Size = new Size(625, 171);
            dataGridViewMayBay.TabIndex = 0;
            // 
            // btnThemMayBay
            // 
            btnThemMayBay.Location = new Point(141, 259);
            btnThemMayBay.Name = "btnThemMayBay";
            btnThemMayBay.Size = new Size(125, 43);
            btnThemMayBay.TabIndex = 1;
            btnThemMayBay.Text = "Thêm máy bay";
            btnThemMayBay.UseVisualStyleBackColor = true;
            btnThemMayBay.Click += btnThemMayBay_Click;
            // 
            // btnSuaMayBay
            // 
            btnSuaMayBay.Location = new Point(359, 259);
            btnSuaMayBay.Name = "btnSuaMayBay";
            btnSuaMayBay.Size = new Size(125, 43);
            btnSuaMayBay.TabIndex = 2;
            btnSuaMayBay.Text = "Sửa máy bay";
            btnSuaMayBay.UseVisualStyleBackColor = true;
            btnSuaMayBay.Click += btnSuaMayBay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(227, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 3;
            label1.Text = "Quản Lí Máy Bay";
            // 
            // MayBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 314);
            Controls.Add(label1);
            Controls.Add(btnSuaMayBay);
            Controls.Add(btnThemMayBay);
            Controls.Add(dataGridViewMayBay);
            Name = "MayBay";
            Text = "MayBay";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMayBay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMayBay;
        private Button btnThemMayBay;
        private Button btnSuaMayBay;
        private Label label1;
    }
}