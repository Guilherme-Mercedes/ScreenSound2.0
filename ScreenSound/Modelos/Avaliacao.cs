namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota) 
    {

        // Validação da nota para garantir que esteja entre 0 e 10, futuramente posso ajustar com try catch 
        if (nota < 0)
        {
            Nota = 0;
        }
        else if (nota > 10)
        {
            Nota = 10;
        }
        else
        {
            Nota = nota;
        }
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }

}
