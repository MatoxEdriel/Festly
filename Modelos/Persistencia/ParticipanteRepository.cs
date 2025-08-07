using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;

namespace Modelos.Persistencia
{
    public class ParticipanteRepository
    {
        private masterEntities _context;

        public ParticipanteRepository() { 
            _context = new masterEntities();

        }


        public List<Participante> GetAll() {


            return _context.Participantes.ToList();
        }
    }
}
