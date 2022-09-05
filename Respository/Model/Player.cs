using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Position Position { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }

    public enum Position
    {
        GoalKeeper,
        Defender,
        midfielder,
        Attack
    }
}
