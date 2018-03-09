namespace _2018Proje_SupFollup_v2
{
    partial class Transactions
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
            this.trns_btn_admn = new System.Windows.Forms.Button();
            this.trns_btn_rapor = new System.Windows.Forms.Button();
            this.trns_btn_sistem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trns_btn_admn
            // 
            this.trns_btn_admn.Location = new System.Drawing.Point(465, 12);
            this.trns_btn_admn.Name = "trns_btn_admn";
            this.trns_btn_admn.Size = new System.Drawing.Size(98, 41);
            this.trns_btn_admn.TabIndex = 0;
            this.trns_btn_admn.Tag = "yt";
            this.trns_btn_admn.Text = "Yönetim";
            this.trns_btn_admn.UseVisualStyleBackColor = true;
            this.trns_btn_admn.Click += new System.EventHandler(this.trns_btn_admn_Click);
            // 
            // trns_btn_rapor
            // 
            this.trns_btn_rapor.Location = new System.Drawing.Point(237, 12);
            this.trns_btn_rapor.Name = "trns_btn_rapor";
            this.trns_btn_rapor.Size = new System.Drawing.Size(98, 41);
            this.trns_btn_rapor.TabIndex = 1;
            this.trns_btn_rapor.Tag = "ra";
            this.trns_btn_rapor.Text = "Rapor";
            this.trns_btn_rapor.UseVisualStyleBackColor = true;
            // 
            // trns_btn_sistem
            // 
            this.trns_btn_sistem.Location = new System.Drawing.Point(12, 12);
            this.trns_btn_sistem.Name = "trns_btn_sistem";
            this.trns_btn_sistem.Size = new System.Drawing.Size(98, 41);
            this.trns_btn_sistem.TabIndex = 2;
            this.trns_btn_sistem.Tag = "si";
            this.trns_btn_sistem.Text = "Sistem";
            this.trns_btn_sistem.UseVisualStyleBackColor = true;
            this.trns_btn_sistem.Click += new System.EventHandler(this.trns_btn_sistem_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 100);
            this.Controls.Add(this.trns_btn_sistem);
            this.Controls.Add(this.trns_btn_rapor);
            this.Controls.Add(this.trns_btn_admn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.Button trns_btn_admn;
        private global::System.Windows.Forms.Button trns_btn_rapor;
        private global::System.Windows.Forms.Button trns_btn_sistem;
    }
}