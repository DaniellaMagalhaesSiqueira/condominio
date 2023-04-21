using Condominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace Condominio.DAO
{
    class AdmService
    {
        //public static Administrador Login(string email, string senha)
        //{
        //    string sql = $"SELECT * FROM administrador WHERE email_adm = '{email}' AND " +
        //        $"senha_adm = '{senha}';";

        //Conexao con = new Conexao();
        //try
        //{
        //    con.Conectar();
        //    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con.Conn);
        //    DataTable dataTable = new DataTable();
        //    dataAdapter.Fill(dataTable);
        //    if (dataTable.Rows.Count < 1)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        var adm = new Administrador(
        //            Int32.Parse(dataTable.Rows[0]["id_adm"].ToString()),
        //            dataTable.Rows[0]["nome_adm"].ToString(),
        //            dataTable.Rows[0]["email_adm"].ToString(),
        //            dataTable.Rows[0]["senha_adm"].ToString()
        //            );
        //        return adm;
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    return null;
        //}
        //finally
        //{
        //    con.Desconectar();
        //}
        //    }
    }
}
