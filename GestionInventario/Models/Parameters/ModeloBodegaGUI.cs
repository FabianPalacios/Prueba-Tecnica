using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario.Models.Parameters
{
    /// <summary>
    /// Modelo de la clase Bodega en la capa GestionInventario con sus atributos 
    /// </summary>
    public class ModeloBodegaGUI
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
