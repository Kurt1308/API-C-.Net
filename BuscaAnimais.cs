using ExemploApi1.Model;
using ExemploApi1.Interface;


namespace ExemploApi1.Service
{
    public class BuscaAnimais : AdicionaAnimais, IBuscaAnimais
    {
        public List<Gatos> buscaGatos()
        {
            int arraySize = 3;
            List<Gatos> gatos = new List<Gatos>();
            StreamReader sr = new StreamReader("./txt.txt");

            string linhaAtual = string.Empty;

            while (true)
            {
                linhaAtual = sr.ReadLine();
                if (linhaAtual != null)
                {
                    string[] dadosAtuais = linhaAtual.Split('|');
                    dadosAtuais[2] = dadosAtuais[2].Trim();
                    dadosAtuais[1] = dadosAtuais[1].Trim();
                    if (dadosAtuais[0].ToUpper().Trim() == "GATO" && dadosAtuais.Length == arraySize && dadosAtuais[2].All(char.IsDigit) && dadosAtuais[1].All(char.IsLetter))
                    {
                        CriarAnimais inseregato = new CriarAnimais();
                        Gatos temporario = inseregato.CriaGato(dadosAtuais);


                        if (Gatos.Validacao(temporario.Idade))
                        {
                            gatos.Add(temporario);


                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                        continue;
                }
                else
                    break;
            }
            foreach (var temporario in gatos)
            {
                BancoDados.inserirAnimais(temporario.tipo, temporario.Raca, temporario.Idade);
            }

            return gatos;
        }


        public List<Cachorro> buscaCachorro()
        {

            List<Cachorro> cachorros = new List<Cachorro>();
            var todasLinhas = File.ReadLines(@"C:\Users\Kley\Desktop\LEITURABICHO.txt");
            foreach (var linha in todasLinhas)
            {
                var array = ValidacaoArray.OArrayEValido(linha);
                
                Cachorro cachorro = new Cachorro();
                if(array != null)
                {
                    if(array[0].ToUpper().Trim() == "CACHORRO")
                    {
                        array[2] = array[2].Trim();
                        array[1] = array[1].Trim();
                        CriarAnimais criarAnimais = new CriarAnimais();
                        cachorro = criarAnimais.CriaCachorro(array);
                        if (Cachorro.Validacao(cachorro.Idade))
                            cachorros.Add(cachorro);
                    }
                }
                continue;
            }
            return cachorros;
        }
        public Todos buscaTodosAnimais()
        {
            Todos animais = AdicionaAnimal();
            return animais;
        }
        public List<UniãoTodostxt> animaisParaSql()
        {
            var todasLinhas = File.ReadLines(@"C:\Users\Kley\Desktop\LEITURABICHO.txt");
            List<UniãoTodostxt> uniaotodos = new List<UniãoTodostxt>();
            foreach (var linha in todasLinhas)
            {
                var array = ValidacaoArray.OArrayEValido(linha);
                CriarAnimais criarAnimais = new CriarAnimais();
                if(array != null)
                {
                    UniãoTodostxt uniaoTodostxt = new UniãoTodostxt();
                    uniaoTodostxt = criarAnimais.CriaTodos(array);
                    uniaotodos.Add(uniaoTodostxt); 
                }
                continue;
            }
            foreach (var uniãoTodostxt in uniaotodos)
            {
                BancoDados.inserirAnimais(uniãoTodostxt.Animal, uniãoTodostxt.Raca, uniãoTodostxt.Idade);
            }
        return uniaotodos;

        }

    }
}
