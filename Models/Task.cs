using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace ToDo.Models
{
    public class Task
    {
        public int taskID { get; set; } //ID of the task

        [Display(Name ="Task Title: ")]
        public string taskTitle { get; set; }

        [Display(Name = "Task Body: ")]
        public string taskBody { get; set; }

        [Display(Name = "Task Owner: ")]
        public string taskOwner { get; set; } //Name of user who created the task

        [Display(Name = "Task Priority: ")]
        public bool taskPriority { get; set; } //is the task a priority or not

        [Display(Name = "Task Completed: ")]
        public bool taskComplete { get; set; }

        [Display(Name = "Task Creation Time: ")]
        public DateTime taskCreationTime { get; set; }

        [Display(Name = "Task Completion Time: ")]
        public DateTime? taskCompletionTime { get; set; }

        public List<Task> listTasks { get; set; }
    }
}