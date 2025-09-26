using System.Text.Json.Serialization;

namespace PlanMyMeal.Domain.Models
{
    public class Recipe
    {
        [JsonPropertyName("recipeId")]
        public string RecipeId { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; } = string.Empty;

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; } = string.Empty;

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [JsonPropertyName("updateAt")]
        public DateTime UpdateAt { get; set; } = DateTime.UtcNow;

        [JsonPropertyName("difficulty")]
        public string Difficulty { get; set; }

        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonPropertyName("totalTimeMinutes")]
        public int TotalTimeMinutes { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("calories")]
        public int Calories { get; set; }

        [JsonPropertyName("diets")]
        public List<string> Diets { get; set; } = new();

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; } = new();

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();


        public Recipe()
        {

        }

        public Recipe(string title, string difficulty,string type)
        {
            Title = title;
            Difficulty = difficulty;
            Type = type;
        }

        public Recipe(string userId, string title, string imageUrl, string difficulty, int totalTimeMinutes, string type, int calories, List<string> diets, List<string> tags, List<Ingredient> ingredients)
        {
            UserId = userId;
            Title = title;
            ImageUrl = imageUrl;
            Difficulty = difficulty;
            TotalTimeMinutes = totalTimeMinutes;
            Type = type;
            Calories = calories;
            Diets = diets;
            Tags = tags;
            Ingredients = ingredients;
        }
    }
}
