using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TaurusApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private readonly PlayerService _playerService;

        public PlayerController(PlayerService playerService)
        {
            _playerService = playerService;
        }


        [HttpGet]
        public ActionResult<IList<Player>> Get()
        {
            var playerList = _playerService.Get();
            return Ok(playerList);
        }

        [HttpGet("{id}")]
        public ActionResult<Player> GetActionResult(string id)
        {
            var player = _playerService.Get(id);
            return player;
        }

        [HttpPost]
        public ActionResult<Player> Create(Player player)
        {
            _playerService.Create(player);

            return CreatedAtRoute("GetPlayer", new { id = player.Id.ToString() }, player);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, Player playerIn)
        {
            var player = _playerService.Get(id);

            if (player == null)
            {
                return NotFound();
            }

            _playerService.Update(id, playerIn);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var player = _playerService.Get(id);

            if (player == null)
            {
                return NotFound();
            }

            _playerService.Remove(player.Id);

            return NoContent();
        }
    }
}