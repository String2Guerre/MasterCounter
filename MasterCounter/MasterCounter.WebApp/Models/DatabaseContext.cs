using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MasterCounter.WebApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Skill> Skills { get; set; }

    }
}