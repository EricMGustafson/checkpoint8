using System;

namespace checkpoint8.Models
{
  public class Ingredient
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Quantity { get; set; }
    public int RecipeId { get; set; }
    public string CreatorId { get; set; }
    public Account Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}