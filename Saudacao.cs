namespace DesafioCSharp_01;

public class Saudacao
{
    public void SaudacaoUsuario(string name)
    {
        int voltar;
        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
        Console.WriteLine($"{name}, digite 0, para voltar ao menu principal");

        voltar = Convert.ToInt32(Console.ReadLine());

        if(voltar != 0)
        {
            Console.WriteLine("Aplicativo Encerrado");
            Environment.Exit(0);
        }
        Menu menu = new Menu();

        menu.MenuPrincipal(name);


    }
}
