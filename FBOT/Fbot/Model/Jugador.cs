using Fbot.Model.Core;
using IceChatPlugin;

namespace Fbot.Model
{
    public class Jugador: IJugador
    {
        public string Codigo { get; private set; }
        public string Host { get; private set; }
        public string Nick { get; private set; }

        public DatosIrc Datos { get; private set; }
        public Jugador (PluginArgs d, string codigo)
        {
            Codigo = codigo;
            Nick = d.Nick;
            Host = d.Host;
            Datos = ObtenerDatosIrc(d);
        }

        private DatosIrc ObtenerDatosIrc(PluginArgs d)
        {
            return new DatosIrc()
            {
                Message = d.Message,
                Canal = d.Channel,
                Command = d.Command,
                DccIP = d.dccIP,
                DccPort = int.TryParse(d.dccPort, out int valor) ? valor : 0,
                Extra = d.Extra
            };
        }

        public string Ejecutar(PluginArgs d)
        {
            var resultado = "Sin datos";
            Datos = ObtenerDatosIrc(d);
            //todo: Implementar resto de funcionalidad.
            return resultado;
        }

        #region Statics
        private string ObtenerClave(PluginArgs args)
        {
            return $"{args.Host}-{args.Nick}";
        }
        #endregion
    }

    public interface IJugador
    {
        string  Ejecutar(PluginArgs d);

    }   

}



