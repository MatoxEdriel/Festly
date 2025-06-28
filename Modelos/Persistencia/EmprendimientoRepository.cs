using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;


namespace Modelos.Emprendimiento
{
    public class EmprendimientoRepository
    {
        //Saco el orm 
        private masterEntities _context;

        public EmprendimientoRepository() { 
        
            _context = new masterEntities();
        
        }

        public List<Modelos.EF.Emprendimiento> GetAll()
        {
            return _context.Emprendimientos.ToList();
        }


    }
}
