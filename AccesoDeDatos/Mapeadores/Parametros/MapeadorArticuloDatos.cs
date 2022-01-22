using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Mapeadores.Parametros
{
    public class MapeadorArticuloDatos: MapeadorBaseDatos<tb_articulo, ArticuloDbModel>
    {
        /// <summary>
        /// Mapeador que convierte un objeto tb_articulo de la base de datos a un objeto ArticuloDbModel 
        /// </summary>
        /// <param name="entrada">Objeto tipo tb_articulo de la base de datos</param>
        /// <returns></returns>
        public override ArticuloDbModel mapearTipo1Tipo2(tb_articulo entrada)
        {
            return new ArticuloDbModel()
            {
                Id = entrada.id,
                Nombre = entrada.nombre,
                Descripcion = entrada.descripcion,
                IdBodega = entrada.id_bodega,
                NombreBodega = entrada.tb_bodega.nombre,
                Cantidad = entrada.cantidad,
                Precio = entrada.precio
            };
        }

        /// <summary>
        /// Mapeador que convierte una lista tb_articulo a una lista tipo ArticuloDbModel
        /// </summary>
        /// <param name="entrada">Lista tipo tb_articulo de la base de datos</param>
        /// <returns></returns>
        public override IEnumerable<ArticuloDbModel> mapearTipo1Tipo2(IEnumerable<tb_articulo> entrada)
        {
            foreach (var item in entrada)
            {
                yield return mapearTipo1Tipo2(item);
            }
        }

        /// <summary>
        /// Mapeador que convierte un Objeto ArticuloDbModel a un objeto tb_articulo
        /// </summary>
        /// <param name="entrada">Objeto tipo ArticuloDbModel que proviene de logica</param>
        /// <returns></returns>
        public override tb_articulo mapearTipo2Tipo1(ArticuloDbModel entrada)
        {
            return new tb_articulo()
            {
                id = entrada.Id,
                nombre = entrada.Nombre,
                descripcion = entrada.Descripcion,
                id_bodega = entrada.IdBodega,
                cantidad = entrada.Cantidad,
                precio = entrada.Precio
            };
        }

    }
}
