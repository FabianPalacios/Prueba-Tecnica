using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.Implementacion.Parametros;
using LogicaNegocio.Mapeadores.Parametros;
using LogicaNegocio.ModeloLogica.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion.Parametros
{

    public class ImplBodegaLogica
    {
        private ImplBodegaDatos accesoDatos;

        public ImplBodegaLogica()
        {
            this.accesoDatos = new ImplBodegaDatos();
        }

        /// <summary>
        /// Listar Registros
        /// </summary>
        /// <returns>Listado de registros para mostrar en la página</returns>
        public IEnumerable<BodegaLogica> listarRegistros()
        {
            var listado = this.accesoDatos.listarRegistros();
            MapeadorBodegaLogica mapeador = new MapeadorBodegaLogica();
            return mapeador.mapearTipo1Tipo2(listado);
        }

        /// <summary>
        /// Listar Registros Bodegas Diferentes a la bodega de destino en transferir
        /// </summary>
        /// <returns>Listado de Bodegas para mostrar en  el comboBox</returns>
        public IEnumerable<BodegaLogica> listarRegistrosBodegasDiferentes(string Bodega)
        {
            var listado = this.accesoDatos.listarRegistrosBodegasDiferentes(Bodega);
            MapeadorBodegaLogica mapeador = new MapeadorBodegaLogica();
            return mapeador.mapearTipo1Tipo2(listado);
        }

        /// <summary>
        /// Guardar un registro
        /// </summary>
        /// <param name="registro">El registro a almacenar</param>
        /// <returns>true cuando almacena un registro, false cuando no permite el amacenar el registro</returns>
        public Boolean guardarRegistro(BodegaLogica registro)
        {
            MapeadorBodegaLogica mapeador = new MapeadorBodegaLogica();
            BodegaDbModel reg = mapeador.mapearTipo2Tipo1(registro);
            Boolean res = this.accesoDatos.guardarRegistro(reg);
            return res;
        }

        /// <summary>
        /// Eliminar un registro
        /// </summary>
        /// <param name="id">Id del registro a eliminar</param>
        /// <returns>true cuando eliminar el registro, false cuando no permite su eliminación</returns>
        public Boolean eliminarRegistro(int id)
        {
            Boolean res = this.accesoDatos.eliminarRegistro(id);
            return res;
        }

        /// <summary>
        /// Editar un registro
        /// </summary>
        /// <param name="registro">El registro a editar</param>
        /// <returns>true cuando almacena el registro editado, false cuando no permite editar el registro</returns>
        public Boolean EditarRegistro(BodegaLogica registro)
        {
            MapeadorBodegaLogica mapeador = new MapeadorBodegaLogica();
            BodegaDbModel reg = mapeador.mapearTipo2Tipo1(registro);
            Boolean res = this.accesoDatos.editarRegistro(reg);
            return res;
        }



    }
}
