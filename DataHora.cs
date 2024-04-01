namespace DesafioCSharp_01;

public class DataHora
{
    int voltar;
    public void DemonstraDataHora(string name)
    {
        DateTime data = DateTime.Now;
        Console.WriteLine($"Formato Completo");
        Console.WriteLine($"Hoje é {data.ToString("dddd, dd/MM/yyyy HH:mm:ss")}");
        Console.WriteLine($"{data.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"{data.ToString("HH:mm:ss")}");
        Console.WriteLine($"{data.ToString("dd, MMMM, yyyy")}");


        Console.WriteLine($"{name}, digite 0, para voltar ao menu principal");

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
