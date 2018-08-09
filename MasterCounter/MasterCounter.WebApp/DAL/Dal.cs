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
            DB.Dispose();
        }

        public List<Skill> GetAllSkills()
        {
            return DB.Skills.ToList();
        }

        public void CreateSkill(string name)
        {
            DB.Skills.Add(new Skill { Name = name });
            DB.SaveChanges();
        }

        public void UpdateSkill(int id, string name)
        {
            Skill skill = DB.Skills.FirstOrDefault(s => s.Id == id);
            if (skill != null)
            {
                skill.Name = name;
                DB.SaveChanges();
            }
        }
    }
}