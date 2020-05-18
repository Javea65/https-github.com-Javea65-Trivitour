using IceChatPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fbot.Model.Core
{
    public struct  CodigoJugador
    {
        public readonly string _codigo;
        public CodigoJugador(PluginArgs args)
        {
            _codigo = $"{args.Host.ToUpper()}-{args.Nick.ToUpper()}";
        }
        public   string Get() => _codigo;
    }
}
