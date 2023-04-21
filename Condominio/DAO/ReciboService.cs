using Condominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Condominio.DAO
{
    class ReciboService : DAO
    {
        private static string Tabela = "recibo";
        private static string Colunas = "data_pagamento, valor_pagamento, condomino_recibo, descricao_recibo";
        private static string Valores = "@data, @valor, @cond, @desc";
        public static int Inserir(Recibo recibo)
        {
            string sql = $"INSERT INTO {Tabela} ({Colunas}) VALUES ({Valores});";
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@data", recibo.DataPagamento.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@valor", recibo.ValorPagamento);
                    cmd.Parameters.AddWithValue("@cond", recibo.Condomino.IdCondomino);
                    cmd.Parameters.AddWithValue("@desc", recibo.DescricaoRecibo);
                    cmd.ExecuteNonQuery();
                    
                    return Int32.Parse(cmd.Connection.LastInsertRowId.ToString());

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }
        

        public static int Apagar(int idDebito)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DBConnection()))
                {
                    cmd.CommandText = "DELETE FROM recibo WHERE id_recibo = @id";
                    cmd.Parameters.AddWithValue("@id", idDebito);
                    cmd.ExecuteNonQuery();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return -1;
            }
        }

        public static Recibo ObterUltimoDoCondomino(int idCondomino)
        {
            string sql = "SELECT * FROM recibo WHERE id_recibo = " +
                $"(Select MAX(id_recibo) FROM recibo Where condomino_recibo = {idCondomino})";
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var recibo = new Recibo();
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
                        recibo = new Recibo(
                            Int32.Parse(dt.Rows[0]["id_recibo"].ToString()),
                            (DateTime) dt.Rows[0]["data_pagamento"],
                            Double.Parse(dt.Rows[0]["valor_pagamento"].ToString()),
                            CondominoService.Obter(dt.Rows[0]["condomino_recibo"].ToString(), true),
                            dt.Rows[0]["descricao_recibo"].ToString()
                       );
                    }
                    return recibo;
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
    }
}
