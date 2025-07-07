using GenerativeAI;

namespace ScreenSound.Modelos
{
    internal class ResumoIA
    {
        public async Task<string> ExecutarIA(string nomeBanda)
        {
            //Configuração do api key do Gemini AI
            //Utilizei o NGet GenerativeAI para facilitar a integração com o Gemini AI
            //Na aula da Alura eles utilizar o OpenAI, mas como é uma api paga o gemini é uma alternativa gratuita para testes 
            var googleAI = new GoogleAi("AIzaSyCGnESHIYaDnPYy4wTVnRC5pYK8fmhNZJ4");
            var googleModel = googleAI.CreateGenerativeModel("models/gemini-2.0-flash");
            var prompt = $"faca o resumo bem formatado e com poucas linhas da banda {nomeBanda}, e seja informal";
            var resposta = await googleModel.GenerateContentAsync(prompt);
            return resposta.Text;

        }
    }
}
