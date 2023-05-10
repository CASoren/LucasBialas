using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas_Bialas
{
    internal class productoVendido
    {
        //Atributos
        private int id;
        private int idProducto;
        private int stock;
        private int idVenta;


        public productoVendido(int pId,
                                int pIdProducto,
                                int pStock,
                                int pIdVenta)
        {
            this.id = pId;
            this.idProducto = pIdProducto;
            this.stock = pStock;
            this.idVenta = pIdVenta;

        }
        public int GetId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int GetIdProducto() 
        {
            return this.idProducto;
        }

        public void SetIdProducto(int idProducto)
        {
            this.idProducto = idProducto;
        }

        public int GetStock()
        {
            return this.stock;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
        }

        public int GetidVenta()
        {
            return this.idVenta;
        }

        public void SetidVenta(int idVenta)
        {
            this.idVenta = idVenta;
        }
        
    }
}

