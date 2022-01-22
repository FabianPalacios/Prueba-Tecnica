using GestionInventario.Helpers;
using GestionInventario.Mapeador.Log;
using GestionInventario.Mapeador.Parameters;
using GestionInventario.Mapper.Parameters;
using GestionInventario.Models.Log;
using GestionInventario.Models.Parameters;
using LogicaNegocio.Implementacion.Log;
using LogicaNegocio.Implementacion.Parametros;
using LogicaNegocio.ModeloLogica.Log;
using LogicaNegocio.ModeloLogica.Parametros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario._1._1_Vista
{
    public partial class Transferir : Form
    {
        /// <summary>
        /// Insatancia de la capa logica 
        /// </summary>
        private ImplArticuloLogica logicaArticulo = new ImplArticuloLogica();
        private ImplBodegaLogica logicaBodega = new ImplBodegaLogica();
        private ImpLogLogica logicaLog = new ImpLogLogica();

        /// <summary>
        /// Instancia de clasa Mensaje, para uso de las alertas
        /// </summary>
        private Mensaje mensaje = new Mensaje();


        public Transferir()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicialización de los campos o componentes de la vista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transferir_Load(object sender, EventArgs e)
        {
            llenar_gridArticulos();
            CodigoDestino.Text = "";
            CantidadOrigen.Text = "0";
            CantidadDestino.Text = "0";
        }

        /// <summary>
        /// Llenado de la tabla Articulos
        /// </summary>
        private void llenar_gridArticulos()
        {
            IEnumerable<ArticuloLogica> listaDatos = logicaArticulo.listarRegistros();
            MapeadorArticuloGUI mapper = new MapeadorArticuloGUI();
            IEnumerable<ModeloArticuloGUI> listaGUI = mapper.mapearTipo1Tipo2(listaDatos);

            List<ModeloArticuloGUI> listaBodega = listaGUI.ToList();
            dataGridView1.DataSource = listaBodega;
        }


        /// <summary>
        /// Llenado de la tabla Articulo filtrados por id y nombre
        /// </summary>
        private void llenar_gridArticulosDiferentes()
        {
            IEnumerable<ArticuloLogica> listaDatos = logicaArticulo.listarArticulosDiferentes(Int32.Parse(CodigoOrigen.Text), ArticuloOrigen.Text);
            MapeadorArticuloGUI mapper = new MapeadorArticuloGUI();
            IEnumerable<ModeloArticuloGUI> listaGUI = mapper.mapearTipo1Tipo2(listaDatos);

            List<ModeloArticuloGUI> listaBodega = listaGUI.ToList();
            dataGridView2.DataSource = listaBodega;
        }

        /// <summary>
        /// Llenado del comboBox con las bodegas diferentes a la elegida en origen
        /// </summary>
        private void llenar_BodegasDestino()
        {
            IEnumerable<BodegaLogica> listaDatos = logicaBodega.listarRegistrosBodegasDiferentes(BodegaOrigen.Text);
            MapeadorBodegaGUI mapper = new MapeadorBodegaGUI();
            IEnumerable<ModeloBodegaGUI> listaGUI = mapper.mapearTipo1Tipo2(listaDatos);

            List<ModeloBodegaGUI> listaBodega = listaGUI.ToList();
            cmbBodegaDestino.DataSource = listaBodega;
            cmbBodegaDestino.DisplayMember = "Nombre";
            cmbBodegaDestino.ValueMember = "Id";
        }


        /// <summary>
        /// Seleción de un campo dependiendo el click que se le haga a una celda de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoOrigen.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ArticuloOrigen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ArticuloDestino.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            BodegaOrigen.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            CantidadOrigen.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            CodigoBodegaOrigen.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            llenar_BodegasDestino();
            llenar_gridArticulosDiferentes();
        }

        /// <summary>
        /// Seleción de un campo dependiendo el click que se le haga a una celda de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoDestino.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString(); 
            cmbBodegaDestino.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            cmbBodegaDestino.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        /// <summary>
        /// Método para validar los campos de entrada de la vista Transferir
        /// </summary>
        /// <returns></returns>
        private bool validarCampos()
        {
            bool bandera = true;

            //condicción para imperdr que ingrese numeros menos a cero, simbolo y letras
            if (!Regex.IsMatch(CantidadDestino.Text, @"^[1-9][0-9]*$"))
            {
                bandera = false;
                errorProvider1.SetError(CantidadDestino, "El campo no puede contener letras \nEl campo no puede ser menor a 0 \nEl campo no puede contener simbolos");
            }
            else if (Int32.Parse(CantidadDestino.Text) >= Int32.Parse(CantidadOrigen.Text))
            {
                bandera = false;
                errorProvider1.SetError(CantidadDestino, "El cantidad supera el valor en inventario \nSelecione un campo de la tabla");
            }
            if (CantidadDestino.Text == "")
            {
                bandera = false;
                errorProvider1.SetError(CantidadDestino, "El campo no puede ser vacio");
            }
            if(cmbBodegaDestino.Text == "")
            {
                bandera = false;
                errorProvider1.SetError(cmbBodegaDestino, "El campo no puede ser vacio \nSelecione un campo de la tabla");
            }


            return bandera;
        }

        /// <summary>
        /// Boton para transferir un articulo de una bodega a otra, si no encuentra el articulo le crea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(validarCampos()== true)
            {
                if (CodigoDestino.Text == "")
                {
                    //En caso de que el articulo no exista en una bodega lo crea
                    logicaArticulo.crearArticuloTransferir(Int32.Parse(CodigoOrigen.Text), Int32.Parse(CantidadDestino.Text), Convert.ToInt32(cmbBodegaDestino.SelectedValue));
                    
                    //Guardar Log
                    MapeadorLogGUI mapper = new MapeadorLogGUI();
                    LogLogica log = mapper.mapearTipo2Tipo1(new ModeloLogGUI
                    {
                        Fecha = DateTime.Now.ToString("dd-MM-yyyy"),
                        Hora = DateTime.Now.ToString("hh:mm:ss tt"),
                        Id_Bodega_Origen = Int32.Parse(CodigoBodegaOrigen.Text),
                        Id_Bodega_Destino = Convert.ToInt32(cmbBodegaDestino.SelectedValue),
                        Id_Articulo = Int32.Parse(CodigoOrigen.Text),
                        Unidades_Transferidas = Int32.Parse(CantidadDestino.Text)
                    });
                    logicaLog.guardarRegistro(log);

                }
                else
                {
                    //Se envian dos articulos en caso que existan tranfiere las cantidades 
                    logicaArticulo.tranferirArticulo(Int32.Parse(CodigoOrigen.Text), Int32.Parse(CodigoDestino.Text), Int32.Parse(CantidadDestino.Text));
                    
                    //Guardar Log
                    MapeadorLogGUI mapper = new MapeadorLogGUI();
                    LogLogica log = mapper.mapearTipo2Tipo1(new ModeloLogGUI
                    {
                        Fecha = DateTime.Now.ToString("dd-MM-yyyy"),
                        Hora = DateTime.Now.ToString("hh:mm:ss tt"),
                        Id_Bodega_Origen = Int32.Parse(CodigoBodegaOrigen.Text),
                        Id_Bodega_Destino = Convert.ToInt32(cmbBodegaDestino.SelectedValue),
                        Id_Articulo = Int32.Parse(CodigoOrigen.Text),
                        Unidades_Transferidas = Int32.Parse(CantidadDestino.Text)
                    });
                    logicaLog.guardarRegistro(log);
                }
                llenar_gridArticulos();
                llenar_gridArticulosDiferentes();
                mensaje.mensajeInfo("Registro Transferido");
                limpiar();
            }
            else
            {
                mensaje.mensajeError("Selecione cualquier campo de la tabla para transferir", "ERROR TRANSFERIR");
            }
        }

        /// <summary>
        /// Métodos Limpiar Campos
        /// </summary>
        private void limpiar()
        {
            CodigoOrigen.Text = "";
            CodigoDestino.Text = "";
            CantidadOrigen.Text = "0";
            CantidadDestino.Text = "0";
            ArticuloOrigen.Text = "";
            ArticuloDestino.Text = "";
            errorProvider1.Clear();
        }

        private void lblCodigoBodega_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigoOrigen_Click(object sender, EventArgs e)
        {

        }
    }
}
