using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHistory.BusinessEntities;
using CarHistory.DataAccess;

namespace CarHistory.BusinessLogic
{
    public class tbVehiCategoriaBL
    {
        public tbVehiCategoriaDAL VehiCategoriaDAL = new tbVehiCategoriaDAL();
        public string InsTbVehiCategoria(tbVehiCategoria Categoria)
        {
            return VehiCategoriaDAL.InsTbVehiCategoria(Categoria);
        }
        public string UpTbVehiCategoria(tbVehiCategoria Categoria)
        {
            return VehiCategoriaDAL.UpTbVehiCategoria(Categoria);
        }
        public string DelTbVehiCategoria(int vehiCateId)
        {
            return VehiCategoriaDAL.DelTbVehiCategoria(vehiCateId);
        }

        public tbVehiCategoria VerTbVehiCategoriaByVehiCateId(int vehiCateId)
        {
            return VehiCategoriaDAL.VerTbVehiCategoriaByVehiCateId(vehiCateId);
        }

        public List<tbVehiCategoria> VerTbVehiCategoriaLikeNombre(string vehiCateNombre)
        {
            return VehiCategoriaDAL.VerTbVehiCategoriaLikeNombre(vehiCateNombre);
        }
    }
}
