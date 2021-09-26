using MicroRabbit.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MircoRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService ?? throw new ArgumentNullException(nameof(transferService));
        }

        [HttpGet]
        public IActionResult GetTransferLogs()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
