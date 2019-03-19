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
    class StaffDao : IDAO<StaffDTO>
    {

        private readonly DBConnection conn;
        public StaffDao()
        {
            conn = new DBConnection();
        }
        public bool Add(StaffDTO dto)
        {
            bool check = true;
            string sql = "insert into Staff values (@MSNV,@CMND,@Name,@DateOfBirth,@Phone,@Role) ";
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[6];
                sqlParameters[0] = new SqlParameter("@MSNV", SqlDbType.NVarChar) { Value = dto.MSNV };
                sqlParameters[1] = new SqlParameter("@CMND", SqlDbType.NVarChar) { Value = dto.MSNV };
                sqlParameters[2] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = dto.MSNV };
                sqlParameters[3] = new SqlParameter("@DateOfBirth", SqlDbType.NVarChar) { Value = dto.MSNV };
                sqlParameters[4] = new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = dto.MSNV };
                sqlParameters[5] = new SqlParameter("@Role", SqlDbType.NVarChar) { Value = dto.MSNV };
                check = conn.ExecuteInsertQuery(sql, sqlParameters);

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return check;
        }

        public bool DeleteById(object id)
        {
            bool check = true;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            string sql = "delete from Staff where MSNV = @id";
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = id };
            try
            {
                check = conn.ExecuteUpdateQuery(sql, sqlParameters);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return check;
        }

        public List<StaffDTO> GetAll()
        {
            List<StaffDTO> list = new List<StaffDTO>();
            string sql = "select MSNV,CMND,Name,DateOfBirth,Phone,Role from staff";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = conn.ExecuteSelectQuery(sql, sqlParameters);

            foreach (DataRow i in dt.Rows)
            {
                list.Add(GetDataRow(i));
            }
            return list;
        }

        private StaffDTO GetDataRow(DataRow row)
        {
            StaffDTO dto = new StaffDTO();
            dto.CMND = row["CMND"].ToString();
            dto.RoleID = row["Role"].ToString();
            dto.Phone = row["Phone"].ToString();
            dto.MSNV = row["MSNV"].ToString();
            dto.Name = row["Name"].ToString();
            dto.Date = row["DateOfBirth"].ToString();
            dto.CMND = row["CMND"].ToString();
            return dto;
        }

        public StaffDTO SearchById(object id)
        {
            string sql = "select MSNV,CMND,Name,DateOfBirth,Phone,Role from staff where msnv = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = id };
            DataTable dt = conn.ExecuteSelectQuery(sql, sqlParameters);
            if (dt.Rows.Count > 0)
            {

                return GetDataRow(dt.Rows[0]);
            }
            return null;
        }

        public bool Update(StaffDTO dto)
        {
            bool check = true;
            string sql = "update staff  set  (CMND=@cmnd,Name=@name,DateOfBirth=@date,Phone=@phone,Role=@role) where msnv = @msnv";
            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@cmnd", SqlDbType.NVarChar) { Value = dto.CMND};
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.NVarChar) { Value = dto.Name};
            sqlParameters[2] = new SqlParameter("@date", SqlDbType.NVarChar) { Value = dto.Date};
            sqlParameters[3] = new SqlParameter("@phone", SqlDbType.NVarChar) { Value = dto.Phone};
            sqlParameters[4] = new SqlParameter("@role", SqlDbType.NVarChar) { Value = dto.RoleID};
            sqlParameters[5] = new SqlParameter("@msnv", SqlDbType.NVarChar) { Value = dto.MSNV };
            try
            {
                check = conn.ExecuteUpdateQuery(sql, sqlParameters);
                return check;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
