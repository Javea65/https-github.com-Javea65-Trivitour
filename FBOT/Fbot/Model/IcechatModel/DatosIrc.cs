using IceChatPlugin;

namespace Fbot.Model.Core
{
    /// <summary>
    /// Clase que obtiene los datos de jugador
    /// </summary>
    public class DatosIrc
    {
        public string Message { get;  set; }
        public string Command { get;  set; }
        public string DccIP { get;  set; }
        public int DccPort { get;  set; }
        public string Extra { get;  set; }
        public string Canal { get;  set; }
        public string Host { get;  set; }
        public string Nick { get;  set; }

      

    }
}
