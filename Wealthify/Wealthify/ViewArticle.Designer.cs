namespace Wealthify
{
    partial class ViewArticle
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
            this.lblKonten = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKonten
            // 
            this.lblKonten.AutoSize = true;
            this.lblKonten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKonten.Location = new System.Drawing.Point(113, 266);
            this.lblKonten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKonten.MaximumSize = new System.Drawing.Size(1120, 300);
            this.lblKonten.Name = "lblKonten";
            this.lblKonten.Size = new System.Drawing.Size(703, 25);
            this.lblKonten.TabIndex = 7;
            this.lblKonten.Text = "Lorem ipsum dol amet, consecte adipisicing elit sed do. some dsu text will be her" +
    "e.";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJudul.Location = new System.Drawing.Point(113, 99);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJudul.MaximumSize = new System.Drawing.Size(1050, 120);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(956, 65);
            this.lblJudul.TabIndex = 6;
            this.lblJudul.Text = "One click onvoice with full accounting setup";
            this.lblJudul.Click += new System.EventHandler(this.lblJudul1_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.lblKategori.Location = new System.Drawing.Point(113, 62);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(79, 21);
            this.lblKategori.TabIndex = 5;
            this.lblKategori.Text = "INVOICES";
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(1212, 16);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(118, 28);
            this.btnKembali.TabIndex = 19;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // ViewArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 449);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblKonten);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblKategori);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewArticle";
            this.Text = "ViewArticle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewArticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKonten;
        private Label lblJudul;
        private Label lblKategori;
        private Button btnKembali;
    }
}