﻿namespace PhanThiNhan
{
    partial class frm_QuanLyBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyBan));
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ban = new System.Windows.Forms.Label();
            this.data_Ban = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.nud_soluong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.data_thongtinban = new System.Windows.Forms.DataGridView();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_inhoadon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chuyenban = new System.Windows.Forms.Button();
            this.cb_chuyenban = new System.Windows.Forms.ComboBox();
            this.btn_themmon = new System.Windows.Forms.Button();
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.cb_danhmuc = new System.Windows.Forms.ComboBox();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.data_Ban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_thongtinban)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.Red;
            this.lbl_id.Location = new System.Drawing.Point(868, 301);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 24);
            this.lbl_id.TabIndex = 27;
            // 
            // lbl_ban
            // 
            this.lbl_ban.AutoSize = true;
            this.lbl_ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ban.ForeColor = System.Drawing.Color.Red;
            this.lbl_ban.Location = new System.Drawing.Point(451, 301);
            this.lbl_ban.Name = "lbl_ban";
            this.lbl_ban.Size = new System.Drawing.Size(190, 24);
            this.lbl_ban.TabIndex = 28;
            this.lbl_ban.Text = "DANH SÁCH MÓN ";
            // 
            // data_Ban
            // 
            this.data_Ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Ban.Location = new System.Drawing.Point(13, 199);
            this.data_Ban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_Ban.Name = "data_Ban";
            this.data_Ban.RowTemplate.Height = 24;
            this.data_Ban.Size = new System.Drawing.Size(431, 520);
            this.data_Ban.TabIndex = 26;
            this.data_Ban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Ban_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(13, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 128);
            this.panel2.TabIndex = 25;
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Location = new System.Drawing.Point(580, 7);
            this.txt_giamgia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(117, 22);
            this.txt_giamgia.TabIndex = 22;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_xoa.Location = new System.Drawing.Point(359, 2);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(71, 83);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xoá Thông Tin Bàn";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // nud_soluong
            // 
            this.nud_soluong.Location = new System.Drawing.Point(267, 7);
            this.nud_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_soluong.Name = "nud_soluong";
            this.nud_soluong.Size = new System.Drawing.Size(87, 22);
            this.nud_soluong.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số lượng";
            // 
            // data_thongtinban
            // 
            this.data_thongtinban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_thongtinban.Location = new System.Drawing.Point(451, 328);
            this.data_thongtinban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_thongtinban.Name = "data_thongtinban";
            this.data_thongtinban.RowTemplate.Height = 24;
            this.data_thongtinban.Size = new System.Drawing.Size(827, 391);
            this.data_thongtinban.TabIndex = 23;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // aDMINToolStripMenuItem1
            // 
            this.aDMINToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aDMINToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aDMINToolStripMenuItem1.Image")));
            this.aDMINToolStripMenuItem1.Name = "aDMINToolStripMenuItem1";
            this.aDMINToolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.aDMINToolStripMenuItem1.Text = "ADMIN";
            this.aDMINToolStripMenuItem1.Click += new System.EventHandler(this.aDMINToolStripMenuItem1_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // btn_inhoadon
            // 
            this.btn_inhoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_inhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inhoadon.ForeColor = System.Drawing.Color.Red;
            this.btn_inhoadon.Location = new System.Drawing.Point(704, 9);
            this.btn_inhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inhoadon.Name = "btn_inhoadon";
            this.btn_inhoadon.Size = new System.Drawing.Size(115, 76);
            this.btn_inhoadon.TabIndex = 16;
            this.btn_inhoadon.Text = "IN HOÁ ĐƠN";
            this.btn_inhoadon.UseVisualStyleBackColor = false;
            this.btn_inhoadon.Click += new System.EventHandler(this.btn_inhoadon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(593, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Giảm Giá";
            // 
            // btn_chuyenban
            // 
            this.btn_chuyenban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_chuyenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyenban.ForeColor = System.Drawing.Color.Red;
            this.btn_chuyenban.Location = new System.Drawing.Point(435, 34);
            this.btn_chuyenban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chuyenban.Name = "btn_chuyenban";
            this.btn_chuyenban.Size = new System.Drawing.Size(139, 50);
            this.btn_chuyenban.TabIndex = 13;
            this.btn_chuyenban.Text = "Chuyển Bàn";
            this.btn_chuyenban.UseVisualStyleBackColor = false;
            this.btn_chuyenban.Click += new System.EventHandler(this.btn_chuyenban_Click);
            // 
            // cb_chuyenban
            // 
            this.cb_chuyenban.FormattingEnabled = true;
            this.cb_chuyenban.Location = new System.Drawing.Point(435, 7);
            this.cb_chuyenban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_chuyenban.Name = "cb_chuyenban";
            this.cb_chuyenban.Size = new System.Drawing.Size(137, 24);
            this.cb_chuyenban.TabIndex = 14;
            // 
            // btn_themmon
            // 
            this.btn_themmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_themmon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themmon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_themmon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_themmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmon.ForeColor = System.Drawing.Color.Red;
            this.btn_themmon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_themmon.Location = new System.Drawing.Point(199, 39);
            this.btn_themmon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.Size = new System.Drawing.Size(143, 46);
            this.btn_themmon.TabIndex = 11;
            this.btn_themmon.Text = "Thêm Món";
            this.btn_themmon.UseVisualStyleBackColor = false;
            this.btn_themmon.Click += new System.EventHandler(this.btn_themmon_Click);
            // 
            // cb_mon
            // 
            this.cb_mon.FormattingEnabled = true;
            this.cb_mon.Location = new System.Drawing.Point(19, 50);
            this.cb_mon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_mon.Name = "cb_mon";
            this.cb_mon.Size = new System.Drawing.Size(163, 24);
            this.cb_mon.TabIndex = 10;
            // 
            // cb_danhmuc
            // 
            this.cb_danhmuc.FormattingEnabled = true;
            this.cb_danhmuc.Location = new System.Drawing.Point(19, 6);
            this.cb_danhmuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_danhmuc.Name = "cb_danhmuc";
            this.cb_danhmuc.Size = new System.Drawing.Size(163, 24);
            this.cb_danhmuc.TabIndex = 9;
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.thêmMónToolStripMenuItem.Text = "Thêm món";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMónToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.danhMụcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.danhMụcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhMụcToolStripMenuItem.Image")));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_giamgia);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.nud_soluong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_inhoadon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_chuyenban);
            this.panel1.Controls.Add(this.cb_chuyenban);
            this.panel1.Controls.Add(this.btn_themmon);
            this.panel1.Controls.Add(this.cb_mon);
            this.panel1.Controls.Add(this.cb_danhmuc);
            this.panel1.Location = new System.Drawing.Point(451, 194);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 91);
            this.panel1.TabIndex = 24;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.aDMINToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1288, 28);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // frm_QuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 748);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_ban);
            this.Controls.Add(this.data_Ban);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.data_thongtinban);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frm_QuanLyBan";
            this.Text = "frm_QuanLyBan";
            this.Load += new System.EventHandler(this.frm_QuanLyBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Ban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_thongtinban)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ban;
        private System.Windows.Forms.DataGridView data_Ban;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.NumericUpDown nud_soluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_thongtinban;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btn_inhoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chuyenban;
        private System.Windows.Forms.ComboBox cb_chuyenban;
        private System.Windows.Forms.Button btn_themmon;
        private System.Windows.Forms.ComboBox cb_mon;
        private System.Windows.Forms.ComboBox cb_danhmuc;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}