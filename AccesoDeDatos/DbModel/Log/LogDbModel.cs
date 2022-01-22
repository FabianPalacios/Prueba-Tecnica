using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.DbModel.Log
{
    /// <summary>
    /// Modelo  de Log en la capa AccesoDeDatos con sus atributos
    /// </summary>
    public class LogDbModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string hora;

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        private int id_Bodega_Origen;

        public int Id_Bodega_Origen
        {
            get { return id_Bodega_Origen; }
            set { id_Bodega_Origen = value; }
        }

       
        private int id_Bodega_Destino;
        public int Id_Bodega_Destino
        {
            get { return id_Bodega_Destino; }
            set { id_Bodega_Destino = value; }
        }

        private int id_Articulo;
        public int Id_Articulo
        {
            get { return id_Articulo; }
            set { id_Articulo = value; }
        }

        

        private int unidades_Transferidas;

        public int Unidades_Transferidas
        {
            get { return unidades_Transferidas; }
            set { unidades_Transferidas = value; }
        }




    }
}
