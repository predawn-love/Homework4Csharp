using NBAApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NBAApp.Controllers
{
    public class PlayersController : ApiController
    {
        Player[] players = new Player[] { 
            new Player { Id = 1, No = 3, Name = "Chris Paul", Position = "Point Guard", Team = "Los Angeles Clippers" },
            new Player { Id = 2, No = 3, Name = "Dwyane Wade", Position = "Shooting Guard", Team = "Miami Heat" },
            new Player { Id = 3, No = 23, Name = "LeBron James", Position = "Forward", Team = "Cleveland Cavaliers" },
            new Player { Id = 4, No = 21, Name = "Tim Duncan", Position = "Power forward", Team = "San Antonio Spurs" },
            new Player { Id = 5, No = 33, Name = "Marc Gasol", Position = "Center", Team = "Memphis Grizzlies" }
        };

        public IEnumerable<Player> GetAllPlayers()
        {
            return players;
        }

        public IHttpActionResult GetPlayer(int id)
        {
            var player = players.FirstOrDefault<Player>(p => p.Id == id);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }
    }
}
