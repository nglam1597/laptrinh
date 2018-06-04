using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;


namespace hocbai.UC
{
    public partial class UCKhoHang : UserControl
    {
        public UCKhoHang()
        {
            InitializeComponent();
        }

        private void UCKhoHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhoHang();
        }
        private void HienThiDanhSachKhoHang()
        {
            HienThiKhoHangBLL hienThiKhoHangBLL = new HienThiKhoHangBLL();
            gvDanhSachKhoHang.Rows.Clear();
            foreach (KhoHang khoHang in hienThiKhoHangBLL.LayToanBoKhoHang())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvDanhSachKhoHang);
                dataGridViewRow.Cells[0].Value = khoHang.MaKhoHang;
                dataGridViewRow.Cells[1].Value = khoHang.TenKhoHang;
                dataGridViewRow.Cells[2].Value = khoHang.DiaChi;
                dataGridViewRow.Cells[3].Value = khoHang.SoDienThoai;
                gvDanhSachKhoHang.Rows.Add(dataGridViewRow);

            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void labelX13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dotNetBarManager1_ItemClick(object sender, EventArgs e)
        {

        }

        private void btndahsach_Click(object sender, EventArgs e)
        {
            HienThiDanhSachKhoHang();
        }

        private void gvDanhSachKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow dataGridViewRow = gvDanhSachKhoHang.Rows[e.RowIndex];
                txtMakhohang.Text = dataGridViewRow.Cells[0].Value + "";
                txttenkhohang.Text = dataGridViewRow.Cells[1].Value + "";
                txtdiachi.Text = dataGridViewRow.Cells[2].Value + "";
                txtdienthoai.Text = dataGridViewRow.Cells[3].Value + "";
            }
        }
    }
}
