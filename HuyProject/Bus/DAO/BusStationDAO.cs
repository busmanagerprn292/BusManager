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
    public class BusStationDAO : IDAO<BusStationDAO>
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
            dto.Status = int.Parse(row["Status"].ToString());
            return dto;
        }
        public bool Add(BusStationDAO dto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(object id)
        {
            throw new NotImplementedException();
        }

        public List<BusStationDAO> GetAll()
        {
            throw new NotImplementedException();
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

        public bool Update(BusStationDAO dto)
        {
            throw new NotImplementedException();
        }

        public BusStationDAO SearchById(object id)
        {
            throw new NotImplementedException();
        }
    }
}
