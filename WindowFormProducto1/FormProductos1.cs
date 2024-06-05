using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormProducto1
{
    public partial class FormProductos1 : Form
    {
        Producto producto = new Producto();
        Productos productos = new Productos();

        public int index;
        public bool existe;

        public long ValorVerif;
        public long Verif;

        public FormProductos1()
        {
            InitializeComponent();
            dataGridView1.DataSource = productos.ListaDT;
            //ordena la columna
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            lblDescripcionMov.Text = "";
            lblStockMov.Text = "";

        }
        //my
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (textBoxCod1.Text != "" && textBoxCod1.Text != "Codigo")
            {
                ErrorPCod.SetError(textBoxCod1, "");

            }
            else
            {
                ErrorPCod.SetError(textBoxCod1, "Ingrese un código porfavor");
                textBoxCod1.Focus();
                return;
            }

            if (long.TryParse(textBoxCod1.Text, out Verif))
            {
                ValorVerif = long.Parse(textBoxCod1.Text);
                ErrorPCod.SetError(textBoxCod1, "");
            }
            else
            {
                ErrorPCod.SetError(textBoxCod1, "Ingrese un codigo en numeros");
                return;
            }

            if (textBoxDescrip2.Text != "" && textBoxDescrip2.Text != "Descripcion")
            {
                ErrorPDescrip.SetError(textBoxDescrip2, "");
            }
            else
            {
                ErrorPDescrip.SetError(textBoxDescrip2, "Debe ingresar una descripcion");
                textBoxDescrip2.Focus();
                return;
            }





            Producto producto = new Producto(int.Parse(textBoxCod1.Text), textBoxDescrip2.Text);

            existe = productos.ExisteProducto(textBoxCod1.Text);
            if (existe)
            {

                MessageBox.Show("El codigo del producto ya fue cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblStockMov.Text = producto.p_stock.ToString() + "U°";

            productos.InsertoProducto(producto);
            dataGridView1.DataSource = productos.ListaDT;
            dataGridView1.ClearSelection();
            MessageBox.Show("Producto Cargado");

            lblDescripcionMov.Text = productos.BuscarDescripcion(textBoxCod1.Text);
            lblStockMov.Text = productos.BuscarStock(textBoxCod1.Text).ToString() + " Unidades";

            textBoxCod1.Text = "";
            textBoxDescrip2.Text = "";

            ///////////
            ///



        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (textBoxCod1.Text == "")
            {
                ErrorPCod.SetError(textBoxCod1, "Ingrese un codigo");
                return;
            }
            ErrorPCod.SetError(textBoxCod1, "");

            existe = productos.ExisteProducto(textBoxCod1.Text);

            if (long.TryParse(textBoxCod1.Text, out Verif) && existe)
            {
                ValorVerif = long.Parse(textBoxCod1.Text);
                productos.BorrarProducto(textBoxCod1.Text);

                dataGridView1.DataSource = productos.ListaDT;
                dataGridView1.ClearSelection();
                MessageBox.Show("Producto Borrado");

                lblDescripcionMov.Text = productos.BuscarDescripcion(TBoxCod2.Text);
                lblStockMov.Text = productos.BuscarStock(TBoxCod2.Text).ToString() + " Unidades";
                textBoxCod1.Text = "";
                textBoxDescrip2.Text = "";

            }
            else
            {
                MessageBox.Show("El codigo no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            if (textBoxCod1.Text == "")
            {
                ErrorPCod.SetError(textBoxCod1, "Ingrese un codigo");
                return;
            }
            ErrorPCod.SetError(textBoxCod1, "");


            existe = productos.ExisteProducto(textBoxCod1.Text);
            index = productos.BuscarProducto(textBoxCod1.Text);

            if (long.TryParse(textBoxCod1.Text, out Verif) && existe)
            {
                ValorVerif = long.Parse(textBoxCod1.Text);
                dataGridView1.Rows[index].Selected = true;
            }
            else
            {
                MessageBox.Show("El codigo no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void Cargar_Click(object sender, EventArgs e)
        {

            dataGridView1.ClearSelection();

        }






        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            existe = productos.ExisteProducto(textBoxCod1.Text);
            if (!existe)
            {
                MessageBox.Show("Ingrese un codigo valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxCant2.Text == "")
            {
                MessageBox.Show("Ingrese una cantidad valida", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RIngreso.Checked)
            {
                productos.IngresoStock(textBoxCant2.Text, textBoxCod1.Text, producto);
                MessageBox.Show("Stock Actualizado");
            }

            if (RSalida.Checked)
            {
                productos.SalidaStock(textBoxCant2.Text, textBoxCod1.Text, producto);
                MessageBox.Show("Stock Actualizado");
            }

            lblDescripcionMov.Text = productos.BuscarDescripcion(textBoxCod1.Text);
            lblStockMov.Text = productos.BuscarStock(textBoxCod1.Text).ToString() + " Unidades";

            textBoxCod1.Text = "";
            textBoxCant2.Text = "";

            dataGridView1.DataSource = productos.ListaDT;
            dataGridView1.ClearSelection();

        }

    }
    }


            
            
            
            



        
    

        
       
