using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ali;initial catalog=ApiDb;integrated security=true;Encrypt=False;");
        }
        public DbSet <Room> Rooms { get; set; }
        public DbSet <Service> Services { get; set; }
        public DbSet <Staff> Staffs { get; set; }
        public DbSet <Subscribe> Subscribes { get; set; }
        public DbSet <Testimonial> Testimonials { get; set; }
    }
}
