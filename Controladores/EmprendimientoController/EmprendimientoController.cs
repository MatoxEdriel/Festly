using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using Modelos.EF;
using Modelos.Emprendimiento;


namespace Controladores.EmprendimientoController
{
    public class EmprendimientoController
    {

        private EmprendimientoRepository _repo;



        public EmprendimientoController()
        {
            _repo = new EmprendimientoRepository();

        
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





        public void registrarEmprendimiento(string nombre, string facultad, string rubro, string descripcion, System.Drawing.Image logo = null) {

            byte[] logoBytes = null;

            if (logo != null) {

                logoBytes = ConvertirImagenABytes(logo);
            }




            using (var context = new masterEntities())
            {
                var nuevoEmprendimiento = new Emprendimiento
                {
                    Nombre = nombre,
                    Facultad = facultad,
                    Rubro = rubro,
                    Descripcion = descripcion,
                    LogoBinary = logoBytes
                };

                context.Emprendimientos.Add(nuevoEmprendimiento);
                context.SaveChanges();


            }
        }

        public List<Emprendimiento> ObtenerTodos()
        {
            return _repo.GetAll();
        }


    }
}
