using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder.UseSqlServer("server=Rukiye; database=CoreDB; integrated security=true;");
		}
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Belenco> Belencos { get; set; }
        public DbSet<Calisco> Caliscos { get; set; }
        public DbSet<Cimstone> Cimstones { get; set; }
        public DbSet<Coante> Coantes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Granit> Granits { get; set; }
        
    }
}
