using BookStore.WebApp.Models.Domain;
using BookStore.WebApp.Repository.Abstract;

namespace BookStore.WebApp.Repository.Implementation;

public class AuthorService:IAuthorService
{
	private readonly DatabaseContext _context;
	public AuthorService(DatabaseContext context)
	{
		_context = context;
	}
	public bool Add(Author model)
	{
		try
		{
			_context.Authors.Add(model);
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
			_context.Authors.Remove(data);
			_context.SaveChanges();
			return true;
		}
		catch (Exception ex)
		{
			return false;
		}
	}
	public Author FindById(int id)
	{
		return _context.Authors.Find(id);
	}

	public IEnumerable<Author> GetAll() => _context.Authors.ToList();

	public bool Update(Author model)
	{
		try
		{
			_context.Authors.Update(model);
			_context.SaveChanges();
			return true;
		}
		catch (Exception ex) { return false; }
	}

	
}
