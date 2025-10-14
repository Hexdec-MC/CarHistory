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
    public class tbRepuestoBL
    {
        public tbRepuestoDAL RepuestoDAL = new tbRepuestoDAL();
        public string InsTbRepuesto(tbRepuesto Repuesto)
        {
            return RepuestoDAL.InsTbRepuesto(Repuesto);
        }
        public string UpTbRepuesto(tbRepuesto Repuesto)
        {
            return RepuestoDAL.UpTbRepuesto(Repuesto);
        }
        public string DelTbRepuesto(int repuId)
        {
            return RepuestoDAL.DelTbRepuesto(repuId);
        }
        public tbRepuesto VerTbRepuestoByRepuId(int repuId)
        {
            return RepuestoDAL.VerTbRepuestoByRepuId(repuId);
        }

        public List<tbRepuesto> VerTbRepuestoLikeRepuNombre(string repuNombre)
        {
            return RepuestoDAL.VerTbRepuestoLikeRepuNombre(repuNombre);
        }
    }
}
