namespace ScreenSound.Menus;
internal class MenuSair : Menu
{
    public void Executar()
    {
        Console.WriteLine("Obrigado por usar o ScreenSound!");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
        Environment.Exit(0);
    }
}

