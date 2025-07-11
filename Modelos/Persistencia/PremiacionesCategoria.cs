using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;

namespace Modelos.Persistencia
{
    public class PremiacionesCategoriaRepository
    {
        private readonly masterEntities _context;

        public PremiacionesCategoriaRepository() { 
        

            _context = new masterEntities();

        }




        public List<Modelos.EF.PremiacionesCategoria> GetAll()
        {

            return _context.PremiacionesCategorias.ToList();
        }

        public void agregar(Modelos.EF.PremiacionesCategoria premiacionesCategoria)
        {
            _context.PremiacionesCategorias.Add(premiacionesCategoria);
            _context.SaveChanges();
        }





    }
}
