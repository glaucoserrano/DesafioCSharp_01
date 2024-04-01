namespace DesafioCSharp_01;

public class Menu
{
    int opcao;
    public void MenuPrincipal(string name)
    {
        Console.Clear();
        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine("Digite uma opção de programa");
        Console.WriteLine("1 - Saudação");
        Console.WriteLine("2 - Nome Completo");
        Console.WriteLine("9 - Sair");

        opcao = Convert.ToInt32(Console.ReadLine());
        Seleciona(name, opcao);
    }
    public void Seleciona(string name, int opcaoSelecionada)
    {
        switch (opcao)
        {
            case 1:
                Saudacao saudacao = new Saudacao();
                saudacao.SaudacaoUsuario(name);
                break;
            case 2:
                Console.WriteLine("Selecionou 2");
                break;
            case 9:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Você selecionou uma opção inválida. Selecione novamente");
                MenuPrincipal(name);
                break;
        }
    }
}
