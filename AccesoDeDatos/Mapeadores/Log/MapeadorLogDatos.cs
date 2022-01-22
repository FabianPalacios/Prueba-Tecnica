using AccesoDeDatos.DbModel.Log;
using AccesoDeDatos.ModeloDeDatos;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Mapeadores.Log
{
    public class MapeadorLogDatos : MapeadorBaseDatos<tb_log, LogDbModel>
    {
        /// <summary>
        /// Mapeador que convierte un objeto tb_log de la base de datos a un objeto LogDbModel 
        /// </summary>
        /// <param name="entrada">Objeto tipo tb_log de la base de datos</param>
        /// <returns></returns>
        public override LogDbModel mapearTipo1Tipo2(tb_log entrada)
        {
            return new LogDbModel()
            {
                Id = entrada.id,
                Fecha = entrada.fecha,
                Hora = entrada.hora,
                Id_Bodega_Origen = entrada.id_bodega_origen,
                Id_Bodega_Destino = entrada.id_bodega_destino,
                Id_Articulo = entrada.id_articulo,
                Unidades_Transferidas = entrada.unidades_Tranferidas

            };
        }

        /// <summary>
        /// Mapeador que convierte una lista tb_log a una lista tipo LogDbModel
        /// </summary>
        /// <param name="entrada">Lista tipo tb_log de la base de datos</param>
        /// <returns></returns>
        public override IEnumerable<LogDbModel> mapearTipo1Tipo2(IEnumerable<tb_log> entrada)
        {
            foreach (var item in entrada)
            {
                yield return mapearTipo1Tipo2(item);
            }
        }

        /// <summary>
        /// Mapeador que convierte un Objeto LogDbModel a un objeto tb_log
        /// </summary>
        /// <param name="entrada">Objeto tipo LogDbModel que proviene de logica</param>
        /// <returns></returns>
        public override tb_log mapearTipo2Tipo1(LogDbModel entrada)
        {
            return new tb_log()
            {
                id = entrada.Id,
                fecha = entrada.Fecha,
                hora = entrada.Hora,
                id_bodega_origen = entrada.Id_Bodega_Origen,
                id_bodega_destino = entrada.Id_Bodega_Destino,
                id_articulo = entrada.Id_Articulo,
                unidades_Tranferidas = entrada.Unidades_Transferidas
            };
        }
    }
}
