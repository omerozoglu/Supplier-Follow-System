namespace _2018Proje_SupFollup_v2
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.admn_datagrd = new global::System.Windows.Forms.DataGridView();
            this.admn_btn_günc = new global::System.Windows.Forms.Button();
            this.admn_btn_sil = new global::System.Windows.Forms.Button();
            this.admn_k_ad = new global::System.Windows.Forms.Label();
            this.admn_k_yetki = new global::System.Windows.Forms.Label();
            this.admn_k_email = new global::System.Windows.Forms.Label();
            this.admn_k_kad = new global::System.Windows.Forms.Label();
            this.admn_a_email = new global::System.Windows.Forms.Label();
            this.admn_a_kad = new global::System.Windows.Forms.Label();
            this.admn_a_ad = new global::System.Windows.Forms.Label();
            this.admn_k_txt_ara = new global::System.Windows.Forms.TextBox();
            this.label1 = new global::System.Windows.Forms.Label();
            this.admn_btn_geri = new global::System.Windows.Forms.Button();
            ((global::System.ComponentModel.ISupportInitialize)(this.admn_datagrd)).BeginInit();
            this.SuspendLayout();
            // 
            // admn_datagrd
            // 
            this.admn_datagrd.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admn_datagrd.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.admn_datagrd.Location = new global::System.Drawing.Point(0, 259);
            this.admn_datagrd.Name = "admn_datagrd";
            this.admn_datagrd.Size = new global::System.Drawing.Size(754, 150);
            this.admn_datagrd.TabIndex = 10;
            this.admn_datagrd.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.admn_datagrd_CellClick);
            // 
            // admn_btn_günc
            // 
            this.admn_btn_günc.BackColor = global::System.Drawing.Color.MediumSeaGreen;
            this.admn_btn_günc.FlatAppearance.BorderSize = 0;
            this.admn_btn_günc.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
            this.admn_btn_günc.Font = new global::System.Drawing.Font("Calibri", 9.75F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_btn_günc.ForeColor = global::System.Drawing.Color.White;
            this.admn_btn_günc.Location = new global::System.Drawing.Point(596, 138);
            this.admn_btn_günc.Name = "admn_btn_günc";
            this.admn_btn_günc.Size = new global::System.Drawing.Size(70, 40);
            this.admn_btn_günc.TabIndex = 3;
            this.admn_btn_günc.Text = "Güncelle";
            this.admn_btn_günc.UseVisualStyleBackColor = false;
            this.admn_btn_günc.Visible = false;
            this.admn_btn_günc.Click += new global::System.EventHandler(this.admn_btn_günc_Click);
            // 
            // admn_btn_sil
            // 
            this.admn_btn_sil.BackColor = global::System.Drawing.Color.Brown;
            this.admn_btn_sil.FlatAppearance.BorderSize = 0;
            this.admn_btn_sil.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
            this.admn_btn_sil.Font = new global::System.Drawing.Font("Calibri", 9.75F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_btn_sil.ForeColor = global::System.Drawing.Color.White;
            this.admn_btn_sil.Location = new global::System.Drawing.Point(672, 138);
            this.admn_btn_sil.Name = "admn_btn_sil";
            this.admn_btn_sil.Size = new global::System.Drawing.Size(70, 40);
            this.admn_btn_sil.TabIndex = 4;
            this.admn_btn_sil.Text = "Sil";
            this.admn_btn_sil.UseVisualStyleBackColor = false;
            this.admn_btn_sil.Visible = false;
            this.admn_btn_sil.Click += new global::System.EventHandler(this.admn_btn_sil_Click);
            // 
            // admn_k_ad
            // 
            this.admn_k_ad.AutoSize = true;
            this.admn_k_ad.Font = new global::System.Drawing.Font("Calibri", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_k_ad.ForeColor = global::System.Drawing.Color.White;
            this.admn_k_ad.Location = new global::System.Drawing.Point(31, 155);
            this.admn_k_ad.Name = "admn_k_ad";
            this.admn_k_ad.Size = new global::System.Drawing.Size(14, 23);
            this.admn_k_ad.TabIndex = 14;
            this.admn_k_ad.Tag = "ad";
            this.admn_k_ad.Text = " ";
            // 
            // admn_k_yetki
            // 
            this.admn_k_yetki.AutoSize = true;
            this.admn_k_yetki.Font = new global::System.Drawing.Font("Calibri", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_k_yetki.ForeColor = global::System.Drawing.Color.White;
            this.admn_k_yetki.Location = new global::System.Drawing.Point(431, 155);
            this.admn_k_yetki.Name = "admn_k_yetki";
            this.admn_k_yetki.Size = new global::System.Drawing.Size(14, 23);
            this.admn_k_yetki.TabIndex = 13;
            this.admn_k_yetki.Tag = "yetki";
            this.admn_k_yetki.Text = " ";
            // 
            // admn_k_email
            // 
            this.admn_k_email.AutoSize = true;
            this.admn_k_email.Font = new global::System.Drawing.Font("Calibri", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_k_email.ForeColor = global::System.Drawing.Color.White;
            this.admn_k_email.Location = new global::System.Drawing.Point(296, 155);
            this.admn_k_email.Name = "admn_k_email";
            this.admn_k_email.Size = new global::System.Drawing.Size(14, 23);
            this.admn_k_email.TabIndex = 12;
            this.admn_k_email.Tag = "eposta";
            this.admn_k_email.Text = " ";
            // 
            // admn_k_kad
            // 
            this.admn_k_kad.AutoSize = true;
            this.admn_k_kad.Font = new global::System.Drawing.Font("Calibri", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_k_kad.ForeColor = global::System.Drawing.Color.White;
            this.admn_k_kad.Location = new global::System.Drawing.Point(144, 155);
            this.admn_k_kad.Name = "admn_k_kad";
            this.admn_k_kad.Size = new global::System.Drawing.Size(14, 23);
            this.admn_k_kad.TabIndex = 11;
            this.admn_k_kad.Tag = "kad";
            this.admn_k_kad.Text = " ";
            // 
            // admn_a_email
            // 
            this.admn_a_email.AutoSize = true;
            this.admn_a_email.Font = new global::System.Drawing.Font("Calibri", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_a_email.ForeColor = global::System.Drawing.Color.White;
            this.admn_a_email.Location = new global::System.Drawing.Point(31, 100);
            this.admn_a_email.Name = "admn_a_email";
            this.admn_a_email.Size = new global::System.Drawing.Size(54, 23);
            this.admn_a_email.TabIndex = 18;
            this.admn_a_email.Tag = "admn_eposta";
            this.admn_a_email.Text = "email";
            // 
            // admn_a_kad
            // 
            this.admn_a_kad.AutoSize = true;
            this.admn_a_kad.Font = new global::System.Drawing.Font("Calibri", 14.25F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_a_kad.ForeColor = global::System.Drawing.Color.White;
            this.admn_a_kad.Location = new global::System.Drawing.Point(31, 67);
            this.admn_a_kad.Name = "admn_a_kad";
            this.admn_a_kad.Size = new global::System.Drawing.Size(89, 23);
            this.admn_a_kad.TabIndex = 17;
            this.admn_a_kad.Tag = "admn_kad";
            this.admn_a_kad.Text = "username";
            // 
            // admn_a_ad
            // 
            this.admn_a_ad.AutoSize = true;
            this.admn_a_ad.Font = new global::System.Drawing.Font("Calibri", 24F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_a_ad.ForeColor = global::System.Drawing.Color.Black;
            this.admn_a_ad.Location = new global::System.Drawing.Point(231, 9);
            this.admn_a_ad.Name = "admn_a_ad";
            this.admn_a_ad.Size = new global::System.Drawing.Size(92, 39);
            this.admn_a_ad.TabIndex = 16;
            this.admn_a_ad.Tag = "admn_ad";
            this.admn_a_ad.Text = "name";
            // 
            // admn_k_txt_ara
            // 
            this.admn_k_txt_ara.Location = new global::System.Drawing.Point(12, 233);
            this.admn_k_txt_ara.Name = "admn_k_txt_ara";
            this.admn_k_txt_ara.Size = new global::System.Drawing.Size(228, 20);
            this.admn_k_txt_ara.TabIndex = 2;
            this.admn_k_txt_ara.TextChanged += new global::System.EventHandler(this.admn_k_txt_ara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font("Calibri", 24F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = global::System.Drawing.Color.White;
            this.label1.Location = new global::System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(177, 39);
            this.label1.TabIndex = 24;
            this.label1.Tag = "";
            this.label1.Text = "Hosgelidiniz";
            // 
            // admn_btn_geri
            // 
            this.admn_btn_geri.BackColor = global::System.Drawing.Color.MediumSeaGreen;
            this.admn_btn_geri.FlatAppearance.BorderSize = 0;
            this.admn_btn_geri.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
            this.admn_btn_geri.Font = new global::System.Drawing.Font("Calibri", 9.75F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admn_btn_geri.ForeColor = global::System.Drawing.Color.White;
            this.admn_btn_geri.Location = new global::System.Drawing.Point(671, 8);
            this.admn_btn_geri.Name = "admn_btn_geri";
            this.admn_btn_geri.Size = new global::System.Drawing.Size(70, 40);
            this.admn_btn_geri.TabIndex = 0;
            this.admn_btn_geri.Text = "<--";
            this.admn_btn_geri.UseVisualStyleBackColor = false;
            this.admn_btn_geri.Click += new global::System.EventHandler(this.admn_btn_geri_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.SystemColors.Highlight;
            this.ClientSize = new global::System.Drawing.Size(754, 409);
            this.Controls.Add(this.admn_btn_geri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admn_btn_günc);
            this.Controls.Add(this.admn_k_txt_ara);
            this.Controls.Add(this.admn_btn_sil);
            this.Controls.Add(this.admn_a_email);
            this.Controls.Add(this.admn_a_kad);
            this.Controls.Add(this.admn_a_ad);
            this.Controls.Add(this.admn_k_ad);
            this.Controls.Add(this.admn_k_yetki);
            this.Controls.Add(this.admn_k_email);
            this.Controls.Add(this.admn_k_kad);
            this.Controls.Add(this.admn_datagrd);
            this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel";
            this.Load += new global::System.EventHandler(this.AdminPanel_Load);
            ((global::System.ComponentModel.ISupportInitialize)(this.admn_datagrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.DataGridView admn_datagrd;
        private global::System.Windows.Forms.Button admn_btn_sil;
        private global::System.Windows.Forms.Button admn_btn_günc;
        private global::System.Windows.Forms.Label admn_k_ad;
        private global::System.Windows.Forms.Label admn_k_yetki;
        private global::System.Windows.Forms.Label admn_k_email;
        private global::System.Windows.Forms.Label admn_k_kad;
        private global::System.Windows.Forms.Label admn_a_email;
        private global::System.Windows.Forms.Label admn_a_kad;
        private global::System.Windows.Forms.Label admn_a_ad;
        private global::System.Windows.Forms.TextBox admn_k_txt_ara;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Button admn_btn_geri;
    }
}
