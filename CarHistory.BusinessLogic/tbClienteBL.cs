using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHistory.BusinessEntities;
using CarHistory.DataAccess;

namespace CarHistory.BusinessLogic
{
    public class tbClienteBL
    {
        public tbClienteDAL ClienteDAL = new tbClienteDAL();

        public string InsTbCliente(tbCliente Cliente)
        {
            return ClienteDAL.InsTbCliente(Cliente);
        }

        public string UpTbCliente(tbCliente Cliente)
        {
            return ClienteDAL.UpTbCliente(Cliente);
        }

        public string DelTbCliente(int clieId)
        {
            return ClienteDAL.DelTbCliente(clieId);
        }

        public tbCliente VerTbClienteByClieId(int clieId)
        {
            return ClienteDAL.VerTbClienteByClieId(clieId);
        }

        public List<tbCliente> VerTbClienteLikeClieDocNumero(string clieDocNumero)
        {
            return ClienteDAL.VerTbClienteLikeClieDocNumero(clieDocNumero);
        }
    }
}
