using Bus.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.DAO
{
    class TuyenDuongDAO
    {
        private DBConnection conn;
        public TuyenDuongDAO()
        {
            conn = new DBConnection();
        }

        private TuyenDuongDTO GetStudentFromDataRow(DataRow row)
        {
            TuyenDuongDTO td = new TuyenDuongDTO();

            td.BSX = row["BSX"].ToString();
            td.Id =int.Parse( row["id"].ToString().Trim());
            td.Tuyenduong = row["Tuyenduong"].ToString();
            return td;
        }


        public bool Delete(int id)
        {
            string sql = " delete from ... where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = id };

            try
            {
                conn.ExecuteUpdateQuery(sql, sqlParameters);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<TuyenDuongDTO> GetAll()
        {
            string query = string.Format("select BSX,Id,TuyenDuong from TuyenDuong");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            List<TuyenDuongDTO> list = new List<TuyenDuongDTO>();

            foreach (DataRow r in dt.Rows)
            {
                TuyenDuongDTO td = GetStudentFromDataRow(r);
                list.Add(td);
            }

            return list;
        }

        public BusDTO SearchById(int _id)
        {
            string query = "select * from ... where Id LIKE @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            sqlParameters[0].Value = _id;

            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return GetStudentFromDataRow(dt.Rows[0]);
            }

            return null;
        }

        public bool Add(BusDTO bus)
        {
            string query = "INSERT INTO ... values(@BXS,@MAKE,@DateRegistration)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@BXS", SqlDbType.NVarChar) { Value = bus.BSX };
            sqlParameters[1] = new SqlParameter("@DateRegistration", SqlDbType.NVarChar) { Value = bus.DateRegistration };
            sqlParameters[2] = new SqlParameter("@MAKE", SqlDbType.NVarChar) { Value = bus.Make };
            try
            {
                conn.ExecuteInsertQuery(query, sqlParameters);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(BusDTO bus)
        {
            string query = "UPDATE ... SET BXS=@BXS, MAKE=@MAKE,DateRegistration=@DateRegistration WHERE id=@Id";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@BXS", SqlDbType.NVarChar) { Value = bus.BSX };
            sqlParameters[1] = new SqlParameter("@MAKE", SqlDbType.NVarChar) { Value = bus.Make };
            sqlParameters[2] = new SqlParameter("@DateRegistration", SqlDbType.Int) { Value = bus.DateRegistration };
            try
            {
                conn.ExecuteUpdateQuery(query, sqlParameters);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
