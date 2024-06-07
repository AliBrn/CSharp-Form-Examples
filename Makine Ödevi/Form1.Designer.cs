namespace Odev_Makina
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.makinecmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTime1 = new System.Windows.Forms.DateTimePicker();
            this.DateTime2 = new System.Windows.Forms.DateTimePicker();
            this.CizButon = new System.Windows.Forms.Button();
            this.GrafikTablo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(560, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // makinecmbx
            // 
            this.makinecmbx.FormattingEnabled = true;
            this.makinecmbx.Items.AddRange(new object[] {
            "Makine1",
            "Makine2",
            "Makine3",
            "Makine4",
            "Makine5"});
            this.makinecmbx.Location = new System.Drawing.Point(126, 12);
            this.makinecmbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makinecmbx.Name = "makinecmbx";
            this.makinecmbx.Size = new System.Drawing.Size(201, 24);
            this.makinecmbx.TabIndex = 2;
            this.makinecmbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Makine Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "BitişTarihi";
            // 
            // DateTime1
            // 
            this.DateTime1.Location = new System.Drawing.Point(121, 61);
            this.DateTime1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.Size = new System.Drawing.Size(215, 22);
            this.DateTime1.TabIndex = 6;
            this.DateTime1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DateTime2
            // 
            this.DateTime2.Location = new System.Drawing.Point(126, 104);
            this.DateTime2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTime2.Name = "DateTime2";
            this.DateTime2.Size = new System.Drawing.Size(210, 22);
            this.DateTime2.TabIndex = 7;
            this.DateTime2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // CizButon
            // 
            this.CizButon.Location = new System.Drawing.Point(427, 7);
            this.CizButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CizButon.Name = "CizButon";
            this.CizButon.Size = new System.Drawing.Size(202, 29);
            this.CizButon.TabIndex = 8;
            this.CizButon.Text = "Çiz";
            this.CizButon.UseVisualStyleBackColor = true;
            this.CizButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrafikTablo
            // 
            chartArea1.Name = "ChartArea1";
            this.GrafikTablo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GrafikTablo.Legends.Add(legend1);
            this.GrafikTablo.Location = new System.Drawing.Point(-13, 299);
            this.GrafikTablo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrafikTablo.Name = "GrafikTablo";
            this.GrafikTablo.Size = new System.Drawing.Size(663, 293);
            this.GrafikTablo.TabIndex = 9;
            this.GrafikTablo.Text = "GrafikTablosu";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.ForeColor = System.Drawing.Color.Fuchsia;
            title1.Name = "Title1";
            title1.Text = "Makine Günlük Üretim Adet";
            this.GrafikTablo.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1107, 704);
            this.Controls.Add(this.GrafikTablo);
            this.Controls.Add(this.CizButon);
            this.Controls.Add(this.DateTime2);
            this.Controls.Add(this.DateTime1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makinecmbx);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox makinecmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTime1;
        private System.Windows.Forms.DateTimePicker DateTime2;
        private System.Windows.Forms.Button CizButon;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikTablo;
    }
}

