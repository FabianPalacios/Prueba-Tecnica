//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDeDatos.ModeloDeDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_log
    {
        public int id { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public int id_bodega_origen { get; set; }
        public int id_bodega_destino { get; set; }
        public int id_articulo { get; set; }
        public int unidades_Tranferidas { get; set; }
    }
}
