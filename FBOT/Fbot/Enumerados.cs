namespace Fbot
{
    /// <summary>
    ///  Vía por donde se recibe el mensaje del Irc
    /// </summary>
    public enum MensajeRecibidoEnum
    {
        Servidor,
        Canal,
        Query,
        Dcc,
        Ctcp
    }
}
