namespace Wealthify
{
    partial class TambahKantong
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
            this.lblJenisKantong = new System.Windows.Forms.Label();
            this.lblNamaKantong = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cbJenisKantong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaKantong = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJenisKantong
            // 
            this.lblJenisKantong.AutoSize = true;
            this.lblJenisKantong.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJenisKantong.Location = new System.Drawing.Point(45, 74);
            this.lblJenisKantong.Name = "lblJenisKantong";
            this.lblJenisKantong.Size = new System.Drawing.Size(111, 19);
            this.lblJenisKantong.TabIndex = 0;
            this.lblJenisKantong.Text = "Jenis Kantong";
            // 
            // lblNamaKantong
            // 
            this.lblNamaKantong.AutoSize = true;
            this.lblNamaKantong.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNamaKantong.Location = new System.Drawing.Point(45, 113);
            this.lblNamaKantong.Name = "lblNamaKantong";
            this.lblNamaKantong.Size = new System.Drawing.Size(116, 19);
            this.lblNamaKantong.TabIndex = 1;
            this.lblNamaKantong.Text = "Nama Kantong";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(45, 154);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(50, 19);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo";
            // 
            // cbJenisKantong
            // 
            this.cbJenisKantong.FormattingEnabled = true;
            this.cbJenisKantong.Items.AddRange(new object[] {
            "Tunai",
            "E-Wallet",
            "Rekening"});
            this.cbJenisKantong.Location = new System.Drawing.Point(183, 74);
            this.cbJenisKantong.Name = "cbJenisKantong";
            this.cbJenisKantong.Size = new System.Drawing.Size(154, 23);
            this.cbJenisKantong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tambah Kantong";
            // 
            // tbNamaKantong
            // 
            this.tbNamaKantong.Location = new System.Drawing.Point(183, 113);
            this.tbNamaKantong.Name = "tbNamaKantong";
            this.tbNamaKantong.PlaceholderText = "Masukkan nama kantong";
            this.tbNamaKantong.Size = new System.Drawing.Size(154, 23);
            this.tbNamaKantong.TabIndex = 5;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(183, 150);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.PlaceholderText = "Masukkan saldo awal";
            this.tbSaldo.Size = new System.Drawing.Size(154, 23);
            this.tbSaldo.TabIndex = 6;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnSimpan.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(144, 205);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(89, 30);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // TambahKantong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 264);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.tbNamaKantong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJenisKantong);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNamaKantong);
            this.Controls.Add(this.lblJenisKantong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TambahKantong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahKantong";
            this.Load += new System.EventHandler(this.TambahKantong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblJenisKantong;
        private Label lblNamaKantong;
        private Label lblSaldo;
        private ComboBox cbJenisKantong;
        private Label label1;
        private TextBox tbNamaKantong;
        private TextBox tbSaldo;
        private Button btnSimpan;
    }
}