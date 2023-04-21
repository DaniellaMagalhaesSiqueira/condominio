using Condominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace Condominio.DAO
{
    public class ReceitaService : DAO
    {
        private static string Tabela = "receita";
        private static string Colunas = "valor_receita, data_receita, descricao_receita, debito_gerador";
        private static string Valores = "@valor, @data, @desc, @debito";
        private static string Atributos = "@id = id_receita, @valor = valor_receita, " +
            "@data = data_receita, @desc = descricao_receita, @debito = debito_gerador";
        private static string[] Array = { "int", "double", "date", "string", "int" };

        public ReceitaService() : base(Tabela, Colunas, Valores, Atributos, Array)
        {

        }

        public static int Inserir(Receita receita)
        {
            string sql = $"INSERT INTO {Tabela} ({Colunas}) VALUES ({Valores});";
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@valor", Convert.ToDouble(receita.ValorReceita));
                    cmd.Parameters.AddWithValue("@data", receita.DataReceita.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@desc", receita.DescricaoReceita);
                    cmd.Parameters.AddWithValue("@debito", receita.DebitoGerador);
                    cmd.ExecuteNonQuery();

                    return Int32.Parse(cmd.Connection.LastInsertRowId.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        public static List<Receita> Listar(DateTime dataInicio, DateTime dataFim)
        {
            List<Receita> lista = new List<Receita>();
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM receita WHERE " +
                        $"data_receita >= '{dataInicio.ToString("yyyy-MM-dd")}'" +
                        $" AND data_receita <= '{dataFim.ToString("yyy-MM-dd")}';";
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return lista;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var receita = new Receita(
                            Int32.Parse(dt.Rows[i]["id_receita"].ToString()),
                            (double)dt.Rows[i]["valor_receita"],
                            (DateTime)dt.Rows[i]["data_receita"],
                            dt.Rows[i]["descricao_receita"].ToString(),
                            Int32.Parse(dt.Rows[i]["debito_gerador"].ToString())
                            );

                        lista.Add(receita);
                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public static double TotalPorPeriodo(DateTime dtInicial, DateTime dtFinal)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT SUM(valor_receita) as soma FROM receita " +
                        $"WHERE data_receita >= '{dtInicial.ToString("yyyy-MM-dd")}' AND data_receita <= '{dtFinal.ToString("yyyy-MM-dd")}';";
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return 0.00;
                    }

                    var soma = (double)dt.Rows[0]["soma"];

                    return soma;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        public static int SaldoTotalGeral(out double total)
        {
            
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();
            var con = DBConnection();
            double total_receitas = 0;
            double total_despesas = 0;
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT "+
                        "(SELECT SUM(valor_receita) FROM receita) AS total_receitas," +
                        "(SELECT SUM(valor_despesa) FROM despesa where despesa_valida = 0) AS total_despesas, " + 
                        "(SELECT SUM(valor_receita) FROM receita) - (SELECT SUM(valor_despesa) FROM despesa) AS saldo; ";
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        
                        total = (double)dt.Rows[0]["saldo"];
                        total_despesas = (double)dt.Rows[0]["total_despesas"];
                        total_receitas = (double)dt.Rows[0]["total_receitas"];
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                total = 0.0;
                return -1;
            }
            finally
            {
                con.Close();
            }
            total = 0.0;
            return 0;
        }
    }
}
