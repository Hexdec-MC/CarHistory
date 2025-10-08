using CarHistory.BusinessEntities;
using CarHistory.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessLogic
{
    public class claseSeguridadBL
    {
        claseSeguridadDAL SeguridadDAL;
        public claseSeguridadBL()
        {
            SeguridadDAL = new claseSeguridadDAL();
        }
        ~claseSeguridadBL()
        {
            SeguridadDAL = null;
        }
        public tbUsuario verUsuarioPassword(tbUsuario usuario)
        {
            tbUsuario user = new tbUsuario();
            user = SeguridadDAL.verUsuarioPassword(usuario);

            return user;
        }
        public List<tbMenu> verTbMenuByUsuario(int usuId)
        {
            List<tbMenu> listResult = new List<tbMenu>();
            try
            {
                listResult = SeguridadDAL.verTbMenuByUsuario(usuId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ;
            }
            return listResult;
        }
    }
}
