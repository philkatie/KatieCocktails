namespace KatieCocktails.Contracts.Cocktail;

public record CocktailResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModified,
    List<string> Ingredients,
    List<string> Alcohol
    );