using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ModeloLogica.Parametros
{
    /// <summary>
    /// Modelo  de Articulo en la capa LogicaNegocio(Logica) con sus atributos
    /// </summary>
    public class ArticuloLogica
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

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private int idBodega;

        public int IdBodega
        {
            get { return idBodega; }
            set { idBodega = value; }
        }

        private string nombreBodega;

        public string NombreBodega
        {
            get { return nombreBodega; }
            set { nombreBodega = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
