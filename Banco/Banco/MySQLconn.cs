using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Banco
{
    public class MySQLconn
    {
        private string user;
        private string password;

        public MySQLconn(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder();

        //public bool TryConnection(out string Error)
        //{
        //    try
        //    {
        //        Builder.Server = "files.000webhost.com";
        //        Builder.UserID = "betestsas";
        //        Builder.Password = "shadow893";
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
            
        //}

    }
}
