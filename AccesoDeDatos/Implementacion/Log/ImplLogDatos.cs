using AccesoDeDatos.DbModel.Log;
using AccesoDeDatos.Mapeadores.Log;
using AccesoDeDatos.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Implementacion.Log
{
    public class ImplLogDatos
    {
        public object tb_log;

        /// <summary>
        /// Método para listar los log de las transacciones realizadas en transferencias (Vista Log)
        /// </summary>
        /// <returns>Lista las transferencias realizadas</returns>
        public IEnumerable<LogDbModel> listarRegistros()
        {
            var lista = new List<LogDbModel>();

            ///Conexión con la base de datos
            using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
            {
                var listaDatos = (from c in bd.tb_log
                                  select c).OrderBy(m => m.id);
                lista = new MapeadorLogDatos().mapearTipo1Tipo2(listaDatos).ToList();
            }
            return lista;
        }

        /// <summary>
        /// Metodo para guardar un registro de en el log (Vista Log)
        /// </summary>
        /// <param name="registro">Modelo del Log a guardar</param>
        /// <returns>true cuando almacena un registro, false cuando existe un registro o una excepción</returns>
        public bool guardarRegistro(LogDbModel registro)
        {
            try
            {
                ///Conexión con la base de datos
                using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
                {
                    MapeadorLogDatos mapeador = new MapeadorLogDatos();
                    var reg = mapeador.mapearTipo2Tipo1(registro);
                    bd.tb_log.Add(reg);
                    bd.SaveChanges();
                    return true;

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
