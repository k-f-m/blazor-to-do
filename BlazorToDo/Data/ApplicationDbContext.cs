using Microsoft.EntityFrameworkCore;

namespace BlazorToDo.Data
{
    /// <summary>
    /// This class is used to interact with the database in .NET applications.
    /// </summary>
    /// <remarks>
    /// This class inherits from the `DbContext` class provided by the `Microsoft.EntityFrameworkCore` namespace.
    /// </remarks>
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        /// <summary>
        /// Gets or sets a collection of `Todo` objects in the database.
        /// </summary>
        public DbSet<BlazorToDo.Data.Models.Todo> TodoList { get; set; } = default!;
    }
}
