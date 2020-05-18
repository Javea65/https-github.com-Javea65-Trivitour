namespace Fbot.Model.Core
{
    public struct Dcc
    {
        public Dcc(string ip, int port)
        {

            this.Puerto = port;
        }
        public int Puerto { get; private set; }


        //private void Validar()
        //{
        //    if (value<= 0 || value> 5000) 
        //}

    }
}
