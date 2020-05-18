namespace Fbot.Controles
{
    using System.Windows.Forms;

    public class TabPagePrincipal : TabPage
    {
        private readonly string NombrePanel = "Fbot 2019";
        public TabPagePrincipal()
        {
            Configuracion();
        }

        private void Configuracion()
        {
            this.BackColor = System.Drawing.Color.Coral;
            this.Text = NombrePanel;
            this.ResumeLayout();

        }
    }
}
