using GestionInventario.Helpers;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class Bodega : Form
    {
        /// <summary>
        /// Insatancia de la capa logica
        /// </summary>
        private ImplBodegaLogica logica = new ImplBodegaLogica();

        /// <summary>
        /// Instancia de clasa Mensaje, para uso de las alertas
        /// </summary>
        private Mensaje mensaje = new Mensaje();

        /// <summary>
        /// Constructor Bodega incializa los componentes
        /// </summary>
        public Bodega()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicialización de los campos o componentes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bodega_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        /// <summary>
        /// Método para validar los campos de entra de la vista de articulos
        /// </summary>
        /// <returns></returns>
        private bool validarCampos()
        {
            bool bandera = true;
            if(Nombre.Text =="")
            {
                bandera = false;
                errorProvider1.SetError(Nombre, "El campo Nombre no debe ser vacío");
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
        }

        /// <summary>
        /// Seleción de un campo dependiendo el click de la celda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        /// <summary>
        /// Llenado de la tabla bodegas
        /// </summary>
        private void llenar_grid()
        {
            IEnumerable<BodegaLogica> listaDatos = logica.listarRegistros();
            MapeadorBodegaGUI mapper = new MapeadorBodegaGUI();
            IEnumerable<ModeloBodegaGUI> listaGUI = mapper.mapearTipo1Tipo2(listaDatos);

            List<ModeloBodegaGUI> listaBodega = listaGUI.ToList();
            dataGridView1.DataSource = listaBodega;
        } 

        /// <summary>
        /// Boton de creación de una bodega, la cual recibe un nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearBodega_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (validarCampos() == true)
            {
                MapeadorBodegaGUI mapper = new MapeadorBodegaGUI();
                BodegaLogica BodegaDTO = mapper.mapearTipo2Tipo1(new ModeloBodegaGUI { Id = 1, Nombre = Nombre.Text });
                bool isSaved = logica.guardarRegistro(BodegaDTO);

                if (isSaved == false)
                {
                    errorProvider1.SetError(Nombre, "El nombre de la bodega ya existe");
                    mensaje.mensajeError("El nombre de la bodega ya existe en la base de datos", "ERROR GUARDADO");
                }
                else
                {
                    llenar_grid();
                    mensaje.mensajeInfo("Registro Guardado");
                    limpiar();
                }
            }
            
        }

        /// <summary>
        /// Boton de eliminado de una bodega con respecto a un código
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (validarCampos() == true)
            {
                bool isDelete = logica.eliminarRegistro(Int32.Parse(Codigo.Text));

                if (isDelete == false)
                {
                    errorProvider1.SetError(Nombre, "No se puede Eliminar la bodega tiene articulos");
                    mensaje.mensajeError("No se puede Eliminar la bodega tiene articulos", "ERROR ELIMINADO");
                }
                else
                {
                    llenar_grid();
                    mensaje.mensajeInfo("Registro Eliminado");
                    limpiar();
                }
            }

            
        }

        /// <summary>
        /// Boton Para editar una bodega
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (validarCampos() == true)
            {
                MapeadorBodegaGUI mapper = new MapeadorBodegaGUI();
                BodegaLogica BodegaLogica = mapper.mapearTipo2Tipo1(new ModeloBodegaGUI { Id = Int32.Parse(Codigo.Text), Nombre = Nombre.Text });
                bool isSaved = logica.EditarRegistro(BodegaLogica);

                if (isSaved == false)
                {
                    errorProvider1.SetError(Nombre, "El nombre de la bodega ya existe en la base de datos");
                    mensaje.mensajeError("El nombre de la bodega ya existe en la base de datos", "ERROR EDITADO");
                }
                else
                {
                    llenar_grid();
                    mensaje.mensajeInfo("Registro Editado");
                    limpiar();
                }
            }

        }
    }
}
