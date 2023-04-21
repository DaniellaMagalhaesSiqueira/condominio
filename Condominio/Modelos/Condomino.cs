using Condominio.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Modelos
{
    public class Condomino
    {
        public int IdCondomino { get; set; }
        public string Casa { get; set; }
        public string NomeRepresentante { get; set; }
        public string Telefone { get; set; }
        public string Proprietario { get; set; }
        public string Veiculos { get; set; }
        public string EmailCondomino { get; set; }
        public double DebitoAnterior { get; set; }

        public double DebitoAtual;
        public List<Recibo> Recibos { get; set; }
        public List<Debito> Debitos { get; set; }

        public Condomino(int idCondomino, string casa, string nomeRepresentante, 
            string telefone, string proprietario, string veiculos, 
            string emailCondomino, double debitoAnterior)
        {
            IdCondomino = idCondomino;
            Casa = casa;
            NomeRepresentante = nomeRepresentante;
            Telefone = telefone;
            Proprietario = proprietario;
            Veiculos = veiculos;
            EmailCondomino = emailCondomino;
            DebitoAnterior = debitoAnterior;
        }

        public Condomino() { }

        public string PrimeiroNome()
        {
            return NomeRepresentante.Split(" ")[0];
        }
       
        public double GetDebitoAtual()
        {
            List<Debito> lista = CondominoService.ObterListaDebitos(this);
            double valor = 0.00;
            if(lista.Count > 0)
            {
                foreach (var d in lista)
                {
                    valor += d.ValorDebito;
                }
            }
            return valor;
        }
    }
}
