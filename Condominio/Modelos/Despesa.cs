using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Modelos
{
    public class Despesa
    {
        public int IdDespesa { get; set; }
        public DateTime DataDespesa { get; set; }
        public string DescricaoDespesa { get; set; }
        public double ValorDespesa { get; set; }
        public bool DespesaValida { get; set; }
        public int ParcelaDespesa { get; set; }
        public int TotalParcelas { get; set; }
        public int MesDespesa { get; set; }
        public int AnoDespesa { get; set; }
        public DateTime DataPagamentoDespesa { get; set; }

        public Despesa(int idDespesa, DateTime dataDespesa, string descricaoDespesa, double valorDespesa, 
            int parcelaDespesa, int totalParcelas, int mesDespesa, int anoDespesa)
        {
            IdDespesa = idDespesa;
            DataDespesa = dataDespesa;
            DescricaoDespesa = descricaoDespesa;
            ValorDespesa = valorDespesa;
            ParcelaDespesa = parcelaDespesa;
            TotalParcelas = totalParcelas;
            MesDespesa = mesDespesa;
            AnoDespesa = anoDespesa;
            DespesaValida = true;
        }

        public Despesa(DateTime dataDespesa, string descricaoDespesa, double valorDespesa,
            int parcelaDespesa, int totalParcelas, int mesDespesa, int anoDespesa)
        {
            DataDespesa = dataDespesa;
            DescricaoDespesa = descricaoDespesa;
            ValorDespesa = valorDespesa;
            DespesaValida = true;
            ParcelaDespesa = parcelaDespesa;
            TotalParcelas = totalParcelas;
            MesDespesa = mesDespesa;
            AnoDespesa = anoDespesa;
        }
    }
}
