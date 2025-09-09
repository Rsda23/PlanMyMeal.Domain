using System.Text.Json.Serialization;

namespace PlanMyMeal.Domain.Models
{
    public class Ingredient
    {
        [JsonPropertyName("ingredientId")]
        public string IngredientId { get; set; }

        [JsonPropertyName("recipeId")]
        public string RecipeId { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        public Ingredient() 
        {
        
        }

        public Ingredient(string recipeId, string userId, string title)
        {
            RecipeId = recipeId;
            UserId = userId;
            Title = title;
        }
    }
}
