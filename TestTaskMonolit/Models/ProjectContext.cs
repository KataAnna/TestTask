using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskMonolit.Models
{
    public class ProjectContext : IdentityDbContext<IdentityUser>
    {
        public ProjectContext() { }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        public DbSet<Programmer> Programmers { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderViewModel>()
        .HasKey(ovm => new { ovm.ProjectId, ovm.ProgrammerId });

            modelBuilder.Entity<OrderViewModel>()
                .HasOne(ovm => ovm.Project)
                .WithMany(om => om.OrderViewModels)
                .HasForeignKey(om => om.ProjectId);

            modelBuilder.Entity<OrderViewModel>()
                .HasOne(ovm => ovm.Programmer)
                .WithMany(om => om.OrderViewModels)
                .HasForeignKey(om => om.ProgrammerId);

        }
    }
}
