using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Modelos
{
    public class Debito
    {
        public int IdDebito { get; set; }
        public Condomino Condomino { get; set; }
        public string DescricaoDebito { get; set; }
        public double ValorDebito { get; set; }
        public int MesDebito { get; set; }
        public int AnoDebito { get; set; }
        public DateTime DataCriacao { get; set; }
        public Debito() { }

        public Debito(Condomino condomino, string descricaoDebito, double valorDebito, 
            int mesDebito, int anoDebito, DateTime dataCriacao)
        {
            Condomino = condomino;
            DescricaoDebito = descricaoDebito;
            ValorDebito = valorDebito;
            MesDebito = mesDebito;
            AnoDebito = anoDebito;
            DataCriacao = dataCriacao;
        }

        public Debito(int idDebito, Condomino condomino, string descricaoDebito, double valorDebito, 
            int mesDebito, int anoDebito, DateTime dataCriacao)
        {
            IdDebito = idDebito;
            Condomino = condomino;
            DescricaoDebito = descricaoDebito;
            ValorDebito = valorDebito;
            MesDebito = mesDebito;
            AnoDebito = anoDebito;
            DataCriacao = dataCriacao;
        }
    }
}
