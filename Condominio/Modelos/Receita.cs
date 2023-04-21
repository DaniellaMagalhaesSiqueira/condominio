using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Modelos
{
    public class Receita
    {
        public int IdReceita { get; set; }
        public double ValorReceita { get; set; }
        public DateTime DataReceita { get; set; }
        public string DescricaoReceita { get; set; }
        public int DebitoGerador { get; set; }

        public Receita() { }
        public Receita(double valorReceita, DateTime dataReceita, 
            string descricaoReceita, int debitoGerador)
        {
            ValorReceita = valorReceita;
            DataReceita = dataReceita;
            DescricaoReceita = descricaoReceita;
            DebitoGerador = debitoGerador;
        }

        public Receita(int idReceita, double valorReceita, DateTime dataReceita, 
            string descricaoReceita, int debitoGerador)
        {
            IdReceita = idReceita;
            ValorReceita = valorReceita;
            DataReceita = dataReceita;
            DescricaoReceita = descricaoReceita;
            DebitoGerador = debitoGerador;
        }
    }
}
