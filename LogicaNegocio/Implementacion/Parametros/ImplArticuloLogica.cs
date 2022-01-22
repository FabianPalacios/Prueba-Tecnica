using AccesoDeDatos.DbModel.Log;
using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.Implementacion.Log;
using AccesoDeDatos.Implementacion.Parametros;
using LogicaNegocio.Implementacion.Log;
using LogicaNegocio.Mapeadores.Log;
using LogicaNegocio.Mapeadores.Parametros;
using LogicaNegocio.ModeloLogica.Log;
using LogicaNegocio.ModeloLogica.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Implementacion.Parametros
{
    public class ImplArticuloLogica
    {
        /// <summary>
        /// Instancia de la capa AccesoDeDatos
        /// </summary>
        private ImplArticuloDatos accesoDatos;

        public ImplArticuloLogica()
        {
            this.accesoDatos = new ImplArticuloDatos();
        }

        /// <summary>
        /// Listar Registros
        /// </summary>
        /// <returns>Listado de registros para mostrar en la página</returns>
        public IEnumerable<ArticuloLogica> listarRegistros()
        {
            var listado = this.accesoDatos.listarRegistros();
            MapeadorArticuloLogica mapeador = new MapeadorArticuloLogica();
            return mapeador.mapearTipo1Tipo2(listado);
        }

        /// <summary>
        /// Método para listar los articulos aplicando un filtro por bodega (Vista Inventario)
        /// </summary>
        /// <param name="idBodega">Id de bodega a filtrar</param>
        /// <returns>Lista de registros de articulos que filtra por bodega</returns>
        public IEnumerable<ArticuloLogica> listarRegistrosFiltroBodega(int idBodega)
        {
            var listado = this.accesoDatos.listarRegistrosFiltroBodega(idBodega);
            MapeadorArticuloLogica mapeador = new MapeadorArticuloLogica();
            return mapeador.mapearTipo1Tipo2(listado);
        }

        /// <summary>
        /// Metodo para listar los articulos aplicando un filtro por id y nombre del articulo (Vista Transferir)
        /// </summary>
        /// <param name="idArticulo">Id del articulo</param>
        /// <param name="nomArticulo">Nombre del articulo</param>
        /// <returns>Lista de registros de ariculos filtrados por id y nombre del articulo</returns>
        public IEnumerable<ArticuloLogica> listarArticulosDiferentes(int idArticulo, string nomArticulo)
        {
            var listado = this.accesoDatos.listarArticulosDiferentes(idArticulo, nomArticulo);
            MapeadorArticuloLogica mapeador = new MapeadorArticuloLogica();
            return mapeador.mapearTipo1Tipo2(listado);
        }



        /// <summary>
        /// Método para guardar un registro (Vista Articulo)
        /// </summary>
        /// <param name="registro">Modelo del articulo a guardar</param>
        /// <returns>true cuando almacena un registro, false cuando no permite el amacenar el registro</returns>
        public Boolean guardarRegistro(ArticuloLogica registro)
        {
            MapeadorArticuloLogica mapeador = new MapeadorArticuloLogica();
            ArticuloDbModel reg = mapeador.mapearTipo2Tipo1(registro);
            Boolean res = this.accesoDatos.guardarRegistro(reg);
            return res;
        }

        /// <summary>
        /// Método para liminar un registro
        /// </summary>
        /// <param name="id">Id del registro a eliminar</param>
        /// <returns>true cuando eliminar el registro false cuando no permite su eliminación</returns>
        public Boolean eliminarRegistro(int id)
        {
            Boolean res = this.accesoDatos.eliminarRegistro(id);
            return res;
        }

        /// <summary>
        /// Método para editar un registro (Vista Articulo)
        /// </summary>
        /// <param name="registro">Modelo de la vista a ediat</param>
        /// <returns>true cuando almacena el registro editado, false cuando no permite editar el registro</returns>
        public Boolean EditarRegistro(ArticuloLogica registro)
        {
            MapeadorArticuloLogica mapeador = new MapeadorArticuloLogica();
            ArticuloDbModel reg = mapeador.mapearTipo2Tipo1(registro);
            return this.accesoDatos.editarRegistro(reg);
        }

        /// <summary>
        /// Método para buscar un articulo por id
        /// </summary>
        /// <param name="id">Id del articulo a buscar</param>
        /// <returns>Modelo del articulo encontrado</returns>
        public ArticuloLogica buscarArticulo(int id)
        {
            var registro = this.accesoDatos.buscarArticulo(id);
            MapeadorArticuloLogica mapeador = new MapeadorArticuloLogica();
            return mapeador.mapearTipo1Tipo2(registro);
        }

        /// <summary>
        /// Método para buscar la existencia de un articulo en la bodega (Vista Articulo)
        /// </summary>
        /// <param name="registro">Modelo del registro a buscar</param>
        /// <returns>true si encontro el articulo y false si no encuentra el articulo</returns>
        public Boolean buscarArticuloEnBodega(ArticuloLogica registro)
        {
            MapeadorArticuloLogica mapeador = new MapeadorArticuloLogica();
            ArticuloDbModel reg = mapeador.mapearTipo2Tipo1(registro);
            return this.accesoDatos.buscarArticuloEnBodega(reg);
        }

        /// <summary>
        /// Método para transferir un articulo teniendo encuenta que existan (Vista Transferir)
        /// </summary>
        /// <param name="idArticuloOrigen">Id del articulo origen</param>
        /// <param name="idArticuloDestino">Ide del articulo Destino</param>
        /// <param name="cantidadDestino">Cantidad de articulos a transferir</param>
        public void tranferirArticulo(int idArticuloOrigen, int idArticuloDestino, int cantidadDestino)
        {
            ArticuloLogica articuloOrigen = this.buscarArticulo(idArticuloOrigen);
            articuloOrigen.Cantidad = articuloOrigen.Cantidad - cantidadDestino;
            this.EditarRegistro(articuloOrigen);

            ArticuloLogica articuloDestino = this.buscarArticulo(idArticuloDestino);
            articuloDestino.Cantidad = articuloDestino.Cantidad + cantidadDestino;
            this.EditarRegistro(articuloDestino);
        }

        /// <summary>
        /// Método para transferir el articulo a una bodega, si no existe crea el articulo en la bodega
        /// </summary>
        /// <param name="idArticuloOrigen">Id del articulo origen</param>
        /// <param name="cantidadDestino">Cantidad de articulos a transferir</param>
        /// <param name="idBodega">Id de la bodega a transferir</param>
        /// <returns></returns>
        public Boolean crearArticuloTransferir(int idArticuloOrigen, int cantidadDestino,  int idBodega)
        {
            ArticuloLogica articuloOrigen = this.buscarArticulo(idArticuloOrigen);
            articuloOrigen.Cantidad = articuloOrigen.Cantidad - cantidadDestino;
            this.EditarRegistro(articuloOrigen);

            articuloOrigen.IdBodega = idBodega;
            articuloOrigen.Cantidad = cantidadDestino;

            return guardarRegistro(articuloOrigen);
        }


    }
}
