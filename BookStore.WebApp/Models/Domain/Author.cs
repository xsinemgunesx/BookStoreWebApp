using System.ComponentModel.DataAnnotations;
using BookStore.WebApp.Models.Domain;

namespace BookStore.WebApp.Models.Domain;

public class Author
{
    public int Id { get; set; }
   
    public required string Name { get; set; }
}
