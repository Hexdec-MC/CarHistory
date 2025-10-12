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


        public tbVehiModelo VerTbVehiModeloByVehiModeId(int vehiModeId)
        {
            return VehiModeloDAL.VerTbVehiModeloByVehiModeId(vehiModeId);
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

        public List<tbVehiModelo> VerTbVehiModeloTodo()
        {
            return VehiModeloDAL.VerTbVehiModeloTodo();
        }
    }
}
