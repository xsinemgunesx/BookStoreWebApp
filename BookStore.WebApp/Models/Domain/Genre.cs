using System.ComponentModel.DataAnnotations;

namespace BookStore.WebApp.Models.Domain;

public class Genre
{
    public int Id { get; set; }
   
    public required string Name { get; set; }
}
