namespace Fbot.Model.Core
{
    public struct NickUsuario
    {
        public NickUsuario(string nick)
        {
            this.Nick = nick;
        }
        public string Nick { get; private set; }
    }
}
