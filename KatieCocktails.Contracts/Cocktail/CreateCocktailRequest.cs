namespace KatieCocktails.Contracts.Cocktail;

public record CreateCocktailRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Ingredients,
    List<string> Alcohol
    );