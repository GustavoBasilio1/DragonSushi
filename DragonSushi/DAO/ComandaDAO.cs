using DragonSushi.Database;
using DragonSushi.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonSushi.DAO
{
    public class ComandaDAO
    {
        public void cadastrarComanda(Comanda comanda)
        {
            DataBase db = new DataBase();

            string insertQuery = String.Format("spCadastrarComanda(@numMesa)");
            MySqlCommand command = new MySqlCommand(insertQuery, db.conectarDb());
            command.Parameters.Add("@numMesa", MySqlDbType.Int16).Value = comanda.numMesa;



            command.ExecuteNonQuery();
            db.desconectarDb();
        }

    }
}