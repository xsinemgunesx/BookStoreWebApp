using BookStore.WebApp.Models.Domain;
using BookStore.WebApp.Repository.Abstract;

namespace BookStore.WebApp.Repository.Implementation;

public class GenreServices : IGenreService
{
    private readonly DatabaseContext _context;
    public GenreServices(DatabaseContext context)
    {
        _context = context;
    }
    public bool Add(Genre model)
    {
        try
        {
            _context.Genres.Add(model);
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
            _context.Genres.Remove(data);
            _context.SaveChanges();
            return true;
        }catch(Exception ex)
        {
            return false;
        }
    }

		public Genre FindById(int id)
		{
			return _context.Genres.Find(id);
		}

		public IEnumerable<Genre> GetAll() => _context.Genres.ToList();
    
    public bool Update(Genre model)
    {
        try
        {
			_context.Genres.Update(model);
            _context.SaveChanges();
            return true;
        }catch(Exception ex) { return false; }  
    }

		
	}
