using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas_Bialas
{
    internal class Producto
    {
        //atributos
        private int id;
        private string descripcion;
        private decimal costo;
        private decimal precioVenta;
        private int stock;
        private short idUsuario;


        //constructor
        public Producto (int pid,
                       string pdescripcion,
                       decimal pcosto,
                       decimal pprecioVenta,
                       int pstock,
                       short pidUsuario)
        {
            this.id = pid;
            this.descripcion = pdescripcion;
            this.costo = pcosto;
            this.precioVenta = pprecioVenta;
            this.stock = pstock;
            this.idUsuario = pidUsuario;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public decimal PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public short IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }


    }
}
