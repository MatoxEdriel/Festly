using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;
using Modelos.Persistencia;

namespace Controladores.EventoController
{
    public class EventoController
    {
        private EventoRepositorio _repo;


        public EventoController() {
        
            _repo = new EventoRepositorio();    
        }


        public int CrearEvento(string txtTituloEvento,
            DateTime fechaExposicion,
            DateTime dateHourIn,
            DateTime dateHourOut,
           string txtUbicacion) {

            Evento nuevoEvento = new Evento
            {
                NombreEvento = txtTituloEvento,
                FechaPresentacion = fechaExposicion,
                HoraComienzo = dateHourIn.TimeOfDay,
                HoraSalida = dateHourOut.TimeOfDay,
                Ubicacion = txtUbicacion

            };
            return _repo.CrearEvento(nuevoEvento);  
        }

        //public void guardarEvento(Evento evento)
        //{
        //    _repo.AgregarEvento(evento);
        //}   

        //public void registrarEvento(string nombreEvento, DateTime fechaEvento, ) { 



        //    /*
        //     *     public int Id { get; set; }
        //public string Ubicacion { get; set; }
        //public Nullable<int> OrdenPresentacion { get; set; }
        //public int EmprendimientoId { get; set; }
        //public System.DateTime FechaPresentacion { get; set; }
        //public System.TimeSpan HoraComienzo { get; set; }
        //public System.TimeSpan HoraSalida { get; set; }
        //     * 
        //     * 
        //     * 
        //     */






        //}










    }
}
