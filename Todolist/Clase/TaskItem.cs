using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist.Clase
{
    public class TaskItem
    {
        public string? Description { get; set; }
        public int Priority { get; set; }
        public string? Objective { get; set; }
        public bool IsCompleted { get; set; }
    }
}
