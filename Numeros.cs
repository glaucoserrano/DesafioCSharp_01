namespace DesafioCSharp_01;

public class Numeros
{
    int opcao;
    int voltar;


    public void MenuSecundario(string name)
    {
        Console.Clear();
        Console.WriteLine("MENU SECUNDÁRIO");
        Console.WriteLine("Digite uma opção de programa");
        Console.WriteLine("1 - Soma de dois número");
        Console.WriteLine("2 - Subtração de dois números");
        Console.WriteLine("3 - Multiplicação de dois números");
        Console.WriteLine("4 - Divisão de dois números");
        Console.WriteLine("5 - Média de dois números");
        Console.WriteLine("9 - Voltar ao menu principal");
        Console.WriteLine("0 - Sair");

        opcao = Convert.ToInt32(Console.ReadLine());
        Seleciona(name, opcao);
    }
    private void Seleciona(string name,int opcaoSelecionada)
    {
        switch (opcao)
        {
            case 1:
                SomaNumeros(name);
                break;
            case 2:
                SubtracaoNumeros(name);
                break;
            case 3:
                MultiplicacaoNumeros(name);
                break;
            case 4:
                DivisaoNumeros(name);
                break;
            case 5:
                MediaNumeros(name);
                break;
            case 9:
                Menu menu = new Menu();
                menu.MenuPrincipal(name);
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Você selecionou uma opção inválida. Selecione novamente");
                MenuSecundario(name);
                break;
        }
    }

    private void SomaNumeros(string name)
    {
        double numero1 = NumerosAleatorios();
        double numero2 = NumerosAleatorios();

        double soma = numero1 + numero2;

        Console.WriteLine($"Numero 1: {numero1}");
        Console.WriteLine($"Numero 2: {numero2}");
        Console.WriteLine($"A Soma desses 2 número é: {soma}");

        Console.WriteLine($"{name}, digite 0, para voltar ao menu principal");

        voltar = Convert.ToInt32(Console.ReadLine());

        if (voltar != 0)
        {
            Console.WriteLine("Aplicativo Encerrado");
            Environment.Exit(0);
        }

        MenuSecundario(name);

    }
    private void SubtracaoNumeros(string name)
    {
        double numero1 = NumerosAleatorios();
        double numero2 = NumerosAleatorios();

        double soma = numero1 - numero2;

        Console.WriteLine($"Numero 1: {numero1}");
        Console.WriteLine($"Numero 2: {numero2}");
        Console.WriteLine($"A Subtração desses 2 número é: {soma}");

        Console.WriteLine($"{name}, digite 0, para voltar ao menu principal");

        voltar = Convert.ToInt32(Console.ReadLine());

        if (voltar != 0)
        {
            Console.WriteLine("Aplicativo Encerrado");
            Environment.Exit(0);
        }

        MenuSecundario(name);

    }
    private void MultiplicacaoNumeros(string name)
    {
        double numero1 = NumerosAleatorios();
        double numero2 = NumerosAleatorios();

        double soma = numero1 * numero2;

        Console.WriteLine($"Numero 1: {numero1}");
        Console.WriteLine($"Numero 2: {numero2}");
        Console.WriteLine($"A Multiplicação desses 2 número é: {soma}");

        Console.WriteLine($"{name}, digite 0, para voltar ao menu principal");

        voltar = Convert.ToInt32(Console.ReadLine());

        if (voltar != 0)
        {
            Console.WriteLine("Aplicativo Encerrado");
            Environment.Exit(0);
        }

        MenuSecundario(name);
    }
    private void DivisaoNumeros(string name)
    {
        double numero1 = NumerosAleatorios();
        double numero2 = NumerosAleatorios();
        double soma = 0;
        if (numero2 <= 0)
        {
            soma = numero1 / numero2;

            Console.WriteLine($"Numero 1: {numero1}");
            Console.WriteLine($"Numero 2: {numero2}");
            Console.WriteLine($"A Divisão desses 2 número é: {soma}");
        }
        else
        {
            Console.WriteLine("Não foi possivel fazer a divisão, pois o número 2 é menor que zero");
        }

        Console.WriteLine($"{name}, digite 0, para voltar ao menu principal");

        voltar = Convert.ToInt32(Console.ReadLine());

        if (voltar != 0)
        {
            Console.WriteLine("Aplicativo Encerrado");
            Environment.Exit(0);
        }

        MenuSecundario(name);

    }
    private void MediaNumeros(string name)
    {
        double numero1 = NumerosAleatorios();
        double numero2 = NumerosAleatorios();

        double soma = numero1 * numero2 / 2;

        Console.WriteLine($"Numero 1: {numero1}");
        Console.WriteLine($"Numero 2: {numero2}");
        Console.WriteLine($"A Média desses 2 número é: {soma}");

        Console.WriteLine($"{name}, digite 0, para voltar ao menu principal");

        voltar = Convert.ToInt32(Console.ReadLine());

        if (voltar != 0)
        {
            Console.WriteLine("Aplicativo Encerrado");
            Environment.Exit(0);
        }

        MenuSecundario(name);
    }
    private double NumerosAleatorios()
    {

        Random nextNum = new Random();
        return nextNum.NextDouble();
    }
}
