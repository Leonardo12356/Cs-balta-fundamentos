using System.Text;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Formatar();

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

    static void Formatar()
    {
        // dia/mes/ano hora:min:seg
        var data = DateTime.Now;
        Console.WriteLine(data);

        //traz somente o ano
        var formatada = String.Format("{0:yyyy}", data);
        Console.WriteLine(formatada);

        //traz somente o ano
        var formatada2 = String.Format("{0:yy}", data);
        Console.WriteLine(formatada2);

        //traz mês e ano
        var formatada3 = String.Format("{0:y}", data);
        Console.WriteLine(formatada3);

        //traz dia e mês
        var formatada4 = String.Format("{0:M}", data);
        Console.WriteLine(formatada4);

        //traz os minutos
        var formatada5 = String.Format("{0:mm}", data);
        Console.WriteLine(formatada5);

        //pode formatar como quiser
        var formatada6 = String.Format("{0:dd-MM-yyyy}", data);
        Console.WriteLine(formatada6);

        //fração de segundo(f) e time zone(z)
        var formatada7 = String.Format("{0:hh:mm:ss ff z}", data);
        Console.WriteLine(formatada7);

        //short time
        var formatada8 = String.Format("{0:t}", data);
        Console.WriteLine(formatada8);

        //short date
        var formatada9 = String.Format("{0:d}", data);
        Console.WriteLine(formatada9);

        //long time
        var formatada10 = String.Format("{0:T}", data);
        Console.WriteLine(formatada10);

        //long date
        var formatada11 = String.Format("{0:D}", data);
        Console.WriteLine(formatada11);

        //combina data e hora (long)
        var formatada12 = String.Format("{0:f}", data);
        Console.WriteLine(formatada12);

        //combina data e hora (short)
        var formatada13 = String.Format("{0:g}", data);
        Console.WriteLine(formatada13);

        //padrão dos sistemas tanto faz se é R ou r
        var formatada14 = String.Format("{0:r}", data);
        Console.WriteLine(formatada14);

        //padrão para banco não relacional
        var formatada15 = String.Format("{0:s}", data);
        Console.WriteLine(formatada15);

        //padrão para json
        var formatada16 = String.Format("{0:u}", data);
        Console.WriteLine(formatada16);
    }

    static void Valores()
    {
        var data = DateTime.Now;
        Console.WriteLine(data);

        //adiciona ou retira dias 
        Console.WriteLine(data.AddDays(12));
        Console.WriteLine(data.AddDays(-6));

        //adiciona meses
        Console.WriteLine(data.AddMonths(1));

        //adiciona anos
        Console.WriteLine(data.AddYears(1));
    }

    static void ComparacaoDatas()
    {
        var data = DateTime.Now;

        if (data.Date == DateTime.Now.Date)
        {
            Console.WriteLine("É igual!");
        }

    }

    static void Globalizacao()
    {
        //CultureInfo
        var pt = new System.Globalization.CultureInfo("pt-PT");
        var br = new System.Globalization.CultureInfo("pt-BR");
        var en = new System.Globalization.CultureInfo("en-UK");
        var de = new System.Globalization.CultureInfo("de-DE");
        var atual = CultureInfo.CurrentCulture; // pega a cultura da máquina, ex pc japones cultura japonesa



        Console.WriteLine(DateTime.Now.ToString("D", pt));
        Console.WriteLine(DateTime.Now.ToString("D", br));
        Console.WriteLine(DateTime.Now.ToString("D", en));
        Console.WriteLine(DateTime.Now.ToString("D", de));


        //TimeZone
        //pega à hora base, não utiliza time zone
        var utcDate = DateTime.UtcNow;
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(utcDate);

        //volta para a hora da máquina
        Console.WriteLine(utcDate.ToLocalTime());

        //usando time zone
        var timeZoneAustralia =
        TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.WriteLine(timeZoneAustralia);
        var horaAustralia =
        TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
        Console.WriteLine(horaAustralia);

        //listar as times zones disponíveis
        var timezones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timezones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            Console.WriteLine("------------");
        }

        //timeSpan - fração de tempo
        //utilizado para fazer cálculos de horas
        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);

        var timeSpanNanoSegundos = new TimeSpan(1);
        Console.WriteLine(timeSpanNanoSegundos);

        var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
        Console.WriteLine(timeSpanHoraMinutoSegundo);

        var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

        var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

        Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
    }



    //-------------- Módulo "Moedas" --------------

    static void GlobalizacaoMoedas()
    {
        //use decimal para uma precisão maior das moedas
        decimal valor = 10536.25m;
        Console.WriteLine(valor);

        //formatar a exibição para uma cultura específica 
        Console.WriteLine(valor.ToString(
            "C", CultureInfo.CreateSpecificCulture("pt-BR")));

        //formatando valores
        //arredonda a depender do ponto flutuante
        Console.WriteLine(Math.Round(valor));

        //arredonda sempre pra cima
        Console.WriteLine(Math.Ceiling(valor));

        //arredonda sempre pra baixo
        Console.WriteLine(Math.Floor(valor));

    }

    //-------------- Módulo "Arrays" --------------

    static void Arrays()
    {
        //array com tipo definido, porem não é limitado à um só tipo, poderi ter "string,bool..."
        var meuArray = new int[5] { 23, 42, 54, 67, 99 };
        // int[] meuArray = new int[5];
        //podemos inicializar o array desta forma tb:
        meuArray[0] = 12;

        Console.WriteLine(meuArray[0]);
        Console.WriteLine(meuArray[1]);
        Console.WriteLine(meuArray[2]);
        Console.WriteLine(meuArray[3]);
        Console.WriteLine(meuArray[4]);

        //tamanho do array
        Console.WriteLine(meuArray.Length);

        //percorrendo o array
        foreach (var item in meuArray)
        {
            Console.WriteLine(item);
        }

        var funcionarios = new Funcionario[5];
        funcionarios[0] = new Funcionario() { Id = 2579, Nome = "Léo" };

        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine(funcionario.Id);
            Console.WriteLine(funcionario.Nome);
        }

    }

    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }


    //-------------------- Módulo "Exceptions" --------------------

    static void TratamentoErros()
    {
        var arr = new int[3] { 53, 9, 21 };

        // try/catch
        try
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // Cadastrar(" ");
        }
        //você pode tratar mais de um erro, mas sempre trate do mais específico para o mais genérico
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Não encontrei o índice na lista");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.InnerException);
            Console.WriteLine(e.Message);
            Console.WriteLine("Ops, algo deu errado");
        }
        //finally é sempre executado ocorrendo erro ou não
        finally
        {
            Console.WriteLine("Chegou ao fim!");
        }

    }

    static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new Exception("O texto não pode ser nulo ou vazio.");
        }
    }
}

