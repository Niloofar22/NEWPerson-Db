using System;
using Kunskapaplicaton.Models;
using Microsoft.EntityFrameworkCore;

namespace Kunskapaplicaton.Database
{
    public class PersonDbContext : DbContext
    {
        private readonly string constring;//man ge värdena i //constring är namn
        // kopla till sql och this.constring lika med connectionstring
        public PersonDbContext(string connnectionstring)
        {
            this.constring = connnectionstring;
        }
        

        public DbSet<usersinfor> usersinfors { get; set; }
        //
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(constring);
        }

    }
    
}
