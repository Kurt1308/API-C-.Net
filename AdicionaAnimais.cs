using ExemploApi1.Model;
using ExemploApi1.Interface;
using ExemploApi1.Service;
using System.Data.SqlClient;
using System.Data;

namespace ExemploApi1.Service
{
    public class AdicionaAnimais : IAdicionaAnimais
    {

        public Todos AdicionaAnimal()
        {
            BuscaAnimais buscaAnimais = new BuscaAnimais();
            Todos animais = new Todos();
            animais.cachorros = buscaAnimais.buscaCachorro();
            animais.gatos = buscaAnimais.buscaGatos();
            return animais;
        }

        public Gatos adicionaGato(Gatos gatos)
        {
            StreamWriter s = File.AppendText("./txt.txt");
            s.WriteLine("GATO|" + gatos.Raca + "|" + gatos.Idade);
            s.Close();
            return gatos;

        }


    }
}