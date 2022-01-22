using GestionInventario.Models.Parameters;
using LogicaNegocio.ModeloLogica.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario.Mapper.Parameters
{
    public class MapeadorBodegaGUI: MapeadorBaseGUI<BodegaLogica, ModeloBodegaGUI>
    {
        /// <summary>
        /// Mapeador que convierte un objeto BodegaLogica a un objeto ModeloBodegaGUI
        /// </summary>
        /// <param name="entrada">Objeto tipo BodegaLogica del la capa LogicaNegocio</param>
        /// <returns>Retorna un objeto tipo ModeloBodegaGUI</returns>
        public override ModeloBodegaGUI mapearTipo1Tipo2(BodegaLogica entrada)
        {
            return new ModeloBodegaGUI()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

        /// <summary>
        /// Mapeador que convierte una lista tipo BodegaLogica a una lista tipo ModeloBodegaGUI
        /// </summary>
        /// <param name="entrada">Lista tipo BodegaLogica de la capa LogicaNegocio</param>
        /// <returns>Retorna una lista tipo ModeloBodegaGUI</returns>
        public override IEnumerable<ModeloBodegaGUI> mapearTipo1Tipo2(IEnumerable<BodegaLogica> entrada)
        {
            foreach (var item in entrada)
            {
                yield return mapearTipo1Tipo2(item);
            }
        }

        /// <summary>
        /// Mapeador que convierte un objeto ModeloBodegaGUI a un objeto BodegaLogica
        /// </summary>
        /// <param name="entrada">Objeto tipo ModeloBodegaGUI que proviene de la capa GestionInventario</param>
        /// <returns>Retorna un objeto tipo BodegaLogica</returns>
        public override BodegaLogica mapearTipo2Tipo1(ModeloBodegaGUI entrada)
        {
            return new BodegaLogica()
            {
                Id = entrada.Id,
                Nombre = entrada.Nombre
            };
        }

    }
}
