using Condominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;


namespace Condominio.DAO
{
    class CondominoService : DAO
    {
        private static string Tabela = "condomino";
        private static string Colunas = " casa, nome_representante, telefone, proprietario," +
            "veiculos, email_condomino, debito_anterior";
        private static string Valores = "@casa,  @nome, @tel, @prop, @veiculo, @email, @debito";
        public static int Inserir(Condomino cond)
        {
            string sql = $"INSERT INTO {Tabela} ({Colunas}) VALUES ({Valores})";

            var con = DBConnection();
            if (!VerificarSeExiste(cond.Casa))
            {
                try
                {
                    var cmd = con.CreateCommand();
                    using (cmd)
                    {
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@casa", cond.Casa);
                        cmd.Parameters.AddWithValue("@nome", cond.NomeRepresentante);
                        cmd.Parameters.AddWithValue("@tel", cond.Telefone);
                        cmd.Parameters.AddWithValue("@prop", cond.Proprietario);
                        cmd.Parameters.AddWithValue("@veiculo", cond.Veiculos);
                        cmd.Parameters.AddWithValue("@email", cond.EmailCondomino);
                        cmd.Parameters.AddWithValue("@debito", cond.DebitoAnterior);
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
            MessageBox.Show("Esse número de casa já existe.", "Casa já Existe");
            return -1;
        }

        public static int Alterar(Condomino cond)
        {
            string sql = "UPDATE condomino SET nome_representante = @nome, telefone = @tel," +
                         " proprietario = @prop, veiculos = @veiculos, email_condomino = @email," +
                         "debito_anterior = @debito WHERE id_condomino = @id";

            var con = DBConnection();

            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", cond.IdCondomino);
                    cmd.Parameters.AddWithValue("@casa", cond.Casa);
                    cmd.Parameters.AddWithValue("@nome", cond.NomeRepresentante);
                    cmd.Parameters.AddWithValue("@tel", cond.Telefone);
                    cmd.Parameters.AddWithValue("@prop", cond.Proprietario);
                    cmd.Parameters.AddWithValue("@veiculos", cond.Veiculos);
                    cmd.Parameters.AddWithValue("@email", cond.EmailCondomino);
                    cmd.Parameters.AddWithValue("@debito", cond.DebitoAnterior);
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

        public static Condomino Obter(string coluna, bool id)
        {
            string sql = "";
            if (id)
            {
                sql = $"SELECT * FROM condomino WHERE id_condomino = '{coluna}';";
            }
            else
            {
                sql = $"SELECT * FROM condomino WHERE casa = '{coluna}';";

            }

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
           
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    Condomino cond = null;
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return null;
                    }
                    else
                    {
                        cond = new Condomino(
                            Int32.Parse(dt.Rows[0]["id_condomino"].ToString()),
                            dt.Rows[0]["casa"].ToString(),
                            dt.Rows[0]["nome_representante"].ToString(),
                            dt.Rows[0]["telefone"].ToString(),
                            dt.Rows[0]["proprietario"].ToString(),
                            dt.Rows[0]["veiculos"].ToString(),
                            dt.Rows[0]["email_condomino"].ToString(),
                            (double)dt.Rows[0]["debito_anterior"]
                            );

                        //return cond;
                    }
                    ObterListaDebitos(cond);
                    return cond;
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
        public static bool VerificarSeExiste(string casa)
        {
            string sql = $"SELECT * FROM condomino WHERE casa = '{casa}';";

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var con = DBConnection();
            try
            {
                var cmd = con.CreateCommand();
                using (cmd)
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }


        public static List<Condomino> Listar()
        {
            List<Condomino> lista = new List<Condomino>();
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var con = DBConnection();
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM condomino;";
                    da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count < 1)
                    {
                        return null;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var cond = new Condomino(
                            Int32.Parse(dt.Rows[i]["id_condomino"].ToString()),
                            dt.Rows[i]["casa"].ToString(),
                            dt.Rows[i]["nome_representante"].ToString(),
                            dt.Rows[i]["telefone"].ToString(),
                            dt.Rows[i]["proprietario"].ToString(),
                            dt.Rows[i]["veiculos"].ToString(),
                            dt.Rows[i]["email_condomino"].ToString(),

                            (double)dt.Rows[i]["debito_anterior"]
                            );
                        ObterListaDebitos(cond);
                        lista.Add(cond);
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

        public static List<Debito> ObterListaDebitos(Condomino cond)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            List<Debito> debitos = new List<Debito>();
            var con = DBConnection();
            try
            {
                var cmd2 = con.CreateCommand();
                using (cmd2)
                {

                    cmd2.CommandText = $"SELECT * FROM debito WHERE id_condomino = {cond.IdCondomino};";
                    da = new SQLiteDataAdapter(cmd2.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var debito = new Debito(
                            Int32.Parse(dt.Rows[i]["id_debito"].ToString()),
                            cond,
                            dt.Rows[i]["descricao_debito"].ToString(),
                            (double)dt.Rows[i]["valor_debito"],
                            Int32.Parse(dt.Rows[i]["mes_debito"].ToString()),
                            Int32.Parse(dt.Rows[i]["ano_debito"].ToString()),
                            DateTime.Now
                            ) ;
                            debitos.Add(debito);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            
            return debitos;

        }

        public static List<Recibo> InserirListaRecibos(Condomino cond)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            List<Recibo> recibos = new List<Recibo>();
            var con = DBConnection();
            try
            {
                var cmd2 = con.CreateCommand();
                using (cmd2)
                {

                    cmd2.CommandText = $"SELECT * FROM recibo WHERE condomino_recibo = {cond.IdCondomino};";
                    da = new SQLiteDataAdapter(cmd2.CommandText, DBConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var recibo = new Recibo(
                            Int32.Parse(dt.Rows[0]["id_recibo"].ToString()),
                            (DateTime) dt.Rows[0]["data_pagamento"],
                            (double) dt.Rows[0]["valor_pagamento"],
                            cond,
                            dt.Rows[0]["descricao_recibo"].ToString()
                            );
                            recibos.Add(recibo);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return recibos;
        }


    }


}
