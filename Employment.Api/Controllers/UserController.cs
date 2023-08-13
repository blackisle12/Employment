using Employment.Domain.Dto.User;
using Employment.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Employment.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        private readonly ILogger<UserController> logger;

        public UserController(
            IUserService service,
            ILogger<UserController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            try
            {
                var user = await service.Get(id);

                if (user is null) return NotFound();

                return Ok(user);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Get unexpected error");
                return StatusCode(500);
            }
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Post([FromBody] PostRequestDto request)
        {
            try
            {
                await service.Post(request);

                return Ok();
            }
            catch (ArgumentException argEx)
            {
                logger.LogError(argEx, "Post arg error");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Post unexpected error");
                return StatusCode(500);
            }
        }

        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Put([FromBody] PutRequestDto request)
        {
            try
            {
                await service.Put(request);

                return Ok();
            }
            catch (ArgumentException argEx)
            {
                logger.LogError(argEx, "Put arg error");
                return BadRequest(argEx.Message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Put unexpected error");
                return StatusCode(500);
            }
        }
    }
}
