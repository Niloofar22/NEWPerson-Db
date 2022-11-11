using System;
using Kunskapaplicaton.Models;
using Microsoft.EntityFrameworkCore;

namespace Kunskapaplicaton.Database
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext()
        {
        }

       


        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {

        }

        public DbSet<usersinfor> usersinfors { get; set; }
        public DbSet<uaddress> uaddresses { get; set; }


    }
    
}
