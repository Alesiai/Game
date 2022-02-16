using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoalsInStadiumController : ControllerBase
    {
        private readonly DataContext _context;
        public GoalsInStadiumController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<GoalsInStadium> GetUsers()
        {
            return _context.GoalsInStadia.ToList();
        }

        [HttpPut("goals")]
        public IEnumerable<GoalsInStadium> AddGoals(Goal goal)
        {
            _context.Goals.Add(goal);
            _context.SaveChangesAsync();

            return GetAllData.GetData(_context);
        }

        [HttpPut("games")]
        public IEnumerable<GoalsInStadium> AddGames(Game game)
        {
            _context.Games.Add(game);

            _context.SaveChangesAsync();

            return GetAllData.GetData(_context);
        }
    }
}