using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Boss.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Boss.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectParticipant> ProjectParticipants { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Comment>()
                .HasOne("Boss.Models.ProjectParticipant", "ProjectParticipant")
                .WithMany()                        
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
