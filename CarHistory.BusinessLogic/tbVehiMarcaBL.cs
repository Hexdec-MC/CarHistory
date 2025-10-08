using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CarHistory.BusinessEntities;
using CarHistory.DataAccess;

namespace CarHistory.BusinessLogic
{
    public class tbVehiMarcaBL
    {
        public tbVehiMarcaDAL VehiMarcaDAL = new tbVehiMarcaDAL();
        public string InsTbVehiMarca(tbVehiMarca Marca)
        {
            return VehiMarcaDAL.InsTbVehiMarca(Marca);
        }
        public string UpTbVehiMarca(tbVehiMarca Marca)
        {
            return VehiMarcaDAL.UpTbVehiMarca(Marca);
        }
        public string DelTbVehiMarca(int vehiMarId)
        {
            return VehiMarcaDAL.DelTbVehiMarca(vehiMarId);
        }
        public tbVehiMarca VerTbVehiMarcaByVehiMarId(int vehiMarId)
        {
            return VehiMarcaDAL.VerTbVehiMarcaByVehiMarId(vehiMarId);
        }

        public List<tbVehiMarca> VerTbVehiMarcaLikeVehiMarNombre(string vehiMarNombre)
        {
            return VehiMarcaDAL.VerTbVehiMarcaLikeVehiMarNombre(vehiMarNombre);
        }
    }
}
