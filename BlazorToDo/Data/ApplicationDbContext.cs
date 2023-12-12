using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace BlazorToDo.Data
{
    /// <summary>
    /// This class is used to interact with the database.
    /// </summary>
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        /// <summary>
        /// Gets or sets a collection of `Todo` objects in the database.
        /// </summary>
        public DbSet<BlazorToDo.Data.Models.Todo> TodoList { get; set; } = default!;
    }
}
