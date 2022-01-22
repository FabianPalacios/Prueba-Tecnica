using GestionInventario.Mapeador.Log;
using GestionInventario.Models.Log;
using LogicaNegocio.Implementacion.Log;
using LogicaNegocio.ModeloLogica.Log;
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
    public partial class Log : Form
    {
        /// <summary>
        /// Insatancia de la capa logica 
        /// </summary>
        private ImpLogLogica logica = new ImpLogLogica();

        public Log()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicialización de los campos o componentes  de la vista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Log_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        /// <summary>
        /// Llenado de la tabla Log
        /// </summary>
        private void llenar_grid()
        {
            IEnumerable<LogLogica> listaDatos = logica.listarRegistros();
            MapeadorLogGUI mapper = new MapeadorLogGUI();
            IEnumerable<ModeloLogGUI> listaGUI = mapper.mapearTipo1Tipo2(listaDatos);

            List<ModeloLogGUI> listaBodega = listaGUI.ToList();
            dataGridView1.DataSource = listaBodega;
        }
    }
}
