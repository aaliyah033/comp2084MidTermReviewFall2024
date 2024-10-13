using Lab3MidtermReview.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab3MidtermReview.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        DbSet<Candidate> Candidates;
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Lab3MidtermReview.Models.Candidate> Candidate { get; set; } = default!;
    }
}
