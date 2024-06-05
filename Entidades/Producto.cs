using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        Productos productos = new Productos();

        #region Atributos
        private int codigo;
        private string descripcion;
        private int stock;
        
        #region Propiedades
        public int p_codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string p_descripciom
        {
            set { descripcion = value; }
            get { return descripcion; }

        }
        public int p_stock
        {
            get { return stock; }

        }

        #endregion

        #region Constructores
        public Producto()
        {

        }
        public Producto(int cod, string desc)
        {
            codigo = cod;
            descripcion = desc;
            stock = 0;
        }

        #endregion



        #region Metodos
        //public void Ingreso (int cant)
        //{
          //  stock = stock + cant;

        //}

        //public void Salida(int cant)
        //{
          //  stock = stock - cant;
        //}
        #endregion
    }
    #endregion
}