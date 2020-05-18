namespace Fbot.Model.Core
{
    using System.Text.RegularExpressions;

    public struct InternetIP
    {
        public InternetIP(string ip)
        {
            this.Ip = ip ?? string.Empty;
            //if (ip != null)
            //{
            //    var resultado = Validate(ip);

            //    this.Ip = resultado.ToString();
            //}
        }

        private MatchCollection Validate(string ip)
        {
            Regex ipRex = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            //MatchCollection result = ipRex.Matches(ip);
            return ipRex.Matches(ip);
        }
        public string Ip { get; private set; }
    }
}
