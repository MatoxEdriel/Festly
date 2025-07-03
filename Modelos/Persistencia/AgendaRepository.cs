using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;

namespace Modelos.Persistencia
{
    public class AgendaRepository
    {

        private masterEntities _context;


        public AgendaRepository() { 
        
            _context = new masterEntities();
        
        }


        //Esto devuelve la lista de AgendaPresentacion !!! 
        public List<AgendaPresentacion> GetAll()
        {
            return _context.AgendaPresentacions.ToList();
        }


        public void ActualizarOrdenPresentacion(int eventoId, int emprendimientoId, int nuevoOrden)
        {
            var agenda = _context.AgendaPresentacions
                                 .FirstOrDefault(a => a.EventoId == eventoId && a.EmprendimientoId == emprendimientoId);

            if (agenda != null)
            {
                agenda.OrdenPresentacion = nuevoOrden;
                _context.SaveChanges();
            }
        }


        public void GuardarAgenda(AgendaPresentacion agenda)
        {
            _context.AgendaPresentacions.Add(agenda);
            _context.SaveChanges();
        }





    }
}
