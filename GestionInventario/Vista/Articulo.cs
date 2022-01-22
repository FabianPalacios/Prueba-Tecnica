using GestionInventario.Helpers;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario._1._1_Vista
{
    public partial class Articulo : Form
    {
        /// <summary>
        /// Insatancia de la capa logica  Articulo
        /// </summary>
        private ImplArticuloLogica logica = new ImplArticuloLogica();

        /// <summary>
        /// Instancia de la capa logica Bodega
        /// </summary>
        private ImplBodegaLogica logicaBodega = new ImplBodegaLogica();


        /// <summary>
        /// Instancia de clasa Mensaje, para uso de las alertas
        /// </summary>
        private Mensaje mensaje = new Mensaje();


        public Articulo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicialización de los campos o componentes  de la vista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Articulo_Load(object sender, EventArgs e)
        {

            listarBodegas();
            llenar_grid();

            Codigo.Text = "";
            Nombre.Text = "";
            Descripcion.Text = "";
            Cantidad.Text = "0";
            Precio.Text = "0";
        }

        /// <summary>
        /// Método para validar los campos de entra de la vista de articulos
        /// </summary>
        private bool validarCampos()
        {
            bool bandera = true;
            if (Nombre.Text == "")
            {
                bandera = false;
                errorProvider1.SetError(Nombre, "El campo no puede ser vacio");
            }
            if(Descripcion.Text == "")
            {
                bandera = false;
                errorProvider1.SetError(Descripcion, "El campo no puede ser vacio");
            }
            //condicción para imperdr que ingrese numeros menos a cero, simbolo y letras
            if (!Regex.IsMatch(Cantidad.Text, @"^[1-9][0-9]*$") || Cantidad.Text == "")
            {
                bandera = false;
                errorProvider1.SetError(Cantidad, "El campo no puede ser vacio \nEl campo no puede contener letras");
            }
            //condicción para imperdr que ingrese numeros menos a cero, simbolo y letras
            if (!Regex.IsMatch(Precio.Text, @"^[1-9][0-9]*$") || Precio.Text == "")
            {
                bandera = false;
                errorProvider1.SetError(Precio, "El campo no puede ser vacio \nEl campo no puede contener letras");
            }
            return bandera;
        }

        /// <summary>
        /// Métodos Limpiar Campos
        /// </summary>
        private void limpiar()
        {
            Codigo.Text = "";
            Nombre.Text = "";
            Descripcion.Text = "";
            Cantidad.Text = "0";
            Precio.Text = "0";
            errorProvider1.Clear();
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
        /// Llenado de la tabla bodegas
        /// </summary>
        private void llenar_grid()
        {
            IEnumerable<ArticuloLogica> listaDatos = logica.listarRegistros();
            MapeadorArticuloGUI mapper = new MapeadorArticuloGUI();
            IEnumerable<ModeloArticuloGUI> listaGUI = mapper.mapearTipo1Tipo2(listaDatos);

            List<ModeloArticuloGUI> listaBodega = listaGUI.ToList();
            dataGridView1.DataSource = listaBodega;
        }

        /// <summary>
        /// Boton de creación de un articulo, la cual recibe un nombre, descripción, idBodega, cantidad, precio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //Validar los campos de texto
            if(validarCampos() == true)
            {
                MapeadorArticuloGUI mapper = new MapeadorArticuloGUI();
                ArticuloLogica ArticuloLogica = mapper.mapearTipo2Tipo1(new ModeloArticuloGUI
                {
                    Nombre = Nombre.Text,
                    Descripcion = Descripcion.Text,
                    IdBodega = Convert.ToInt32(cmbBodega.SelectedValue),
                    Cantidad = Int32.Parse(Cantidad.Text),
                    Precio = Int32.Parse(Precio.Text)
                });

                //Comprobar que el articulo no se encuentre en bodega
                if (logica.buscarArticuloEnBodega(ArticuloLogica))
                {
                    mensaje.mensajeInfo("Registro ya existe");
                }
                else
                {
                    logica.guardarRegistro(ArticuloLogica);
                }
                
                llenar_grid();
                mensaje.mensajeInfo("Registro Guardado");
                limpiar();
            }
            
        }

        /// <summary>
        /// Seleción de un campo dependiendo el click que se le haga a una celda de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Descripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Cantidad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Precio.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbBodega.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbBodega.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        /// <summary>
        /// Boton de eliminado de un articulo con respecto a un código
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(validarCampos() == true && Codigo.Text != "")
            {
                bool isDelete = logica.eliminarRegistro(Int32.Parse(Codigo.Text));

                if (isDelete == false)
                {
                    mensaje.mensajeError("No se puede Eliminar el articulos", "ERROR ELIMINADO");
                }
                else
                {
                    llenar_grid();
                    mensaje.mensajeInfo("Registro Eliminado");
                    limpiar();
                }
            }
            else
            {
                mensaje.mensajeError("Selecione cualquier campo de la tabla para eliminar", "ERROR ELIMINADO");
            }
        }

        /// <summary>
        /// Boton Para editar un articulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            // Validar los campos de texto
            if (validarCampos() == true && Codigo.Text != "")
            {
                MapeadorArticuloGUI mapper = new MapeadorArticuloGUI();
                ArticuloLogica BodegaLogica = mapper.mapearTipo2Tipo1(new ModeloArticuloGUI
                {
                    Id = Int32.Parse(Codigo.Text),
                    Nombre = Nombre.Text,
                    Descripcion = Descripcion.Text,
                    IdBodega = Convert.ToInt32(cmbBodega.SelectedValue),
                    Cantidad = Int32.Parse(Cantidad.Text),
                    Precio = Int32.Parse(Precio.Text)
                });

                logica.EditarRegistro(BodegaLogica);
                
                llenar_grid();
                mensaje.mensajeInfo("Registro Editado");
                limpiar();
            }
            else
            {
                mensaje.mensajeError("Selecione cualquier campo de la tabla para editar", "ERROR EDITADO");
            }
            

        }
    }
}
