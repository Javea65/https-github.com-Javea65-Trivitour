using System;

namespace TVG.DOMINIO.MODEL.TipoDatos
{
    public class Nick
    {
        const int minimoExtension = 2;
        const int maximoExtension = 25;
        private string nick;

        private string GetNick()
        {
            return nick;
        }

        private void SetNick(string value)
        {
            nick = value;
        }

        public Nick(string nick)
        {
            if (string.IsNullOrWhiteSpace(nick))
                throw new InvalidCastException("El nick tiene que estar informado");
            SetNick(Validar(nick));
        }

        private string Validar(string nick)
        {
            var extensionNick = nick.Trim().Length;

            if (extensionNick < minimoExtension || extensionNick > maximoExtension)
                throw new InvalidCastException($"El nick tiene que tener entre {minimoExtension} a {maximoExtension} de carácteres.");
            return nick;
        }
        public override string ToString()
        {
            return GetNick();
        }
    }
}
