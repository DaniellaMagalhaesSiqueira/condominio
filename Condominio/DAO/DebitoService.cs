using Condominio.Modelos;
using Condominio.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Condominio.DAO
{
    public class DebitoService : DAO
    {
        private static string Colunas = " id_condomino, descricao_debito, valor_debito, mes_debito, ano_debito, data_criacao ";
        private static string Valores = "@cond, @desc, @valor, @mes, @ano, @data";
        private static string ValoresAtribuidos = " id_condomino = @cond, descricao_debito = @desc," +
            " valor_debito = @valor, mes_debito = @mes, ano_debito = @ano data_criacao = @data";
        public static int Inserir(Debito debito)
        {
            string sql = $"INSERT INTO debito ({Colunas}) VALUES ({Valores});";
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@cond", debito.Condomino.IdCondomino);
                    cmd.Parameters.AddWithValue("@desc", debito.DescricaoDebito);
                    cmd.Parameters.AddWithValue("@valor", debito.ValorDebito);
                    cmd.Parameters.AddWithValue("@mes", debito.MesDebito);
                    cmd.Parameters.AddWithValue("@ano", debito.AnoDebito);
                    cmd.Parameters.AddWithValue("@data", debito.DataCriacao.ToString("yyyy-MM-dd"));
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

        public static int LancarDebitos(int mes, int ano)
        {
            var condominio = CondominioAlteracaoService.ObterValido();
            string desc = $"{ano} - {(Meses)mes} (R$ {condominio.ValorAtual})";
            if (DebitoExistente(desc))
            {
                return 2;
            }
            List<Condomino> condominos = CondominoService.Listar();
            var data = DateTime.Now;
            var debito = new Debito();
            foreach (Condomino cond in condominos)
            {

                debito = new Debito(
                    cond, desc, condominio.ValorAtual, mes, ano, data
                 );
                try
                {
                    int idDebito = Inserir(debito);
                    debito.IdDebito = idDebito;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
            }
            InserirDebitoLancado(debito);
            return 1;
        }



        public static int Apagar(int id)
        {
            string sql = "DELETE FROM debito WHERE id_debito = @id;";
            var con = DBConnection();
            try
            {
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        public static int RevogarDebito()
        {
            //string sql = "DELETE FROM debito WHERE data_criacao = (SELECT data_criacao FROM debito WHERE data_criacao = " +
            //    "(Select MAX(data_criacao) FROM debito));";
            string sql = "DELETE FROM debito WHERE descricao_debito = @desc;";
            var con = DBConnection();
            Debito debito = UltimoLancamento();
            try
            {
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@desc", debito.DescricaoDebito);
                    cmd.ExecuteNonQuery();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
                RevogarDebitoLancado();
            }
        }

        public static Debito UltimoLancamento()
        {
            string sql = "SELECT id_debito, mes_debito, ano_debito, descricao_debito, data_criacao " +
                " FROM debito WHERE data_criacao = (Select MAX(data_criacao) FROM debito) " +
                "order by id_debito desc limit 1;";
            var con = DBConnection();
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return null;
                    }
                    var debito = new Debito(
                        Int32.Parse(dt.Rows[0]["id_debito"].ToString()),
                        null,
                        dt.Rows[0]["descricao_debito"].ToString(),
                        0.00,
                        (int)dt.Rows[0]["mes_debito"],
                        (int)dt.Rows[0]["ano_debito"],
                        (DateTime)dt.Rows[0]["data_criacao"]
                        );

                    cmd.ExecuteNonQuery();
                    return debito;
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool DebitoExistente(string desc)
        {
            string sql = $"SELECT * FROM debito WHERE descricao_debito = '{desc}'";
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

            return true;
        }

        public static Debito PorDescricao(string desc)
        {
            string sql = $"SELECT * FROM debito WHERE descricao_debito = '{desc}'";
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var debito = new Debito();
            var con = DBConnection();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return null;
                    }

                    else
                    {
                        debito = new Debito(
                            Int32.Parse(dt.Rows[0]["id_debito"].ToString()),
                            CondominoService.Obter(dt.Rows[0]["id_condomino"].ToString(), true),
                            desc,
                            (double)dt.Rows[0]["valor_debito"],
                            Int32.Parse(dt.Rows[0]["mes_debito"].ToString()),
                            Int32.Parse(dt.Rows[0]["ano_debito"].ToString()),
                            (DateTime)dt.Rows[0]["data_criacao"]
                       );
                    }
                    return debito;
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

        public static int InserirDebitoLancado(Debito debito)
        {
            string sql = "INSERT INTO debito_lancado (mes_lancado, ano_lancado, debito_lancado) " +
                "VALUES (@mes, @ano, @debito);";
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@mes", debito.MesDebito);
                    cmd.Parameters.AddWithValue("@ano", debito.AnoDebito);
                    cmd.Parameters.AddWithValue("@debito", debito.IdDebito);
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

        public static int RevogarDebitoLancado()
        {
            string sql = "DELETE FROM debito_lancado WHERE id_debito_lancado = (Select MAX(id_debito_lancado) FROM debito_lancado);";
            var con = DBConnection();
            //int id = UltimoDebitoLancado();

            try
            {
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }


        }

        public static int LancarDebitosAnual(int ano, out string inclusos)
        {
                var con = DBConnection();
            try
            {
                inclusos = " ";
                List<int> meses = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = $"Select mes_lancado from debito_lancado where ano_lancado = {ano};";
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);

                    if (dt.Rows.Count < 1)
                    {
                        for (int i = 1; i < 13; i++)
                        {
                            LancarDebitos(i, ano);
                        }
                    }
                    else
                    {
                        if (dt.Rows.Count == 12)
                        {
                            return 0;
                        }
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var valor = Int16.Parse(dt.Rows[i]["mes_lancado"].ToString());
                            meses.Remove(valor);
                            
                        }

                        foreach (Int32 mes in meses)
                        {
                            inclusos += mes.ToString() + ", ";
                            LancarDebitos(mes, ano);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                inclusos = "";
                return -1;

            }
            finally
            {
                con.Close();
            }
            inclusos = inclusos.Substring(0, inclusos.Length -1);
            return 1;
        }



    }
}
