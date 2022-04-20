using System.Data.SqlClient;
using System.Data;
using ExemploApi1.Interface;
using ExemploApi1.Model;

namespace ExemploApi1.Service

{
    public class BancoDados : IBancoDados
    {
        public static SqlConnection conexaoSql()
        {
            try
            {
                string conexaoBanco = @"Server = DESKTOP-G3MQTKP\SQLEXPRESS; Database = Animais; Integrated Security = SSPI";
                SqlConnection conexao = new SqlConnection(conexaoBanco);
                if(conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                return conexao;
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public static void inserirAnimais(string? tipo, string? raca, float idade)
        {

            SqlCommand command = new SqlCommand("InsertAnimals", conexaoSql());

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@tipo", tipo);
            command.Parameters.AddWithValue("@raca", raca);
            command.Parameters.AddWithValue("@idade", idade);
            command.ExecuteNonQuery();

            conexaoSql().Close();

        }
        public SqlDataReader todosOsAnimais()
        {

            SqlCommand comando = new SqlCommand("BuscaTodosAnimais");
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandTimeout = 300;

            conexaoSql().Open();

            SqlDataReader temp = comando.ExecuteReader();

            conexaoSql().Close();

            return temp;
        }
    }
}
