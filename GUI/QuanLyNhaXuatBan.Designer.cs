﻿namespace GUI
{
    partial class QuanLyNhaXuatBan
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
            btnhienthi = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtemail = new TextBox();
            label4 = new Label();
            txtdiachi = new TextBox();
            label2 = new Label();
            txtSoDienThoai = new TextBox();
            txttennhaxuatban = new TextBox();
            txtmanhaxuatban = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(156, 474);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 150;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            btnhienthi.Click += btnhienthi_Click;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(413, 474);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 148;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(280, 474);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 147;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(192, 330);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(462, 27);
            txtemail.TabIndex = 146;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(52, 267);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 145;
            label4.Text = "Số Điện Thoại";
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(192, 187);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(462, 27);
            txtdiachi.TabIndex = 144;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(51, 194);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 143;
            label2.Text = "Địa Chỉ";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(192, 260);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(462, 27);
            txtSoDienThoai.TabIndex = 142;
            // 
            // txttennhaxuatban
            // 
            txttennhaxuatban.Location = new Point(192, 120);
            txttennhaxuatban.Name = "txttennhaxuatban";
            txttennhaxuatban.Size = new Size(462, 27);
            txttennhaxuatban.TabIndex = 141;
            // 
            // txtmanhaxuatban
            // 
            txtmanhaxuatban.Location = new Point(192, 48);
            txtmanhaxuatban.Name = "txtmanhaxuatban";
            txtmanhaxuatban.Size = new Size(462, 27);
            txtmanhaxuatban.TabIndex = 140;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(51, 337);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 139;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(42, 123);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 138;
            label3.Text = " Tên Nhà Xuất Bản ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(52, 54);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 137;
            label1.Text = "Mã Nhà Xuất Bản ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(727, 486);
            dataGridView1.TabIndex = 129;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(773, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(745, 613);
            groupBox1.TabIndex = 139;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Nhà Xuất Bản";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(150, 48);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo Nhà Xuất Bản ";
            txtTimKiem.Size = new Size(401, 27);
            txtTimKiem.TabIndex = 128;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(39, 51);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 127;
            label8.Text = "Tìm Kiếm ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnhienthi);
            groupBox2.Controls.Add(btnsua);
            groupBox2.Controls.Add(btnthem);
            groupBox2.Controls.Add(txtemail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtdiachi);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSoDienThoai);
            groupBox2.Controls.Add(txttennhaxuatban);
            groupBox2.Controls.Add(txtmanhaxuatban);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(8, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(742, 613);
            groupBox2.TabIndex = 140;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Nhà Xuất Bản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(612, 18);
            label6.Name = "label6";
            label6.Size = new Size(312, 38);
            label6.TabIndex = 151;
            label6.Text = "Quản Lý Nhà Xuất Bản";
            // 
            // QuanLyNhaXuatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "QuanLyNhaXuatBan";
            Size = new Size(1521, 776);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnhienthi;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtemail;
        private Label label4;
        private TextBox txtdiachi;
        private Label label2;
        private TextBox txtSoDienThoai;
        private TextBox txttennhaxuatban;
        private TextBox txtmanhaxuatban;
        private Label label5;
        private Label label3;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtTimKiem;
        private Label label8;
        private GroupBox groupBox2;
        private Label label6;
    }
}
