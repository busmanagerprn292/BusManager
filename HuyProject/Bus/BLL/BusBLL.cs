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
                dao.DeleteAllScheduleOfBus(id);
                dao.DeleteById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OwnerDTO> GetOwnerList()
        {
            try
            {
                OwnerDAO oDao = new OwnerDAO();
                return oDao.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public BusStationDTO GetDetailOfScheduleById(int id)
        {
            try
            {
                return dao.GetDetailOfScheduleById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string GetRoleNameById(string RoleId)
        {
            try
            {
                return dao.GetRoleNameById(RoleId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<BusStationDTO> SearchScheduleOfBusByBusId(string busId)
        {
            try
            {
                return dao.SearchScheduleOfBusByBusId(busId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AddBusStation(BusStationDTO dto)
        {
            try
            {
                dao.AddBusStation(dto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeleteBusStationById(int id)
        {
            try
            {
                dao.DeleteBusStationById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void UpdateBusStation(BusStationDTO dto)
        {
            try
            {
                dao.UpdateBusStation(dto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
