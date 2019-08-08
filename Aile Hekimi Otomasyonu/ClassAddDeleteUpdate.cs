using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Aile_Hekimi_Otomasyonu
{
    class ClassAddDeleteUpdate
    {   //veri tabanı bağlantı nesnesi
        public OleDbConnection con;
        //veri tabanı bağlantı kontrol edip eğer bağlantı kapalı ise bağlantıyı açma komutu
        public void connectOpen()
        {
            con = new OleDbConnection();
             con.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBAhbsVeriTabani.mdb");
           //con.ConnectionString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"DBAhbsVeriTabani.accdb");
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        
        public void DBCommand(string command)
        {
            connectOpen();
            OleDbCommand comm = new OleDbCommand(command, con);
            comm.ExecuteNonQuery();
            connectClose();
        }

        public OleDbDataReader DBResult(string result)
        {
            connectOpen();
            OleDbCommand komut = new OleDbCommand(result, con);
            OleDbDataReader read = komut.ExecuteReader();
            return read;
        }
        public void connectClose()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
    }
}






