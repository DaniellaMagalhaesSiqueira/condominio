using Condominio.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Condominio.Util
{
    public static class CaminhoArquivo
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
            Environment.OSVersion.Platform == PlatformID.MacOSX) ?
            //Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            Environment.GetEnvironmentVariable("HOME") :
            Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Documents\\");
            string folderPath = Path.Combine(home, "RECIBOS_CONDOMINIO");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            return path.Replace("~", folderPath);


            // Environment.OSVersion.Platform == PlatformID.Win32NT
        }
        public static string Nome(Recibo recibo)
        {
            string dt = $"{recibo.DataPagamento.Day}{recibo.DataPagamento.Month}"
                    + $"{recibo.DataPagamento.Year}";
            string nome = @"~\recibo" + recibo.IdRecibo + "casa" + recibo.Condomino.Casa
                +recibo.Condomino.PrimeiroNome()+"_"+dt+".pdf";
            string arquivo = nome.ParseHome(); ;
            
            return arquivo;
        }
    }
}
