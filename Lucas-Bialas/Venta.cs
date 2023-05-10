using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas_Bialas
{
    internal class Venta
    {
        //Atributos
        private int id;
        private string comentarios;
        private int idUsuario;


        public Venta(int pId,
                      string pComentario,
                      int pIdUsuario)
        {
            this.id = pId;
            this.comentarios = pComentario;
            this.idUsuario = pIdUsuario;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetComentarios()
        {
            return this.comentarios;
        }

        public void SetComentarios(string comentarios)
        {
            this.comentarios = comentarios;

        }

        public int GetidUsuario()
        {
            return this.idUsuario;
        }

        public void SetidUsuario(int idUsuario)
        {
            this.idUsuario= idUsuario;
        }
    }
}
