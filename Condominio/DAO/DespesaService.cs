using Condominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace Condominio.DAO
{
    public class DespesaService : DAO
    {
        private static string Colunas = "data_despesa, descricao_despesa, valor_despesa, parcela_despesa, total_parcelas, mes_despesa, ano_despesa, despesa_valida";
        private static string Valores = "@data, @descricao, @valor, @parcela, @total, @mes, @ano, @valida";
        public static List<Despesa> Listar()
        {
            List<Despesa> lista = new List<Despesa>();
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM despesa WHERE despesa_valida = 1;";
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return lista;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var despesa = new Despesa(
                            Int32.Parse(dt.Rows[i]["id_despesa"].ToString()),
                            (DateTime)dt.Rows[i]["data_despesa"],
                            dt.Rows[i]["descricao_despesa"].ToString(),
                            (double)dt.Rows[i]["valor_despesa"],
                            Int32.Parse(dt.Rows[i]["parcela_despesa"].ToString()),
                            Int32.Parse(dt.Rows[i]["total_parcelas"].ToString()),
                            Int32.Parse(dt.Rows[i]["mes_despesa"].ToString()),
                            Int32.Parse(dt.Rows[i]["ano_despesa"].ToString())
                            );

                        lista.Add(despesa);
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

        public static List<Despesa> ListarPorMes(int mes)
        {
            var despesas = Listar();
            var result = new List<Despesa>();

            foreach(Despesa dp in despesas)
            {
                if(dp.MesDespesa == mes && dp.AnoDespesa == DateTime.Now.Year)
                {
                    result.Add(dp);
                }
            }

            return result;
        }
        public static List<Despesa> Listar(DateTime dataInicio, DateTime dataFim)
        {
            List<Despesa> lista = new List<Despesa>();
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM despesa WHERE despesa_valida = 1" +
                        $" AND (data_despesa) BETWEEN '{dataInicio.ToString("yyyy-MM-dd")}' AND '{dataFim.ToString("yyyy-MM-dd")}';";
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return lista;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var despesa = new Despesa(
                            Int32.Parse(dt.Rows[i]["id_despesa"].ToString()),
                            (DateTime)dt.Rows[i]["data_despesa"],
                            dt.Rows[i]["descricao_despesa"].ToString(),
                            (double)dt.Rows[i]["valor_despesa"],
                            Int32.Parse(dt.Rows[i]["parcela_despesa"].ToString()),
                            Int32.Parse(dt.Rows[i]["total_parcelas"].ToString()),
                            Int32.Parse(dt.Rows[i]["mes_despesa"].ToString()),
                            Int32.Parse(dt.Rows[i]["ano_despesa"].ToString())
                            );

                        lista.Add(despesa);
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
         public static List<Despesa> ListarPagas(DateTime dataInicio, DateTime dataFim)
        {
            List<Despesa> lista = new List<Despesa>();
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM despesa WHERE despesa_valida = 0" +
                        $" AND (data_pagamento_despesa) BETWEEN '{dataInicio.ToString("yyyy-MM-dd")}' AND '{dataFim.ToString("yyyy-MM-dd")}';";
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return lista;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var despesa = new Despesa(
                            Int32.Parse(dt.Rows[i]["id_despesa"].ToString()),
                            (DateTime)dt.Rows[i]["data_despesa"],
                            dt.Rows[i]["descricao_despesa"].ToString(),
                            (double)dt.Rows[i]["valor_despesa"],
                            Int32.Parse(dt.Rows[i]["parcela_despesa"].ToString()),
                            Int32.Parse(dt.Rows[i]["total_parcelas"].ToString()),
                            Int32.Parse(dt.Rows[i]["mes_despesa"].ToString()),
                            Int32.Parse(dt.Rows[i]["ano_despesa"].ToString())
                            );

                        lista.Add(despesa);
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

        public static int Inserir(Despesa despesa)
        {
            string sql = $"INSERT INTO despesa ({Colunas}) VALUES ({Valores});";

            var con = DBConnection();

            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {

                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", despesa.DataDespesa.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@descricao", despesa.DescricaoDespesa);
                    cmd.Parameters.AddWithValue("@valor", despesa.ValorDespesa);
                    cmd.Parameters.AddWithValue("@parcela", despesa.ParcelaDespesa);
                    cmd.Parameters.AddWithValue("@total", despesa.TotalParcelas);
                    cmd.Parameters.AddWithValue("@mes", despesa.MesDespesa);
                    cmd.Parameters.AddWithValue("@ano", despesa.AnoDespesa);
                    cmd.Parameters.AddWithValue("@valida", despesa.DespesaValida);
                    cmd.ExecuteNonQuery();
                    return 1;
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

        public static double TotalPorPeriodo(DateTime dtInicial, DateTime dtFinal)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT SUM(valor_despesa) as soma FROM despesa WHERE despesa_valida = 1" +
                        $" AND data_inicio >= '{dtInicial.ToString("yyyy-MM-dd")}' AND data_fim <= '{dtFinal.ToString("yyyy-MM-dd")}';";
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

        public static Despesa Obter(int id)
        {
            string sql = $"SELECT * FROM despesa WHERE id_despesa = {id};";

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    Despesa desp = null;
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return null;
                    }

                    desp = new Despesa(
                        Int32.Parse(dt.Rows[0]["id_despesa"].ToString()),
                        (DateTime) dt.Rows[0]["data_despesa"],
                        dt.Rows[0]["descricao_despesa"].ToString(),
                        (double) dt.Rows[0]["valor_despesa"],
                        Int32.Parse(dt.Rows[0]["parcela_despesa"].ToString()),
                        Int32.Parse(dt.Rows[0]["total_parcelas"].ToString()),
                        Int32.Parse(dt.Rows[0]["mes_despesa"].ToString()),
                        Int32.Parse(dt.Rows[0]["ano_despesa"].ToString())
                        );
                    desp.DespesaValida = (bool)dt.Rows[0]["despesa_valida"];

                    return desp;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public static int Excluir(int id, DateTime data)
        {
            //new DateTime(data.Year, data.Month, 1)
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                  
                    Despesa desp = null;
                    cmd.CommandText = "UPDATE despesa SET despesa_valida = 0, " +
                        $"data_pagamento_despesa = '{data.ToString("yyyy-MM-dd")}' WHERE id_despesa = " + id + " ;";
                    cmd.ExecuteNonQuery();
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
