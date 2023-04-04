using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]


public class FilmeController : ControllerBase
{
    private readonly List<Filme> filmes = new();

    [HttpPost]
    public void AdicionaFilme([FromBody]Filme filme)
    {
        filmes.Add(filme);

        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Genero);
        Console.WriteLine(filme.Duracao);
    }
}
