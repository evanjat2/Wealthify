namespace Wealthify
{
    partial class ArtikelListForm
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
            this.dgvArtikel = new System.Windows.Forms.DataGridView();
            this.artikel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikel
            // 
            this.dgvArtikel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikel_id,
            this.kategori,
            this.judul});
            this.dgvArtikel.Location = new System.Drawing.Point(78, 93);
            this.dgvArtikel.Name = "dgvArtikel";
            this.dgvArtikel.RowHeadersWidth = 62;
            this.dgvArtikel.RowTemplate.Height = 33;
            this.dgvArtikel.Size = new System.Drawing.Size(1776, 819);
            this.dgvArtikel.TabIndex = 0;
            this.dgvArtikel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikel_CellContentClick);
            // 
            // artikel_id
            // 
            this.artikel_id.DataPropertyName = "artikel_id";
            this.artikel_id.HeaderText = "ID Artikel";
            this.artikel_id.MinimumWidth = 8;
            this.artikel_id.Name = "artikel_id";
            // 
            // kategori
            // 
            this.kategori.DataPropertyName = "kategori";
            this.kategori.HeaderText = "Kategori";
            this.kategori.MinimumWidth = 8;
            this.kategori.Name = "kategori";
            // 
            // judul
            // 
            this.judul.DataPropertyName = "judul";
            this.judul.HeaderText = "Judul";
            this.judul.MinimumWidth = 8;
            this.judul.Name = "judul";
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(1685, 938);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(169, 47);
            this.btnKembali.TabIndex = 11;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // ArtikelListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dgvArtikel);
            this.Name = "ArtikelListForm";
            this.Text = "ArtikelListForm";
            this.Load += new System.EventHandler(this.ArtikelListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvArtikel;
        private DataGridViewTextBoxColumn artikel_id;
        private DataGridViewTextBoxColumn kategori;
        private DataGridViewTextBoxColumn judul;
        private Button btnKembali;
    }
}