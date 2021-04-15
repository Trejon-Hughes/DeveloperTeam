using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeam
{
    class DeveloperTeamRepo
    {
        List<Team> allTeams = new List<Team>();
        public void CreateTeam(int id, string name)
        {
            Team team = new Team();
            team.Name = name;
            team.ID = id;
            allTeams.Add(team);
        }

        public void AddMember(string team, int id, string lastName, bool psAccountAccess)
        {
            Developer dev = new Developer(id, lastName, psAccountAccess);
            foreach (Team content in allTeams)
            {
                if (content.Name == team)
                {
                    content.Developers.Add(dev);
                }
            }
        }

        public void RemoveMember(string team, int id)
        {
            foreach (Team content in allTeams)
            {
                if (content.Name == team)
                {
                    foreach (Developer developer in content.Developers)
                    {
                        if(developer.ID == id)
                        {
                            content.Developers.Remove(developer);
                        }
                    }
                }
            }
        }

        public Team GetTeam(int id)
        {
            foreach (Team content in allTeams)
            {
                if (content.ID == id)
                {
                    return content;
                }
            }
            return null;
        }

        public void RemoveTeam(int id)
        {
            foreach (Team content in allTeams)
            {
                if (content.ID == id)
                {
                    allTeams.Remove(content);
                }
            }
        }
    }
}
