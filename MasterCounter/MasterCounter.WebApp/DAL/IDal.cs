using MasterCounter.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCounter.WebApp.DAL
{
    public interface IDal : IDisposable
    {
        List<Skill> GetAllSkills();
    }
}
