namespace DesafioCSharp_01;

public class NomeCompleto
{
    public void NomeSobrenome(string name)
    {
        string? lastName;
        int voltar;

        Console.Clear();
        Console.WriteLine("Digite seu sobrenome");
        lastName = Console.ReadLine();

        Console.WriteLine($"Seu nome completo é {name} {lastName}");
        Console.WriteLine($"{name} {lastName}, digite 0, para voltar ao menu principal");

        voltar = Convert.ToInt32(Console.ReadLine());

        if (voltar != 0)
        {
            Console.WriteLine("Aplicativo Encerrado");
            Environment.Exit(0);
        }
        Menu menu = new Menu();

        menu.MenuPrincipal(name);
    }
}
