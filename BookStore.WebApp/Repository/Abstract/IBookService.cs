using BookStore.WebApp.Models.Domain;

namespace BookStore.WebApp.Repository.Abstract;

public interface IBookService
{
	bool Add(Book model);
	bool Update(Book model);
	bool Delete(int id);
	Book FindById(int id);
	IEnumerable<Book> GetAll();
}
