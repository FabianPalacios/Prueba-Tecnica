using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventario.Mapper.Parameters
{
    /// <summary>
    /// Clase abstract de métodos mapeadores genericos de la capa GestionInventario
    /// </summary>
    /// <typeparam name="Tipo1">origen</typeparam>
    /// <typeparam name="Tipo2">destino</typeparam>
    public abstract class MapeadorBaseGUI<Tipo1, Tipo2>
    {
        public abstract Tipo2 mapearTipo1Tipo2(Tipo1 entrada);
        public abstract IEnumerable<Tipo2> mapearTipo1Tipo2(IEnumerable<Tipo1> entrada);

        public abstract Tipo1 mapearTipo2Tipo1(Tipo2 entrada);
    }
}
