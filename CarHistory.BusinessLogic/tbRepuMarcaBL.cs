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
    public class tbRepuMarcaBL
    {
        public tbRepuMarcaDAL RepuMarcaDAL = new tbRepuMarcaDAL();
        public string InsTbRepuMarca(tbRepuMarca Marca)
        {
            return RepuMarcaDAL.InsTbRepuMarca(Marca);
        }
        public string UpTbRepuMarca(tbRepuMarca Marca)
        {
            return RepuMarcaDAL.UpTbRepuMarca(Marca);
        }
        public string DelTbRepuMarca(int repuMarId)
        {
            return RepuMarcaDAL.DelTbRepuMarca(repuMarId);
        }
        public tbRepuMarca VerTbRepuMarcaByRepuMarId(int repuMarId)
        {
            return RepuMarcaDAL.VerTbRepuMarcaByRepuMarId(repuMarId);
        }

        public List<tbRepuMarca> VerTbRepuMarcaLikeRepuMarNombre(string repuMarNombre)
        {
            return RepuMarcaDAL.VerTbRepuMarcaLikeRepuMarNombre(repuMarNombre);
        }
    }
}
