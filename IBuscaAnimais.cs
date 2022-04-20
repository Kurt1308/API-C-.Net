using ExemploApi1.Model;
using System.Data;
using System.Data.SqlClient;

namespace ExemploApi1.Interface
{
    public interface IBuscaAnimais
    {
        public List<Gatos> buscaGatos();
        public List<Cachorro> buscaCachorro();
        public Todos buscaTodosAnimais();
        public List<UniãoTodostxt> animaisParaSql();
    }
}
