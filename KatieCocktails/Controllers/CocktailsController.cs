using KatieCocktails.Contracts.Cocktail;
using Microsoft.AspNetCore.Mvc;

namespace KatieCocktails.Controllers;

[ApiController]
public class CocktailsController : ControllerBase
{
    [HttpPost("/cocktails")]
    public IActionResult CreateCocktail(CreateCocktailRequest request)
    {
        return Ok(request);
    }

    [HttpGet("/cocktails/{id:guid}")]
    public IActionResult GetCocktail(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/cocktails/{id:guid}")]
    public IActionResult UpsertCocktail(Guid id, UpsertCocktailRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("/cocktails/{id:guid}")]
    public IActionResult DeleteCocktail(Guid id)
    {
        return Ok(id);
    }
}