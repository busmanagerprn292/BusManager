using Bus.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.DAO
{
    class OwnerDAO : IDAO<OwnerDTO>
    {
        private readonly DBConnection conn;
        public OwnerDAO()
        {
            conn = new DBConnection();
        }
        private OwnerDTO GetOwnerDTOFromDataRow(DataRow row)
        {
            OwnerDTO dto = new OwnerDTO();
            dto.Id = row["Id"].ToString();
            dto.Name = row["Name"].ToString();
            dto.Phone = row["Phone"].ToString();
            dto.DateOfBirth = DateTime.Parse(row["DateOfBirth"].ToString());
            dto.CMND = row["CMND"].ToString();
            dto.Address= row["Address"].ToString();
            return dto;
        }
        public bool Add(OwnerDTO dto)
        {
            string query = "Insert into Owner values(@id,@name,@phone,@DoB,@CMND,@address)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = dto.Id };
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.NVarChar) { Value = dto.Name };
            sqlParameters[2] = new SqlParameter("@phone", SqlDbType.NVarChar) { Value = dto.Phone };
            sqlParameters[3] = new SqlParameter("@DoB", SqlDbType.Date) { Value = dto.DateOfBirth };
            sqlParameters[4] = new SqlParameter("@CMND", SqlDbType.NVarChar) { Value = dto.CMND };
            sqlParameters[5] = new SqlParameter("@address", SqlDbType.NVarChar) { Value = dto.Address };
            try
            {
                conn.ExecuteInsertQuery(query, sqlParameters);
                return true;
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.Message);
                throw ex;
            }
        }

        public bool DeleteById(object id)
        {
            string query = "Delete Owner Where Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = id.ToString() };
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

        public List<OwnerDTO> GetAll()
        {
            string query = string.Format("select * from Owner");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            List<OwnerDTO> list = new List<OwnerDTO>();

            foreach (DataRow r in dt.Rows)
            {
                OwnerDTO owner = GetOwnerDTOFromDataRow(r);
                list.Add(owner);
            }

            return list;
        }

        public OwnerDTO SearchById(object id)
        {
            string query = "Select * From Owner Where Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar);
            sqlParameters[0].Value = id.ToString();

            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return GetOwnerDTOFromDataRow(dt.Rows[0]);
            }
            return null;
        }

        public bool Update(OwnerDTO dto)
        {
            string query = "Update Owner set Name = @name , Phone = @phone, DateOfBirth = @DoB , CMND = @CMND , Address = @address Where Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = dto.Id };
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.NVarChar) { Value = dto.Name };
            sqlParameters[2] = new SqlParameter("@phone", SqlDbType.NVarChar) { Value = dto.Phone };
            sqlParameters[3] = new SqlParameter("@DoB", SqlDbType.Date) { Value = dto.DateOfBirth };
            sqlParameters[4] = new SqlParameter("@CMND", SqlDbType.NVarChar) { Value = dto.CMND };
            sqlParameters[5] = new SqlParameter("@address", SqlDbType.NVarChar) { Value = dto.Address };
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
        public List<BusDTO> GetListBusOfOwner(string id)
        {
            string query = string.Format("select * from Bus , Owner Where bus.OwnerId = Owner.Id and Owner.Id = @id");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = id };
            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            List<BusDTO> list = new List<BusDTO>();

            foreach (DataRow r in dt.Rows)
            {
                BusDTO bus = new BusDTO();
                bus.Id = r["BusID"].ToString();
                bus.BSX = r["BSX"].ToString();
                bus.Brand = r["Brand"].ToString();
                bus.DateRegistration = DateTime.Parse(r["DateRegistration"].ToString());
                bus.OwnerID = r["OwnerId"].ToString();
                bus.RouteID = r["IDTuyenDuong"].ToString();
                list.Add(bus);
            }
            return list;
        }
    }
}
