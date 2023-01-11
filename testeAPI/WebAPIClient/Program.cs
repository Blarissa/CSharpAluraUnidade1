using System.Net.Http.Headers;
//Usando um HttpClient para manipular solicitações e respostas
using HttpClient client = new();
//Configura cabeçalhos HTTP de todas as solicitações:
//Um cabeçalho Accept: para aceitar respostas JSON
//Um cabeçalho User-Agent.
//Esses cabeçalhos são verificados pelo código do servidor GitHub
//e são necessários para recuperar informações do GitHub.
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

await ProcessRepositoriesAsync(client);

static async Task ProcessRepositoriesAsync(HttpClient client)
{
    var json = await client.GetStringAsync(
         "https://api.github.com/orgs/dotnet/repos");

    Console.Write(json);
}