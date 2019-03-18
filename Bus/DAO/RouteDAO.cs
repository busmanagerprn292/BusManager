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
    class RouteDAO : IDAO<RouteDTO>
    {
        private readonly DBConnection conn;
        public RouteDAO()
        {
            conn = new DBConnection();
        }
        private RouteDTO GetRouteDTOFromDataRow(DataRow row)
        {
            RouteDTO dto = new RouteDTO();
            dto.Id = int.Parse(row["Id"].ToString());
            dto.TuyenDuong = row["TuyenDuong"].ToString();
            return dto;
        }
        public bool Add(RouteDTO dto)
        {
            string query = "Insert into Route values(@id,@name)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int) { Value = dto.Id };
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.NVarChar) { Value = dto.TuyenDuong };
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

        public bool DeleteById(object id)
        {
            string query = "Delete Route Where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int) { Value = Convert.ToInt32(id) };
            try
            {
                conn.ExecuteDeleteQuery(query, sqlParameters);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<RouteDTO> GetAll()
        {
            string query = string.Format("select * from Route");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            List<RouteDTO> list = new List<RouteDTO>();

            foreach (DataRow r in dt.Rows)
            {
                RouteDTO route = GetRouteDTOFromDataRow(r);
                list.Add(route);
            }

            return list;
        }

        public RouteDTO SearchById(object id)
        {
            string query = "Select * From Route Where Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);

            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return GetRouteDTOFromDataRow(dt.Rows[0]);
            }
            return null;
        }

        public bool Update(RouteDTO dto)
        {
            string query = "Update Route set TuyenDuong = @name Where Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.NVarChar) { Value = dto.TuyenDuong };
            sqlParameters[1] = new SqlParameter("@id", SqlDbType.Int) { Value = dto.Id };
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
