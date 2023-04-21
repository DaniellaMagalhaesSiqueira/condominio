using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Modelos
{
    public class Recibo
    {

        public int IdRecibo { get; set; }
        public DateTime DataPagamento { get; set; }
        public double ValorPagamento { get; set; }
        public Condomino Condomino { get; set; }
        public string DescricaoRecibo { get; set; }
        public Recibo() { }

        public Recibo(DateTime dataPagamento, double valorPagamento, Condomino condomino, string descricao)
        {
            DataPagamento = dataPagamento;
            ValorPagamento = valorPagamento;
            this.Condomino = condomino;
            DescricaoRecibo = descricao;
        }

        public Recibo(int idRecibo, DateTime dataPagamento, double valorPagamento, 
            Condomino condomino, string descricao)
        {
            IdRecibo = idRecibo;
            DataPagamento = dataPagamento;
            ValorPagamento = valorPagamento;
            this.Condomino = condomino;
            DescricaoRecibo = descricao;
        }
    }
}
