

using System.Data.SqlClient;

namespace Recuperação_UC_12_e_13
{
    public class Banco
    {
        public Banco()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(
                    "Integrated Security=true;"+
                    "Server=JHON;"+
                    "Database=venda;"+
                    "Trusted_Connection=true;"
                );
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    string sql = "SELECT * FROM tblclientes";
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql,conn))
                    {
                    conn.Open();
                     using (SqlDataReader tabela = cmd.ExecuteReader())
                        {
                            while(tabela.Read())
                            {
                                lista.Add(new Cliente(){
                                    cpf_cnpj = tabela["cpf_cnpj"].ToString(),
                                    nome = tabela["nome"].ToString(),
                                    endereco = tabela["endereco"].ToString(),
                                    rg_ie = tabela["rg_ie"].ToString(),
                                    tipo = Convert.ToChar(tabela["tipo"]),
                                    valor = (float)Convert.ToDecimal(tabela["valor"]),
                                    valor_imposto = (float)Convert.ToDecimal(tabela["valor_imposto"]),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private List<Cliente> lista = new List<Cliente>();
        public List<Cliente> GetLista()
        {
            return lista;
        }
        public string GetListaString()
        {
            string enviar = "<!DOCTYPE html>\n<html>\n<head>\n<meta charset='utf-8'/>\n"+
            "<title>Cadastro de Cliente</title>\n"+
            "</head>\n<body>"+
            "<h1>Lista de Clientes</h1>"+
            "<table><thead><tr>" +
            "<table><thead><tr>"+
            "<th>cpf_cnpj</th>" +
            "<th>Nome</th>" +
            "<th>endereco</th>" +
            "<th>rg_ie</th>" +
            "<th>Tipo</th>" +
            "<th>Valor</th>" +
            "<th>Valor Imposto</th>"+
            "<th>Total</th>" +
        "</thead><tbody> " ;
        foreach (Cliente cli in GetLista())
        {enviar += "<tr>"+
        $"<td>{cli.cpf_cnpj}</td>"+
        $"<td>{cli.nome}</td>"+
        $"<td>{cli.endereco}</td>"+
        $"<td>{cli.rg_ie}</td>"+
        $"<td>{cli.tipo}</td>"+
        $"<td>{cli.valor.ToString("C")}</td>"+
        $"<td>{cli.valor_imposto.ToString("C")}</td>"+
        $"<td>{cli.total.ToString("C")}</td>"+
        "</tr>";
        }
        enviar += "</tbody><table><body></html>";
        return enviar;
        }
    }
}