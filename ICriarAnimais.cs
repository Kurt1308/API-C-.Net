using ExemploApi1.Model;
using ExemploApi1.Service;

namespace ExemploApi1.Interface
{
    public interface ICriarAnimais
    {
        public Gatos CriaGato(string[] dadosAtuais);
        public Cachorro CriaCachorro(string[] dadosAtuais);
        public UniãoTodostxt CriaTodos(string[] dadosAtuais);
    }
}
