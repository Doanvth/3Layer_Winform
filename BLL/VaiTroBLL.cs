using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class VaiTroBLL
    {
        VaiTroDAL dal = new VaiTroDAL();

        public DataTable GetVaiTroList()
        {
            return dal.GetAllVaiTro();
        }
    }
}
