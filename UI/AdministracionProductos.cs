using BLL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;



namespace UI
{
    public partial class AdministracionProductos : Form
    {
        private static int IdUsuarioSesion = 1;
        private static int IdRegistro = 0;
        public AdministracionProductos()
        {
            InitializeComponent();
        }

        private void AdministracionProductos_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void cargarGrid()
        {
            try
            {
                //listo el orden de la entidad
                GridProductos.DataSource = BLL_Productos.Lista();
                GridProductos.Columns[0].Visible = false;
                GridProductos.Columns[1].HeaderText = "Descripción del producto";
                GridProductos.Columns[2].HeaderText = "Cantidad";
                GridProductos.Columns[3].Visible = false;
                GridProductos.Columns[4].Visible = false;
                GridProductos.Columns[5].Visible = false;
                GridProductos.Columns[6].Visible = false;
                GridProductos.Columns[7].Visible = false;
                GridProductos.Columns[7].Visible = false;
                LimpiarCampos();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validarFormulario()
        {
            if (string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Ingrese la descripción del producto");
                return false;
            }
            if (txtProducto.Text.Length > 200)
            {
                MessageBox.Show("El campo descripción del producto debe ser menor a 200 caracteres");
                return false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Ingrese Cantidad");
                return false;
            }
            if (txtCantidad.Text.Length > 7 || txtCantidad.Text.Length > 7)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return false;
            }
            if (BLL_Productos.ValidarDescripcionProduct(txtProducto.Text, IdRegistro))
            {
                MessageBox.Show("Ya se encuentra un producto registrado con la misma descripción.");
                return false;
            }


            return true;
        }
        private void Guardar()
        {
            if (validarFormulario())
            {
                Productos Entidad = new Productos();
                Entidad.Descripcion = txtProducto.Text;
                Entidad.Cantidad = txtCantidad.Text;


                if (IdRegistro > 0)
                {
                    //Actualizar
                    Entidad.IdProducto = IdRegistro;
                    Entidad.IdUsuarioActualiza = IdUsuarioSesion;
                    if (BLL_Productos.Update(Entidad))
                    {
                        MessageBox.Show("Registro actualizado con exito");
                        cargarGrid();
                        return;
                    }
                    MessageBox.Show("El Registro no fue actualizado con exito");
                    return;
                }

                //Insertar          
                Entidad.IdUsuarioRegistra = IdUsuarioSesion;
                if (BLL_Productos.Insert(Entidad).IdProducto > 0)
                {
                    MessageBox.Show("Registro agregado con exito");
                    cargarGrid();
                    return;
                }
                MessageBox.Show("El Registro no fue agregado con exito");
                return;
            }
        }
        private void Anular()
        {
            try
            {
                Productos entidad = new();
                entidad.IdProducto = IdRegistro;
                entidad.IdUsuarioActualiza = IdUsuarioSesion;
                if (BLL_Productos.Anular(entidad))
                {
                    MessageBox.Show("Registro anulado con exito");
                    cargarGrid();
                    return;
                }
                MessageBox.Show("El Registro no fue anulado con exito");
                return;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
        private void cargarCampos()
        {
            try
            {
                IdRegistro = Convert.ToInt32(GridProductos.CurrentRow.Cells[0].Value);
                txtProducto.Text = GridProductos.CurrentRow.Cells[1].Value.ToString();
                txtCantidad.Text = GridProductos.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            IdRegistro = 0;
            txtProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void GridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCampos();
        }
    }
}
