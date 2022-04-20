namespace ExemploApi1.Model
{
    public class Cachorro
    {
        public string tipo = "CACHORRO";
        public float Idade { get; set; }
        public string? Raca { get; set; }

        public static bool Validacao(float idade)
        {
            if (idade < 101)
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
