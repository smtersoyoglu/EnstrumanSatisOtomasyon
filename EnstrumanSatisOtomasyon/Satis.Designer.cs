namespace EnstrumanSatisOtomasyon
{
    partial class Satis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SatisCikisLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EnsAdTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EnsMiktarTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EnsUcretTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BilgiDGV = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SatisFaturaDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeriBtn = new System.Windows.Forms.Button();
            this.TemizleBtn = new System.Windows.Forms.Button();
            this.YazdırBtn = new System.Windows.Forms.Button();
            this.TutarLbl = new System.Windows.Forms.Label();
            this.UcretLbl = new System.Windows.Forms.Label();
            this.MarkaFilterCb = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BilgiDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatisFaturaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.SatisCikisLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 79);
            this.panel1.TabIndex = 3;
            // 
            // SatisCikisLabel
            // 
            this.SatisCikisLabel.AutoSize = true;
            this.SatisCikisLabel.BackColor = System.Drawing.Color.Transparent;
            this.SatisCikisLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SatisCikisLabel.ForeColor = System.Drawing.Color.MediumOrchid;
            this.SatisCikisLabel.Location = new System.Drawing.Point(1172, 0);
            this.SatisCikisLabel.Name = "SatisCikisLabel";
            this.SatisCikisLabel.Size = new System.Drawing.Size(28, 26);
            this.SatisCikisLabel.TabIndex = 2;
            this.SatisCikisLabel.Text = "X";
            this.SatisCikisLabel.Click += new System.EventHandler(this.SatisCikisLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(401, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAMET MÜZİK MAĞAZASI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label5.Location = new System.Drawing.Point(15, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enstrüman Adı";
            // 
            // EnsAdTb
            // 
            this.EnsAdTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnsAdTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnsAdTb.Location = new System.Drawing.Point(19, 159);
            this.EnsAdTb.Name = "EnsAdTb";
            this.EnsAdTb.Size = new System.Drawing.Size(180, 19);
            this.EnsAdTb.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumOrchid;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label3.Location = new System.Drawing.Point(19, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 3);
            this.label3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label7.Location = new System.Drawing.Point(241, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Miktar";
            // 
            // EnsMiktarTb
            // 
            this.EnsMiktarTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnsMiktarTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnsMiktarTb.Location = new System.Drawing.Point(241, 159);
            this.EnsMiktarTb.Name = "EnsMiktarTb";
            this.EnsMiktarTb.Size = new System.Drawing.Size(180, 19);
            this.EnsMiktarTb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MediumOrchid;
            this.label8.Location = new System.Drawing.Point(241, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 3);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label9.Location = new System.Drawing.Point(443, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ücret";
            // 
            // EnsUcretTb
            // 
            this.EnsUcretTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnsUcretTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnsUcretTb.Location = new System.Drawing.Point(443, 159);
            this.EnsUcretTb.Name = "EnsUcretTb";
            this.EnsUcretTb.Size = new System.Drawing.Size(180, 19);
            this.EnsUcretTb.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.MediumOrchid;
            this.label10.Location = new System.Drawing.Point(443, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 3);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button1.Location = new System.Drawing.Point(269, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BilgiDGV
            // 
            this.BilgiDGV.BackgroundColor = System.Drawing.Color.White;
            this.BilgiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BilgiDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.BilgiDGV.Location = new System.Drawing.Point(19, 359);
            this.BilgiDGV.Name = "BilgiDGV";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.BilgiDGV.Size = new System.Drawing.Size(527, 288);
            this.BilgiDGV.TabIndex = 40;
            this.BilgiDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BilgiDGV_CellClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button5.Location = new System.Drawing.Point(307, 302);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 37);
            this.button5.TabIndex = 44;
            this.button5.Text = "Yenile";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label12.Location = new System.Drawing.Point(132, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 21);
            this.label12.TabIndex = 43;
            this.label12.Text = "Marka Filtrele";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label4.Location = new System.Drawing.Point(836, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 26);
            this.label4.TabIndex = 45;
            this.label4.Text = "Müşteri Faturası";
            // 
            // SatisFaturaDGV
            // 
            this.SatisFaturaDGV.BackgroundColor = System.Drawing.Color.White;
            this.SatisFaturaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SatisFaturaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SatisFaturaDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.SatisFaturaDGV.Location = new System.Drawing.Point(648, 163);
            this.SatisFaturaDGV.Name = "SatisFaturaDGV";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.SatisFaturaDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SatisFaturaDGV.Size = new System.Drawing.Size(543, 403);
            this.SatisFaturaDGV.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ücret";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Miktar";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Toplam";
            this.Column5.Name = "Column5";
            // 
            // GeriBtn
            // 
            this.GeriBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GeriBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriBtn.ForeColor = System.Drawing.Color.MediumOrchid;
            this.GeriBtn.Location = new System.Drawing.Point(707, 624);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(90, 37);
            this.GeriBtn.TabIndex = 47;
            this.GeriBtn.Text = "Geri";
            this.GeriBtn.UseVisualStyleBackColor = false;
            this.GeriBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TemizleBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemizleBtn.ForeColor = System.Drawing.Color.MediumOrchid;
            this.TemizleBtn.Location = new System.Drawing.Point(887, 624);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(90, 37);
            this.TemizleBtn.TabIndex = 48;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.UseVisualStyleBackColor = false;
            this.TemizleBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // YazdırBtn
            // 
            this.YazdırBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.YazdırBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YazdırBtn.ForeColor = System.Drawing.Color.MediumOrchid;
            this.YazdırBtn.Location = new System.Drawing.Point(1056, 624);
            this.YazdırBtn.Name = "YazdırBtn";
            this.YazdırBtn.Size = new System.Drawing.Size(90, 37);
            this.YazdırBtn.TabIndex = 49;
            this.YazdırBtn.Text = "Yazdır";
            this.YazdırBtn.UseVisualStyleBackColor = false;
            this.YazdırBtn.Click += new System.EventHandler(this.YazdırBtn_Click);
            // 
            // TutarLbl
            // 
            this.TutarLbl.AutoSize = true;
            this.TutarLbl.BackColor = System.Drawing.Color.Transparent;
            this.TutarLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TutarLbl.ForeColor = System.Drawing.Color.MediumOrchid;
            this.TutarLbl.Location = new System.Drawing.Point(861, 582);
            this.TutarLbl.Name = "TutarLbl";
            this.TutarLbl.Size = new System.Drawing.Size(71, 22);
            this.TutarLbl.TabIndex = 50;
            this.TutarLbl.Text = "Tutar =";
            // 
            // UcretLbl
            // 
            this.UcretLbl.AutoSize = true;
            this.UcretLbl.BackColor = System.Drawing.Color.Transparent;
            this.UcretLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UcretLbl.ForeColor = System.Drawing.Color.MediumOrchid;
            this.UcretLbl.Location = new System.Drawing.Point(948, 582);
            this.UcretLbl.Name = "UcretLbl";
            this.UcretLbl.Size = new System.Drawing.Size(55, 22);
            this.UcretLbl.TabIndex = 51;
            this.UcretLbl.Text = "Ücret";
            // 
            // MarkaFilterCb
            // 
            this.MarkaFilterCb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MarkaFilterCb.FormattingEnabled = true;
            this.MarkaFilterCb.Items.AddRange(new object[] {
            "Yamaha",
            "Casio",
            "Suziki",
            "Hercules",
            "Fenix"});
            this.MarkaFilterCb.Location = new System.Drawing.Point(99, 308);
            this.MarkaFilterCb.Name = "MarkaFilterCb";
            this.MarkaFilterCb.Size = new System.Drawing.Size(180, 27);
            this.MarkaFilterCb.TabIndex = 52;
            this.MarkaFilterCb.SelectionChangeCommitted += new System.EventHandler(this.MarkaFilterCb_SelectionChangeCommitted);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 673);
            this.Controls.Add(this.MarkaFilterCb);
            this.Controls.Add(this.UcretLbl);
            this.Controls.Add(this.TutarLbl);
            this.Controls.Add(this.YazdırBtn);
            this.Controls.Add(this.TemizleBtn);
            this.Controls.Add(this.GeriBtn);
            this.Controls.Add(this.SatisFaturaDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BilgiDGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EnsUcretTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EnsMiktarTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EnsAdTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satis";
            this.Load += new System.EventHandler(this.Satis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BilgiDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatisFaturaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SatisCikisLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EnsAdTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EnsMiktarTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EnsUcretTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView BilgiDGV;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView SatisFaturaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button GeriBtn;
        private System.Windows.Forms.Button TemizleBtn;
        private System.Windows.Forms.Button YazdırBtn;
        private System.Windows.Forms.Label TutarLbl;
        private System.Windows.Forms.Label UcretLbl;
        private System.Windows.Forms.ComboBox MarkaFilterCb;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}