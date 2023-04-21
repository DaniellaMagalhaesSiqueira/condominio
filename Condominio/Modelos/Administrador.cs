using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Modelos
{
    public class Administrador
    {
        public int IdAdm { get; set; }
        public string NomeAdm { get; set; }
        public string EmailAdm { get; set; }
        public string SenhaAdm { get; set; }

        public Administrador(int idAdm, string nomeAdm, string emailAdm, string senhaAdm)
        {
            IdAdm = idAdm;
            NomeAdm = nomeAdm;
            EmailAdm = emailAdm;
            SenhaAdm = senhaAdm;
        }

        public Administrador() { }
    }
}
