using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class TasksManager
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Done { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }
    }
}
