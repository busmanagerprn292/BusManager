using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bus.DTO;

namespace Bus.DAO
{
    class BusDAO
    {
        private DBConnection conn;
        public BusDAO()
        {
            conn = new DBConnection();
        }
        private BusDTO GetStudentFromDataRow(DataRow row)
        {
            BusDTO bus = new BusDTO();

            bus.BSX = row["BXS"].ToString();
            bus.Make = row["Make"].ToString().Trim();
            bus.DateRegistration = row["DateRegistration"].ToString().Trim();
            return bus;
        }

        public bool Delete(int id)
        {
            string sql = " delete from Bus where BSX like @id";
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

        public List<BusDTO> GetAll()
        {
            string query = string.Format("select BSX,Make,DateRegistration from Bus");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            List<BusDTO> list = new List<BusDTO>();

            foreach (DataRow r in dt.Rows)
            {
                BusDTO bus = GetStudentFromDataRow(r);
                list.Add(bus);
            }

            return list;
        }

        public BusDTO SearchById(int _id)
        {
            string query = "select BSX,Make,DateRegistration from Bus where BSX LIKE @Id";
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
            string query = "INSERT INTO BUS values(@BXS,@MAKE,@DateRegistration)";
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
            string query = "UPDATE BUS SET BXS=@BXS, MAKE=@MAKE,DateRegistration=@DateRegistration WHERE id=@Id";
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
