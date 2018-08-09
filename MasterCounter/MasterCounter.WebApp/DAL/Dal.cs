using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MasterCounter.WebApp.Models;

namespace MasterCounter.WebApp.DAL
{
    public class Dal : IDal
    {
        private DatabaseContext DB;

        public Dal()
        {
            DB = new DatabaseContext();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Skill> GetAllSkills()
        {
            return DB.Skills.ToList();
        }
    }
}