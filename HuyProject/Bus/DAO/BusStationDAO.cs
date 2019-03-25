using Bus.BLL;
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
    public class BusStationDAO : IDAO<BusStationDTO>
    {
        private readonly DBConnection conn;

        public BusStationDAO()
        {
            conn = new DBConnection();
        }
        private BusStationDTO GetBusStationDTOFromDataRow(DataRow row)
        {
            BusStationDTO dto = new BusStationDTO();
            dto.ID = int.Parse(row["ID"].ToString());
            dto.BusID = row["BusID"].ToString();
            dto.MSNVDRIVER = row["MSNVDRIVER"].ToString();
            dto.MSNVCAST = row["MSNVCAST"].ToString();
            dto.DepartureTime = row["DepartureTime"].ToString();
            dto.TimeBack = row["TimeBack"].ToString();
            dto.Status = row["Status"].ToString();
            return dto;
        }
        public bool Add(BusStationDTO dto)
        {
            string query = "Insert into BusStation values(@BusID,@MSNVDRIVER,@DepartureTime,@TimeBack,@MSNVCAST,@Status)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@BusID", SqlDbType.NVarChar) { Value = dto.BusID };
            sqlParameters[1] = new SqlParameter("@MSNVDRIVER", SqlDbType.NVarChar) { Value = dto.MSNVDRIVER };
            sqlParameters[2] = new SqlParameter("@TimeBack", SqlDbType.DateTime) { Value = dto.TimeBack };
            sqlParameters[3] = new SqlParameter("@MSNVCAST", SqlDbType.NVarChar) { Value = dto.MSNVCAST };
            sqlParameters[4] = new SqlParameter("@Status", SqlDbType.Int) { Value = dto.Status };
            sqlParameters[5] = new SqlParameter("@DepartureTime", SqlDbType.DateTime) { Value = dto.DepartureTime };
            try
            {
                conn.ExecuteInsertQuery(query, sqlParameters);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        //public List<>

        public bool DeleteById(object id)
        {
            throw new NotImplementedException();
        }

        public List<BusStationDTO> GetAllBus()
        {
            string query = "Select * from BusStation";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            try
            {
                DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
                List<BusStationDTO> list = new List<BusStationDTO>();
                foreach (DataRow r in dt.Rows)
                {
                    BusStationDTO dto = GetBusStationDTOFromDataRow(r);
                    list.Add(dto);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<BusStationDTO> SearchScheduleOfBusByBusId(string busId)
        {
            string query = "Select * from BusStation Where BusId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.NVarChar) { Value = busId.ToString() };

            try
            {
                DataTable dt = conn.ExecuteSelectQuery(query, sqlParameters);
                List<BusStationDTO> list = new List<BusStationDTO>();
                foreach (DataRow r in dt.Rows)
                {
                    BusStationDTO dto = GetBusStationDTOFromDataRow(r);
                    list.Add(dto);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(BusStationDTO dto)
        {
            throw new NotImplementedException();
        }

        public BusStationDTO SearchById(object id)
        {
            throw new NotImplementedException();
        }

        BusStationDAO IDAO<BusStationDAO>.SearchById(object id)
        {
            throw new NotImplementedException();
        }

        List<BusStationDTO> IDAO<BusStationDTO>.GetAll()
        {
            throw new NotImplementedException();
        }

        BusStationDTO IDAO<BusStationDTO>.SearchById(object id)
        {
            throw new NotImplementedException();
        }

    }
}
