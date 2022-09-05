using Respository.Data;
using Respository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository.Controller
{
    public class PlayerController
    {
        public readonly AppDbContext _context;

        public PlayerController(AppDbContext context)
        {
            _context = context;
        }

        public List<Player> GetAllPlayer()
        {
            return _context.Player.ToList();
        }

        public void AddPlayer(Player Player)
        {
            _context.Player.Add(Player);
            _context.SaveChanges();
        }
    }
}
