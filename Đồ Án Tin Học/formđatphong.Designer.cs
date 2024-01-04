namespace Đồ_Án_Tin_Học
{
    partial class formđatphong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formđatphong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdenngay = new System.Windows.Forms.DateTimePicker();
            this.dtptungay = new System.Windows.Forms.DateTimePicker();
            this.rdotrong = new System.Windows.Forms.RadioButton();
            this.rdoday = new System.Windows.Forms.RadioButton();
            this.rdofull = new System.Windows.Forms.RadioButton();
            this.dgvdsphong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcancuoc = new System.Windows.Forms.TextBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpdenngay);
            this.groupBox1.Controls.Add(this.dtptungay);
            this.groupBox1.Controls.Add(this.rdotrong);
            this.groupBox1.Controls.Add(this.rdoday);
            this.groupBox1.Controls.Add(this.rdofull);
            this.groupBox1.Controls.Add(this.dgvdsphong);
            this.groupBox1.Location = new System.Drawing.Point(262, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(456, 48);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(112, 31);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ Ngày";
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdenngay.Location = new System.Drawing.Point(308, 48);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(127, 26);
            this.dtpdenngay.TabIndex = 3;
            // 
            // dtptungay
            // 
            this.dtptungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptungay.Location = new System.Drawing.Point(91, 48);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(126, 26);
            this.dtptungay.TabIndex = 3;
            // 
            // rdotrong
            // 
            this.rdotrong.AutoSize = true;
            this.rdotrong.Location = new System.Drawing.Point(362, 98);
            this.rdotrong.Name = "rdotrong";
            this.rdotrong.Size = new System.Drawing.Size(157, 24);
            this.rdotrong.TabIndex = 2;
            this.rdotrong.TabStop = true;
            this.rdotrong.Text = "Các Phòng Trống";
            this.rdotrong.UseVisualStyleBackColor = true;
            this.rdotrong.CheckedChanged += new System.EventHandler(this.rdotrong_CheckedChanged);
            // 
            // rdoday
            // 
            this.rdoday.AutoSize = true;
            this.rdoday.Location = new System.Drawing.Point(190, 98);
            this.rdoday.Name = "rdoday";
            this.rdoday.Size = new System.Drawing.Size(140, 24);
            this.rdoday.TabIndex = 1;
            this.rdoday.TabStop = true;
            this.rdoday.Text = "Các phòng đầy";
            this.rdoday.UseVisualStyleBackColor = true;
            this.rdoday.CheckedChanged += new System.EventHandler(this.rdoday_CheckedChanged);
            // 
            // rdofull
            // 
            this.rdofull.AutoSize = true;
            this.rdofull.Location = new System.Drawing.Point(6, 98);
            this.rdofull.Name = "rdofull";
            this.rdofull.Size = new System.Drawing.Size(163, 24);
            this.rdofull.TabIndex = 1;
            this.rdofull.TabStop = true;
            this.rdofull.Text = "Tất Cả Các Phòng";
            this.rdofull.UseVisualStyleBackColor = true;
            this.rdofull.CheckedChanged += new System.EventHandler(this.rdofull_CheckedChanged);
            // 
            // dgvdsphong
            // 
            this.dgvdsphong.AllowUserToAddRows = false;
            this.dgvdsphong.AllowUserToDeleteRows = false;
            this.dgvdsphong.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvdsphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvdsphong.Location = new System.Drawing.Point(0, 151);
            this.dgvdsphong.Name = "dgvdsphong";
            this.dgvdsphong.RowHeadersWidth = 20;
            this.dgvdsphong.RowTemplate.Height = 28;
            this.dgvdsphong.Size = new System.Drawing.Size(568, 235);
            this.dgvdsphong.TabIndex = 0;
            this.dgvdsphong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Maphong";
            this.Column2.HeaderText = "Mã Phòng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tinhtrang";
            this.Column3.HeaderText = "Tình Trạng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Loaiphong";
            this.Column4.HeaderText = "Loại Phòng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // txtcancuoc
            // 
            this.txtcancuoc.Location = new System.Drawing.Point(73, 162);
            this.txtcancuoc.Name = "txtcancuoc";
            this.txtcancuoc.Size = new System.Drawing.Size(171, 26);
            this.txtcancuoc.TabIndex = 2;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(73, 216);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(171, 81);
            this.txtghichu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ghi Chú";
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(96, 397);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(114, 43);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Làm Mới";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.Image")));
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDatPhong.Location = new System.Drawing.Point(96, 317);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(114, 64);
            this.btnDatPhong.TabIndex = 1;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formđatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(827, 452);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txtcancuoc);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.groupBox1);
            this.Name = "formđatphong";
            this.Text = "formđatphong";
            this.Load += new System.EventHandler(this.formđatphong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdotrong;
        private System.Windows.Forms.RadioButton rdoday;
        private System.Windows.Forms.RadioButton rdofull;
        private System.Windows.Forms.DataGridView dgvdsphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtcancuoc;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}