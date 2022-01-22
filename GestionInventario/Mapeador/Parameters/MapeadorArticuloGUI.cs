using GestionInventario.Mapper.Parameters;
using GestionInventario.Models.Parameters;
using LogicaNegocio.ModeloLogica.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario.Mapeador.Parameters
{
    public class MapeadorArticuloGUI: MapeadorBaseGUI<ArticuloLogica, ModeloArticuloGUI>
    {
        /// <summary>
        /// Mapeador que convierte un objeto ArticuloLogica a un objeto ModeloArticuloGUI
        /// </summary>
        /// <param name="entrada">Objeto tipo ArticuloLogica del la capa LogicaNegocio</param>
        /// <returns>Retorna un objeto tipo ModeloArticuloGUI</returns>
        public override ModeloArticuloGUI mapearTipo1Tipo2(ArticuloLogica entrada)
        {
            return new ModeloArticuloGUI()
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
        /// Mapeador que convierte una lista tipo ArticuloLogica a una lista tipo ModeloArticuloGUI
        /// </summary>
        /// <param name="entrada">Lista tipo ArticuloLogica de la capa LogicaNegocio</param>
        /// <returns>Retorna una lista tipo ModeloArticuloGUI</returns>
        public override IEnumerable<ModeloArticuloGUI> mapearTipo1Tipo2(IEnumerable<ArticuloLogica> entrada)
        {
            foreach (var item in entrada)
            {
                yield return mapearTipo1Tipo2(item);
            }
        }

        /// <summary>
        /// Mapeador que convierte un objeto ModeloArticuloGUI a un objeto ArticuloLogica
        /// </summary>
        /// <param name="entrada">Objeto tipo ModeloArticuloGUI que proviene de la capa GestionInventario</param>
        /// <returns>Retorna un objeto tipo ArticuloLogica</returns>
        public override ArticuloLogica mapearTipo2Tipo1(ModeloArticuloGUI entrada)
        {
            return new ArticuloLogica()
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
