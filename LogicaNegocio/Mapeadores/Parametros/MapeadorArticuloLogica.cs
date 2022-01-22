using AccesoDeDatos.DbModel.Parametros;
using LogicaNegocio.ModeloLogica.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Mapeadores.Parametros
{
    public class MapeadorArticuloLogica : MapeadorBaseLogica<ArticuloDbModel, ArticuloLogica>
    {
        /// <summary>
        /// Mapeador que convierte un objeto ArticuloDbModel a un objeto ArticuloLogica
        /// </summary>
        /// <param name="entrada">Objeto tipo ArticuloDbModel del la capa AccesoDeDatos</param>
        /// <returns>Retorna un objeto tipo ArticuloLogica</returns>
        public override ArticuloLogica mapearTipo1Tipo2(ArticuloDbModel entrada)
        {
            return new ArticuloLogica()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre,
                Descripcion = entrada.Descripcion,
                IdBodega = entrada.IdBodega,
                NombreBodega = entrada.NombreBodega,
                Cantidad = entrada.Cantidad,
                Precio = entrada.Precio
            };
        }

        /// <summary>
        /// Mapeador que convierte una lista ArticuloDbModel a una lista tipo ArticuloLogica
        /// </summary>
        /// <param name="entrada">Lista tipo ArticuloDbModel de la capa AccesoDeDatos</param>
        /// <returns>Retorna una lista tipo ArticuloLogica</returns>
        public override IEnumerable<ArticuloLogica> mapearTipo1Tipo2(IEnumerable<ArticuloDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return mapearTipo1Tipo2(item);
            }
        }

        /// <summary>
        /// Mapeador que convierte un Objeto ArticuloLogica a un objeto ArticuloDbModel
        /// </summary>
        /// <param name="entrada">Objeto tipo ArticuloLogica que proviene de la capaGestionInventario</param>
        /// <returns>Retorna un objeto tipo ArticuloDbModel</returns>
        public override ArticuloDbModel mapearTipo2Tipo1(ArticuloLogica entrada)
        {
            return new ArticuloDbModel()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre,
                Descripcion = entrada.Descripcion,
                IdBodega = entrada.IdBodega,
                Cantidad = entrada.Cantidad,
                Precio = entrada.Precio
            };
        }
    }
}
