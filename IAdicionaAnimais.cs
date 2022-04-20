using ExemploApi1.Model;
namespace ExemploApi1.Interface;
using System.Data.SqlClient;
using System.Data;

public interface IAdicionaAnimais
{
    public Todos AdicionaAnimal();
    public Gatos adicionaGato(Gatos gatos);


}
