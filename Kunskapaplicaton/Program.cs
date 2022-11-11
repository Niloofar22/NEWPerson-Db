using System;
using Kunskapaplicaton.Database;
using Kunskapaplicaton.Models;
using Microsoft.EntityFrameworkCore;

namespace Kunskapaplicaton
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PersonDbContext db = new PersonDbContext())

            {
                var Listusersinfor = db.usersinfors.ToListAsync();
                Console.WriteLine("All usersinfor");
                foreach(var item in Listusersinfor)
                {

                }
            }
                Console.WriteLine("please enter you Info");
            int id = Convert.ToInt32(Console.ReadLine());
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            string title = Console.ReadLine();
            usersinfor newPerson = new usersinfor()
            {
                id = 6,
                first_name = fname,
                last_name = lname,
                title = title,
            };
            AddPerson addPer = new AddPerson();
            addPer.AddNewPerson(newPerson);

            DbContext.IDeletePerson(usersinfor);
            DbContext.Savechanges();

            
        }
    }
}
