using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Modelos
{
    public class CondominioAlteracao
    {
        public int IdCondominio { get; set; }
        public DateTime DataAlteracao { get; set; }
        public double ValorAtual { get; set; }
        public double ValorAnterior { get; set; }
        public bool Valido { get; set; }
        public CondominioAlteracao(DateTime dataAlteracao,
            double valorAtual, double valorAnterior, bool valido)
        {
            DataAlteracao = dataAlteracao;
            ValorAtual = valorAtual;
            ValorAnterior = valorAnterior;
            Valido = valido;
        }

        public CondominioAlteracao(int idCondominio, DateTime dataAlteracao,
            double valorAtual, double valorAnterior, bool valido)
        {
            IdCondominio = idCondominio;
            DataAlteracao = dataAlteracao;
            ValorAtual = valorAtual;
            ValorAnterior = valorAnterior;
            Valido = valido;
        }
    }
}
