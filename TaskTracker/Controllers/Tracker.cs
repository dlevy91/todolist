using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskTracker.DAO;
using TaskTracker.Models;

namespace TaskTracker.Controllers
{
    public class TrackerController : Controller
    {
        private readonly TaskTrackerDbContext _context;

        public TrackerController(TaskTrackerDbContext context)
        {
            _context = context;
        }
//----------------------------------------------------------------------------------------------------------------
    
        public IActionResult ViewTasks()
        {
            return View(_context);
        }

        public IActionResult ViewDetails(int taskID)
        {
            UserTask foundTask = _context.Tasks.FirstOrDefault(t => t.id == taskID);

            return View(foundTask);
        }

//-----------------------------------------------------------------------------------------------------------------

        public IActionResult AddTask(UserTask newTask)
        {
            if(ModelState.IsValid)
            {
            _context.Tasks.Add(newTask);
            _context.SaveChanges();
            return RedirectToAction("ViewTasks");
            }
            else{
                return View("AddTaskForm", newTask);
            }
        }

        public IActionResult AddTaskForm()
        {
            return View();
        }

//-----------------------------------------------------------------------------------------------------------------

        public IActionResult EditTask(UserTask taskUp)
        {
            UserTask foundTask = _context.Tasks.FirstOrDefault(t => t.id == taskUp.id);

            if(foundTask != null)
            {
                if(ModelState.IsValid)
                {
                foundTask.taskDescription = taskUp.taskDescription;
                foundTask.taskName = taskUp.taskName;
                _context.SaveChanges();

                return RedirectToAction("ViewTasks");
                }
                else{
                    return View("EditTaskForm", taskUp);
                }
            }
            else{
                return Content("No Task Found!");
            }
        }

        public IActionResult EditTaskForm(int taskID)
        {
            UserTask foundTask = _context.Tasks.FirstOrDefault(t => t.id == taskID);
            if(foundTask != null)
            {
            return View(foundTask);
            }
            else{
                return Content("No Task Found");
            }
        }

//-----------------------------------------------------------------------------------------------------------------

        public IActionResult DeleteTask(int taskID)
        {
            UserTask foundTask = _context.Tasks.FirstOrDefault(t => t.id == taskID);

            if(foundTask != null)
            {
            _context.Remove(foundTask);
            _context.SaveChanges();

            return RedirectToAction("ViewTasks");
            }
            else{
                return Content("No Task found");
            }
        }

        public IActionResult TaskFinish(int taskID)
        {
            UserTask foundTask = _context.Tasks.FirstOrDefault(t => t.id == taskID);
            if(foundTask != null)
            {
            return View(foundTask);
            }
            else{
                return Content("No Task Found.");
            }
        }
    }
}