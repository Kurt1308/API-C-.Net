using ExemploApi1.Model;
using ExemploApi1.Interface;

namespace ExemploApi1.Service
{
    public class CriarAnimais : ICriarAnimais 
    {
        public Gatos CriaGato(string[] dadosAtuais)
        {
            Gatos temporario = new Gatos();
            temporario.Idade = float.Parse(dadosAtuais[2]);
            temporario.Raca = dadosAtuais[1];
            return temporario;
        }
        public Cachorro CriaCachorro(string[] dadosAtuais)
        {
            Cachorro temporario1 = new Cachorro();
            temporario1.Idade = float.Parse(dadosAtuais[2]);
            temporario1.Raca = dadosAtuais[1];
            return temporario1;
        }
        public  UniãoTodostxt CriaTodos(string[] dadosAtuais)
        {
            UniãoTodostxt temporario = new UniãoTodostxt();
            temporario.Animal = dadosAtuais[0];
            temporario.Raca = dadosAtuais[1];
            temporario.Idade = float.Parse(dadosAtuais[2]);

            return temporario;

        }


    }
}
