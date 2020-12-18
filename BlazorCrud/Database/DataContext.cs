using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Database
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
