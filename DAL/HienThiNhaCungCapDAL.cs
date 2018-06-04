using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;


namespace DAL
{
    public class HienThiNhaCungCapDAL : DataAccess
    {
        public List<NhaCungCap> HienThiDanhSachNCC()
        {
            try
            {
                List<NhaCungCap> DanhSachNCC = new List<NhaCungCap>();
                OpenDataBase();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "HienThiNhaCungCap";
                sqlCommand.Connection = sqlConnection;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    NhaCungCap nhaCungCap = new NhaCungCap()
                    {
                        MaNhaCungCap = sqlDataReader[0].ToString(),
                        TenNhaCungCap = sqlDataReader[1].ToString(),
                        DiaChi = sqlDataReader[2].ToString(),
                        SoDienThoai = sqlDataReader[3].ToString()
                    };
                    DanhSachNCC.Add(nhaCungCap);
                }
                CloseDataBase();
                return DanhSachNCC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
