using System;
using Kunskapaplicaton.Database;
using Kunskapaplicaton.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Kunskapaplicaton
{
    internal class DeletePerson : IDeletePerson
    {
        private readonly PersonDbContext _personDbContext;

        public DeletePerson(PersonDbContext db)
        {
            this._personDbContext = db;
        }


        public void Remove(usersinfor usersinfor)
        {
            var query = "Remove usersinfor(id, first_name, last_name, title) values(@id, @first_name, @last_name, @title)";
            var parameter = new SqlParameter[]
            {
                new SqlParameter("@id",usersinfor.id),
                new SqlParameter("@first_name", usersinfor.first_name),
                new SqlParameter("@last_name", usersinfor.last_name),
                new SqlParameter("@title", usersinfor.title),

            };

            _personDbContext.Database.ExecuteSqlRaw(query, parameter);

        }
    }

        
    }
