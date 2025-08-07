using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;
using Modelos.Persistencia;

namespace Controladores.ParticipanteController
{
    public class ParticipanteController
    {

        private ParticipanteRepository _repo;
        public ParticipanteController() { 
        
           _repo = new ParticipanteRepository();
        }


        public List<Participante> ObtenerTodos() {
            return _repo.GetAll();

        }


        public byte[] ConvertirImagenABytes(System.Drawing.Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(imagen);
                bmp.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }


        public void registrarParticipante(
            string primerNombre,
            string segundoNombre,
            string apellidoPaterno,
            string apellidoMaterno,
            string cargo,
            System.Drawing.Image PhotoBinary = null)
        {
            byte[] photo = null;


            if (PhotoBinary != null) { 
                photo = ConvertirImagenABytes(PhotoBinary);
            }

            using (var context = new masterEntities())
            {
                var participante = new Participante()
                {
                        primerNombre = primerNombre,
                        segundoNombre = segundoNombre,
                        apellidoPaterno = apellidoPaterno,
                        apellidoMaterno = apellidoMaterno,
                        Cargo = cargo,
                        PhotoBinary = photo
                };

                context.Participantes.Add(participante);
                context.SaveChanges();
            }






        }



    }
}
