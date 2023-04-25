internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Menu();

    }

    static void Menu()
    {
        Console.WriteLine("Bem vindo, o que você deseja fazer? ");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");

        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0:
                System.Environment.Exit(0);
                break;
            case 1:
                Open();
                break;
            case 2:
                Edit();
                break;
            default:
                Menu();
                break;
        }

    }

    static void Open()
    {

    }

    static void Edit()
    {

    }
}