using System;
using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Models
{
    public class CompleteTask
    {
        [Key]
        public int id {get; set;}

        [Required]
        [Display(Name = "Task Name")]
        public string taskName {get; set;}

        [Required]
        [Display(Name = "Task Description")]
        public string taskDescription {get; set;}
    }
    
}