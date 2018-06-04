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
    public partial class UCNhaCungCap : UserControl
    {
        public UCNhaCungCap()
        {
            InitializeComponent();
        }
        private void UCNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNCC();
        }
        private void HienThiDanhSachNCC()
        {
            HienThiNhaCungCapBLL hienThiNhaCungCapBLL = new HienThiNhaCungCapBLL();
            gvNhaCungCap.Rows.Clear();
            foreach (NhaCungCap nhaCungCap in hienThiNhaCungCapBLL.HienThiDanhSachNCC())
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(gvNhaCungCap);
                dataGridViewRow.Cells[0].Value = nhaCungCap.MaNhaCungCap;
                dataGridViewRow.Cells[1].Value = nhaCungCap.TenNhaCungCap;
                dataGridViewRow.Cells[2].Value = nhaCungCap.DiaChi;
                dataGridViewRow.Cells[3].Value = nhaCungCap.SoDienThoai;
                gvNhaCungCap.Rows.Add(dataGridViewRow);
            }
        }


        private void btndahsach_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNCC();
        }

        private void gvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
