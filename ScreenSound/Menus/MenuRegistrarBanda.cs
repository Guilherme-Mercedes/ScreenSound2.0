using ScreenSound.Modelos;
namespace ScreenSound.Menus;
internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");

        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        ResumoIA resumoIA = new ResumoIA();
        string resumo = resumoIA.ExecutarIA(nomeDaBanda).GetAwaiter().GetResult();
        banda.Resumo = resumo;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}

