using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MasterCounter.WebApp.Models;

namespace MasterCounter.WebApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Skill> Skills { get; set; }

    }
}