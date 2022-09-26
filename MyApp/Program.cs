using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // var id = Guid.NewGuid();
        // id.ToString();

        // id = new Guid("d32af0a6-206a-4f5f-a287-7970e2ac698e");

        // if (id == Guid.NewGuid())
        //     Console.WriteLine(id.ToString().Substring(0, 8));

        //INTERPOLAÇÃO!!!

        // var price = 10.2;
        // var texto = "O preço do produto é" + price;
        // var texto = string.Format("O preço do produto é {0} apenas na promoção", price);
        // var texto = $@"O preço do produto é 
        // {price} apenas na promoção"; // se adicionarmos um @ posso quebrar a linha pois 
        //ele entende como se tudo    fosse uma string
        // Console.WriteLine(texto);

        //Comparação de strings

        // var texto = "Testando";
        // Console.WriteLine(texto.CompareTo("Testando"));

        // var texto = "Este texto é um teste";
        // Console.WriteLine(texto.Contains("teste")); // retorna um bool
        // Console.WriteLine(texto.Contains("Teste"));
        // Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); //ignora letra maiuscula

        //  StartsWith/EndsWith

        // Console.WriteLine(texto.StartsWith("Este"));
        // Console.WriteLine(texto.StartsWith("este"));
        // Console.WriteLine(texto.StartsWith("tetxo"));

        // Console.WriteLine(texto.EndsWith("Este"));
        // Console.WriteLine(texto.EndsWith("este"));
        // Console.WriteLine(texto.EndsWith("xpro"));

        //EQUALS


        // Console.WriteLine(texto.Equals("Este texto é um teste"));
        // Console.WriteLine(texto.Equals("este texto é um teste"));
        // Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));

        //ÍNDICES

        // Console.WriteLine(texto.IndexOf("é")); //IndexOff sempre pede o mesmo tipo ex: string = string
        // Console.WriteLine(texto.LastIndexOf("s")); // Encontra a última letra da frase que eu escolher, ex S

        //  Métodos adicionais

        // Console.WriteLine(texto.ToLower());
        // Console.WriteLine(texto.ToUpper());
        // Console.WriteLine(texto.Insert(5, "Aqui"));
        // Console.WriteLine(texto.Remove(5, 5));
        // Console.WriteLine(texto.Length);

        //MANIPULANDO STRINGS

        // Console.WriteLine(texto.Replace("Este", "isto"));
        // Console.WriteLine(texto.Replace("xxxxxx", "X"));

        // var divisao = texto.Split(" ");
        // Console.WriteLine(divisao[0]);
        // Console.WriteLine(divisao[1]);
        // Console.WriteLine(divisao[2]);
        // Console.WriteLine(divisao[3]);

        // var resultado = texto.Substring(5, 5);
        // // var resultado = texto.Substring(5, texto.LastIndexOf("o"));
        // Console.WriteLine(resultado);

        // Console.WriteLine(texto.Trim());  // Serve pra retirar os espaços do início e do fim

        // STRINGBUILDER
        var texto = new StringBuilder();
        texto.Append("Este texto é um teste");
        texto.Append("é um teste");
        texto.Append("Este texto");
        texto.Append("Este um teste");

        texto.ToString();
        Console.WriteLine(texto);



    }
}