namespace KatieCocktails.Contracts.Cocktail;

public record UpsertCocktailRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Ingredients,
    List<string> Alcohol
    );