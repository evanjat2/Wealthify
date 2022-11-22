namespace Wealthify
{
    partial class AddArticleForm
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
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.tbJudul = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblKategori.Location = new System.Drawing.Point(95, 99);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(112, 32);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblJudul.Location = new System.Drawing.Point(96, 206);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(77, 32);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Judul";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblContent.Location = new System.Drawing.Point(95, 317);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(105, 32);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Content";
            // 
            // tbKategori
            // 
            this.tbKategori.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbKategori.Location = new System.Drawing.Point(96, 150);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(1624, 31);
            this.tbKategori.TabIndex = 3;
            // 
            // tbJudul
            // 
            this.tbJudul.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbJudul.Location = new System.Drawing.Point(95, 251);
            this.tbJudul.Name = "tbJudul";
            this.tbJudul.Size = new System.Drawing.Size(1624, 31);
            this.tbJudul.TabIndex = 4;
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbContent.Location = new System.Drawing.Point(96, 367);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(1624, 483);
            this.tbContent.TabIndex = 5;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.ForeColor = System.Drawing.Color.Black;
            this.btnTambah.Location = new System.Drawing.Point(1551, 875);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(169, 47);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah Artikel";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(1366, 875);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(169, 47);
            this.btnKembali.TabIndex = 10;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // AddArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1806, 1050);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbJudul);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblKategori);
            this.Name = "AddArticleForm";
            this.Text = "AddArticleForm";
            this.Load += new System.EventHandler(this.AddArticleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKategori;
        private Label lblJudul;
        private Label lblContent;
        private TextBox tbKategori;
        private TextBox tbJudul;
        private TextBox tbContent;
        private Button btnTambah;
        private Button btnKembali;
    }
}