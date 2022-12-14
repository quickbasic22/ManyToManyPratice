using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinBreakAwayGreekAdventures.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonPhoto Photo { get; set; }
    }
}
