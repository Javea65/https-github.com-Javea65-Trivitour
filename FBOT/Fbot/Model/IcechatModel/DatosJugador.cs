using IceChatPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbot.Model.IcechatModel
{
    public class DatosJugador
    {
        public string Host { get; private set; }
        public string Nick { get; private set; }

        public static DatosJugador Create(PluginArgs d) => new DatosJugador()
        {
            Host = d.Host,
            Nick = d.Nick
        };
    }
}
