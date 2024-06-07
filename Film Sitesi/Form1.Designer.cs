namespace OOP_Movie_App
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Filmler = new System.Windows.Forms.ListBox();
            this.ad_tb = new System.Windows.Forms.TextBox();
            this.soyad_tb = new System.Windows.Forms.TextBox();
            this.gun_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kirala_btn = new System.Windows.Forms.Button();
            this.yastxtbox = new System.Windows.Forms.TextBox();
            this.ceptxtbox = new System.Windows.Forms.TextBox();
            this.tctxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Kitap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CepTelefonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kitap,
            this.Kisi,
            this.Yas,
            this.TcNo,
            this.CepTelefonu,
            this.Sure});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(714, 452);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Filmler
            // 
            this.Filmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Filmler.FormattingEnabled = true;
            this.Filmler.ItemHeight = 29;
            this.Filmler.Location = new System.Drawing.Point(740, 12);
            this.Filmler.Name = "Filmler";
            this.Filmler.Size = new System.Drawing.Size(374, 178);
            this.Filmler.TabIndex = 1;
            // 
            // ad_tb
            // 
            this.ad_tb.Location = new System.Drawing.Point(720, 246);
            this.ad_tb.Name = "ad_tb";
            this.ad_tb.Size = new System.Drawing.Size(111, 22);
            this.ad_tb.TabIndex = 2;
            // 
            // soyad_tb
            // 
            this.soyad_tb.Location = new System.Drawing.Point(865, 246);
            this.soyad_tb.Name = "soyad_tb";
            this.soyad_tb.Size = new System.Drawing.Size(111, 22);
            this.soyad_tb.TabIndex = 3;
            // 
            // gun_tb
            // 
            this.gun_tb.Location = new System.Drawing.Point(720, 328);
            this.gun_tb.Name = "gun_tb";
            this.gun_tb.Size = new System.Drawing.Size(111, 22);
            this.gun_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(749, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adınız";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(894, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadınız";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(761, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gün";
            // 
            // kirala_btn
            // 
            this.kirala_btn.BackColor = System.Drawing.Color.Teal;
            this.kirala_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kirala_btn.Location = new System.Drawing.Point(881, 390);
            this.kirala_btn.Name = "kirala_btn";
            this.kirala_btn.Size = new System.Drawing.Size(130, 62);
            this.kirala_btn.TabIndex = 9;
            this.kirala_btn.Text = "Kirala";
            this.kirala_btn.UseVisualStyleBackColor = false;
            this.kirala_btn.Click += new System.EventHandler(this.kirala_btn_Click);
            // 
            // yastxtbox
            // 
            this.yastxtbox.Location = new System.Drawing.Point(1003, 246);
            this.yastxtbox.Name = "yastxtbox";
            this.yastxtbox.Size = new System.Drawing.Size(111, 22);
            this.yastxtbox.TabIndex = 10;
            this.yastxtbox.TextChanged += new System.EventHandler(this.yastxtbox_TextChanged);
            // 
            // ceptxtbox
            // 
            this.ceptxtbox.Location = new System.Drawing.Point(1003, 328);
            this.ceptxtbox.Name = "ceptxtbox";
            this.ceptxtbox.Size = new System.Drawing.Size(111, 22);
            this.ceptxtbox.TabIndex = 12;
            // 
            // tctxtbox
            // 
            this.tctxtbox.Location = new System.Drawing.Point(865, 328);
            this.tctxtbox.Name = "tctxtbox";
            this.tctxtbox.Size = new System.Drawing.Size(111, 22);
            this.tctxtbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(1041, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(878, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tc Kimlik No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(1015, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cep Telefonu";
            // 
            // Kitap
            // 
            this.Kitap.HeaderText = "Film";
            this.Kitap.MinimumWidth = 6;
            this.Kitap.Name = "Kitap";
            this.Kitap.ReadOnly = true;
            this.Kitap.Width = 125;
            // 
            // Kisi
            // 
            this.Kisi.HeaderText = "Kisi";
            this.Kisi.MinimumWidth = 6;
            this.Kisi.Name = "Kisi";
            this.Kisi.ReadOnly = true;
            this.Kisi.Width = 125;
            // 
            // Yas
            // 
            this.Yas.HeaderText = "Yas";
            this.Yas.MinimumWidth = 6;
            this.Yas.Name = "Yas";
            this.Yas.Width = 125;
            // 
            // TcNo
            // 
            this.TcNo.HeaderText = "Tc No";
            this.TcNo.MinimumWidth = 6;
            this.TcNo.Name = "TcNo";
            this.TcNo.Width = 125;
            // 
            // CepTelefonu
            // 
            this.CepTelefonu.HeaderText = "Cep Telefonu";
            this.CepTelefonu.MinimumWidth = 6;
            this.CepTelefonu.Name = "CepTelefonu";
            this.CepTelefonu.Width = 125;
            // 
            // Sure
            // 
            this.Sure.HeaderText = "Tutar";
            this.Sure.MinimumWidth = 6;
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            this.Sure.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1299, 662);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tctxtbox);
            this.Controls.Add(this.ceptxtbox);
            this.Controls.Add(this.yastxtbox);
            this.Controls.Add(this.kirala_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gun_tb);
            this.Controls.Add(this.soyad_tb);
            this.Controls.Add(this.ad_tb);
            this.Controls.Add(this.Filmler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox Filmler;
        private System.Windows.Forms.TextBox ad_tb;
        private System.Windows.Forms.TextBox soyad_tb;
        private System.Windows.Forms.TextBox gun_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kirala_btn;
        private System.Windows.Forms.TextBox yastxtbox;
        private System.Windows.Forms.TextBox ceptxtbox;
        private System.Windows.Forms.TextBox tctxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CepTelefonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
    }
}

