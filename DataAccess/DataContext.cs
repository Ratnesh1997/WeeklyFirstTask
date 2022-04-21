using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeeklyFirstTask.Models;

namespace WeeklyFirstTask.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }

        public DbSet<UserDetails> GetUserDetails { get; set; }
        public DbSet<LoginDetails> GetLoginDetails{ get; set; }
        //public DbSet<Country> Countriess { get; set; }
        //public DbSet<State> Statess { get; set; }
        public DbSet<Doctor> GetDoctors { get; set; }


    }
}
