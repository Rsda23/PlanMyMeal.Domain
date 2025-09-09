using System.Text.Json.Serialization;

namespace PlanMyMeal.Domain.Models
{
    public class Recipe
    {
        [JsonPropertyName("recipeId")]
        public string RecipeId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();


        public Recipe()
        {

        }

        public Recipe(string title, List<Ingredient> ingredients)
        {
            Title = title;
            Ingredients = ingredients;
        }
    }
}
