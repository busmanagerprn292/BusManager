using Bus.DAO;
using Bus.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.BLL
{
    class OwnerBLL
    {
        private OwnerDAO dao;
        public OwnerBLL()
        {
            dao = new OwnerDAO();
        }
        public List<OwnerDTO> GetOwnerList()
        {
            return dao.GetAll();
        }
        public OwnerDTO GetOwnerById(string id)
        {
            return dao.SearchById(id);
        }
        public void InsertOwner(string id, string name , string phone , DateTime dob , string CMND , string address)
        {
            try
            {
                OwnerDTO dto = new OwnerDTO { Id = id, Name = name , Phone = phone , DateOfBirth = dob , CMND = CMND , Address = address };
                dao.Add(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateOwner(string id, string name, string phone, DateTime dob, string CMND, string address)
        {
            try
            {
                OwnerDTO dto = new OwnerDTO { Id = id, Name = name, Phone = phone, DateOfBirth = dob, CMND = CMND, Address = address };
                dao.Update(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteOwner(string id)
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
        public List<BusDTO> GetMyListBuses(string id)
        {
            return dao.GetListBusOfOwner(id);
        }
    }
}
