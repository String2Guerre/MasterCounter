using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterCounter.WebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Skill> Skills { get; set; }

    }
}