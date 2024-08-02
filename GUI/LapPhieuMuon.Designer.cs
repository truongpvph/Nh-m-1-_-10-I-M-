namespace GUI
{
    partial class LapPhieuMuon
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
            btnChiTiet = new Button();
            label10 = new Label();
            datengaytra = new DateTimePicker();
            label5 = new Label();
            dateNgaymuon = new DateTimePicker();
            label7 = new Label();
            dgvPhieuChitiet = new DataGridView();
            txtghichu = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            cbbPhieuMuon = new ComboBox();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            dgvSach = new DataGridView();
            txtTimKiemSach = new TextBox();
            label4 = new Label();
            txtMaPhieuMuon = new TextBox();
            label9 = new Label();
            txtSDT = new TextBox();
            label1 = new Label();
            txtMaDocGia = new TextBox();
            dgvPhieuMuon = new DataGridView();
            cbbmataikhoan = new ComboBox();
            label2 = new Label();
            btnhienthi = new Button();
            btnsua = new Button();
            btnTaoPhieuMuon = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChitiet).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.FromArgb(255, 192, 128);
            btnChiTiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChiTiet.Location = new Point(460, 645);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(94, 29);
            btnChiTiet.TabIndex = 153;
            btnChiTiet.Text = "Tạo";
            btnChiTiet.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(275, 645);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 134;
            label10.Text = "VND";
            // 
            // datengaytra
            // 
            datengaytra.Location = new Point(144, 518);
            datengaytra.Name = "datengaytra";
            datengaytra.Size = new Size(308, 27);
            datengaytra.TabIndex = 128;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(19, 516);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 127;
            label5.Text = "Ngày Ngày trả";
            // 
            // dateNgaymuon
            // 
            dateNgaymuon.Location = new Point(144, 471);
            dateNgaymuon.Name = "dateNgaymuon";
            dateNgaymuon.Size = new Size(308, 27);
            dateNgaymuon.TabIndex = 126;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(24, 645);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 125;
            label7.Text = "Tổng Tiền";
            // 
            // dgvPhieuChitiet
            // 
            dgvPhieuChitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuChitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuChitiet.Location = new Point(19, 69);
            dgvPhieuChitiet.Name = "dgvPhieuChitiet";
            dgvPhieuChitiet.RowHeadersWidth = 51;
            dgvPhieuChitiet.Size = new Size(545, 382);
            dgvPhieuChitiet.TabIndex = 0;
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(6, 26);
            txtghichu.Multiline = true;
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(387, 37);
            txtghichu.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(144, 642);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 156;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(19, 28);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 155;
            label8.Text = "Phiếu mượn";
            // 
            // cbbPhieuMuon
            // 
            cbbPhieuMuon.FormattingEnabled = true;
            cbbPhieuMuon.Location = new Point(144, 26);
            cbbPhieuMuon.Name = "cbbPhieuMuon";
            cbbPhieuMuon.Size = new Size(343, 28);
            cbbPhieuMuon.TabIndex = 154;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtghichu);
            groupBox4.Location = new Point(24, 562);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(420, 69);
            groupBox4.TabIndex = 147;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ghi Chú ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(cbbPhieuMuon);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(btnChiTiet);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(datengaytra);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dateNgaymuon);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dgvPhieuChitiet);
            groupBox3.Location = new Point(488, 147);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(575, 683);
            groupBox3.TabIndex = 149;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách chọn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(18, 476);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 124;
            label6.Text = "Ngày Mượn";
            // 
            // dgvSach
            // 
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(6, 69);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(598, 601);
            dgvSach.TabIndex = 155;
            // 
            // txtTimKiemSach
            // 
            txtTimKiemSach.Location = new Point(115, 21);
            txtTimKiemSach.Name = "txtTimKiemSach";
            txtTimKiemSach.PlaceholderText = "Tìm kiếm dựa theo tên sách";
            txtTimKiemSach.Size = new Size(321, 27);
            txtTimKiemSach.TabIndex = 154;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(33, 24);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 153;
            label4.Text = "Tìm Kiếm";
            // 
            // txtMaPhieuMuon
            // 
            txtMaPhieuMuon.Enabled = false;
            txtMaPhieuMuon.Location = new Point(152, 74);
            txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            txtMaPhieuMuon.Size = new Size(207, 27);
            txtMaPhieuMuon.TabIndex = 158;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(26, 72);
            label9.Name = "label9";
            label9.Size = new Size(120, 20);
            label9.TabIndex = 157;
            label9.Text = "Mã phiếu mượn";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(152, 178);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(207, 27);
            txtSDT.TabIndex = 156;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 176);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 155;
            label1.Text = "Số điện thoại";
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.Enabled = false;
            txtMaDocGia.Location = new Point(152, 226);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.Size = new Size(207, 27);
            txtMaDocGia.TabIndex = 154;
            // 
            // dgvPhieuMuon
            // 
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuon.Location = new Point(6, 310);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.RowHeadersWidth = 51;
            dgvPhieuMuon.Size = new Size(467, 360);
            dgvPhieuMuon.TabIndex = 153;
            // 
            // cbbmataikhoan
            // 
            cbbmataikhoan.FormattingEnabled = true;
            cbbmataikhoan.Location = new Point(152, 121);
            cbbmataikhoan.Name = "cbbmataikhoan";
            cbbmataikhoan.Size = new Size(207, 28);
            cbbmataikhoan.TabIndex = 152;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 224);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 150;
            label2.Text = "Tên Độc Giả";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(49, 269);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 149;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(278, 269);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 148;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnTaoPhieuMuon
            // 
            btnTaoPhieuMuon.BackColor = Color.FromArgb(255, 192, 128);
            btnTaoPhieuMuon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaoPhieuMuon.Location = new Point(168, 269);
            btnTaoPhieuMuon.Name = "btnTaoPhieuMuon";
            btnTaoPhieuMuon.Size = new Size(94, 29);
            btnTaoPhieuMuon.TabIndex = 147;
            btnTaoPhieuMuon.Text = "Tạo";
            btnTaoPhieuMuon.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 124);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 145;
            label3.Text = "Tên nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSach);
            groupBox2.Controls.Add(txtTimKiemSach);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(1069, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(610, 683);
            groupBox2.TabIndex = 148;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Phiếu Mượn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaPhieuMuon);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaDocGia);
            groupBox1.Controls.Add(dgvPhieuMuon);
            groupBox1.Controls.Add(cbbmataikhoan);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnhienthi);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnTaoPhieuMuon);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(5, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 683);
            groupBox1.TabIndex = 147;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phiếu Mượn";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(632, 15);
            label11.Name = "label11";
            label11.Size = new Size(234, 38);
            label11.TabIndex = 159;
            label11.Text = "Lập Phiếu Mượn";
            // 
            // LapPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label11);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LapPhieuMuon";
            Size = new Size(1705, 887);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuChitiet).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChiTiet;
        private Label label10;
        private DateTimePicker datengaytra;
        private Label label5;
        private DateTimePicker dateNgaymuon;
        private Label label7;
        private DataGridView dgvPhieuChitiet;
        private TextBox txtghichu;
        private TextBox textBox1;
        private Label label8;
        private ComboBox cbbPhieuMuon;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label6;
        private DataGridView dgvSach;
        private TextBox txtTimKiemSach;
        private Label label4;
        private TextBox txtMaPhieuMuon;
        private Label label9;
        private TextBox txtSDT;
        private Label label1;
        private TextBox txtMaDocGia;
        private DataGridView dgvPhieuMuon;
        private ComboBox cbbmataikhoan;
        private Label label2;
        private Button btnhienthi;
        private Button btnsua;
        private Button btnTaoPhieuMuon;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label11;
    }
}
