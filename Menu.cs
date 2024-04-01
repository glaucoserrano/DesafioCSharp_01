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
        Console.WriteLine("3 - Numeros");
        Console.WriteLine("4 - Verifica Placa");
        Console.WriteLine("5 - Data Hora");
        Console.WriteLine("9 - Sair");

        opcao = Convert.ToInt32(Console.ReadLine());
        Seleciona(name, opcao);
    }
    private void Seleciona(string name, int opcaoSelecionada)
    {
        switch (opcao)
        {
            case 1:
                Saudacao saudacao = new Saudacao();
                saudacao.SaudacaoUsuario(name);
                break;
            case 2:
                NomeCompleto nome = new NomeCompleto();
                nome.NomeSobrenome(name);
                break;
            case 3:
                Numeros numero = new Numeros();
                numero.MenuSecundario(name);
                break;
            case 4:
                VerificarPlaca placa = new VerificarPlaca();
                placa.ConsultaPlaca(name);
                break;
            case 5:
                DataHora data = new DataHora();
                data.DemonstraDataHora(name);
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
