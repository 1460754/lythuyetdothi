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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
         ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // sodinh
         // 
         this.sodinh.Location = new System.Drawing.Point(180, 145);
         this.sodinh.Name = "sodinh";
         this.sodinh.Size = new System.Drawing.Size(256, 20);
         this.sodinh.TabIndex = 0;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(446, 143);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(118, 23);
         this.button1.TabIndex = 1;
         this.button1.Text = "Nhập Số Đỉnh";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // dd
         // 
         this.dd.Enabled = false;
         this.dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dd.FormattingEnabled = true;
         this.dd.Location = new System.Drawing.Point(27, 217);
         this.dd.Name = "dd";
         this.dd.Size = new System.Drawing.Size(51, 28);
         this.dd.TabIndex = 7;
         // 
         // dc
         // 
         this.dc.Enabled = false;
         this.dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dc.FormattingEnabled = true;
         this.dc.Location = new System.Drawing.Point(102, 217);
         this.dc.Name = "dc";
         this.dc.Size = new System.Drawing.Size(51, 28);
         this.dc.TabIndex = 8;
         // 
         // trongso
         // 
         this.trongso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.trongso.Location = new System.Drawing.Point(180, 217);
         this.trongso.Name = "trongso";
         this.trongso.Size = new System.Drawing.Size(103, 26);
         this.trongso.TabIndex = 9;
         // 
         // button2
         // 
         this.button2.Enabled = false;
         this.button2.Location = new System.Drawing.Point(27, 270);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(231, 35);
         this.button2.TabIndex = 10;
         this.button2.Text = "Thêm";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // dt
         // 
         this.dt.AllowUserToAddRows = false;
         this.dt.AllowUserToDeleteRows = false;
         this.dt.AllowUserToOrderColumns = true;
         this.dt.AllowUserToResizeColumns = false;
         this.dt.AllowUserToResizeRows = false;
         this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dt.ColumnHeadersVisible = false;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dt.DefaultCellStyle = dataGridViewCellStyle1;
         this.dt.Location = new System.Drawing.Point(314, 198);
         this.dt.MultiSelect = false;
         this.dt.Name = "dt";
         this.dt.ReadOnly = true;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dt.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.dt.RowHeadersVisible = false;
         this.dt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
         this.dt.RowsDefaultCellStyle = dataGridViewCellStyle3;
         this.dt.ScrollBars = System.Windows.Forms.ScrollBars.None;
         this.dt.Size = new System.Drawing.Size(518, 351);
         this.dt.TabIndex = 11;
         this.dt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellClick);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(24, 146);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(140, 17);
         this.label1.TabIndex = 12;
         this.label1.Text = "Ma Trận Trọng Số";
         // 
         // button3
         // 
         this.button3.Enabled = false;
         this.button3.Location = new System.Drawing.Point(27, 458);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(231, 34);
         this.button3.TabIndex = 13;
         this.button3.Text = "Hoàn tất";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(207, 186);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(57, 15);
         this.label4.TabIndex = 28;
         this.label4.Text = "Trọng Số";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.Transparent;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(101, 186);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(59, 15);
         this.label3.TabIndex = 27;
         this.label3.Text = "Đỉnh cuối";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(24, 186);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(57, 15);
         this.label2.TabIndex = 26;
         this.label2.Text = "Đỉnh đầu";
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(27, 513);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(231, 34);
         this.button4.TabIndex = 29;
         this.button4.Text = "Hủy Bỏ";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // button5
         // 
         this.button5.Enabled = false;
         this.button5.Location = new System.Drawing.Point(27, 395);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(231, 37);
         this.button5.TabIndex = 30;
         this.button5.Text = "Lưu  Đồ Thị (.txt)";
         this.button5.UseVisualStyleBackColor = true;
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
         this.button6.Enabled = false;
         this.button6.Location = new System.Drawing.Point(27, 334);
         this.button6.Name = "button6";
         this.button6.Size = new System.Drawing.Size(231, 38);
         this.button6.TabIndex = 31;
         this.button6.Text = "Ma Trận Ngẫu Nhiên";
         this.button6.UseVisualStyleBackColor = true;
         this.button6.Click += new System.EventHandler(this.button6_Click);
         // 
         // Nhapmatran
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(995, 561);
         this.ContextMenuStrip = this.contextMenuStrip1;
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
    }
}