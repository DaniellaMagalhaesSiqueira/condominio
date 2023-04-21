using Condominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text;

namespace Condominio.DAO
{
    class CondominioAlteracaoService : DAO
    {
        private static string Colunas = "data_alteracao, valor_atual, valor_anterior, condominio_valido";
        private static string Valores = "@data, @atual, @anterior, @valido";
        private static string ValoresAtribuidos = " data_alteracao = @data, valor_atual = @atual, valor_anterior = @anterior, condominio_valido = @valido";
        public static int Inserir(CondominioAlteracao condominio)
        {
            string sql = $"INSERT INTO condominio_alteracao ({Colunas}) VALUES ({Valores});";
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", condominio.DataAlteracao);
                    cmd.Parameters.AddWithValue("@atual", condominio.ValorAtual);
                    cmd.Parameters.AddWithValue("@anterior", condominio.ValorAnterior);
                    cmd.Parameters.AddWithValue("@valido", true);
                    cmd.ExecuteNonQuery();
                    return Int32.Parse(cmd.Connection.LastInsertRowId.ToString());
                    
                }
            }
            catch(Exception ex)
            {
                Debug.Write(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
                InvalidarUltimo();
            }
        }

        public static int InvalidarUltimo()
        {
            string sql = "UPDATE condominio_alteracao set condominio_valido = false " +
                "WHERE id_condominio = (SELECT MAX(id_condominio) - 1" +
                " FROM condominio_alteracao);";

           
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    return 1;
                }
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }

        }
        public static CondominioAlteracao ObterValido()
        {
            string sql = "SELECT * FROM condominio_alteracao WHERE id_condominio = " +
                "(SELECT MAX(id_condominio) FROM condominio_alteracao);";
            //string sql = "SELECT * FROM condominio_alteracao WHERE valido = 1;";

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    CondominioAlteracao cond = null;
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return null;
                    }
                    else
                    {
                        cond = new CondominioAlteracao(
                            Int32.Parse(dt.Rows[0]["id_condominio"].ToString()),
                            (DateTime)dt.Rows[0]["data_alteracao"],
                            (double)dt.Rows[0]["valor_atual"],
                            (double)dt.Rows[0]["valor_anterior"],
                            (bool) dt.Rows[0]["condominio_valido"]
                            );
                    }
                    return cond;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
