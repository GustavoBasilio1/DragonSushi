using DragonSushi.Database;
using DragonSushi.ViewModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonSushi.DAO
{
    public class EnderecoDAO
    {
            public void cadastrarEndereco(EnderecoViewModel vmEndereco)
            {
                DataBase db = new DataBase();

                string insertQuery = String.Format("call spCadastrarEndereco(@numEndereco,@descrEndereco,@rua,@bairro,@cidade, @idEstado)");
                MySqlCommand command = new MySqlCommand(insertQuery, db.conectarDb());
                command.Parameters.Add("@numEndereco", MySqlDbType.VarChar).Value = vmEndereco.Endereco.numEndereco;
                command.Parameters.Add("@descrEndereco", MySqlDbType.VarChar).Value = vmEndereco.Endereco.descrEndereco;
                command.Parameters.Add("@rua", MySqlDbType.VarChar).Value = vmEndereco.Rua.rua;
                command.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = vmEndereco.Bairro.bairro;
                command.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = vmEndereco.Cidade.cidade;
                command.Parameters.Add("@idEstado", MySqlDbType.VarChar).Value = vmEndereco.Estado.idEstado;


                command.ExecuteNonQuery();
                db.desconectarDb();
            }
        }
    }
