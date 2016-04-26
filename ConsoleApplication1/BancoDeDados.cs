using MySql.Data.MySqlClient;
using System;

namespace ConsoleApplication1
{
    class BancoDeDados
    {
        private MySqlConnection conn;

        private MySqlCommand query;

        public BancoDeDados()
        {
            this.conectar();
        }

        private void conectar()
        {
            conn = new MySqlConnection("server=localhost; user=root; password=96342292; database=teste");
        }

        public void preparar(string sql)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.conn;
                query.CommandText = sql;
                this.query = query;
            } catch (MySqlException e)
            {
                Console.WriteLine(e.Message.ToUpper());
                this.conn.Close();
            }
            
        }

        public MySqlDataReader executar()
        {
            return this.query.ExecuteReader();
        }

        public void fechar()
        {
            this.conn.Close();
        }
        public void abrir()
        {
            this.conn.Open();
        }

    }
}

