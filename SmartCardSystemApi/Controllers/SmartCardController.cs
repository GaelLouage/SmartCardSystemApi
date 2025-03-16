using Microsoft.AspNetCore.Mvc;
using SmartCardSystemApi.Enums;
using SmartCardSystemApi.Factory.Classes;
using SmartCardSystemApi.Factory.Interfaces;
using SmartCardSystemApi.Models;

namespace SmartCardSystemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmartCardController : ControllerBase
    {
        private readonly ILogger<SmartCardController> _logger;
        private List<SmartCardEntity> _smartCardUsers = new List<SmartCardEntity>
        {
            new SmartCardEntity { EmployeeName = "Alice", EmployeeId = 1001, ChipId = "CHIP123", AccessLevel = SmartCardAccessLevel.USER },
            new SmartCardEntity { EmployeeName = "Bob", EmployeeId = 1002, ChipId = "CHIP456", AccessLevel = SmartCardAccessLevel.AUTHENTICATED_USER },
            new SmartCardEntity { EmployeeName = "Charlie", EmployeeId = 1003, ChipId = "CHIP789", AccessLevel = SmartCardAccessLevel.ADMINISTRATOR },
            new SmartCardEntity { EmployeeName = "David", EmployeeId = 1004, ChipId = "CHIP999", AccessLevel = SmartCardAccessLevel.ISSUER }
        };
        public SmartCardController(ILogger<SmartCardController> logger)
        {
            _logger = logger;
        }
        [HttpGet("GetUsersAccess")]
        public IActionResult Get(SmartCardAccessLevel lvl)
        {
            ICardAccess cardAccess = SmartCardFactory.GetSmartCard(lvl);
            return Ok(cardAccess.Operation());
        }
    }
}
