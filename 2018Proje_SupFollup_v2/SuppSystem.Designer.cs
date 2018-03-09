namespace _2018Proje_SupFollup_v2
{
    partial class SuppSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sys_dtgrd = new System.Windows.Forms.DataGridView();
            this.sys_isnad = new System.Windows.Forms.Label();
            this.sys_özllk = new System.Windows.Forms.Label();
            this.sys_kimypl = new System.Windows.Forms.Label();
            this.sys_fiyat = new System.Windows.Forms.Label();
            this.sys_log = new System.Windows.Forms.Label();
            this.sys_btn_günc = new System.Windows.Forms.Button();
            this.sys_btn_sil = new System.Windows.Forms.Button();
            this.sy_btn_ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sys_dtgrd)).BeginInit();
            this.SuspendLayout();
            // 
            // sys_dtgrd
            // 
            this.sys_dtgrd.AllowUserToAddRows = false;
            this.sys_dtgrd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.sys_dtgrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.sys_dtgrd.BackgroundColor = System.Drawing.Color.White;
            this.sys_dtgrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sys_dtgrd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.sys_dtgrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.sys_dtgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sys_dtgrd.DefaultCellStyle = dataGridViewCellStyle15;
            this.sys_dtgrd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sys_dtgrd.Location = new System.Drawing.Point(0, 326);
            this.sys_dtgrd.Name = "sys_dtgrd";
            this.sys_dtgrd.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sys_dtgrd.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.sys_dtgrd.RowTemplate.ReadOnly = true;
            this.sys_dtgrd.Size = new System.Drawing.Size(884, 175);
            this.sys_dtgrd.TabIndex = 0;
            this.sys_dtgrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sys_dtgrd_CellClick);
            // 
            // sys_isnad
            // 
            this.sys_isnad.AutoSize = true;
            this.sys_isnad.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sys_isnad.Location = new System.Drawing.Point(12, 9);
            this.sys_isnad.Name = "sys_isnad";
            this.sys_isnad.Size = new System.Drawing.Size(79, 26);
            this.sys_isnad.TabIndex = 1;
            this.sys_isnad.Tag = "name";
            this.sys_isnad.Text = "isin adı";
            // 
            // sys_özllk
            // 
            this.sys_özllk.AutoSize = true;
            this.sys_özllk.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sys_özllk.Location = new System.Drawing.Point(12, 54);
            this.sys_özllk.Name = "sys_özllk";
            this.sys_özllk.Size = new System.Drawing.Size(77, 26);
            this.sys_özllk.TabIndex = 2;
            this.sys_özllk.Tag = "prop";
            this.sys_özllk.Text = "Özellik";
            // 
            // sys_kimypl
            // 
            this.sys_kimypl.AutoSize = true;
            this.sys_kimypl.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sys_kimypl.Location = new System.Drawing.Point(12, 96);
            this.sys_kimypl.Name = "sys_kimypl";
            this.sys_kimypl.Size = new System.Drawing.Size(50, 26);
            this.sys_kimypl.TabIndex = 3;
            this.sys_kimypl.Tag = "prsn";
            this.sys_kimypl.Text = "Kim";
            // 
            // sys_fiyat
            // 
            this.sys_fiyat.AutoSize = true;
            this.sys_fiyat.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sys_fiyat.Location = new System.Drawing.Point(12, 140);
            this.sys_fiyat.Name = "sys_fiyat";
            this.sys_fiyat.Size = new System.Drawing.Size(58, 26);
            this.sys_fiyat.TabIndex = 4;
            this.sys_fiyat.Tag = "prc";
            this.sys_fiyat.Text = "Fiyat";
            // 
            // sys_log
            // 
            this.sys_log.AutoSize = true;
            this.sys_log.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sys_log.Location = new System.Drawing.Point(12, 188);
            this.sys_log.Name = "sys_log";
            this.sys_log.Size = new System.Drawing.Size(46, 26);
            this.sys_log.TabIndex = 5;
            this.sys_log.Tag = "log";
            this.sys_log.Text = "Log";
            // 
            // sys_btn_günc
            // 
            this.sys_btn_günc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sys_btn_günc.FlatAppearance.BorderSize = 0;
            this.sys_btn_günc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sys_btn_günc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sys_btn_günc.ForeColor = System.Drawing.Color.White;
            this.sys_btn_günc.Location = new System.Drawing.Point(17, 245);
            this.sys_btn_günc.Name = "sys_btn_günc";
            this.sys_btn_günc.Size = new System.Drawing.Size(70, 40);
            this.sys_btn_günc.TabIndex = 7;
            this.sys_btn_günc.Text = "Güncelle";
            this.sys_btn_günc.UseVisualStyleBackColor = false;
            this.sys_btn_günc.Visible = false;
            this.sys_btn_günc.Click += new System.EventHandler(this.sys_btn_günc_Click);
            // 
            // sys_btn_sil
            // 
            this.sys_btn_sil.BackColor = System.Drawing.Color.Brown;
            this.sys_btn_sil.FlatAppearance.BorderSize = 0;
            this.sys_btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sys_btn_sil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sys_btn_sil.ForeColor = System.Drawing.Color.White;
            this.sys_btn_sil.Location = new System.Drawing.Point(93, 245);
            this.sys_btn_sil.Name = "sys_btn_sil";
            this.sys_btn_sil.Size = new System.Drawing.Size(70, 40);
            this.sys_btn_sil.TabIndex = 8;
            this.sys_btn_sil.Text = "Sil";
            this.sys_btn_sil.UseVisualStyleBackColor = false;
            this.sys_btn_sil.Visible = false;
            this.sys_btn_sil.Click += new System.EventHandler(this.sys_btn_sil_Click);
            // 
            // sy_btn_ekle
            // 
            this.sy_btn_ekle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sy_btn_ekle.FlatAppearance.BorderSize = 0;
            this.sy_btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sy_btn_ekle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sy_btn_ekle.ForeColor = System.Drawing.Color.White;
            this.sy_btn_ekle.Location = new System.Drawing.Point(802, 12);
            this.sy_btn_ekle.Name = "sy_btn_ekle";
            this.sy_btn_ekle.Size = new System.Drawing.Size(70, 40);
            this.sy_btn_ekle.TabIndex = 9;
            this.sy_btn_ekle.Text = "EKLE";
            this.sy_btn_ekle.UseVisualStyleBackColor = false;
            this.sy_btn_ekle.Visible = false;
            this.sy_btn_ekle.Click += new System.EventHandler(this.sy_btn_ekle_Click);
            // 
            // SuppSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.sy_btn_ekle);
            this.Controls.Add(this.sys_btn_sil);
            this.Controls.Add(this.sys_btn_günc);
            this.Controls.Add(this.sys_log);
            this.Controls.Add(this.sys_fiyat);
            this.Controls.Add(this.sys_kimypl);
            this.Controls.Add(this.sys_özllk);
            this.Controls.Add(this.sys_isnad);
            this.Controls.Add(this.sys_dtgrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SuppSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppSystem";
            this.Load += new System.EventHandler(this.SuppSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sys_dtgrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sys_dtgrd;
        private System.Windows.Forms.Label sys_isnad;
        private System.Windows.Forms.Label sys_özllk;
        private System.Windows.Forms.Label sys_kimypl;
        private System.Windows.Forms.Label sys_fiyat;
        private System.Windows.Forms.Label sys_log;
        private System.Windows.Forms.Button sys_btn_günc;
        private System.Windows.Forms.Button sys_btn_sil;
        private System.Windows.Forms.Button sy_btn_ekle;
    }
}