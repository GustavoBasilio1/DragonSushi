using DragonSushi.Database;
using DragonSushi.ViewModel;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace DragonSushi.DAO
{
    public class ProdutoDAO
    {
        //CONSULTAR ESTOQUE PELO NOME DO PRODUTO
        //public async Task<ProdutoViewModel> ConsultarEstoque(string nomeProd)
        //{
        //    HttpClient httpClient = new HttpClient();
        //    var response = await httpClient.GetAsync($"https://smallredrock2.conveyor.cloud/api/ProdutoApi/ConsultarEstoque?nomeProd=Atum");
        //    var jsonString = await response.Content.ReadAsStringAsync();

        //    ProdutoViewModel jsonObject = JsonConvert.DeserializeObject<ProdutoViewModel>(jsonString);

        //    if(jsonObject != null)
        //    {
        //        return jsonObject;
        //    }
        //    else
        //    {
        //        return new ProdutoViewModel
        //        {
        //            Verificacao = true
        //        };
        //    }
        //}

        ////CONSULTAR CARDÁPIO PELO NOME DO PRODUTO 
        //public async Task<ProdutoViewModel> ConsultarCardapio(string nomeProd)
        //{
        //    HttpClient httpClient = new HttpClient();
        //    var response = await httpClient.GetAsync($"https://smallredrock2.conveyor.cloud/api/ProdutoApi/ConsultarCardapio?nomeProd={nomeProd}");
        //    var jsonString = await response.Content.ReadAsStringAsync();

        //    ProdutoViewModel jsonObject = JsonConvert.DeserializeObject<ProdutoViewModel>(jsonString);

        //    if (jsonObject != null)
        //    {
        //        return jsonObject;
        //    }
        //    else
        //    {
        //      return  new ProdutoViewModel
        //        {
        //            Verificacao = true
        //        };
        //    }
        //}

        public void cadastrarProduto(ProdutoViewModel vmProduto)
        {
            DataBase db = new DataBase();

            string insertQuery = String.Format("call spCadastrarProduto(@nomeProd,@imgProd,@descrProd,@preco,@estoque, @ingrediente, @categoria, @qntdProd, @unMedida)");
            MySqlCommand command = new MySqlCommand(insertQuery, db.conectarDb());
            command.Parameters.Add("@nomeProd", MySqlDbType.VarChar).Value = vmProduto.Produto.nomeProd;
            command.Parameters.Add("@imgProd", MySqlDbType.VarChar).Value = vmProduto.Produto.imgProd;
            command.Parameters.Add("@descrProd", MySqlDbType.VarChar).Value = vmProduto.Produto.descrProd;
            command.Parameters.Add("@preco", MySqlDbType.Decimal).Value = vmProduto.Produto.preco;
            command.Parameters.Add("@estoque", MySqlDbType.Byte).Value = vmProduto.Produto.estoque;
            command.Parameters.Add("@ingrediente", MySqlDbType.Byte).Value = vmProduto.Produto.ingrediente;
            command.Parameters.Add("@categoria", MySqlDbType.VarChar).Value = vmProduto.Categoria.categoria;
            command.Parameters.Add("@qntdProd", MySqlDbType.Decimal).Value = vmProduto.Produto.qntdProd;
            command.Parameters.Add("@unMedida", MySqlDbType.VarChar).Value = vmProduto.UnMedida.unMedida;

            command.ExecuteNonQuery();

        }

    }
}