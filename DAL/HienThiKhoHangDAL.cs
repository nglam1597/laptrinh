using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class HienThiKhoHangDAL : DataAccess
    {
        public List<KhoHang> LayToanBoKhoHang()
        {
            try
            {
                List<KhoHang> DanhSachKhoHang = new List<KhoHang>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiDanhSachKhoHang";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    KhoHang khoHang = new KhoHang()
                    {
                        MaKhoHang = sqlDataReader.GetString(0),
                        TenKhoHang = sqlDataReader.GetString(1),
                        DiaChi = sqlDataReader.GetString(2),
                        SoDienThoai = sqlDataReader.GetString(3)
                    };
                    DanhSachKhoHang.Add(khoHang);
                }
                sqlDataReader.Close();
                return DanhSachKhoHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
