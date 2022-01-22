using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.Mapeadores.Parametros;
using AccesoDeDatos.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Implementacion.Parametros
{
    public class ImplArticuloDatos
    {
        public object tb_articulo;

        /// <summary>
        /// Método para listar Registros de Articulos
        /// </summary>
        /// <returns>Lista de registros de articulos</returns>
        public IEnumerable<ArticuloDbModel> listarRegistros()
        {
            var lista = new List<ArticuloDbModel>();

            ///Conexión con la base de datos
            using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
            {             
                var listaDatos = (from c in bd.tb_articulo
                                  select c).OrderBy(m => m.id);
                lista = new MapeadorArticuloDatos().mapearTipo1Tipo2(listaDatos).ToList();
            }
            return lista;
        }



        /// <summary>
        /// Método para listar Registros con un filtro Bodega  para (Vista Inventario)
        /// </summary>
        /// <param name="idBodega">Id de la bodega a filtrar</param>
        /// <returns>Lista de registros de articulos que filtra por bodega</returns>
        public IEnumerable<ArticuloDbModel> listarRegistrosFiltroBodega(int idBodega)
        {
            var lista = new List<ArticuloDbModel>();

            ///Conexión con la base de datos
            using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
            {
                var listaDatos = (from c in bd.tb_articulo
                                  where c.id_bodega.Equals(idBodega)
                                  select c).OrderBy(m => m.id).ToList();
                lista = new MapeadorArticuloDatos().mapearTipo1Tipo2(listaDatos).ToList();
            }
            return lista;
        }


        /// <summary>
        /// Método para listar registro con filtro idArticulo y nomArticulto (Vista Transferir)
        /// </summary>
        /// <param name="idArticulo">Id del Articulo a filtrar</param>
        /// <param name="nomArticulo">Nombre del articulo a filtrar</param>
        /// <returns>Lista de registros de articulos filtrados por id y nombre del articulo</returns>
        public IEnumerable<ArticuloDbModel> listarArticulosDiferentes(int idArticulo, string nomArticulo)
        {
            var lista = new List<ArticuloDbModel>();

            ///Conexión con la base de datos
            using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
            {
                var listaDatos = (from c in bd.tb_articulo
                                  where c.id != idArticulo && c.nombre.Equals(nomArticulo)
                                  select c).OrderBy(m => m.id).ToList();
                lista = new MapeadorArticuloDatos().mapearTipo1Tipo2(listaDatos).ToList();
            }
            return lista;
        }

        /// <summary>
        /// Metodo para guardar un registro de articulo (Vista Articulo)
        /// </summary>
        /// <param name="registro">Modelo del articulo a guardar</param>
        /// <returns>true cuando almacena un registro, false cuando existe un registro o una excepción</returns>
        public bool guardarRegistro(ArticuloDbModel registro)
        {
            try
            {
                ///Conexión con la base de datos
                using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
                {
                    MapeadorArticuloDatos mapeador = new MapeadorArticuloDatos();
                    var reg = mapeador.mapearTipo2Tipo1(registro);
                    bd.tb_articulo.Add(reg);
                    bd.SaveChanges();
                    return true;

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Método para editar un registro (Vista Articulo)
        /// </summary>
        /// <param name="registro">Modelo del registro a editar</param>
        /// <returns>true cuando almacena, false cuando existe un registroo o una excepción</returns>
        public bool editarRegistro(ArticuloDbModel registro)
        {
            try
            {
                ///Conexión con la base de datos
                using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
                {
                    MapeadorArticuloDatos mapeador = new MapeadorArticuloDatos();
                    var reg = mapeador.mapearTipo2Tipo1(registro);
                    bd.Entry(reg).State = EntityState.Modified;
                    bd.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Método de eliminar un registro por id
        /// </summary>
        /// <param name="id">Id del registro a eliminar</param>
        /// <returns>true cuando elimina, false cuando existe un registro o una  excepción</returns>
        public bool eliminarRegistro(int id)
        {
            try
            {
                ///Conexión con la base de datos
                using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
                {

                    //Verificación de la existencia de un articulo
                    tb_articulo registo = bd.tb_articulo.Find(id);
                    if (registo == null)
                    {
                        return false;
                    }
                    else
                    {
                        bd.tb_articulo.Remove(registo);
                        bd.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Método para buscar un articulo por Id (Vista tranferir)
        /// </summary>
        /// <param name="id">Id del articulo a buscar</param>
        /// <returns>Retorna el modelo buscado</returns>
        public ArticuloDbModel buscarArticulo(int id)
        {
            using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
            {
                tb_articulo registro = bd.tb_articulo.Find(id);
                return new MapeadorArticuloDatos().mapearTipo1Tipo2(registro);
            }
        }
        
        /// <summary>
        /// Método para buscar  la existencia de un articulo en la bodega
        /// </summary>
        /// <param name="registro">Modelo del articulo a buscar</param>
        /// <returns>true si encontro el articulo y false si no encontro o una excepción</returns>
        public bool buscarArticuloEnBodega(ArticuloDbModel registro)
        {
            try
            {
                using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
                {
                    if (bd.tb_articulo.Where(x => x.nombre.Equals(registro.Nombre) & x.descripcion.Equals(registro.Descripcion)
                    & x.id_bodega.Equals(registro.IdBodega) & x.cantidad.Equals(registro.Cantidad) & x.precio.Equals(registro.Precio)).Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            } catch(Exception e)
            {
                throw e;
            }
        }

    }
}
