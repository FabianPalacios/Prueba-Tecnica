using GestionInventario.Mapper.Parameters;
using GestionInventario.Models.Log;
using LogicaNegocio.ModeloLogica.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario.Mapeador.Log
{
    public class MapeadorLogGUI : MapeadorBaseGUI<LogLogica, ModeloLogGUI>
    {
        /// <summary>
        /// Mapeador que convierte un objeto LogLogica a un objeto ModeloLogGUI
        /// </summary>
        /// <param name="entrada">Objeto tipo LogLogica del la capa LogicaNegocio</param>
        /// <returns>Retorna un objeto tipo ModeloLogGUI</returns>
        public override ModeloLogGUI mapearTipo1Tipo2(LogLogica entrada)
        {
            return new ModeloLogGUI()
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
        /// Mapeador que convierte una lista tipo LogLogica a una lista tipo ModeloLogGUI
        /// </summary>
        /// <param name="entrada">Lista tipo LogLogica de la capa LogicaNegocio</param>
        /// <returns>Retorna una lista tipo ModeloLogGUI</returns>
        public override IEnumerable<ModeloLogGUI> mapearTipo1Tipo2(IEnumerable<LogLogica> entrada)
        {
            foreach (var item in entrada)
            {
                yield return mapearTipo1Tipo2(item);
            }
        }

        /// <summary>
        /// Mapeador que convierte un objeto ModeloLogGUI a un objeto LogLogica
        /// </summary>
        /// <param name="entrada">Objeto tipo ModeloLogGUI que proviene de la capa GestionInventario</param>
        /// <returns>Retorna un objeto tipo LogLogica</returns>
        public override LogLogica mapearTipo2Tipo1(ModeloLogGUI entrada)
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
    }
}
