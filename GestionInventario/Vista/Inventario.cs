using GestionInventario.Mapeador.Parameters;
using GestionInventario.Mapper.Parameters;
using GestionInventario.Models.Parameters;
using LogicaNegocio.Implementacion.Parametros;
using LogicaNegocio.ModeloLogica.Parametros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario._1._1_Vista
{
    public partial class Inventario : Form
    {
        /// <summary>
        /// Insatancia de la capa logicaNegocio  de Articulos
        /// </summary>
        private ImplArticuloLogica logicaArticulo = new ImplArticuloLogica();

        /// <summary>
        /// Instancia de la capa LogicaNegocio de Bodega
        /// </summary>
        private ImplBodegaLogica logicaBodega = new ImplBodegaLogica();


        public Inventario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicialización de los campos o componentes de la vista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inventario_Load(object sender, EventArgs e)
        {
            listarBodegas();
        }

        /// <summary>
        /// Llevar el comboBox con los campos de bodega
        /// </summary>
        private void listarBodegas()
        {
            IEnumerable<BodegaLogica> listaDatos = logicaBodega.listarRegistros();
            MapeadorBodegaGUI mapper = new MapeadorBodegaGUI();
            IEnumerable<ModeloBodegaGUI> listaGUI = mapper.mapearTipo1Tipo2(listaDatos);

            List<ModeloBodegaGUI> listaBodega = listaGUI.ToList();
            cmbBodega.DataSource = listaBodega;
            cmbBodega.DisplayMember = "Nombre";
            cmbBodega.ValueMember = "Id";
        }

        /// <summary>
        /// Boton para aplicar la busqueda ade articulos por bodega
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IEnumerable<ArticuloLogica> listaDatos = logicaArticulo.listarRegistrosFiltroBodega(Convert.ToInt32(cmbBodega.SelectedValue));
            MapeadorArticuloGUI mapper = new MapeadorArticuloGUI();
            IEnumerable<ModeloArticuloGUI> listaGUI = mapper.mapearTipo1Tipo2(listaDatos);

            List<ModeloArticuloGUI> listaBodega = listaGUI.ToList();
            dataGridView1.DataSource = listaBodega;
        }


    }
}
