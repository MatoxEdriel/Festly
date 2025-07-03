using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;
using Modelos.Persistencia;

namespace Controladores.AgendaController
{



    public class AgendaController
    {


        private readonly AgendaRepository _agendaRepository;

        public AgendaController() {

            _agendaRepository = new AgendaRepository();


        }

        public void actualizarOrdenPresentacion(int eventoId, int emprendimientoId, int nuevoOrden) { 
            _agendaRepository.ActualizarOrdenPresentacion(eventoId, emprendimientoId, nuevoOrden);  
        }



        public void GuardarAgenda(int eventoId, int emprendimientoId, int ordenPresentacion)
        {
            var nuevaAgenda = new Modelos.EF.AgendaPresentacion
            {
                EventoId = eventoId,
                EmprendimientoId = emprendimientoId,
                OrdenPresentacion = ordenPresentacion
            };

            _agendaRepository.GuardarAgenda(nuevaAgenda);
        }


        public List<Modelos.EF.AgendaPresentacion> ObtenerAgendaPresentaciones()
        {
            return _agendaRepository.GetAll();
        }

    }
}
