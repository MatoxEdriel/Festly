using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;

namespace Modelos.Persistencia
{
    public class EventoRepositorio
    {

        private masterEntities _context;



        public EventoRepositorio()
        {

            _context = new masterEntities();

        }


        public int CrearEvento(Evento evento) {
            _context.Eventos.Add(evento);
            //Console.WriteLine($"Intentando insertar Evento con EmprendimientoId = {evento.EmprendimientoId}");

            _context.SaveChanges();
            return evento.Id;
        }



   
        public void EliminarEvento(int id)
        {
           
        }
        public Evento BuscarEvento(int id)
        {
        
            return new Evento(); 
        }
     

        public List<Modelos.EF.Evento> GetAll() { 
        
            return _context.Eventos.ToList();
        }



     
    }
}
