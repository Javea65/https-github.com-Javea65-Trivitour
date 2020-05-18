namespace IceChatPlugin
{
    using Fbot;
    using Fbot.Model;
    using Fbot.Model.Core;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class Plugin : IPluginIceChat
    {
        private IDictionary<string, Jugador> _listaJugadores = new Dictionary<string, Jugador>();
        private readonly string m_version_Hora = "1903";
        private readonly string m_version_Dia = "24";
        private readonly string m_version_Mes = "04";
        private readonly string m_version_Año = "20";

        #region Inicio

        //all the events get declared here
        public override event OutGoingCommandHandler OnCommand;

        //declare the standard properties
        private readonly string m_Name;
        private readonly string m_Author;
        private readonly string m_Version;

        public override string Name { get { return m_Name; } }
        public override string Version { get { return m_Version; } }
        public override string Author { get { return m_Author; } }

        public Plugin()
        {
            //set your default values here
            m_Name = "Fbot 2020";
            m_Author = "Javea65";
            m_Version = string.Format("1.{0}.{1}.{2}.{3}", m_version_Año, m_version_Mes, m_version_Dia, m_version_Hora);
        }
        //declare the standard methods
        public override void Dispose()
        {

        }

        public override void Initialize()
        {
            CargandoPaneles(this.LeftPanel);
        }

        //if you want to add a new method to override, use public override

        #endregion
        #region Control

        //private TabPage JbotListTab;
        private Panel JbotPanel;
        private void CargandoPaneles(TabControl ElPanel)
        {

            //ucPanel Bot = new ucPanel(this.Version);

            TabPage JbotListTab = new Fbot.Controles.TabPagePrincipal();// new TabPage("Jbot");

            this.JbotPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            // this.JbotPanel.Controls.Add(PANEL);
            JbotListTab.Controls.Add(this.JbotPanel);
            ElPanel.TabPages.Add(JbotListTab);
            //this.JbotPanel.Width = PANEL.Width + 2;
            //this.JbotPanel.Height = PANEL.Height + 2;
            JbotListTab.Height = this.JbotPanel.Height;
            JbotListTab.Width = this.JbotPanel.Width;
            ElPanel.Width = JbotListTab.Width + 5;
            ElPanel.Height = JbotListTab.Height + 5;
            ElPanel.Dock = DockStyle.Fill;
        }


        #endregion

        #region Message
        public override PluginArgs ChannelMessage(PluginArgs args)
        {
            ComprobarMensaje(args, MensajeRecibidoEnum.Canal);
            return base.ChannelMessage(args);
        }
        #region Recibiendo Mensajes
        public override PluginArgs DCCChatMessage(PluginArgs args)
        {
            ComprobarMensaje(args, MensajeRecibidoEnum.Dcc);
            return base.DCCChatMessage(args);
        }
        public override PluginArgs QueryMessage(PluginArgs args)
        {
            ComprobarMensaje(args, MensajeRecibidoEnum.Query);
            return base.QueryMessage(args);
        }
        public override PluginArgs ServerMessage(PluginArgs args)
        {
            ComprobarMensaje(args, MensajeRecibidoEnum.Servidor);
            return base.ServerMessage(args);
        }
        public override PluginArgs CtcpMessage(PluginArgs args)
        {
            ComprobarMensaje(args, MensajeRecibidoEnum.Ctcp);
            return base.ServerMessage(args);
        }
        #endregion

        private void ComprobarMensaje(PluginArgs args, MensajeRecibidoEnum recibido)
        {            
            CrearJugador( args);        
        }

        protected internal  void CrearJugador(PluginArgs args)
        {
            var clave = new CodigoJugador(args).Get();
            if (_listaJugadores.ContainsKey(clave)) return;
            _listaJugadores.Add(clave, new Jugador(args,clave));
        }

        

 
        #endregion

    }
}