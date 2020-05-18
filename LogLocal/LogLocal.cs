using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogLocal
{
    public class LogLocal: ILogear
    {
        private const string DIRECCIONLOCAL =@"C:\LogsFbot\";
        private const string CODIGOLOG = "LOG";
        private string _ficheroLog;


        public LogLocal(string nombreSeccion, string nombre) //todo: crear 2 campos, para distinguirlo en una carpeta.
        {
            CrearFicheroLog(nombreSeccion, nombre);
        }
         

        /// <summary>
        /// Comprobamos que la dirección donde tiene que escribir existe
        /// </summary>
        private string  CrearDireccionLocal(string nombreCarpeta)
        {
            string direccionLocal = $"{ DIRECCIONLOCAL}/{nombreCarpeta}/";
            if (!Directory.Exists(direccionLocal))
            {
                _ = Directory.CreateDirectory(direccionLocal);
            }
            return direccionLocal;
        }

        private string CrearFicheroLocal(string direccionLocal, string nombre)
        {
            var nombreFichero = $"{CODIGOLOG}·{nombre}·{DateTime.Now.ToShortDateString()}·{DateTime.Now.ToShortTimeString()}.log"
    .Replace("/", "").Replace(":", "");
            var direccionFichero = $"{direccionLocal }{nombreFichero}";
            if (!File.Exists(direccionFichero)) File.Create(direccionFichero);
            return direccionFichero;
        }
        private void CrearFicheroLog(string nombreSeccion, string nombre)
        {
            var direccionLocal = CrearDireccionLocal(nombreSeccion);
            _ficheroLog = CrearFicheroLocal(direccionLocal, nombre);
        }


        public void Grabar(string titulo, string subtitulo)
        {
            if (string.IsNullOrWhiteSpace(_ficheroLog)) return;
            try
            {
                using (StreamWriter file =
           new StreamWriter(_ficheroLog, true))
                {
                    file.WriteLine($"[{DateTime.Now.ToLocalTime()}]>{titulo.ToUpper()}:{subtitulo}"); ;
                }
            }
            catch (Exception)
            {
                //todo: ver que hacemos con las excepciones, pero no tienen que ser bloqueantes                
            }
        }
    }

     interface ILogear
    {
        void Grabar(string titulo, string subtitulo);
    }
}
