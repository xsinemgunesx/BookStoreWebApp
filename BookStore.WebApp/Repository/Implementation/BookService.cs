using BookStore.WebApp.Models.Domain;
using BookStore.WebApp.Repository.Abstract;

namespace BookStore.WebApp.Repository.Implementation;

public class BookService : IBookService
{
	private readonly DatabaseContext _context;
	public BookService(DatabaseContext context)
	{
		_context = context;
	}
	public bool Add(Book model)
	{
		try
		{
			_context.Books.Add(model);
			_context.SaveChanges();
			return true;
		}
		catch (Exception ex) { return false; }
	}
	public bool Delete(int id)
	{
		try
		{
			var data = this.FindById(id);
			if (data == null)
				return false;
			_context.Books.Remove(data);
			_context.SaveChanges();
			return true;
		}
		catch (Exception ex)
		{
			return false;
		}
	}
	public Book FindById(int id)
	{
		return _context.Books.Find(id);
	}

	public IEnumerable<Book> GetAll()
	{
		var data = (from book in _context.Books
					join author in _context.Authors
					on book.AuthorId equals author.Id
					join publisher in _context.Publishers 
					on book.PublisherId equals publisher.Id
					join genre in _context.Genres
					on book.GenreId equals genre.Id
					select new Book
					{
						Id = book.Id,
						AuthorId = author.Id,
						GenreId =book.GenreId,
						Isbn =book.Isbn,
						PublisherId = book.PublisherId,
						Title = book.Title,
						TotalPages = book.TotalPages,
						GenreName = genre.Name,
						AuthorName = author.Name,
						PublisherName = publisher.Name
					}

					).ToList();
		return data;
	}

	public bool Update(Book model)
	{
		try
		{
			_context.Books.Update(model);
			_context.SaveChanges();
			return true;
		}
		catch (Exception ex) { return false; }
	}

}
