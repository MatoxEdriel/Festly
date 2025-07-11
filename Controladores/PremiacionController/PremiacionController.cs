using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.EF;
using Modelos.Persistencia;

namespace Controladores.PremiacionController
{
    public class PremiacionController
    {

         private readonly PremiacionesCategoriaRepository _repoPremiacion;

        public PremiacionController() { 
        
            _repoPremiacion = new PremiacionesCategoriaRepository();
        }


        public int CrearPremiacion(int categoriaId , int emprendimientoId, string txtObservacion)
        {
            PremiacionesCategoria nuevaPremiacion = new PremiacionesCategoria
            {
                CategoriaId = categoriaId,
                EmprendimientoId = emprendimientoId,    
                Observaciones = txtObservacion

            };
            _repoPremiacion.agregar(nuevaPremiacion);
            return nuevaPremiacion.Id;
        }

        //te amo ctm





    }
}
