namespace ExemploApi1.Model
{
    public class Gatos
    {
        public string tipo = "GATO";
        public float Idade { get; set; }
        public string? Raca { get; set; }

        public static bool Validacao(float idade)
        {
            if (idade < 6)
            {
                return true;
            }
            else
            {
                return false;
            }
                  

        }
    }
}
