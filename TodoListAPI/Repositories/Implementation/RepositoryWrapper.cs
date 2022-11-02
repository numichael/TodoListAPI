using TodoListAPI.Data;
using TodoListAPI.Repositories.Interfaces;

namespace TodoListAPI.Repositories.Implementation
{
    public class RepositoryWrapper
    {
        private readonly ApplicationDbContext _context;

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

    }
}