
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Tasks
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskTime { get; set; }
        public string TaskOwner { get; set; }

    }
}