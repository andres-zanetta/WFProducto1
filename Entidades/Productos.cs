using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Entidades
{
    public class Productos
    {
        //creamos lista
        public DataTable ListaDT {get;set;} = new DataTable();

        //creamos estructura para la lisa alumnos

        public Productos()
        {
            ListaDT.TableName = "ListaDeProductos";
            ListaDT.Columns.Add("Codigo");
            ListaDT.Columns.Add("Descripcion");
            ListaDT.Columns.Add("Stock");

            LeerArchivo();
        }
       
        // Lee el archivo Alumno.xml y si este exsite

        public void LeerArchivo()
        {
            if (System.IO.File.Exists ("Productos.xml"))
            {
                ListaDT.ReadXml("Productos.xml");
            }

        }
        //Inserta un nuevo alumno en la lista de alumnos y y escribe la lista en el xml

        public void InsertoProducto(Producto aProducto)
        {
            ListaDT.Rows.Add();
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Codigo"] = aProducto.p_codigo;
            ListaDT.Rows[NuevoRenglon]["Descripcion"] = aProducto.p_descripciom;
            ListaDT.Rows[NuevoRenglon]["Stock"] = aProducto.p_stock;


            ListaDT.WriteXml("Productos.xml");
        }

       //Ingresa el producto
        public void IngresoStock(string txtCant, string txtId, Producto aProducto)
        {
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Codigo"].ToString()))
                {
                    row["Stock"] = Convert.ToInt32(row["Stock"]) + Convert.ToInt32(txtCant);
                    ListaDT.WriteXml("Productos.xml");
                }
            }
            ListaDT.AcceptChanges();
            return;
        }

       //sale el producto
        public void SalidaStock(string txtCant, string txtId, Producto aProducto)
        {
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Codigo"].ToString()))
                {
                    row["Stock"] = Convert.ToInt32(row["Stock"]) - Convert.ToInt32(txtCant);
                    ListaDT.WriteXml("Productos.xml");
                }
            }
            ListaDT.AcceptChanges();
            return;
        }

        //borro el producto
        public bool BorrarProducto(string txtId)
        {
            bool existe = false;
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {

                if (txtId == (row["Codigo"].ToString()))
                {
                    row.Delete();
                    ListaDT.WriteXml("Productos.xml");
                    existe = true;
                }
            }
            ListaDT.AcceptChanges();
            return existe;
        }

        //Existe?
        public bool ExisteProducto(string txtId)
        {
            bool existe = false;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Codigo"].ToString()))
                {
                    existe = true;
                }
            }
            return existe;

        }

        //busco

        public int BuscarProducto(string txtId)
        {
            int index = 0;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Codigo"].ToString()))
                {
                    index = ListaDT.Rows.IndexOf(row);

                }
            }
            return index;

        }

        //busco Desc
        public string BuscarDescripcion(string txtCod)
        {
            string DescripcionEncontrada = null;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtCod == (row["Codigo"].ToString()))
                {
                    DescripcionEncontrada = (row["Descripcion"].ToString());

                }
            }
            return DescripcionEncontrada;

        }

        //Bsuco Stock
        public int BuscarStock(string txtCod)
        {
            int StockEncontrado = 0;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtCod == (row["Codigo"].ToString()))
                {
                    StockEncontrado = Convert.ToInt32(row["Stock"]);

                }
            }
            return StockEncontrado;

        }

        private int NuevoId()
        {
            int NuevoId = 0;

            foreach (DataRow fila in ListaDT.Rows)
            {
                if (NuevoId < Convert.ToInt32(fila["Id"]))
                {
                    NuevoId = Convert.ToInt32(fila["Id"]);
                }
            }

            NuevoId++;
            return NuevoId;
        }

    }

}
