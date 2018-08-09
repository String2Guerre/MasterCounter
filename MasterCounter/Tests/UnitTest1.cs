using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using MasterCounter.WebApp.Models;
using MasterCounter.WebApp.DAL;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateAndCheckSkill()
        {
            IDatabaseInitializer<DatabaseContext> init = new DropCreateDatabaseAlways<DatabaseContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new DatabaseContext());

            using (IDal dal = new Dal())
            {
                dal.CreateSkill("puzzle");
                List<Skill> skills = dal.GetAllSkills();

                Assert.IsNotNull(skills);
                Assert.AreEqual(1, skills.Count);
                Assert.AreEqual("puzzle", skills[0].Name);

            }
        }
    }
}
