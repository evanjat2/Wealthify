namespace Wealthify
{
    partial class Transaksi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblKeluar = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnArtikel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.btnTambahTransaksi = new System.Windows.Forms.Button();
            this.btnTampilTransaksi = new System.Windows.Forms.Button();
            this.cbKantong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategoriTransaksi = new System.Windows.Forms.ComboBox();
            this.tbCatatan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNominal = new System.Windows.Forms.TextBox();
            this.cbJenisTransaksi = new System.Windows.Forms.ComboBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNamaKantong = new System.Windows.Forms.Label();
            this.lblJenisKantong = new System.Windows.Forms.Label();
            this.btnHapusTransaksi = new System.Windows.Forms.Button();
            this.btnUbahTransaksi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTanggalTransaksi = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.lblKeluar);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnArtikel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLaporan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 749);
            this.panel1.TabIndex = 1;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.Location = new System.Drawing.Point(126, 192);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(55, 19);
            this.lblAdmin.TabIndex = 30;
            this.lblAdmin.Text = "Admin";
            // 
            // lblKeluar
            // 
            this.lblKeluar.AutoSize = true;
            this.lblKeluar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKeluar.Location = new System.Drawing.Point(122, 660);
            this.lblKeluar.Name = "lblKeluar";
            this.lblKeluar.Size = new System.Drawing.Size(56, 19);
            this.lblKeluar.TabIndex = 10;
            this.lblKeluar.Text = "Keluar";
            this.lblKeluar.Click += new System.EventHandler(this.lblKeluar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Wealthify.Properties.Resources.artikel;
            this.pictureBox4.Location = new System.Drawing.Point(40, 421);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 40);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Wealthify.Properties.Resources.laporan;
            this.pictureBox3.Location = new System.Drawing.Point(40, 358);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 40);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(98, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Artikel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Laporan";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(68, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(163, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "jekicihuy@gmail.com";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(75, 211);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Jeki Davidson";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wealthify.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(75, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 136);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnArtikel
            // 
            this.btnArtikel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnArtikel.FlatAppearance.BorderSize = 0;
            this.btnArtikel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
            this.btnArtikel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtikel.Location = new System.Drawing.Point(0, 408);
            this.btnArtikel.Name = "btnArtikel";
            this.btnArtikel.Size = new System.Drawing.Size(305, 62);
            this.btnArtikel.TabIndex = 33;
            this.btnArtikel.UseVisualStyleBackColor = false;
            this.btnArtikel.Click += new System.EventHandler(this.btnArtikel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 62);
            this.panel2.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Wealthify.Properties.Resources.transaksi;
            this.pictureBox2.Location = new System.Drawing.Point(40, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 40);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(98, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transaksi";
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Location = new System.Drawing.Point(0, 345);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(305, 62);
            this.btnLaporan.TabIndex = 31;
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(360, 173);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowTemplate.Height = 25;
            this.dgvTransaksi.Size = new System.Drawing.Size(953, 506);
            this.dgvTransaksi.TabIndex = 31;
            this.dgvTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaksi_CellContentClick);
            // 
            // btnTambahTransaksi
            // 
            this.btnTambahTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnTambahTransaksi.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTambahTransaksi.Location = new System.Drawing.Point(998, 47);
            this.btnTambahTransaksi.Name = "btnTambahTransaksi";
            this.btnTambahTransaksi.Size = new System.Drawing.Size(93, 63);
            this.btnTambahTransaksi.TabIndex = 32;
            this.btnTambahTransaksi.Text = "Tambah Transaksi";
            this.btnTambahTransaksi.UseVisualStyleBackColor = false;
            this.btnTambahTransaksi.Click += new System.EventHandler(this.btnTambahTransaksi_Click);
            // 
            // btnTampilTransaksi
            // 
            this.btnTampilTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnTampilTransaksi.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTampilTransaksi.Location = new System.Drawing.Point(998, 121);
            this.btnTampilTransaksi.Name = "btnTampilTransaksi";
            this.btnTampilTransaksi.Size = new System.Drawing.Size(315, 28);
            this.btnTampilTransaksi.TabIndex = 33;
            this.btnTampilTransaksi.Text = "Tampilkan Transaksi";
            this.btnTampilTransaksi.UseVisualStyleBackColor = false;
            this.btnTampilTransaksi.Click += new System.EventHandler(this.btnTampilTransaksi_Click);
            // 
            // cbKantong
            // 
            this.cbKantong.FormattingEnabled = true;
            this.cbKantong.Location = new System.Drawing.Point(498, 48);
            this.cbKantong.Name = "cbKantong";
            this.cbKantong.Size = new System.Drawing.Size(154, 23);
            this.cbKantong.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Kantong";
            // 
            // cbKategoriTransaksi
            // 
            this.cbKategoriTransaksi.FormattingEnabled = true;
            this.cbKategoriTransaksi.Location = new System.Drawing.Point(499, 126);
            this.cbKategoriTransaksi.Name = "cbKategoriTransaksi";
            this.cbKategoriTransaksi.Size = new System.Drawing.Size(154, 23);
            this.cbKategoriTransaksi.TabIndex = 41;
            // 
            // tbCatatan
            // 
            this.tbCatatan.Location = new System.Drawing.Point(785, 125);
            this.tbCatatan.Name = "tbCatatan";
            this.tbCatatan.PlaceholderText = "Tambahkan catatan";
            this.tbCatatan.Size = new System.Drawing.Size(186, 23);
            this.tbCatatan.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(679, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Catatan";
            // 
            // tbNominal
            // 
            this.tbNominal.Location = new System.Drawing.Point(785, 87);
            this.tbNominal.Name = "tbNominal";
            this.tbNominal.PlaceholderText = "Masukkan nominal";
            this.tbNominal.Size = new System.Drawing.Size(186, 23);
            this.tbNominal.TabIndex = 38;
            // 
            // cbJenisTransaksi
            // 
            this.cbJenisTransaksi.FormattingEnabled = true;
            this.cbJenisTransaksi.Items.AddRange(new object[] {
            "Pemasukan",
            "Pengeluaran"});
            this.cbJenisTransaksi.Location = new System.Drawing.Point(498, 87);
            this.cbJenisTransaksi.Name = "cbJenisTransaksi";
            this.cbJenisTransaksi.Size = new System.Drawing.Size(154, 23);
            this.cbJenisTransaksi.TabIndex = 37;
            this.cbJenisTransaksi.SelectedIndexChanged += new System.EventHandler(this.cbJenisTransaksi_SelectedIndexChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(679, 91);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(69, 19);
            this.lblSaldo.TabIndex = 36;
            this.lblSaldo.Text = "Nominal";
            // 
            // lblNamaKantong
            // 
            this.lblNamaKantong.AutoSize = true;
            this.lblNamaKantong.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNamaKantong.Location = new System.Drawing.Point(361, 128);
            this.lblNamaKantong.Name = "lblNamaKantong";
            this.lblNamaKantong.Size = new System.Drawing.Size(68, 19);
            this.lblNamaKantong.TabIndex = 35;
            this.lblNamaKantong.Text = "Kategori";
            // 
            // lblJenisKantong
            // 
            this.lblJenisKantong.AutoSize = true;
            this.lblJenisKantong.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJenisKantong.Location = new System.Drawing.Point(360, 90);
            this.lblJenisKantong.Name = "lblJenisKantong";
            this.lblJenisKantong.Size = new System.Drawing.Size(120, 19);
            this.lblJenisKantong.TabIndex = 34;
            this.lblJenisKantong.Text = "Jenis Transaksi";
            // 
            // btnHapusTransaksi
            // 
            this.btnHapusTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnHapusTransaksi.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHapusTransaksi.Location = new System.Drawing.Point(1220, 48);
            this.btnHapusTransaksi.Name = "btnHapusTransaksi";
            this.btnHapusTransaksi.Size = new System.Drawing.Size(93, 62);
            this.btnHapusTransaksi.TabIndex = 44;
            this.btnHapusTransaksi.Text = "Hapus Transaksi";
            this.btnHapusTransaksi.UseVisualStyleBackColor = false;
            this.btnHapusTransaksi.Click += new System.EventHandler(this.btnHapusTransaksi_Click);
            // 
            // btnUbahTransaksi
            // 
            this.btnUbahTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnUbahTransaksi.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUbahTransaksi.Location = new System.Drawing.Point(1108, 47);
            this.btnUbahTransaksi.Name = "btnUbahTransaksi";
            this.btnUbahTransaksi.Size = new System.Drawing.Size(96, 63);
            this.btnUbahTransaksi.TabIndex = 45;
            this.btnUbahTransaksi.Text = "Ubah Transaksi";
            this.btnUbahTransaksi.UseVisualStyleBackColor = false;
            this.btnUbahTransaksi.Click += new System.EventHandler(this.btnUbahTransaksi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(679, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Tanggal";
            // 
            // dtpTanggalTransaksi
            // 
            this.dtpTanggalTransaksi.CustomFormat = "";
            this.dtpTanggalTransaksi.Location = new System.Drawing.Point(785, 49);
            this.dtpTanggalTransaksi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalTransaksi.Name = "dtpTanggalTransaksi";
            this.dtpTanggalTransaksi.Size = new System.Drawing.Size(186, 23);
            this.dtpTanggalTransaksi.TabIndex = 47;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.dtpTanggalTransaksi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUbahTransaksi);
            this.Controls.Add(this.btnHapusTransaksi);
            this.Controls.Add(this.cbKantong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategoriTransaksi);
            this.Controls.Add(this.tbCatatan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNominal);
            this.Controls.Add(this.cbJenisTransaksi);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNamaKantong);
            this.Controls.Add(this.lblJenisKantong);
            this.Controls.Add(this.btnTampilTransaksi);
            this.Controls.Add(this.btnTambahTransaksi);
            this.Controls.Add(this.dgvTransaksi);
            this.Controls.Add(this.panel1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblAdmin;
        private Label lblKeluar;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblEmail;
        private Label lblName;
        private PictureBox pictureBox1;
        private Button btnLaporan;
        private Button btnArtikel;
        private Panel panel2;
        public DataGridView dgvTransaksi;
        private Button btnTambahTransaksi;
        private Button btnTampilTransaksi;
        private ComboBox cbKantong;
        private Label label1;
        private ComboBox cbKategoriTransaksi;
        private TextBox tbCatatan;
        private Label label2;
        private TextBox tbNominal;
        private ComboBox cbJenisTransaksi;
        private Label lblSaldo;
        private Label lblNamaKantong;
        private Label lblJenisKantong;
        private Button btnHapusTransaksi;
        private Button btnUbahTransaksi;
        private Label label6;
        private DateTimePicker dtpTanggalTransaksi;
    }
}