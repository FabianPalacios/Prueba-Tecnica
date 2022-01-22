using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario.Helpers
{
    public class Mensaje
    {
        /// <summary>
        /// Método para mostrar el mensaje de error
        /// </summary>
        /// <param name="comentario">Comentario que va a tener el error</param>
        /// <param name="titulo">Titulo del mensajes de error</param>
        public void mensajeError(string comentario, string titulo)
        {
            MessageBox.Show(comentario, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Método para indicar una mensaje 
        /// </summary>
        /// <param name="comentario">Comentario que va a tener la alerta</param>
        public void mensajeInfo(string comentario)
        {
            MessageBox.Show(comentario);
        }
    }
}
