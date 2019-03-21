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
    class RoleDao
    {
        private readonly DBConnection conn;
        public RoleDao()
        {
            conn = new DBConnection();
        }

        public RoleDTO GetRoleRow(DataRow row)
        {
            RoleDTO dt = new RoleDTO();

            dt.RoleID = row["roleId"].ToString();
            dt.RoleName = row["RoleName"].ToString();

            return dt;
        }
        public List<RoleDTO> GetAll()
        {
            string sql = "Select * from role ";
            List<RoleDTO> list = new List<RoleDTO>();
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = conn.ExecuteSelectQuery(sql, sqlParameters);
            foreach (DataRow i in dt.Rows)
            {
                list.Add(GetRoleRow(i));
            }
            return list;
        }
    }
}
