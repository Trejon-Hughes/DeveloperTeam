using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeam
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Developer> Developers { get; set; }

        public Team() { }

        public Team(int id, string name, List<Developer> developers)
        {
            ID = id;
            Name = name;
            Developers = developers;
        }
    }

    public class Developer
    {
        public int ID { get; }
        public string LastName { get; set; }
        public bool PSAccountAccess { get; set; }

        public Developer() { }

        public Developer(int id, string lastName, bool psAccountAccess)
        {
            ID = id;
            LastName = lastName;
            PSAccountAccess = psAccountAccess;
        }
    }
}
