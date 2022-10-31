using DragonSushi.Database;
using DragonSushi.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonSushi.DAO
{
    public class PedidoDAO
    {

        public void cadastrarPedido(Pedido pedido)
        {
            DataBase db = new DataBase();

            string insertQuery = String.Format("call spCadastrarPedido(@qtdProd,@descrPedido,@fkProd,@fkComanda)");
            MySqlCommand command = new MySqlCommand(insertQuery, db.conectarDb());
            command.Parameters.Add("@qtdProd", MySqlDbType.Int32).Value = pedido.qtdProd;
            command.Parameters.Add("@descrPedido", MySqlDbType.VarChar).Value = pedido.descrPedido;
            command.Parameters.Add("@fkProd", MySqlDbType.Int32).Value = pedido.fkProd;
            command.Parameters.Add("@fkComanda", MySqlDbType.Int32).Value = pedido.fkComanda;


            command.ExecuteNonQuery();
            db.desconectarDb();
        }
    }
}