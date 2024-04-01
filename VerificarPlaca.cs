namespace DesafioCSharp_01;

public class VerificarPlaca
{
    int voltar;
    public void ConsultaPlaca(string name)
    {
        string placa;
        bool valido;
        Console.WriteLine("Digite a placa do veículo: ");
        placa = Console.ReadLine();

        valido = VerificaPlaca(placa);
        if(valido)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }

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
    private bool VerificaPlaca(string placa)
    {
        // Verifica se a placa tem 7 caracteres
        if (placa.Length != 7)
            return false;

        // Verifica se os três primeiros caracteres são letras
        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
                return false;
        }

        // Verifica se os quatro últimos caracteres são números
        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
                return false;
        }

        return true;
    }
}
