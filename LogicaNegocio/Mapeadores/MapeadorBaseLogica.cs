using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Mapeadores
{
    /// <summary>
    /// Clase abstract de métodos mapeadores genericos de la capa LogicaNegocio
    /// </summary>
    /// <typeparam name="Tipo1">origen</typeparam>
    /// <typeparam name="Tipo2">destino</typeparam>
    public abstract class MapeadorBaseLogica<Tipo1, Tipo2>
    {
        public abstract Tipo2 mapearTipo1Tipo2(Tipo1 entrada);
        public abstract IEnumerable<Tipo2> mapearTipo1Tipo2(IEnumerable<Tipo1> entrada);
        public abstract Tipo1 mapearTipo2Tipo1(Tipo2 entrada);
    }
}
