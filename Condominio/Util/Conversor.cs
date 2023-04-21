using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Condominio.Util
{
    public class Conversor
    {
        public static double ConverteStringParaDouble(string valor)
        {
            double valorConvertido = 0.00;
            if (valor != "")
            {

                short digito = 0;
                string str = "";
                foreach (var c in valor)
                {
                    if (Int16.TryParse(c.ToString(), out digito))
                    {
                        str += digito + "";
                    }
                    else
                    {
                        if (c.ToString().Equals(",") || c.ToString().Equals("."))
                        {
                            str += ",";
                        }
                    }
                }
                try
                {
                    valorConvertido = double.Parse(str);
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }

            return valorConvertido;
        }

        public static void ApenasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static double ConverteValorDebito(string valor)
        {
            double valorConvertido = 0.00;
            if (valor != null || valor != "")
            {

                short digito = 0;
                string str = "";
                foreach (var c in valor)
                {
                    if (Int16.TryParse(c.ToString(), out digito))
                    {
                        str += digito + "";
                    }
                    else
                    {
                        if (c.ToString().Equals(",") || c.ToString().Equals("."))
                        {
                            str += ",";
                        }
                    }
                }


                valorConvertido = double.Parse(str);
            }

            return valorConvertido;
        }

        public static string ConverteDoubleParaString(double valor)
        {
            string str = valor + "";
            if (!str.Contains(",") && !str.Contains("."))
            {
                str += ",00";
            }
            return str;
        }

        public static double ValorMonetario(TextBox valor, KeyPressEventArgs e)
        {
            double valorConvertido = 0.00;
            valor.SelectionStart = valor.Text.Length + 1;


            return valorConvertido;
        }

        public static string DescricaoDebitoParaRecibo(string valor)
        {
            string valorConvertido = "";
            if (valor.Contains("(R$"))
            {
                foreach (var letra in valor)
                {
                    if (letra.ToString().Equals("("))
                    {
                        return valorConvertido;
                    }
                    valorConvertido += letra.ToString();
                }
                return valorConvertido;
            }
            return valor;
        }

        public static string DescReceita(string descricao)
        {
            Debug.WriteLine(descricao);
            string desc = "";
            if(descricao.Contains("PARCELAS DE CONDOMÍNIO"))
            {
                try
                {
                    //string[] descTotal = descricao.Split("_");
                    //string[] resto = descTotal[1].Split(" - ");
                    //string ano = resto[1];
                    //string mes = resto[2].Split(" ")[0];
                    //string valor = resto[2].Split(" ")[1] + resto[2].Split(" ")[2];
 

                    desc = descricao.Replace("_PARCELAS DE CONDOMÍNIO -", "(COND.)");
                    //Debug.WriteLine("Descrição: " + desc);
                    //desc = "Condomínio:" + desc.Split("_")[0] + "-";
                    //desc += mes + "/" + ano + valor;
                    
                    return desc.Substring(0, desc.Length - 1);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return descricao;
                }
            }
            else if(descricao.Contains("DESPESA ESPECÍFICA"))
            {
                desc = descricao.Replace("_DESPESA ESPECÍFICA - ", "(OUTRAS)");
                return desc;
            }
            else
            {
                return descricao;
            }
        }
    }
}
