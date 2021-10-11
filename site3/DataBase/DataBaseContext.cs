using Microsoft.EntityFrameworkCore;
using site3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site3.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Palavra> Palavras { get; set; }


        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base (options)
        {
            Database.EnsureCreated();
        }


    }
}
