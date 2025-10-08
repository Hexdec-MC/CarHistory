using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CarHistory.BusinessEntities;
using CarHistory.DataAccess;

namespace CarHistory.BusinessLogic
{
    public class tbVehiModeloBL
    {
        public tbVehiModeloDAL VehiModeloDAL = new tbVehiModeloDAL();
        public string InsTbVehiModelo(tbVehiModelo Modelo)
        {
            return VehiModeloDAL.InsTbVehiModelo(Modelo);
        }


        public List<tbVehiModelo> VerTbVehiModeloCombustible()
        {
            return VehiModeloDAL.VerTbVehiModeloCombustible();
        }
        public List<tbVehiModelo> VerTbVehiModeloAro()
        {
            return VehiModeloDAL.VerTbVehiModeloAro();
        }
        public List<tbVehiModelo> VerTbVehiModeloRodaje()
        {
            return VehiModeloDAL.VerTbVehiModeloRodaje();
        }
    }
}
