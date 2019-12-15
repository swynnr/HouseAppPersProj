using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace housmatesDBMS.data
{
    class House
    {
        public List<Task> tasks{ get; }
        public List<Housemate> housemates { get; }
        public string houseName { get; set; }
        public int houseID { get; private set; }

        public House()
        {
            tasks = null;
            housemates = null;
            houseName = "Default House";
            houseID = -1;
        }
        public House(string name)
        {
            tasks = null;
            housemates = null;
            houseName = name;
            houseID = -1;
        }
        public House(List<Task> tempT, List<Housemate> tempH, string name)
        {
            tasks = tempT;
            housemates = tempH;
            houseName = name;
            houseID = -1;
        }

        public bool updateHouse(House obj)
        {
            return true;
        }

    };
}
