using AccesoDeDatos.DbModel.Log;
using AccesoDeDatos.Implementacion.Log;
using LogicaNegocio.Mapeadores.Log;
using LogicaNegocio.ModeloLogica.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion.Log
{
    public class ImpLogLogica
    {
        private ImplLogDatos accesoDatos;

        public ImpLogLogica()
        {
            this.accesoDatos = new ImplLogDatos();
        }

        /// <summary>
        /// Listar Registros Log
        /// </summary>
        /// <returns>Listado de registros para mostrar en la página</returns>
        public IEnumerable<LogLogica> listarRegistros()
        {
            var listado = this.accesoDatos.listarRegistros();
            MapeadorLogLogica mapeador = new MapeadorLogLogica();
            return mapeador.mapearTipo1Tipo2(listado);
        }

        /// <summary>
        /// Método para guardar un registro (Vista Articulo)
        /// </summary>
        /// <param name="registro">Modelo de Log a guardar</param>
        /// <returns>true cuando almacena un registro, false cuando no permite el amacenar el registro</returns>
        public Boolean guardarRegistro(LogLogica registro)
        {
            MapeadorLogLogica mapeador = new MapeadorLogLogica();
            LogDbModel reg = mapeador.mapearTipo2Tipo1(registro);
            Boolean res = this.accesoDatos.guardarRegistro(reg);
            return res;
        }
    }
}
