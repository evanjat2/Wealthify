namespace Wealthify
{
    partial class TambahTransaksi
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbNominal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbJenisTransaksi = new System.Windows.Forms.ComboBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNamaKantong = new System.Windows.Forms.Label();
            this.lblJenisKantong = new System.Windows.Forms.Label();
            this.tbCatatan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKategoriTransaksi = new System.Windows.Forms.ComboBox();
            this.kantongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbKantong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kantongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kantongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantongBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnSimpan.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(145, 271);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(89, 30);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbNominal
            // 
            this.tbNominal.Location = new System.Drawing.Point(185, 190);
            this.tbNominal.Name = "tbNominal";
            this.tbNominal.PlaceholderText = "Masukkan nominal";
            this.tbNominal.Size = new System.Drawing.Size(154, 23);
            this.tbNominal.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tambah Transaksi";
            // 
            // cbJenisTransaksi
            // 
            this.cbJenisTransaksi.FormattingEnabled = true;
            this.cbJenisTransaksi.Items.AddRange(new object[] {
            "Pemasukan",
            "Pengeluaran"});
            this.cbJenisTransaksi.Location = new System.Drawing.Point(185, 111);
            this.cbJenisTransaksi.Name = "cbJenisTransaksi";
            this.cbJenisTransaksi.Size = new System.Drawing.Size(154, 23);
            this.cbJenisTransaksi.TabIndex = 11;
            this.cbJenisTransaksi.SelectedIndexChanged += new System.EventHandler(this.cbJenisTransaksi_SelectedIndexChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(47, 194);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(69, 19);
            this.lblSaldo.TabIndex = 10;
            this.lblSaldo.Text = "Nominal";
            // 
            // lblNamaKantong
            // 
            this.lblNamaKantong.AutoSize = true;
            this.lblNamaKantong.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNamaKantong.Location = new System.Drawing.Point(47, 153);
            this.lblNamaKantong.Name = "lblNamaKantong";
            this.lblNamaKantong.Size = new System.Drawing.Size(68, 19);
            this.lblNamaKantong.TabIndex = 9;
            this.lblNamaKantong.Text = "Kategori";
            // 
            // lblJenisKantong
            // 
            this.lblJenisKantong.AutoSize = true;
            this.lblJenisKantong.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJenisKantong.Location = new System.Drawing.Point(47, 114);
            this.lblJenisKantong.Name = "lblJenisKantong";
            this.lblJenisKantong.Size = new System.Drawing.Size(120, 19);
            this.lblJenisKantong.TabIndex = 8;
            this.lblJenisKantong.Text = "Jenis Transaksi";
            // 
            // tbCatatan
            // 
            this.tbCatatan.Location = new System.Drawing.Point(185, 228);
            this.tbCatatan.Name = "tbCatatan";
            this.tbCatatan.PlaceholderText = "Tambahkan catatan";
            this.tbCatatan.Size = new System.Drawing.Size(154, 23);
            this.tbCatatan.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Catatan";
            // 
            // cbKategoriTransaksi
            // 
            this.cbKategoriTransaksi.FormattingEnabled = true;
            this.cbKategoriTransaksi.Location = new System.Drawing.Point(185, 151);
            this.cbKategoriTransaksi.Name = "cbKategoriTransaksi";
            this.cbKategoriTransaksi.Size = new System.Drawing.Size(154, 23);
            this.cbKategoriTransaksi.TabIndex = 18;
            // 
            // cbKantong
            // 
            this.cbKantong.FormattingEnabled = true;
            this.cbKantong.Location = new System.Drawing.Point(185, 72);
            this.cbKantong.Name = "cbKantong";
            this.cbKantong.Size = new System.Drawing.Size(154, 23);
            this.cbKantong.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kantong";
            // 
            // kantongBindingSource1
            // 
            this.kantongBindingSource1.DataSource = typeof(Wealthify.Kantong);
            // 
            // TambahTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 348);
            this.Controls.Add(this.cbKantong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKategoriTransaksi);
            this.Controls.Add(this.tbCatatan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbNominal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJenisTransaksi);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNamaKantong);
            this.Controls.Add(this.lblJenisKantong);
            this.Name = "TambahTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahTransaksi";
            this.Load += new System.EventHandler(this.TambahTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kantongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kantongBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSimpan;
        private TextBox tbNominal;
        private Label label1;
        private ComboBox cbJenisTransaksi;
        private Label lblSaldo;
        private Label lblNamaKantong;
        private Label lblJenisKantong;
        private TextBox tbCatatan;
        private Label label2;
        private ComboBox cbKategoriTransaksi;
        private BindingSource kantongBindingSource;
        private ComboBox cbKantong;
        private Label label3;
        private BindingSource kantongBindingSource1;
    }
}