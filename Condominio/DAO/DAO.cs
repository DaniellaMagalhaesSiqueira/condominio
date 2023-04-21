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
    public class Tabela
    {
        Dictionary<string, string> Colunas { get; set; }
    }
    public class DAO
    {
        private static SQLiteConnection SQLiteConn;
        private static string Tabela;
        private static string Colunas;
        private static string Valores;
        private static string Atributos;
        private static string[] ListaAtributos;

        public DAO(string tabela, string colunas, string valores, string atributos, string[] lista)
        {
            Tabela = tabela;
            Colunas = colunas;
            Valores = valores;
            Atributos = atributos;
            ListaAtributos = lista;

        }

        public DAO() { }

        protected static SQLiteConnection DBConnection()
        {
            SQLiteConn = new SQLiteConnection("Data Source = db_condominio.db");
            SQLiteConn.Open();
            return SQLiteConn;
        }
        public static int Executar(string sql)
        {
            var con = DBConnection();
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
        //public static bool Inserir(object[] obj)
        //{
        //    string[] cols = Colunas.Split(",");

        //    var con = DBConnection();
        //    try
        //    {
        //        using (var cmd = new SQLiteCommand(con))
        //        {
        //            cmd.CommandText = $"INSERT INTO {Tabela} ({Colunas}) VALUES ({Valores});";
        //            for (int i = 0; i < cols.Length; i++)
        //            {
        //                if (ListaAtributos[i].Equals("date"))
        //                {
        //                    cmd.Parameters.AddWithValue(Valores.Split(",")[i], ((DateTime)obj[i]).ToString("yyyy-MM-dd"));
        //                }
        //                else
        //                {
        //                    cmd.Parameters.AddWithValue(Valores.Split(",")[i], obj[i]);
        //                }
        //            }
        //            cmd.ExecuteNonQuery();
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.Write(ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        public static Dictionary<string, string> Consultar(TipoModelo tabela)
        {
            var resultado = new Dictionary<string, string>();

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    switch (tabela)
                    {
                        case TipoModelo.Administrador:

                            break;

                        case TipoModelo.Condominio:


                            break;

                        case TipoModelo.Condomino:
                            var tabelaRetorno = new Dictionary<string, string>();
                            cmd.CommandText = "Select * from Condomino";
                            da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                            da.Fill(dt);
                            if (dt.Rows.Count < 1)
                            {
                                return null;
                            }
                            else
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    tabelaRetorno.Add("id_condomino", dt.Rows[i]["id_condomino"].ToString());
                                    tabelaRetorno.Add("casa", dt.Rows[i]["casa"].ToString());
                                    tabelaRetorno.Add("complemento", dt.Rows[i]["complemento"].ToString());
                                    tabelaRetorno.Add("nome_representante", dt.Rows[0]["nome_representante"].ToString());
                                    tabelaRetorno.Add("telefone", dt.Rows[i]["telefone"].ToString());
                                    tabelaRetorno.Add("proprietario", dt.Rows[i]["proprietario"].ToString());
                                    tabelaRetorno.Add("veiculos", dt.Rows[i]["veiculos"].ToString());
                                    tabelaRetorno.Add("email_condomino", dt.Rows[i]["email_condomino"].ToString());
                                    tabelaRetorno.Add("debito_anterior", dt.Rows[i]["debito_anterior"].ToString());
                                }
                            }

                            return tabelaRetorno;

                        case TipoModelo.Contato:

                            break;

                        case TipoModelo.Debito:

                            break;

                        case TipoModelo.Despesa:

                            break;

                        case TipoModelo.Receita:

                            break;

                        case TipoModelo.Recibo:

                            break;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }



            return resultado;
        }

    }
}
