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
            string query = "select * from Bus";
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
        public bool DeleteAllScheduleOfBus(string busId)
        {
            string query = "Delete BusStation Where busId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = busId };
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
        public BusStationGridView GetDetailOfScheduleById(int scheduleId)
        {
            string query = "Select * From BusStation Where Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = scheduleId;

            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                BusStationGridView dto = new BusStationGridView();
                dto.ID = int.Parse(dt.Rows[0]["ID"].ToString());
                dto.BusID = dt.Rows[0]["BusID"].ToString();
                dto.MSNVDRIVER = dt.Rows[0]["MSNVDRIVER"].ToString();
                dto.MSNVCAST = dt.Rows[0]["MSNVCAST"].ToString();
                dto.DepartureTime =  dt.Rows[0]["DepartureTime"].ToString();
                dto.TimeBack = dt.Rows[0]["TimeBack"].ToString();
                dto.Status = dt.Rows[0]["Status"].ToString();
                return dto;
            }
            return null;
        }
        public String GetRoleNameById (string roleId)
        {
            string query = "Select NameRole From Role Where Role = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar);
            sqlParameters[0].Value = roleId;

            DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["NameRole"].ToString();
            }
            return null;
        }
        public List<BusStationGridView> SearchScheduleOfBusByBusId(string busId)
        {
            string query = "Select * from BusStation Where BusId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = busId.ToString() };

            try
            {
                DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
                List<BusStationGridView> list = new List<BusStationGridView>();
                foreach (DataRow r in dt.Rows)
                {
                    BusStationGridView dto = GetBusStationDTOFromDataRow(r);
                    list.Add(dto);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private BusStationGridView GetBusStationDTOFromDataRow(DataRow row)
        {
            BusStationGridView dto = new BusStationGridView();
            dto.ID = int.Parse(row["ID"].ToString());
            dto.BusID = row["BusID"].ToString();
            dto.MSNVDRIVER = row["MSNVDRIVER"].ToString();
            dto.MSNVCAST = row["MSNVCAST"].ToString();
            dto.DepartureTime = row["DepartureTime"].ToString();
            dto.TimeBack = row["TimeBack"].ToString();
            dto.Status = row["Status"].ToString();
            return dto;
        }
        public bool AddBusStation(BusStationGridView dto)
        {
            string query = "Insert into BusStation values(@busId,@MSNVDRIVER,@DepartureTime,@TimeBack,@MSNVCAST,@Status)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@busId", SqlDbType.NVarChar) { Value = dto.BusID };
            sqlParameters[1] = new SqlParameter("@MSNVDRIVER", SqlDbType.NVarChar) { Value = dto.MSNVDRIVER };
            sqlParameters[2] = new SqlParameter("@DepartureTime", SqlDbType.NVarChar) { Value = dto.DepartureTime};
            sqlParameters[3] = new SqlParameter("@TimeBack", SqlDbType.NVarChar) { Value = dto.TimeBack };
            sqlParameters[4] = new SqlParameter("@MSNVCAST", SqlDbType.NVarChar) { Value = dto.MSNVCAST };
            sqlParameters[5] = new SqlParameter("@Status", SqlDbType.NVarChar) { Value = dto.Status };
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

        public bool DeleteBusStationById(int id)
        {
            string query = "Delete BusStation Where Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int) { Value = id };
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
        public bool UpdateBusStation(BusStationGridView dto)
        {
            string query = "Update BusStation set BusId = @busId, MSNVDRIVER= @MSNVDRIVER, DepartureTime = @DepartureTime , TimeBack = @TimeBack , MSNVCAST = @MSNVCAST Where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int) { Value = dto.ID };
            sqlParameters[1] = new SqlParameter("@busId", SqlDbType.NVarChar) { Value = dto.BusID };
            sqlParameters[2] = new SqlParameter("@MSNVDRIVER", SqlDbType.NVarChar) { Value = dto.MSNVDRIVER };
            sqlParameters[3] = new SqlParameter("@DepartureTime", SqlDbType.NVarChar) { Value = dto.DepartureTime };
            sqlParameters[4] = new SqlParameter("@TimeBack", SqlDbType.NVarChar) { Value = dto.TimeBack };
            sqlParameters[5] = new SqlParameter("@MSNVCAST", SqlDbType.NVarChar) { Value = dto.MSNVCAST };
            //sqlParameters[5] = new SqlParameter("@Status", SqlDbType.NVarChar) { Value = dto.Status };
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
