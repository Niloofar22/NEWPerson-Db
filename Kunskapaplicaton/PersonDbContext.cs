using System;
using Kunskapaplicaton.Models;
using Microsoft.EntityFrameworkCore;

namespace Kunskapaplicaton.Database
{
    public class PersonDbContext : DbContext
    {
        private readonly string constring;//man ge värdena i //constring är namn

        public PersonDbContext()
        {
        }

        // kopla till sql och this.constring lika med connectionstring
        public PersonDbContext(string connnectionstring)
        {
            this.constring = connnectionstring;
        }

        public static object PersonDb { get; internal set; }

        public DbSet<usersinfor> usersinfors { get; set; }
        //
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(constring);
        }

       
    }
    
}
