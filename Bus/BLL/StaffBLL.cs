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
        private readonly StaffDao dao;

        public StaffBLL()
        {
            dao = new StaffDao();
        }

        public List<StaffDTO> getAll()
        {
            return dao.GetAll();
        }

    }


}
