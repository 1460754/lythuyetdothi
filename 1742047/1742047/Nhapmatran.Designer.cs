namespace FordBell
{
    partial class Nhapmatran
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhapmatran));
            this.sodinh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dd = new System.Windows.Forms.ComboBox();
            this.dc = new System.Windows.Forms.ComboBox();
            this.trongso = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xuấtRaFileĐồThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sodinh
            // 
            this.sodinh.Location = new System.Drawing.Point(12, 130);
            this.sodinh.Name = "sodinh";
            this.sodinh.Size = new System.Drawing.Size(57, 20);
            this.sodinh.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nhập Số Đỉnh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dd
            // 
            this.dd.Enabled = false;
            this.dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd.FormattingEnabled = true;
            this.dd.Location = new System.Drawing.Point(324, 101);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(51, 28);
            this.dd.TabIndex = 7;
            // 
            // dc
            // 
            this.dc.Enabled = false;
            this.dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dc.FormattingEnabled = true;
            this.dc.Location = new System.Drawing.Point(399, 101);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(51, 28);
            this.dc.TabIndex = 8;
            // 
            // trongso
            // 
            this.trongso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trongso.Location = new System.Drawing.Point(477, 101);
            this.trongso.Name = "trongso";
            this.trongso.Size = new System.Drawing.Size(55, 26);
            this.trongso.TabIndex = 9;
            this.trongso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trongso_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(548, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToOrderColumns = true;
            this.dt.AllowUserToResizeColumns = false;
            this.dt.AllowUserToResizeRows = false;
            this.dt.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle4;
            this.dt.GridColor = System.Drawing.SystemColors.Control;
            this.dt.Location = new System.Drawing.Point(206, 133);
            this.dt.MultiSelect = false;
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dt.RowHeadersVisible = false;
            this.dt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dt.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dt.Size = new System.Drawing.Size(518, 351);
            this.dt.TabIndex = 11;
            this.dt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập Ma Trận Trọng Số";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(727, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "Hoàn tất";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Trọng Số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cột";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hàng";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(727, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 34);
            this.button4.TabIndex = 29;
            this.button4.Text = "Hủy Bỏ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(727, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 29);
            this.button5.TabIndex = 30;
            this.button5.Text = "Lưu  Đồ Thị (.txt)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtRaFileĐồThịToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 26);
            // 
            // xuấtRaFileĐồThịToolStripMenuItem
            // 
            this.xuấtRaFileĐồThịToolStripMenuItem.Name = "xuấtRaFileĐồThịToolStripMenuItem";
            this.xuấtRaFileĐồThịToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.xuấtRaFileĐồThịToolStripMenuItem.Text = "Xuất ra File Đồ Thị";
            this.xuấtRaFileĐồThịToolStripMenuItem.Click += new System.EventHandler(this.xuấtRaFileĐồThịToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(727, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 31);
            this.button6.TabIndex = 31;
            this.button6.Text = "Ma Trận Ngẫu Nhiên";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 161);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(169, 323);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Nhapmatran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 500);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trongso);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sodinh);
            this.Name = "Nhapmatran";
            this.Text = "Nhập Liệu Đồ Thị";
            this.Load += new System.EventHandler(this.Nhapmatran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sodinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dd;
        private System.Windows.Forms.ComboBox dc;
        private System.Windows.Forms.TextBox trongso;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xuấtRaFileĐồThịToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}