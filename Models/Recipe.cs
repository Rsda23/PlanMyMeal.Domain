using System.Text.Json.Serialization;

namespace PlanMyMeal.Domain.Models
{
    public class Recipe
    {
        [JsonPropertyName("recipeId")]
        public string RecipeId { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();


        public Recipe()
        {

        }

        public Recipe(string userId, string title, List<Ingredient> ingredients)
        {
            UserId = userId;
            Title = title;
            Ingredients = ingredients;
        }
    }
}
