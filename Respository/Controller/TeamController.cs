using Respository.Data;
using Respository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository.Controller
{
    public class TeamController
    {
        public readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        public List<Team> GetAllTeam()
        {
            return _context.Team.ToList();
        }

        public void AddTeam(Team Team)
        {
            _context.Team.Add(Team);
            _context.SaveChanges();
        }
    }
}
