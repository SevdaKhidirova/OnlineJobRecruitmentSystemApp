using jobrecuritment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}
        public DbSet<Level> Levels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<CardOne> CardOne { get; set; }
        public DbSet<CardTwo> CardTwo { get; set; }
        public DbSet<CardThree> CardThree { get; set; }
        public DbSet<JobVacancy> JobVacancies { get; set; }
        public DbSet<CompanyLogo> CompanyLogos { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Interests> Interests { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<UserToVacancy> userToVacancies { get; set; }
    }
}
