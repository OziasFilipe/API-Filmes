using API_Sistema_Farmacia.Data;
using API_Sistema_Farmacia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Threading.Tasks;

namespace API_Sistema_Farmacia.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmesController : ControllerBase
{
    
    private DataContext _dataContext;
 
    

    public FilmesController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpPost]
    public void CadastrarFilme(FilmesModels filmeModelo)
    {
        _dataContext.Add(filmeModelo);
        _dataContext.SaveChanges();
    }


    [HttpGet]
    public IEnumerable<FilmesModels> BuscarTodosFilmes()
    {
        return _dataContext.filmes;
    }

    [HttpGet("Paginacao")]
    public IEnumerable<FilmesModels> BuscarTodosPorPaginacao(int skip = 0, int take = 5)
    {
        return _dataContext.filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult BuscarFilmePorId(int id)
    {

        var filmes = _dataContext.filmes.FirstOrDefault(filmes => filmes.cod_filme == id);

        if (filmes == null) return NotFound();

        return Ok(filmes);
    }



}
