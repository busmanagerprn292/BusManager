using Bus.DAO;
using Bus.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.BLL
{
    class RouteBLL
    {
        private readonly RouteDAO dao;
        public RouteBLL()
        {
            dao = new RouteDAO();
        }
        public List<RouteDTO> GetRouteList()
        {
            return dao.GetAll();
        }
        public RouteDTO GetRouteById(int id)
        {
            return dao.SearchById(id);
        }
        public void InsertRoute(int id, string tuyenDuong)
        {
            try
            {
                RouteDTO dto = new RouteDTO { Id = id, TuyenDuong = tuyenDuong };
                dao.Add(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateRoute(int id, string tuyenDuong)
        {
            try
            {
                RouteDTO dto = new RouteDTO { Id = id, TuyenDuong = tuyenDuong };
                dao.Update(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteRoute(int id)
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
    }
}
