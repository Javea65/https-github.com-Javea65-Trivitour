namespace Fbot.Controles
{
    using System.Windows.Forms;
    public class PanelLateral : Panel
    {
        public PanelLateral()
        {
            this.Name = "Panel Datos";
            Configuracion();
        }
        private void Configuracion()
        {
            ConfigurarMedidas();
        }
        private void ConfigurarMedidas()
        {
            this.Height = 150;
            this.Dock = DockStyle.Bottom;
        }
    }
}
