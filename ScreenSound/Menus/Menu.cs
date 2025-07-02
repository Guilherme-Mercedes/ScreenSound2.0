namespace ScreenSound.Menus;

// Essa classe Menu é uma classe base que pode ser usada por outros menus para exibir títulos formatados
// Utilizando heranca eu consigo reaproveitar código e manter a responsabilidade única de cada classe
internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
}

