using System;
using TVG.DOMINIO.MODEL.TipoDatos;
namespace TVG.DOMINIO.MODEL
{
    public class JugadorBase
    {
        private Guid Id { get; set; }
        public Nick Nick { get; private set; }

        protected internal JugadorBase(string nombre)
        {
            Nick = new Nick(nombre);
            Id = Guid.NewGuid();
        }
    }
}
