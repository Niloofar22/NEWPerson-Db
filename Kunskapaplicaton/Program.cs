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
            var Context = new PersonDbContext("Server = localhost; Database = PersonDb; Trusted_Connection = True");//be readonly rabt darad
            

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
            AddPerson addPer = new AddPerson(Context);
            addPer.AddNewPerson(newPerson);

          

            
        }
    }
}
