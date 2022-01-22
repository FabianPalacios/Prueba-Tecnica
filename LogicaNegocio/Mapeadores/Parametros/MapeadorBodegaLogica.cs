using AccesoDeDatos.DbModel.Parametros;
using LogicaNegocio.ModeloLogica.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Mapeadores.Parametros
{
    public class MapeadorBodegaLogica : MapeadorBaseLogica<BodegaDbModel, BodegaLogica>
    {
        /// <summary>
        /// Mapeador que convierte un objeto BodegaDbModel a un objeto BodegaLogica
        /// </summary>
        /// <param name="entrada">Objeto tipo BodegaDbModel del la capa AccesoDeDatos</param>
        /// <returns>Retorna un objeto BodegaLogica</returns>
        public override BodegaLogica mapearTipo1Tipo2(BodegaDbModel entrada)
        {
            return new BodegaLogica()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        /// <summary>
        /// Mapeador que convierte una lista BodegaDbModel a una lista tipo BodegaLogica
        /// </summary>
        /// <param name="entrada">Lista tipo BodegaDbModel de la capa AccesoDeDatos</param>
        /// <returns>Retorna una lista tipo BodegaLogica</returns>
        public override IEnumerable<BodegaLogica> mapearTipo1Tipo2(IEnumerable<BodegaDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return mapearTipo1Tipo2(item);
            }
        }

        /// <summary>
        /// Mapeador que convierte un Objeto BodegaLogica a un objeto BodegaDbModel
        /// </summary>
        /// <param name="entrada">Objeto tipo BodegaLogica que proviene de la capaGestionInventario</param>
        /// <returns>Retorna un objeto tipo BodegaDbModel</returns>
        public override BodegaDbModel mapearTipo2Tipo1(BodegaLogica entrada)
        {
            return new BodegaDbModel()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

    }
}
