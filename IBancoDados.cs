using System.Data.SqlClient;
using System.Data;
using ExemploApi1.Service;
using ExemploApi1.Model;


namespace ExemploApi1.Interface
{
    public interface IBancoDados
    {
        public SqlDataReader todosOsAnimais();
    }
}
