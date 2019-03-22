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
    public class BusDAO : IDAO<BusDTO>
    {
        private readonly DBConnection conn;
        public BusDAO()
        {
            conn = new DBConnection();
        }
        private BusDTO GetBusDTOFromDataRow(DataRow row)
        {
            BusDTO dto = new BusDTO();
            dto.Id = row["BusId"].ToString();
            dto.BSX = row["BSX"].ToString();
            dto.Brand = row["Brand"].ToString();
            dto.OwnerID = row["OwnerId"].ToString();
            dto.RouteID = row["IDTuyenDuong"].ToString();
            dto.DateRegistration = DateTime.Parse(row["DateRegistration"].ToString());
            return dto;
        }
        public List<BusDTO> GetAll()
        {
            string query = string.Format("select * from Bus");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            List<BusDTO> list = new List<BusDTO>();

            foreach (DataRow r in dt.Rows)
            {
                BusDTO bus = GetBusDTOFromDataRow(r);
                list.Add(bus);
            }

            return list;
        }
        public bool Add(BusDTO dto)
        {
            string query = "Insert into Bus values(@id,@bsx,@brand,@DateRegistration,@ownerId,@idTuyenDuong)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = dto.Id };
            sqlParameters[1] = new SqlParameter("@bsx", SqlDbType.NVarChar) { Value = dto.BSX };
            sqlParameters[2] = new SqlParameter("@brand", SqlDbType.NVarChar) { Value = dto.Brand };
            sqlParameters[3] = new SqlParameter("@DateRegistration", SqlDbType.Date) { Value = dto.DateRegistration };
            sqlParameters[4] = new SqlParameter("@ownerId", SqlDbType.NVarChar) { Value = dto.OwnerID };
            sqlParameters[5] = new SqlParameter("@idTuyenDuong", SqlDbType.Int) { Value = dto.RouteID };
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

        public bool Update(BusDTO dto)
        {
            string query = "Update Bus set BSX = @bsx , brand = @brand , DateRegistration = @DateRegistration , OwnerId = @ownerId , IdTuyenDuong = @idTuyenDuong Where busId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = dto.Id };
            sqlParameters[1] = new SqlParameter("@bsx", SqlDbType.NVarChar) { Value = dto.BSX };
            sqlParameters[2] = new SqlParameter("@brand", SqlDbType.NVarChar) { Value = dto.Brand };
            sqlParameters[3] = new SqlParameter("@DateRegistration", SqlDbType.Date) { Value = dto.DateRegistration };
            sqlParameters[4] = new SqlParameter("@ownerId", SqlDbType.NVarChar) { Value = dto.OwnerID };
            sqlParameters[5] = new SqlParameter("@idTuyenDuong", SqlDbType.Int) { Value = int.Parse(dto.RouteID) };
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

        public bool DeleteById(object id)
        {
            string query = "Delete Bus Where busId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = id };
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

        public BusDTO SearchById(object id)
        {
            string query = "Select * From Bus Where BusId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar);
            sqlParameters[0].Value = id;

            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return GetBusDTOFromDataRow(dt.Rows[0]);
            }
            return null;
        }
        
    }
}
