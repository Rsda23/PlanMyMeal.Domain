using System.Text.Json.Serialization;

namespace PlanMyMeal.Domain.Models
{
    public class Ingredient
    {
        [JsonPropertyName("recipeId")]
        public string RecipeId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        public Ingredient() 
        {
        
        }

        public Ingredient(string title)
        {
            Title = title;
        }
    }
}
