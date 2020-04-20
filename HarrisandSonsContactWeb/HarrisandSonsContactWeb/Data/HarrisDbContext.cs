using HarrisandSonsContactWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisandSonsContactWeb.Data
{
    /// <summary>
    /// This class creates the database based on the classes PersonalContact and Business Contact
    /// and it inherits the DbContext class
    /// </summary>
    public class HarrisDbContext : DbContext
    {
        public HarrisDbContext(DbContextOptions<HarrisDbContext> options) : base(options)
        {
        }

        public DbSet<PersonalContact> PersonalContacts { get; set; }
        public DbSet<BusinessContact> BusinessContacts { get; set; }

    }
}
