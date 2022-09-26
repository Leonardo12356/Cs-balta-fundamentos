using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Datas();

    }

    /*Módulo Strings*/
    static void Guids()
    {
        //cria um hash aleatório
        var id = Guid.NewGuid();
        id.ToString(); //para transformar o hash em uma string
        Console.WriteLine("id criado: " + id);


        //podemos associar uma string ao guid
        //deve estar dentro dos padrões do guid
        var id2 = Guid.NewGuid();
        id2 = new Guid("d32af0a6-206a-4f5f-a287-7970e2ac698e");
        Console.WriteLine("id associado: " + id2);


        //para mostrar apenas alguns caracteres do hash
        var id3 = Guid.NewGuid();
        Console.WriteLine("id com menos caracteres: " + id3.ToString().Substring(0, 8));

        //se não usar Guid.NewGuid() o hash será criado apenas com zeros!
        id3 = new Guid();
        Console.WriteLine("id errado: " + id3);
    }


    static void Interpolacao()
    {
        var price = 10.2;

        //1º
        var texto = "O preço do produto é " + price + " apenas na promoção.";
        Console.WriteLine(texto);

        //2º
        var texto2 = string.Format("O preço do produto é {0} apenas na promoção.", price);
        Console.WriteLine(texto2);

        //3º
        var texto3 = $"O preço do produto é {price} apenas na promoção.";
        Console.WriteLine(texto3);

        //Usamos "@" para quebrar a linha normalmente usado em texto grande
        var texto4 = @"Teste para a 
            quebra de linha";
        Console.WriteLine(texto4);

        var texto5 = "Teste para a \n quebra de linha";
        Console.WriteLine(texto5);

        var texto6 = @"Teste para a \n quebra de linha";
        Console.WriteLine(texto6);
    }

    static void Comparacao()
    {

        //método compare - retorna um inteiro(0 igual / 1 diferente)
        var texto = "Testando";
        Console.WriteLine("Compare");
        Console.WriteLine(texto.CompareTo("Testando"));
        Console.WriteLine(texto.CompareTo("testando"));
        Console.WriteLine("");

        //método contains - retorna um boolean
        var texto2 = "Este texto é um teste";
        Console.WriteLine("Contains");
        Console.WriteLine(texto2.Contains("teste"));
        Console.WriteLine(texto2.Contains("Teste"));
        //ignora o case sensite tanto no contains quanto no compare
        Console.WriteLine(texto2.Contains("Teste", StringComparison.OrdinalIgnoreCase));

    }

    static void StartEndsWith()
    {
        var texto = "Este texto é um teste";

        //Starts with para saber se a string começa com aquela palavra/letra - retorna um boolean
        Console.WriteLine("StartsWith");
        Console.WriteLine(texto.StartsWith("Este"));
        Console.WriteLine(texto.StartsWith("este"));
        Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("");



        //End with para saber se a string termina com aquela palavra/letra - retorna um boolean
        Console.WriteLine("EndsWith");
        Console.WriteLine(texto.EndsWith("teste"));
        Console.WriteLine(texto.EndsWith("Teste"));
        Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(texto.EndsWith("este"));
        Console.WriteLine(texto.EndsWith("e"));
        Console.WriteLine(texto.EndsWith("xpro"));
        Console.WriteLine("");
    }

    static void Equal()
    {
        //método de comparação - retorna boolean
        var texto = "Este texto é um teste";
        Console.WriteLine("equals com string");
        Console.WriteLine(texto.Equals("Este texto é um teste"));
        Console.WriteLine(texto.Equals("este texto é um teste"));
        Console.WriteLine(texto.Equals(" este texto é um teste "));
        Console.WriteLine(texto.Equals("este texto é um "));
        Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("");

        var texto2 = 33;
        Console.WriteLine("equals com int");
        Console.WriteLine(texto2.Equals(22));
        Console.WriteLine(texto2.Equals(33));

    }

    static void Indice()
    {

        //indica a posição do caractere/palavra
        var texto = "Este texto é um teste";
        Console.WriteLine(texto.IndexOf("é"));
        Console.WriteLine(texto.IndexOf("texto"));

        //busca o último index do carctere/palavra
        Console.WriteLine(texto.LastIndexOf("s"));
    }

    static void OutrosMetodos()
    {
        var texto = "ESTE texto é um teste.";
        //converte o texto todo para minúsculo
        Console.WriteLine(texto.ToLower());

        //converte o texto todo para maiúsculo
        Console.WriteLine(texto.ToUpper());

        //insere carctere/palavra no nosso texto
        Console.WriteLine(texto.Insert(11, "AQUI (teste do insert) "));

        //remove caractere/palavra do nosso texto
        Console.WriteLine(texto.Remove(14, 1));

        //mostra o tamanho da string
        Console.WriteLine(texto.Length);

        //faz a troca de uma palavra
        Console.WriteLine(texto.Replace("ESTE", "ISTO"));

        //divide o texto - retorna uma lista
        var divisao = texto.Split(" ");
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);
        Console.WriteLine(divisao[4]);

        //retorna a palavra desejada, devemos passar a posição e o número de caracteres que desejamos
        var resultado = texto.Substring(5, 5);
        Console.WriteLine(resultado);

        //remove espaços no começo e no fim
        var texto2 = "     Teste de Espaços. ";
        Console.WriteLine(texto2.Trim());

    }

    static void Builder()
    {
        //criar linhas de uma forma dinâmica
        //em alguns casos deverá ser convertido para string
        var texto = new StringBuilder();
        texto.Append("Este texto é um teste ");
        texto.Append("Est teste ");
        texto.Append("Este um teste ");
        texto.Append("Este texto este ");
        texto.ToString();

        Console.WriteLine(texto);
    }



    static void Datas()
    {

        //se não inicializar pega um  valor padrão
        Console.Clear();

        var data = new DateTime();
        Console.WriteLine(data);

        //Pega a data atual
        data = DateTime.Now;
        Console.WriteLine(data);

        //para atribuir uma data - ano, mês, dia, hora, minutos, segundos
        data = new DateTime(2020, 10, 12, 8, 23, 14);

        //obter as informações de forma separada
        Console.WriteLine(data.Year);
        Console.WriteLine(data.Month);
        Console.WriteLine(data.Day);
        Console.WriteLine(data.Hour);
        Console.WriteLine(data.Minute);
        Console.WriteLine(data.Second);

        //descobrir o dia da semana
        Console.WriteLine(data.DayOfWeek);

    }
}