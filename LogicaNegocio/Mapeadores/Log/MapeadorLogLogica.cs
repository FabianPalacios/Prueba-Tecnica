using AccesoDeDatos.DbModel.Log;
using LogicaNegocio.ModeloLogica.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Mapeadores.Log
{
    public class MapeadorLogLogica: MapeadorBaseLogica<LogDbModel, LogLogica>
    {
        /// <summary>
        /// Mapeador que convierte un objeto LogDbModel a un objeto LogLogica
        /// </summary>
        /// <param name="entrada">Objeto tipo LogDbModel del la capa AccesoDeDatos</param>
        /// <returns>Retorna un objeto tipo LogLogica</returns>
        public override LogLogica mapearTipo1Tipo2(LogDbModel entrada)
        {
            return new LogLogica()
            {
                Id = entrada.Id,
                Fecha = entrada.Fecha,
                Hora = entrada.Hora,
                Id_Bodega_Origen = entrada.Id_Bodega_Origen,
                Id_Bodega_Destino = entrada.Id_Bodega_Destino,
                Id_Articulo = entrada.Id_Articulo,
                Unidades_Transferidas = entrada.Unidades_Transferidas
            };
        }

        /// <summary>
        /// Mapeador que convierte una lista LogDbModel a una lista tipo LogLogica
        /// </summary>
        /// <param name="entrada">Lista tipo LogDbModel de la capa AccesoDeDatos</param>
        /// <returns>Retorna una lista tipo LogLogica</returns>
        public override IEnumerable<LogLogica> mapearTipo1Tipo2(IEnumerable<LogDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return mapearTipo1Tipo2(item);
            }
        }

        /// <summary>
        /// Mapeador que convierte un Objeto LogLogica a un objeto LogDbModel
        /// </summary>
        /// <param name="entrada">Objeto tipo LogLogica que proviene de la capaGestionInventario</param>
        /// <returns>Retorna un objeto tipo LogDbModel</returns>
        public override LogDbModel mapearTipo2Tipo1(LogLogica entrada)
        {
            return new LogDbModel()
            {
                Id = entrada.Id,
                Fecha = entrada.Fecha,
                Hora = entrada.Hora,
                Id_Bodega_Origen = entrada.Id_Bodega_Origen,
                Id_Bodega_Destino = entrada.Id_Bodega_Destino,
                Id_Articulo = entrada.Id_Articulo,
                Unidades_Transferidas = entrada.Unidades_Transferidas
            };
        }
    }
}
