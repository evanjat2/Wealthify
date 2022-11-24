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
            this.lblKategori.Location = new System.Drawing.Point(66, 59);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(75, 21);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblJudul.Location = new System.Drawing.Point(67, 124);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(52, 21);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Judul";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblContent.Location = new System.Drawing.Point(66, 190);
            this.lblContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(71, 21);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Content";
            // 
            // tbKategori
            // 
            this.tbKategori.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbKategori.Location = new System.Drawing.Point(67, 90);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(1138, 23);
            this.tbKategori.TabIndex = 3;
            // 
            // tbJudul
            // 
            this.tbJudul.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbJudul.Location = new System.Drawing.Point(66, 151);
            this.tbJudul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbJudul.Name = "tbJudul";
            this.tbJudul.Size = new System.Drawing.Size(1138, 23);
            this.tbJudul.TabIndex = 4;
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbContent.Location = new System.Drawing.Point(67, 220);
            this.tbContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(1138, 291);
            this.tbContent.TabIndex = 5;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.ForeColor = System.Drawing.Color.Black;
            this.btnTambah.Location = new System.Drawing.Point(1086, 525);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(118, 28);
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
            this.btnKembali.Location = new System.Drawing.Point(956, 525);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(118, 28);
            this.btnKembali.TabIndex = 10;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // AddArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 449);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbJudul);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblKategori);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddArticleForm";
            this.Text = "AddArticleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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