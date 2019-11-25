using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class AtaudBLL
    {
        public ATAUD CrearAtaud(ATAUD Ataud) 
        {
            ATAUD nuevoAtaud = new ATAUD();
            using (var r = new Repository<ATAUD>())
            {
                nuevoAtaud = r.Create(Ataud);
            }
            return nuevoAtaud;
        }

        public ATAUD ObtenerAtaud(int id)
        {
            ATAUD Ataud= null;
            using (var r = new Repository<ATAUD>())
            {
                Ataud = r.Retrieve(p => p.ID == id);
            }
            return Ataud;
        }

        public List<ATAUD> ObtenerAtaudPorNombre()
        {
            List<ATAUD> Ataudes = null;
            using (var r = new Repository<ATAUD>())
            {
                Ataudes = r.RetrieveAllOrder(p => p.Codigo);
            }
            return Ataudes;
        }

        public bool Actualizar(ATAUD Ataud)
        {
            bool result = false;
            using (var r = new Repository<ATAUD>())
            {
                result = r.Update(Ataud);
            }
            return result;
        }

        public bool Eliminar(ATAUD Ataud)
        {
            bool result = false;
            using (var r = new Repository<ATAUD>())
            {
                result = r.Delete(Ataud);
            }
            return result;
        }
    }
}
