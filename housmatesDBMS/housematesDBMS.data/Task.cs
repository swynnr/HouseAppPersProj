using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housmatesDBMS.data
{
    public class Task
    {
        public int taskID { get; private set; }
        public int houseID { get; private set; }
        public bool isOpen { get; set; }
        public bool repeat { get; set; }
        public string taskDescription { get; set; }
        public string taskName { get; set; }
        public DateTime dueDate { get; set; }
        public DateTime finishDate { get; set; }

        public Task()
        {
            taskID = -1;
            houseID = -1;
            isOpen = false;
            repeat = false;
            taskDescription = "Default Constructor Task";
            taskName = "Generic Task";
            dueDate = DateTime.Now;
            finishDate = new DateTime(9999, 1, 1);
        }
       

        public void updateTask(Task obj)
        {

        }


    }
}
