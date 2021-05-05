using HowToAPI.Data;
using HowToAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HowToAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommandRepository _repository;

        public CommandsController(ICommandRepository repository) => _repository = repository;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandbyId(id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);
        }
    }
}
