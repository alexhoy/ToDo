using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDo.DAL;
using ToDo.Models;
using System.Data.Entity;
using System.Net;

namespace ToDo.Controllers
{
    public class UserController
    {

        public void Register (User u)
        {
            u.DateRegistered = DateTime.Now;
            
            
        }

        public void Unregister(User u)
        {


        }

    }
}