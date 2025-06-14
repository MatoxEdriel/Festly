using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;

namespace Controladores.ParticipanteController
{
    public class ParticipanteController
    {



        public void registrarParticipante(string nombres, string cargo)
        {

            using (var context = new masterEntities())
            {
                var participante = new Participante()
                {
                        Nombres = nombres,  
                        Cargo = cargo   
                };

                context.Participantes.Add(participante);
                context.SaveChanges();
            }






        }



    }
}
