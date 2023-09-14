using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookStore.WebApp.Models.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.WebApp.Models.Domain;

public class Book
{
	
    public int Id { get; set; }
   
    public required string Title { get; set; }
    public required string Isbn { get; set; }
    public required int TotalPages { get; set; }
    public required int AuthorId { get; set; }
    public required int PublisherId { get; set; }
    public required int GenreId { get; set; }

	[NotMapped]
	public string? AuthorName { get; set; }
	[NotMapped]
	public string? PublisherName { get; set; }
	[NotMapped]
	public string? GenreName { get; set; }

	[NotMapped]
	public List<SelectListItem>? AuthorList { get; set; }
	[NotMapped]
	public List<SelectListItem>? PublisherList { get; set; }
	[NotMapped]
	public List<SelectListItem>? GenreList { get; set; }

}
