using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.Mapeadores.Parametros;
using AccesoDeDatos.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Implementacion.Parametros
{
    public class ImplBodegaDatos
    {
        public object tb_bodega;

        /// <summary>
        /// Método para listar Registros con un filtro
        /// </summary>
        /// <returns>Lista de registros con el filtro aplicado</returns>
        public IEnumerable<BodegaDbModel> listarRegistros()
        {
            var lista = new List<BodegaDbModel>();

            ///Conexión con la base de datos
            using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
            {
                var listaDatos = (from c in bd.tb_bodega
                                  select c).OrderBy(m => m.id);
                lista = new MapeadorBodegaDatos().mapearTipo1Tipo2(listaDatos).ToList();
            }
            return lista;
        }

        /// <summary>
        /// Método para listar Registros con un filtro
        /// </summary>
        /// <returns>Lista de registros con el filtro aplicado</returns>
        public IEnumerable<BodegaDbModel> listarRegistrosBodegasDiferentes(string Bodega)
        {
            var lista = new List<BodegaDbModel>();

            ///Conexión con la base de datos
            using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
            {
                var listaDatos = (from c in bd.tb_bodega
                                  where c.nombre !=  Bodega
                                  select c).OrderBy(m => m.id);
                lista = new MapeadorBodegaDatos().mapearTipo1Tipo2(listaDatos).ToList();
            }
            return lista;
        }

        /// <summary>
        /// Metodo para almacenar un registro de bodega
        /// </summary>
        /// <param name="registro">El registro a almacenar</param>
        /// <returns>true cuando almacena un registro, false cuando existe un registro o una excepción</returns>
        public bool guardarRegistro(BodegaDbModel registro)
        {
            try
            {
                ///Conexión con la base de datos
                using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
                {
                    //Verificación de la existencia de una bodega con el mismo nombre
                    if (bd.tb_bodega.Where(x => x.nombre.ToLower().Equals(registro.Nombre.ToLower())).Count() > 0)
                    {
                        return false;
                    }
                    else
                    {
                        MapeadorBodegaDatos mapeador = new MapeadorBodegaDatos();
                        var reg = mapeador.mapearTipo2Tipo1(registro);
                        bd.tb_bodega.Add(reg);
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
        /// Método para editar un registro
        /// </summary>
        /// <param name="registro">Registro editado</param>
        /// <returns>true cuando almacena, false cuando existe un registroo o una excepción</returns>
        public bool editarRegistro(BodegaDbModel registro)
        {
            try
            {
                ///Conexión con la base de datos
                using (GestionInventarioBDEntities bd = new GestionInventarioBDEntities())
                {
                    //Verificación de la existencia de un registro con el mismo nombre
                    if (bd.tb_bodega.Where(x => x.nombre.ToLower().Equals(registro.Nombre.ToLower())).Count() > 0)
                    {
                        return false;
                    }
                    else
                    {
                        MapeadorBodegaDatos mapeador = new MapeadorBodegaDatos();
                        var reg = mapeador.mapearTipo2Tipo1(registro);
                        bd.Entry(reg).State = EntityState.Modified;
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

                    //Verificación de la existencia de la bodega y que la bodega no tenga articulos
                    tb_bodega registo = bd.tb_bodega.Find(id);
                    if (registo == null || registo.tb_articulo.Count() > 0)
                    {
                        return false;
                    }
                    else
                    {
                        bd.tb_bodega.Remove(registo);
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






    }
}
