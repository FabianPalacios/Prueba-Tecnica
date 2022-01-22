using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ModeloLogica.Parametros
{
    /// <summary>
    /// Modelo  de Bodega en la capa LogicaNegocio con sus atributos
    /// </summary>
    public class BodegaLogica
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string  nombre;

        public string  Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
