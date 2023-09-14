using BookStore.WebApp.Models.Domain;
using BookStore.WebApp.Repository.Abstract;

namespace BookStore.WebApp.Repository.Implementation;

public class PublisherService : IPublisherService
{
    private readonly DatabaseContext _context;
    public PublisherService(DatabaseContext context)
    {
        _context = context;
    }
    public bool Add(Publisher model)
    {
        try
        {
            _context.Publishers.Add(model);
            _context.SaveChanges();
            return true;
        }
        catch (Exception ex) { return false; }
    }

	public bool Add(Genre model)
	{
		throw new NotImplementedException();
	}

	public bool Delete(int id)
    {
        try
        {
            var data = this.FindById(id);
            if (data == null)
                return false;
            _context.Publishers.Remove(data);
            _context.SaveChanges();
            return true;
        }catch(Exception ex)
        {
            return false;
        }
    }

		public Publisher FindById(int id)
		{
			return _context.Publishers.Find(id);
	}

		public IEnumerable<Publisher> GetAll() => _context.Publishers.ToList();
    
    public bool Update(Publisher model)
    {
        try
        {
			_context.Publishers.Update(model);
            _context.SaveChanges();
            return true;
        }catch(Exception ex) { return false; }  
    }

	
}
