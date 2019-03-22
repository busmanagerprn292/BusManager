using Bus.DAO;
using Bus.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.BLL
{
    class StaffBLL
    {
        private readonly StaffDao Sdao;
        private readonly RoleDao Rdao;

        public StaffBLL()
        {
            Sdao = new StaffDao();
            Rdao = new RoleDao();
        }
        public List<StaffDTO> getAll()
        {
            return Sdao.GetAll();
        }
        public List<RoleDTO> getAllR()
        {
            return Rdao.GetAll();
        }
        public bool InsertStaff(StaffDTO dto)
        {
            return Sdao.Add(dto);
        }

        public bool UpdateStaff(StaffDTO dto)
        {
            return Sdao.Update(dto);
        }

        public bool DeleteStaff(string id)
        {
            return Sdao.DeleteById(id);
        }
    }
}
