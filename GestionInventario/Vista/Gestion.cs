using GestionInventario._1._1_Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Boton para redireccionar a la vista Articulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArticulo_Click(object sender, EventArgs e)
        {
            using (Articulo articulo = new Articulo()) articulo.ShowDialog();
        }

        /// <summary>
        /// Bonton para redireccionar  a la vista Bodega
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBodega_Click(object sender, EventArgs e)
        {
            using (Bodega bodega = new Bodega()) bodega.ShowDialog();

        }

        /// <summary>
        /// Bonton para redireccionar  a la vista Inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventario_Click(object sender, EventArgs e)
        {
            using (Inventario inventario = new Inventario()) inventario.ShowDialog();
        }

        /// <summary>
        /// Bonton para redireccionar  a la vista Transferencias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            using (Transferir transferir = new Transferir()) transferir.ShowDialog();
        }

        /// <summary>
        /// Bonton para redireccionar  a la vista Log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLog_Click(object sender, EventArgs e)
        {
            using (Log log = new Log()) log.ShowDialog();
        }
    }
}
