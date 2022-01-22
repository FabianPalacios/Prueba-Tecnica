using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.ModeloDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Mapeadores.Parametros
{
    public class MapeadorBodegaDatos : MapeadorBaseDatos<tb_bodega, BodegaDbModel>
    {
        /// <summary>
        /// Mapeador que convierte un objeto tb_bodega de la base de datos a un objeto BodegaDbModel 
        /// </summary>
        /// <param name="entrada">Objeto tipo tb_bodega de la base de datos</param>
        /// <returns></returns>
        public override BodegaDbModel mapearTipo1Tipo2(tb_bodega entrada)
        {
            return new BodegaDbModel()
            {
                Id = entrada.id,
                Nombre = entrada.nombre
            };
        }

        /// <summary>
        /// Mapeador que convierte una lista tb_bodega a una lista tipo BodegaDbModel
        /// </summary>
        /// <param name="entrada">Lista tipo tb_bodega de la base de datos</param>
        /// <returns></returns>
        public override IEnumerable<BodegaDbModel> mapearTipo1Tipo2(IEnumerable<tb_bodega> entrada)
        {
            foreach (var item in entrada)
            {
                yield return mapearTipo1Tipo2(item);
            }
        }

        /// <summary>
        /// Mapeador que convierte un Objeto BodegaDbModel a un objeto tb_bodega
        /// </summary>
        /// <param name="entrada">Objeto tipo BodegaDbModel que proviene de logica</param>
        /// <returns></returns>
        public override tb_bodega mapearTipo2Tipo1(BodegaDbModel entrada)
        {
            return new tb_bodega()
            {
                id = entrada.Id,
                nombre = entrada.Nombre
            };
        }

    }
}
