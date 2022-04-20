namespace ExemploApi1.Service
{
    public class ValidacaoArray
    {
        public static String[]? OArrayEValido(string? linha)
        {
            int arraySize = 3;
            if (linha == null)
                return null;
            String[] array = linha.Split("|");
            if (array.Length != arraySize)
                return null;
            if (!float.TryParse(array[2], out float idade))
                return null;
            return array;
        }
    }
}
