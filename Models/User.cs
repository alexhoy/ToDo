using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int[] AssocTaskIDs { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime LastLoginTime { get; set; }
        public List<User> users { get; set; }

    }
}