using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FordBell
{
    public partial class suamatran : Form
    {
        public suamatran()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tam.matran = mt;
            this.Close();
            
        }
        int[,] mt;
        int sdinh;
        private void suamatran_Load(object sender, EventArgs e)
        {
            mt = tam.matran;
            sdinh = tam.sodinh;
            ToListView();
            dd.Items.Clear();
            dc.Items.Clear();
            for (int i = 1; i <= sdinh;i++ )
            {
                dd.Items.Add(i);
                dc.Items.Add(i);
            }
        }
        void ToListView()
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            int wid = dt.Width / sdinh;
            int hei = dt.Height / sdinh;
            for (int i = 1; i <= sdinh; i++)
            {
                
                dt.Columns.Add(i.ToString(), i.ToString());
                
                dt.Columns[i - 1].Width = wid;
            }


            for (int i = 0; i < sdinh; i++)
            {
                dt.Rows.Add();
                dt.Rows[i].Height = hei;
                
                for (int j = 0; j < sdinh; j++)
                {
                    if(i==j)
                    {
                        dt[j, i].Value = "0";
                    }
                    else if (mt[i, j] == 9999999  )
                    {
                        dt[j, i].Value = "∞";
                    }
                    
                    else
                        dt[j, i].Value = mt[i, j];
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int dinhdau = int.Parse(dd.Text);
                int dinhcuoi = int.Parse(dc.Text);
                int ts;
                if (trongso.Text == "")
                {
                    ts = 9999999;
                }
                else
                    ts = int.Parse(trongso.Text);
                if (dinhdau != dinhcuoi)
                {
                    mt[dinhdau - 1, dinhcuoi - 1] = mt[dinhcuoi - 1, dinhdau - 1] = ts;
                }
                else
                    MessageBox.Show("Khoảng cách này không thể sửa !!!");

                ToListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void dt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dd.Text = (e.RowIndex + 1).ToString();
            dc.Text = (e.ColumnIndex + 1).ToString();
            
            trongso.Text = mt[e.RowIndex, e.ColumnIndex].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Tập tin đồ thị |*.txt";
                saveFileDialog1.ShowDialog();
                System.IO.StreamWriter ghi = new System.IO.StreamWriter(saveFileDialog1.FileName);
                ghi.WriteLine(sdinh);
                for (int i = 0; i < sdinh; i++)
                {
                    string st = "";
                    for (int j = 0; j < sdinh; j++)
                    {
                        if (mt[i,j]==9999999)
                            st +=   "0 ";
                        else
                        st += mt[i, j] + " ";
                    }
                    ghi.WriteLine(st);
                }
                ghi.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
