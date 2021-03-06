using I_Eat_Spargus.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I_Eat_Spargus.DB
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;DataBase=usersDB;Trusted_Connection=True;");
        }
    }
}
