using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterCounter.WebApp.Models
{
    public class Skill
    {
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }

    }
}