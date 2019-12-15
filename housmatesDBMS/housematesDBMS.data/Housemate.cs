using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housmatesDBMS.data
{
    class Housemate
    {
        public string name { get; private set; }
        public int housemateID { get; private set; }
        public int houseID { get; private set; }
        public List<Task> tasksDone { get; private set; }

        public Housemate()
        {
            name = "default";
            housemateID = -1;
            houseID = -1;
            tasksDone = null;
        }

        public bool update(Housemate obj)
        {
            return true;
        }

    }
}
