using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HienThiNhaCungCapBLL
    {
        HienThiNhaCungCapDAL HienThiNhaCungCapDAL = new HienThiNhaCungCapDAL();

        public List<NhaCungCap> HienThiDanhSachNCC()
        {
            return HienThiNhaCungCapDAL.HienThiDanhSachNCC();
        }
    }
}
