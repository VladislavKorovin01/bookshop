
using bookshop.domain.Entities;

namespace bookshop.domain.Interfaces
{
    public interface IBookRepository
    {
        public void Add();
        public Task<IEnumerable<BookEntity>> GetAll();
        public Task<BookEntity> GetById(long id);
        public Task Update(BookEntity book);
        public Task Delete(long id);
    }
}
