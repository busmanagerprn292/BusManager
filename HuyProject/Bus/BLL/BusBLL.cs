using Bus.DAO;
using Bus.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.BLL
{
    class BusBLL
    {
        private BusDAO dao;
        public BusBLL()
        {
            dao = new BusDAO();
        }
        public List<BusDTO> GetBusList()
        {
            return dao.GetAll();
        }
        public BusDTO GetBusById(string id)
        {
            return dao.SearchById(id);
        }
        public void InsertBus(string id, string bsx, string brand, DateTime dateRegistration, string ownerId, string routeId)
        {
            try
            {
                BusDTO dto = new BusDTO { Id = id, Brand = brand, BSX = bsx, DateRegistration = dateRegistration, OwnerID = ownerId, RouteID = routeId };
                dao.Add(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateBus(string id, string bsx, string brand, DateTime dateRegistration, string ownerId, string routeId)
        {
            try
            {
                BusDTO dto = new BusDTO { Id = id, Brand = brand, BSX = bsx, DateRegistration = dateRegistration, OwnerID = ownerId, RouteID = routeId };
                dao.Update(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteBus(string id)
        {
            try
            {
                dao.DeleteById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BusStationDTO> SearchScheduleOfBusByBusId(string busId)
        {
            BusStationDAO bsDao = new BusStationDAO();
            return bsDao.SearchScheduleOfBusByBusId(busId);
        }
        public List<OwnerDTO> GetOwnerList()
        {
            OwnerDAO oDao = new OwnerDAO();
            return oDao.GetAll();
        }
    }
}
