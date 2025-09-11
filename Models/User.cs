using System.Text.Json.Serialization;

namespace PlanMyMeal.Domain.Models
{
    public class User
    {
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; } = "member";

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; } = string.Empty;

        [JsonPropertyName("pseudo")]
        public string Pseudo { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("hashedPassword")]
        public string HashedPassword { get; set; }
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("lastLoginAt")]
        public DateTime LastLoginAt { get; set; }



        public User() 
        { 

        }

        public User(string pseudo, string email, string hashedPassword)
        {
            Pseudo = pseudo;
            Email = email;
            HashedPassword = hashedPassword;
            CreatedAt = DateTime.UtcNow;
            LastLoginAt = DateTime.UtcNow;
        }
    }
}
