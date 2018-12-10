﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ToDo.Models;

namespace ToDo.DAL
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
    
}