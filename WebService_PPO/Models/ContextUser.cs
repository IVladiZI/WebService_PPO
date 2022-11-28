using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService_PPO.Models
{
    public class ContextUser : DbContext
    {
        public ContextUser(DbContextOptions<ContextUser> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<User> User{get;set;}
    }
}
