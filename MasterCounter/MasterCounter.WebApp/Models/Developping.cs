using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterCounter.WebApp.Models
{
    public class Developping
    {
        public virtual User User { get; set; }
        public virtual Skill Skill { get; set; }
        public double HoursPassed { get; set; }
    }
}