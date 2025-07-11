using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;

namespace Modelos.Persistencia
{
    public class CategoriaRepository
    {
        private readonly masterEntities _context;
        public CategoriaRepository() { 
            _context = new masterEntities();

        }


        public List<Modelos.EF.CategoriasPremiacion> GetAll()
        {

            return _context.CategoriasPremiacions
                .OrderBy(c => c.Nombre).ToList();
        
        }









    }

}
