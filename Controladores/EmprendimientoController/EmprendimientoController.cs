using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



        public void registrarEmprendimiento(string nombre, string facultad, string rubro, string descripcion) {

            using (var context = new masterEntities())
            {
                var nuevoEmprendimiento = new Emprendimiento
                {
                    Nombre = nombre,
                    Facultad = facultad,
                    Rubro = rubro,
                    Descripcion = descripcion
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
